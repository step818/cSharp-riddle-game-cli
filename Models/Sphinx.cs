namespace RoS.Models
{
  class Sphinx
  {
    private string _riddle;
    private string _correct;
    private int _order;

    public Sphinx(string riddle, string correct, int order)
    {
      _riddle = riddle;
      _correct = correct;
      _order = order;
    }

    public string GetRiddle()
    {
      return _riddle;
    }

    public string GetCorrect()
    {
      return _correct;
    }

    public int GetOrder()
    {
      return _order;
    }

    public bool CheckAnswer(string userAnswer)
    {
      return (_correct == userAnswer);
    }
  }
}