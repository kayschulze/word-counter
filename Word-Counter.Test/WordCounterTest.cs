using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Test
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void CountRepeats_CountOneInstanceOfWord_True()
    {
      //Arrange
      int expectedValue = 1;
      string originalString = "I used to own a cat";
      string originalWord = "cat";
      RepeatCounter newCounter = new RepeatCounter(originalString, originalWord);

      //Act
      int actualValue = newCounter.CountRepeats();

      //Assert
      Assert.AreEqual(expectedValue, actualValue);
    }

  }
}
