using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    string _inputtedString;
    string _inputtedWord;
    int _wordInstances;
    List<string> _stringsToWordsList = new List<string> {};

    public RepeatCounter(string inputtedString, string inputtedWord)
    {
      _inputtedString = inputtedString;
      _inputtedWord = inputtedWord;
    }

    public int CountRepeats()
    {
      return 0;
    }
  }
}
