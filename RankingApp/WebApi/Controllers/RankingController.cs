using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using System.Collections.Generic;
using System.Linq;
using WebApi.Data;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        ApplicationDBContext _context;

        public RankingController(ApplicationDBContext context)
        {
            _context = context;
        }

        //Create
        [HttpPost]
        public GameResult AddGameResult([FromBody]GameResult gameResult)
        {
            _context.GameResults.Add(gameResult);
            _context.SaveChanges();

            return gameResult;
        }

        //Read
        // 1: every item
        [HttpGet]
        public List<GameResult> GetGameResults()
        {
            List<GameResult> results = _context.GameResults.OrderByDescending(item => item.Score).ToList();


            return results;
        }
        // 2:pick one item of id
        [HttpGet("{id}")]
        public GameResult GetGameResult(int id)
        {
            GameResult result = _context.GameResults.Where(item => item.Id == id).FirstOrDefault();


            return result;
        }


        //Update
        [HttpPut]
        public bool UpdateGameResult([FromBody] GameResult gameResult)
        {
            var findResult = _context.GameResults.Where(item => item.Id == gameResult.Id).FirstOrDefault();
            if (findResult == null)
                return false;
            findResult.UserName = gameResult.UserName;
            findResult.Score = gameResult.Score;
            _context.SaveChanges();
            return true;
        }

        //Delete
        [HttpDelete("{id}")]
        public bool DeleteGameResult(int id)
        {
            var findResult = _context.GameResults.Where(item => item.Id == id).FirstOrDefault();
            if (findResult == null)
                return false;
            _context.GameResults.Remove(findResult);
            _context.SaveChanges();
            return true;
        }


    }
}
