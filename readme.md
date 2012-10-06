#System.DateTime .ToConversational() Extension Method#
================================

**Purpose**

this extension methods calculates TimeSpan between DateTime.Now and the selected DateTime and returns a conversational form of the DateTime using a builtin dictionary

**Usage**

'''c#

DateTime date =DateTime.Now.AddMinutes(-30);

Label1.Text = date.ToConversational(); // "نیم ساعت قبل"

'''

for more samples check Unit Test project 

**Dependecies**

this method uses [Farhani.PersianDate](barnamenevis.org/showthread.php?90830) dll to convert not founded in dictionary DateTimes to persian dates.