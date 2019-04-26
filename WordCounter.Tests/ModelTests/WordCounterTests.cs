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

  }
}
