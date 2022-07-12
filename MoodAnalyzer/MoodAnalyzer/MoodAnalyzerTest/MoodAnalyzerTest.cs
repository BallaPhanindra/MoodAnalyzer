using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer.MoodAnalyzerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer.MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void GivenHAPPYMoodShouldReturnHappy()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in HAPPY Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
