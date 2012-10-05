// -----------------------------------------------------------------------
// <copyright file="Extensions.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ConversationalDate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Farhani.PersianDate;

    /// <summary>
    /// تبدیل تاریخ به عبارت محاوره ای معادل آن
    /// </summary>
    public static class Extensions
    {
        #region defined ranges

        /// <summary>
        /// محدوده های زمانی و عنوان موردنظر برای آنها
        /// </summary>
        static List<Tuple<TimeSpan[], string>> Ranges = new List<Tuple<TimeSpan[], string>>()
        {
           Tuple.Create(new[]{new TimeSpan(0,0,0,0),new TimeSpan(0,0,0,29)},"هم اکنون"),
           Tuple.Create(new[]{new TimeSpan(0,0,0,30),new TimeSpan(0,0,0,59)},"لحظاتی قبل"),
           Tuple.Create(new[]{new TimeSpan(0,0,1,0),new TimeSpan(0,0,7,59)},"چند دقیقه قبل"),
           Tuple.Create(new[]{new TimeSpan(0,0,8,0),new TimeSpan(0,0,12,59)},"حدود یک ربع پیش"),
           Tuple.Create(new[]{new TimeSpan(0,0,13,0),new TimeSpan(0,0,18,59)},"یک ربع پیش"),
           Tuple.Create(new[]{new TimeSpan(0,0,19,0),new TimeSpan(0,0,25,59)},"حدود نیم ساعت پیش"),
           Tuple.Create(new[]{new TimeSpan(0,0,26,0),new TimeSpan(0,0,35,59)},"نیم ساعت پیش"),
           Tuple.Create(new[]{new TimeSpan(0,0,36,0),new TimeSpan(0,0,49,59)},"{M} دقیقه قبل"),
           Tuple.Create(new[]{new TimeSpan(0,0,50,0),new TimeSpan(0,0,59,59)},"حدود یک ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,1,0,0),new TimeSpan(0,1,10,59)},"یک ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,1,11,0),new TimeSpan(0,1,19,59)},"یک ساعت و ربع پیش"),
           Tuple.Create(new[]{new TimeSpan(0,1,20,0),new TimeSpan(0,1,40,59)},"یک ساعت و نیم پیش"),
           Tuple.Create(new[]{new TimeSpan(0,1,41,0),new TimeSpan(0,1,55,59)},"حدود دو ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,1,56,0),new TimeSpan(0,2,10,59)},"دو ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,2,11,0),new TimeSpan(0,2,19,59)},"دو ساعت و ربع پیش"),
           Tuple.Create(new[]{new TimeSpan(0,2,20,0),new TimeSpan(0,2,40,59)},"دو ساعت و نیم پیش"),
           Tuple.Create(new[]{new TimeSpan(0,2,41,0),new TimeSpan(0,2,55,59)},"حدود سه ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,2,56,0),new TimeSpan(0,2,59,59)},"سه ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,3,0,0),new TimeSpan(0,6,59,59)},"{H} ساعت قبل"),
           Tuple.Create(new[]{new TimeSpan(0,7,0,0),new TimeSpan(0,23,59,59)},"امروز"),
           Tuple.Create(new[]{new TimeSpan(0,24,0,0),new TimeSpan(0,47,59,59)},"دیروز"),
           Tuple.Create(new[]{new TimeSpan(0,48,0,0),new TimeSpan(0,71,59,59)},"پریروز"),
           Tuple.Create(new[]{new TimeSpan(0,72,0,0),new TimeSpan(0,143,59,59)},"{D} روز پیش"),
           Tuple.Create(new[]{new TimeSpan(0,144,0,0),new TimeSpan(0,167,59,59)},"یک هفته ی پیش"),
           Tuple.Create(new[]{new TimeSpan(0,168,0,0),new TimeSpan(0,720,59,59)},"{D} روز پیش"),

        };

        #endregion

        #region Extension methods (1)

        /// <summary>
        /// زمان طی شده از یک تاریخ مشخص نسبت به زمان جاری را محاسبه و در قالب یک عبارت محاوره ای برمی گرداند
        /// </summary>
        /// <param name="from">تاریخ موردنظر به میلادی</param>
        /// <returns></returns>
        public static string ToConversational(this DateTime from)
        {
            // محاسبه تفاوت زمانی
            var differ = DateTime.Now.Subtract(from);

            // حذف میلی ثانیه
            differ = new TimeSpan(differ.Days, differ.Hours, differ.Minutes, differ.Seconds);

            int[] lessThanOrEqual = { -1, 0 };
            int[] greaterThanOrEqual = { 0, 1 };

            var matched = (from range in Ranges
                           where lessThanOrEqual.Contains(range.Item1[0].CompareTo(differ)) // بزرگتر مساوی حد پایین محدوده زمانی باشد
                            && greaterThanOrEqual.Contains(range.Item1[1].CompareTo(differ)) // کوچکتر مساوی حد بالایی محدوده زمانی باشد
                           select range.Item2).FirstOrDefault();


            if (!string.IsNullOrEmpty(matched))
            {
                return InjectDateParts(differ, matched);
            }
            else
            {
                return new PerDate().GetPersianDate(from);
            }

            

        }

        #endregion

        #region Private Methods (1)

        /// <summary>
        /// مقداردهی به متغیرهای زمانی تعیین شده در متن عبارت
        /// </summary>
        /// <param name="differ">تفاوت زمانی با زمان جاری</param>
        /// <param name="expression">عبارت معادل تفاوت زمانی</param>
        /// <returns></returns>
        static string InjectDateParts(TimeSpan differ, string expression)
        {
            expression = expression.Replace("{H}", differ.Hours.ToString());

            expression = expression.Replace("{M}", differ.Minutes.ToString());

            expression = expression.Replace("{D}", differ.Days.ToString());

            return expression;
        }

        #endregion
    }
}
