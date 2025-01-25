using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Threading;

namespace Charter.Tests
{
    [TestClass]
    public sealed class BasicTests
    {
        [TestMethod]
        public void CanCreateDataPoint()
        {
            DataPoint dataPoint = new();

            Assert.IsNotNull(dataPoint);

            dataPoint.Value = 1;
            dataPoint.Label = "1";

            Assert.AreEqual(1, dataPoint.Value);
        }

        [TestMethod]
        public void HasDeepSleepData()
        {
            Assert.IsNotNull(SampleData.MinutesOfDeepSleep);
            Assert.IsTrue(SampleData.MinutesOfDeepSleep.Count > 0);
        }

        [TestMethod]
        public void AllDeepSleepPointsHaveAForegroundColor()
        {
            Assert.IsFalse(SampleData.MinutesOfDeepSleep.Any(d => d.Foreground == null));
        }

        [TestMethod]
        public void AllDeepSleepPointsHaveALabel()
        {
            Assert.IsFalse(SampleData.MinutesOfDeepSleep.Any(d => d.Label == null));
        }
    }
}
