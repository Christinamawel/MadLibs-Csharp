using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/MadLib")]
    public ActionResult MadLib(string adj, string nounOne, string transp, string verb, string color, string nounTwo, string foodOne, string foodTwo, string person, string saying)
    {
      MadLib newMadLib = new MadLib();
      newMadLib.Adj = adj;
      newMadLib.NounOne = nounOne;
      newMadLib.Transp = transp;
      newMadLib.Verb = verb;
      newMadLib.Color = color;
      newMadLib.NounTwo = nounTwo;
      newMadLib.FoodOne = foodOne;
      newMadLib.FoodTwo = foodTwo;
      newMadLib.Person = person;
      newMadLib.Saying = saying;
      return View(newMadLib);
    }
  }
}