#pragma checksum "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e945755803075d702772b990edefddf457decfff851cd89f3ee2cb164e32d603"
// <auto-generated/>
#pragma warning disable 1591
namespace RankingApp.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using RankingApp

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\_Imports.razor"
using SharedData;

#nullable disable
#nullable restore
#line 2 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
 using SharedData.Models;

#nullable disable
#nullable restore
#line 3 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
 using RankingApp.Data.Services;

#nullable disable
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
      "/ranking"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Ranking : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ranking</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<global::Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
        

#line default
#line hidden
#nullable disable

#nullable restore
#line 15 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
         if (_gameResults == null)
        {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(4, "            ");
                __builder2.AddMarkupContent(5, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(6, "            ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.AddMarkupContent(10, @"<thead>
                    <tr>
                        <th>UserName</th>
                        <th>Score</th>
                        <th>Date</th>
                        <th>Edit</th>
                        <th>Delete</th>

                    </tr>
                </thead>
                ");
                __builder2.OpenElement(11, "tbody");
                __builder2.AddMarkupContent(12, "\r\n");
#nullable restore
#line 33 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                    

#line default
#line hidden
#nullable disable

#nullable restore
#line 33 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                     foreach (var gameResult in _gameResults)
                    {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(13, "                        ");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "\r\n                            ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 36 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                 gameResult.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                            ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 37 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                 gameResult.Score

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 38 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                 gameResult.PlayedOn.ToString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                          ()=>UpdateGameResult(gameResult)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "td");
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "class", "btn btn-primary");
                __builder2.AddAttribute(37, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                          ()=>DeleteGameResult(gameResult)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(38, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 46 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                    }

#line default
#line hidden
#nullable disable

                __builder2.AddContent(42, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n");
#nullable restore
#line 49 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"


#line default
#line hidden
#nullable disable

                __builder2.AddContent(45, "            ");
                __builder2.OpenElement(46, "p");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "class", "btn btn-primary");
                __builder2.AddAttribute(50, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                          AddGameResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(51, "add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 53 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"


            

#line default
#line hidden
#nullable disable

#nullable restore
#line 55 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
             if(_showPopup)
            {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(54, "                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "modal");
                __builder2.AddAttribute(57, "style", "display:block");
                __builder2.AddAttribute(58, "role", "dialog");
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "modal-dialog");
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "modal-content");
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "modal-header");
                __builder2.AddMarkupContent(68, "\r\n                                ");
                __builder2.AddMarkupContent(69, "<h3 claass=\"modal-title\">Add/Update GameResult</h3>\r\n\r\n                                ");
                __builder2.OpenElement(70, "button");
                __builder2.AddAttribute(71, "type", "button");
                __builder2.AddAttribute(72, "class", "close");
                __builder2.AddAttribute(73, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                              ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(74, "\r\n                                    ");
                __builder2.AddMarkupContent(75, "<spaan area-hidden>X</spaan>\r\n\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "modal-body");
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.AddMarkupContent(81, "<label for=\"UserNaame\">Username</label>\r\n                                ");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "text", "text");
                __builder2.AddAttribute(85, "placeholder", "UserName");
                __builder2.AddAttribute(86, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                                                            _gameResult.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _gameResult.UserName = __value, _gameResult.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.AddMarkupContent(89, "<label for=\"UserNaame\">Score</label>\r\n                                ");
                __builder2.OpenElement(90, "input");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "text", "text");
                __builder2.AddAttribute(93, "placeholder", "UserName");
                __builder2.AddAttribute(94, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                                                            _gameResult.Score

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _gameResult.Score = __value, _gameResult.Score));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                                ");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "class", "btn btn-primary");
                __builder2.AddAttribute(99, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                                                                          SavegameResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(100, "\r\n                                    Save \r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 82 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
            }

#line default
#line hidden
#nullable disable

#nullable restore
#line 82 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                


        }

#line default
#line hidden
#nullable disable

                __builder2.AddMarkupContent(106, "\r\n    ");
            }
            ));
            __builder.AddAttribute(107, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<global::Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n        You are not authorized\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
       
    List<GameResult> _gameResults;

    bool _showPopup;
    GameResult _gameResult;

    protected override async Task OnInitializedAsync()
    {
        _gameResults = await RankingService.GetGameResultAsync();
    }


    void AddGameResult()
    {
        _showPopup = true;
        _gameResult = new GameResult(){ Id = 0 };
    }   

    void ClosePopup()
    {
        _showPopup = false;
    }   


    void UpdateGameResult(GameResult gameResult)
    {
        _showPopup = true;
        _gameResult = gameResult;
    }   

    async Task DeleteGameResult(GameResult gameResult)
    {
        var result = RankingService.DeleteGameResult(gameResult); 
        _gameResults = await RankingService.GetGameResultAsync();   
    }   


    async Task SavegameResult()
    {
        if(_gameResult.Id == 0)
        {
           _gameResult.PlayedOn = DateTime.Now; 
           var result = await RankingService.AddGameResult(_gameResult);
        }
        else
        {
           var result = await RankingService.UpdateGameResult(_gameResult);    
        }
        _showPopup = false; 
        _gameResults = await RankingService.GetGameResultAsync(); 
    }




#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
        RankingService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\userWin\Desktop\c\test2\RankingApp\RankingApp\Pages\Ranking.razor"
                       RankingService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
