using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    string _inputtedString;
    string _upperCaseString;
    string _inputtedWord;
    string _upperCaseWord;
    int _wordInstances;
    string [] _stringsToWordsArray;

    public RepeatCounter(string inputtedString, string inputtedWord)
    {
      _inputtedString = inputtedString;
      _inputtedWord = inputtedWord;
      _wordInstances = 0;
    }

    //Make both the inputted string and word upper case so that they can more easily be compared with each other.
    public void MakeAllUpperCase()
    {
      _upperCaseString = _inputtedString.ToUpper();
      _upperCaseWord = _inputtedWord.ToUpper();
    }

    //Takes inputted string and separates the string based on spaces and punctuation.
    public void CreateStringArray()
    {
      char [] splitCharacters = {' ', '.', '?', '!', ':', ';'};
      _stringsToWordsArray = _upperCaseString.Split(splitCharacters);
    }

    public void CountWordsInString()
    {
      foreach (string word in _stringsToWordsArray)
      {
        if (word == _upperCaseWord)
        {
          _wordInstances += 1;
        }
      }
    }

    public int CountRepeats()
    {
      MakeAllUpperCase();
      CreateStringArray();
      CountWordsInString();

      return _wordInstances;
    }
  }
}
