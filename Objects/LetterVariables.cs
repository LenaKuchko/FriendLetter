namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _location;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string Location)
    {
      _location = Location;
    }
  }
}
