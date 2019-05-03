using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      RepeatCounter newWord = new Word("ostrich");
      Assert.AreEqual(typeof(RepeatCounter), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string findWord = "wolf";
      Word newWord = new Word("wolf");

      string result = newWord.GetWord();
      Assert.AreEqual(newWord, result);
    }

    [TestMethod]
    public void SetWord_SetWord_Int()
    {
        string oldFindWord = "buffalo";
        string newFindWord = "otter";
        Word newWord = new Word(oldFindWord);

        newWord.SetFindWord(newFindWord);
        string result = newWord.GetFindWord();
        Assert.AreEqual(newFindWord, result);
    }

    [TestMethod]
    public void SearchForWord_SearchStringForWord_Int()
    {
      string findWord = "otters";
      string searchForWord = "so many otters chasing a butterfly, extra otters";
      Word newWord = new Word(findWord);
      int expectedOut = 2;

      newWord.SearchForWord(searchForWord);
      int result = newWord.GetWordCount();
      Assert.AreEqual(expectedOut, result);
    }
  }
}
