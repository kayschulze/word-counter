using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    string _inputtedString;
    string _inputtedWord;
    int _wordInstances;
    string [] _stringsToWordsArray;

    public RepeatCounter(string inputtedString, string inputtedWord)
    {
      _inputtedString = inputtedString;
      _inputtedWord = inputtedWord;
      _wordInstances = 0;
    }

    //Takes inputted string and separates the string based on spaces and punctuation.
    public void CreateStringArray()
    {
      char [] splitCharacters = {' ', '.', '?', '!', ':', ';'};
      _stringsToWordsArray = _inputtedString.Split(splitCharacters);
    }

    public void CountWordsInString()
    {
      foreach (string word in _stringsToWordsArray)
      {
        if (word == _inputtedWord)
        {
          _wordInstances += 1;
        }
      }
    }

    public int CountRepeats()
    {
      CreateStringArray();
      CountWordsInString();

      return _wordInstances;
    }
  }
}
