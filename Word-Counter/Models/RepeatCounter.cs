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
        int _wordInstancesIncludePlural;
        string [] _stringsToWordArray;  //String is divided into array of words
        char [][] _inputtedStringCharArray;  //Array of words is divided into many arrays of chars
        char [] _inputtedWordCharArray;  //Original matching word divided into char array.

        public RepeatCounter(string inputtedString, string inputtedWord)
        {
            _inputtedString = inputtedString;
            _inputtedWord = inputtedWord;
            _wordInstances = 0;
            _wordInstancesIncludePlural = 0;
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

        public bool MatchingWord(char [] word)
        {
            for (int j = 0; j < _inputtedWordCharArray.Length; j++)
            {
                if (word[j] != _inputtedWordCharArray[j])
                {
                    return false;
                }
            }
            return true;
        }

        public void IncludePluralWordsInCount()
        {
            foreach (string word in _stringsToWordArray)
            {
                for (int i = 0; i < _stringsToWordArray.Length; i++)
                {
                    for (int j = 0; j < _stringsToWordArray.Length; j++)
                    {
                        _inputtedStringCharArray[i][j] = _stringsToWordArray[j].ToCharArray()[j];
                    }
                    //_inputtedStringCharArray[i] = _stringsToWordArray[i].ToCharArray();
                }
            }

            _inputtedWordCharArray = _upperCaseWord.ToCharArray();

            foreach (char [] charword in _inputtedStringCharArray)
            {
                if (MatchingWord(charword))
                {
                    _wordInstancesIncludePlural++;
                }
            }
        }

        public int CountRepeatsIncludePlural()
        {
            MakeAllUpperCase();
            CreateStringArray();
            IncludePluralWordsInCount();

            return _wordInstancesIncludePlural;
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
