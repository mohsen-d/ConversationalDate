﻿System.DateTime .ToConversational() Extension Method
================================

**Purpose**

this extension calculates the TimeSpan between DateTime.Now and the selected DateTime and returns a conversational form of the DateTime using a built-in dictionary

**Usage**

<pre>
using ConversationalDate;
.
.
.

DateTime date = DateTime.Now.AddMinutes(-30);

Label1.Text = date.ToConversational(); // "نیم ساعت قبل"

</pre>

for more samples check Unit Test project 

**Dependecies**

this method uses [Farhani.PersianDate](http://barnamenevis.org/showthread.php?90830) dll to convert DateTimes not founded in dictionary to persian dates.
