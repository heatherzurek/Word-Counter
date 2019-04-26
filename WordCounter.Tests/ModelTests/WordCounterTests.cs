using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("catdog");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetFindWord_ReturnsFindWord_String()
    {
      string findWord = "puppykitten";
      Word newWord = new Word("puppykitten");

      string result = newWord.GetFindWord();
      Assert.AreEqual(findWord, result);
    }

    [TestMethod]
    public void SetFindWord_SetFindWord_Int()
    {
        string oldFindWord = "puppykitten";
        string newFindWord = "puppydog";
        Word newWord = new Word(oldFindWord);

        newWord.SetFindWord(newFindWord);
        string result = newWord.GetFindWord();
        Assert.AreEqual(newFindWord, result);
    }

    [TestMethod]
    public void SearchForWord_SearchStringForWord_Int()
    {
      string findWord = "puppy";
      string searchForWord = "Would you like a puppy";
      Word newWord = new Word(findWord);
      int expectedOut = 1;

      newWord.SearchForWord(searchForWord);
      int result = newWord.GetWordCount()
      Assert.AreEqual(expectedOut, result);
    }

    //i need a test here to add how many times the word occurs in total

  }
}
