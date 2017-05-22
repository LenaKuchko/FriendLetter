using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Jessica");
        myLetterVariables.SetLocation("Alaska");

        return View["hello.cshtml", myLetterVariables];
      };
    }
  }
}
