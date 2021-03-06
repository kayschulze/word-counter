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
    public void CountRepeats_CountMultipleInstancesOfWord_True()
    {
      //Arrange
      int expectedValue = 2;
      string originalString = "The cat that I like the most is Callie cat";
      string originalWord = "cat";
      RepeatCounter newCounter = new RepeatCounter(originalWord, originalString);

      //Act
      int actualValue = newCounter.CountRepeats();

      //Assert
      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestMethod]
    public void CountRepeats_CountWordsDespiteCase_True()
    {
      //Arrange
      int expectedValue = 2;
      string originalString = "Cat toys include cat nip";
      string originalWord = "cat";
      RepeatCounter newCounter = new RepeatCounter(originalWord, originalString);

      //Act
      int actualValue = newCounter.CountRepeats();

      //Assert
      Assert.AreEqual(expectedValue, actualValue);
    }

  }
}
