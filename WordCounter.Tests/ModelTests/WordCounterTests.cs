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
      Word newWord = new Word("dog");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetFindWord_ReturnsFindWord_String()
    {
      string findWord = "puppy";
      Word newWord = new Word("puppy");

      string result = newWord.GetFindWord();
      Assert.AreEqual(findWord, result);
    }

    [TestMethod]
    public void SetFindWord_SetFindWord_String()
    {
        string oldFindWord = "puppy";
        string newFindWord = "puppydog";
        Word newWord = new Word(oldFindWord);

        newWord.SetFindWord(newFindWord);
        string result = newWord.GetFindWord();
        Assert.AreEqual(newFindWord, result);
    }

    [TestMethod]
    public void SearchForWord_SearchStringForWord_Int()
    {
      string findWord = "dog";
      string searchForWord = "I own a dog";
      Word newWord = new Word(findWord);
      int expectedOut = 1;

      newWord.SearchForWord(searchForWord);
      int result = int.Parse(newWord.GetFindWord());
      Assert.AreEqual(expectedOut, result);
    }

  }
}
