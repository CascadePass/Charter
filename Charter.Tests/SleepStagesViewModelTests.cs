using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charter.Tests
{
    [TestClass]
    public class SleepStagesViewModelTests
    {
        [TestMethod]
        public void CorrectNumberOfLabels()
        {
            SleepStagesViewModel vm = new();

            Assert.AreEqual(vm.MuseDeepSleepMinutes.Length, vm.Labels.Length);
            Console.WriteLine($"vm.MuseDeepSleepMinutes and vm.Labels have {vm.Labels.Length} items.");
        }

        [TestMethod]
        public void DeepSleepSameNumbersOfPoints()
        {
            SleepStagesViewModel vm = new();

            Assert.AreEqual(vm.MuseDeepSleepMinutes.Length, vm.GarminDeepSleepMinutes.Length);
            Console.WriteLine($"vm.MuseDeepSleepMinutes and vm.GarminDeepSleepMinutes have {vm.Labels.Length} items.");
        }
    }
}
