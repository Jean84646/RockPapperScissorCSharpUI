
using Microsoft.AspNetCore.Mvc;
using RockPaperScissor.Models;

namespace RockPaperScissor.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/play")]
    public ActionResult Play()
    {
      RockPaperScissorGame newGame = new RockPaperScissorGame(Request.Query["playerPick"]);
      return View("Index", newGame.GamePlay());
    }
  }
}
