using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class GameResult
{
    public string UserName;
    public int Score;  
}


public class Webmanager : MonoBehaviour
{

    string _baseUrl = "https://localhost:44386/api";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameResult res = new GameResult()
        {
            UserName = "test",
            Score = 100
        };


        SendPostRequest("ranking", res, (uwr) =>
        {
            Debug.Log("Todo : Update UI");    
        });

        SendGetRequest("ranking", (uwr) =>
        {
            Debug.Log("Todo : Update UI");
        });

    }

    public void SendPostRequest(string url, object obj, Action<UnityWebRequest> callback)
    {
        StartCoroutine(CoSendWebRequest(url, "POST", obj, callback));
    }
    public void SendGetRequest(string url, Action<UnityWebRequest> callback)
    {
        StartCoroutine(CoSendWebRequest(url, "GET", null, callback));
    }

    IEnumerator CoSendWebRequest(string url, string method, object obj, Action<UnityWebRequest> callback)
    {
        yield return null;

        string _sendUrl = $"{_baseUrl}/{url}";

        byte[] jsonBytes = null;

        if (obj != null)
        {
            string json = JsonUtility.ToJson(obj);
            jsonBytes = System.Text.Encoding.UTF8.GetBytes(json);
        }

        var uwr = new UnityWebRequest(_sendUrl, method);

        uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
        uwr.downloadHandler = new DownloadHandlerBuffer();

        uwr.SetRequestHeader("Content-Type", "application/json");

        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError || uwr.isHttpError)
        {
            Debug.LogError(uwr.error);
        }
        else
        {
            Debug.Log("Recv" + uwr.downloadHandler.text);

            callback.Invoke(uwr);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    
}
