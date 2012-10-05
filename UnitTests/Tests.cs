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
        public void ToConversationalShouldReturnAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-15);

            string expected = "یک ربع پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnNow()
        {
            DateTime date = DateTime.Now;

            string expected = "هم اکنون";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostNow()
        {
            DateTime date = DateTime.Now.AddSeconds(-30);

            string expected = "لحظاتی قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnFewMinutesAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-5);

            string expected = "چند دقیقه قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-12);

            string expected = "حدود یک ربع پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostHalfAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-23);

            string expected = "حدود نیم ساعت پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnHalfAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-28);

            string expected = "نیم ساعت پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnNMinutesAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-45);

            string expected = "45 دقیقه قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostAnHourAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-57);

            string expected = "حدود یک ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAnHourAgo()
        {
            DateTime date = DateTime.Now.AddHours(-1);

            string expected = "یک ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAnHourAndAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-72);

            string expected = "یک ساعت و ربع پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAnHourAndAHalfAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-95);

            string expected = "یک ساعت و نیم پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostTwoHouresAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-110);

            string expected = "حدود دو ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnTwoHouresAgo()
        {
            DateTime date = DateTime.Now.AddMinutes(-125);

            string expected = "دو ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnTwoHouresAndAQuarterAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-17);

            string expected = "دو ساعت و ربع پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnTwoHouresAndAHalfAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-30);

            string expected = "دو ساعت و نیم پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAlmostThreeHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-41);

            string expected = "حدود سه ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnThreeHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-2).AddMinutes(-56);

            string expected = "سه ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnNHouresAgo()
        {
            DateTime date = DateTime.Now.AddHours(-4).AddMinutes(-56);

            string expected = "4 ساعت قبل";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnToday()
        {
            DateTime date = DateTime.Now.AddHours(-23);

            string expected = "امروز";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnYesterday()
        {
            DateTime date = DateTime.Now.AddDays(-1);

            string expected = "دیروز";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnTheDayBeforeYesterday()
        {
            DateTime date = DateTime.Now.AddDays(-2);

            string expected = "پریروز";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnNDaysAgo()
        {
            DateTime date = DateTime.Now.AddDays(-5);

            string expected = "5 روز پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);

            date = DateTime.Now.AddDays(-12);

            expected = "12 روز پیش";

            actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnAWeekAgo()
        {
            DateTime date = DateTime.Now.AddDays(-6);

            string expected = "یک هفته ی پیش";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToConversationalShouldReturnFullTimeInPersianForTooOldDate()
        {
            DateTime date = new DateTime(2012, 03, 20);

            string expected = "1391/01/01";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ToConversationalShouldReturnFullTimeInPersianForLongFutureDate()
        {
            DateTime date = new DateTime(2020, 03, 20);

            string expected = "1399/01/01";

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ToConversationalShouldReturnFullTimeInPersianForNearFutureDate()
        {
            DateTime date = DateTime.Now.AddMinutes(5);

            string expected = new Farhani.PersianDate.PerDate().GetPersianDate(date);

            string actual = date.ToConversational();

            Assert.AreEqual(expected, actual);

        }

    }
}
