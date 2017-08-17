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
        string [] _stringsToWordArray;  //String is divided into array of words

        public RepeatCounter(string inputtedWord, string inputtedString)
        {
            _inputtedString = inputtedString;
            _inputtedWord = inputtedWord;
            _wordInstances = 0;
        }

        public string GetWord()
        {
          return _inputtedWord;
        }

        public string GetPhrase()
        {
          return _inputtedString;
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
            _stringsToWordArray = _upperCaseString.Split(splitCharacters);
        }

        public void CountWordsInString()
        {
            foreach (string word in _stringsToWordArray)
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
