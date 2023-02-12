using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/hello")]   //route decorator
    public string Hello() { return "Hello friend!"; }
    // called the action, because it defines what the site will do when a client requests this particular path

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    // the name of the parameters must match the value of the name attribute on the form inputs
    {
    LetterVariable myLetterVariable = new LetterVariable();
    myLetterVariable.Recipient = recipient;
    myLetterVariable.Sender = sender;
    myLetterVariable.Location = location;
    myLetterVariable.Souvenir = souvenir;
    return View(myLetterVariable);
    }
  }
}

// HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement