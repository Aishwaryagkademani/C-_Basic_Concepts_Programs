using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingWithMsTesting;

namespace MoodAnalyserMsTesting1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnalyserMsTesting test1 = new MoodAnalyserMsTesting();

            string arrange = "sad";
            string act = test1.SadMoodAnalyser("I am very sad");
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MoodAnalyserMsTesting test2 = new MoodAnalyserMsTesting();

            string arrange = "happy";
            string act = test2.HappyMoodAnalyser("You seem to be happy today");
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void TestingarrayNoOfElements()
        {
            int count = 6;
            CountNoOfElements t1 = new CountNoOfElements();
            Assert.AreEqual(count, t1.Arraycount(new int[] { 12, 32, 43, 54, 63, 24 }));
        }

    }
}
