// -----------------------------------------------------------------------
// <copyright file="Tests.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using ConversationalDate;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void TimeElapsedShouldReturnAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-15);

            string expected = "یک ربع پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnNow()
        {
            DateTime date = DateTime.Now.AddSeconds(-1);

            string expected = "هم اکنون";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostNow()
        {
            DateTime date = DateTime.Now.AddSeconds(-30);

            string expected = "لحظاتی قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnFewMinutesAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-5);

            string expected = "چند دقیقه قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-12);

            string expected = "حدود یک ربع پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostHalfAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-23);

            string expected = "حدود نیم ساعت پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnHalfAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-28);

            string expected = "نیم ساعت پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnNMinutesAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-45);

            string expected = "45 دقیقه قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-57);

            string expected = "حدود یک ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAnHourAgo()
        {
            DateTime date = DateTime.Now.AddHours(-1);

            string expected = "یک ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAnHourAndAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-72);

            string expected = "یک ساعت و ربع پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAnHourAndAHalfAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-95);

            string expected = "یک ساعت و نیم پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostTwoHouresAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-110);

            string expected = "حدود دو ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnTwoHouresAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-125);

            string expected = "دو ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnTwoHouresAndAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-17);

            string expected = "دو ساعت و ربع پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnTwoHouresAndAHalfAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-30);

            string expected = "دو ساعت و نیم پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAlmostThreeHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-41);

            string expected = "حدود سه ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnThreeHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-56);

            string expected = "سه ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnNHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-4).AddMinutes(-56);

            string expected = "4 ساعت قبل";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnToday()
        {
            DateTime date = DateTime.Now.AddHours(-23);

            string expected = "امروز";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnYesterday()
        {
            DateTime date = DateTime.Now.AddDays(-1);

            string expected = "دیروز";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnTheDayBeforeYesterday()
        {
            DateTime date = DateTime.Now.AddDays(-2);

            string expected = "پریروز";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnNDaysAgo()
        {
            DateTime date = DateTime.Now.AddDays(-5);

            string expected = "5 روز پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);

            date = DateTime.Now.AddDays(-12);

            expected = "12 روز پیش";

            actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TimeElapsedShouldReturnAWeekAgo()
        {
            DateTime date = DateTime.Now.AddDays(-6);

            string expected = "یک هفته ی پیش";

            string actual = date.ElapsedTime();

            Assert.AreEqual(expected, actual);
        }


    }
}
