using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AutoMapper.Runtime.Extensions.UnitTesting
{
    internal class ScenarioHelper
    {
        public static Cow Create_Cow()
        {
            return new Cow()
            {
                Bool = Constants.Bool.value1,
                DateTime = Constants.DateTime.value1,
                Decimal = Constants.Decimal.value1,
                Guid = Constants.Guid.value1,
                Int = Constants.Int.value1,
                String = Constants.String.value1,
                Dictionary = new Dictionary<Guid, string>() { { Constants.Guid.value3, "value1" } },

                // Array of primitives
                BoolArray = new bool[] { Constants.Bool.value1, Constants.Bool.value2 },
                DateTimeArray = new DateTime[] { Constants.DateTime.value1, Constants.DateTime.value2 },
                DecimalArray = new decimal[] { Constants.Decimal.value1, Constants.Decimal.value2 },
                GuidArray = new Guid[] { Constants.Guid.value1, Constants.Guid.value2 },
                IntArray = new int[] { Constants.Int.value1, Constants.Int.value2 },
                StringArray = new string[] { Constants.String.value1, Constants.String.value2 },

                // List of primitives
                BoolList = new List<bool>() { Constants.Bool.value1, Constants.Bool.value2 },
                DateTimeList = new List<DateTime>() { Constants.DateTime.value1, Constants.DateTime.value2 },
                DecimalList = new List<decimal>() { Constants.Decimal.value1, Constants.Decimal.value2 },
                GuidList = new List<Guid>() { Constants.Guid.value1, Constants.Guid.value2 },
                IntList = new List<int>() { Constants.Int.value1, Constants.Int.value2 },
                StringList = new List<string>() { Constants.String.value1, Constants.String.value2 }
            };
        }

        public static void Assert_Cow(Cow cow)
        {
            Assert.AreEqual(Constants.Bool.value1, cow.Bool);
            Assert.AreEqual(Constants.DateTime.value1, cow.DateTime);
            Assert.AreEqual(Constants.Decimal.value1, cow.Decimal);
            Assert.AreEqual(Constants.Guid.value1, cow.Guid);
            Assert.AreEqual(Constants.Int.value1, cow.Int);
            Assert.AreEqual(Constants.String.value1, cow.String);
            Assert.AreEqual("value1", cow.Dictionary[Constants.Guid.value3]);

            Assert.AreEqual(Constants.Bool.value1, cow.BoolArray[0]);
            Assert.AreEqual(Constants.Bool.value2, cow.BoolArray[1]);
            Assert.AreEqual(Constants.DateTime.value1, cow.DateTimeArray[0]);
            Assert.AreEqual(Constants.DateTime.value2, cow.DateTimeArray[1]);
            Assert.AreEqual(Constants.Decimal.value1, cow.DecimalArray[0]);
            Assert.AreEqual(Constants.Decimal.value2, cow.DecimalArray[1]);
            Assert.AreEqual(Constants.Guid.value1, cow.GuidArray[0]);
            Assert.AreEqual(Constants.Guid.value2, cow.GuidArray[1]);
            Assert.AreEqual(Constants.Int.value1, cow.IntArray[0]);
            Assert.AreEqual(Constants.Int.value2, cow.IntArray[1]);
            Assert.AreEqual(Constants.String.value1, cow.StringArray[0]);
            Assert.AreEqual(Constants.String.value2, cow.StringArray[1]);

            Assert.AreEqual(Constants.Bool.value1, cow.BoolList[0]);
            Assert.AreEqual(Constants.Bool.value2, cow.BoolList[1]);
            Assert.AreEqual(Constants.DateTime.value1, cow.DateTimeList[0]);
            Assert.AreEqual(Constants.DateTime.value2, cow.DateTimeList[1]);
            Assert.AreEqual(Constants.Decimal.value1, cow.DecimalList[0]);
            Assert.AreEqual(Constants.Decimal.value2, cow.DecimalList[1]);
            Assert.AreEqual(Constants.Guid.value1, cow.GuidList[0]);
            Assert.AreEqual(Constants.Guid.value2, cow.GuidList[1]);
            Assert.AreEqual(Constants.Int.value1, cow.IntList[0]);
            Assert.AreEqual(Constants.Int.value2, cow.IntList[1]);
            Assert.AreEqual(Constants.String.value1, cow.StringList[0]);
            Assert.AreEqual(Constants.String.value2, cow.StringList[1]);
        }

        public static void Assert_Mule(Mule mule)
        {
            Assert.AreEqual(Constants.Bool.value1, mule.Bool);
            Assert.AreEqual(Constants.DateTime.value1, mule.DateTime);
            Assert.AreEqual(Constants.Decimal.value1, mule.Decimal);
            Assert.AreEqual(Constants.Guid.value1, mule.Guid);
            Assert.AreEqual(Constants.Int.value1, mule.Int);
            Assert.AreEqual(Constants.String.value1, mule.String);
            Assert.AreEqual("value1", mule.Dictionary[Constants.Guid.value3]);

            Assert.AreEqual(Constants.Bool.value1, mule.BoolArray[0]);
            Assert.AreEqual(Constants.Bool.value2, mule.BoolArray[1]);
            Assert.AreEqual(Constants.DateTime.value1, mule.DateTimeArray[0]);
            Assert.AreEqual(Constants.DateTime.value2, mule.DateTimeArray[1]);
            Assert.AreEqual(Constants.Decimal.value1, mule.DecimalArray[0]);
            Assert.AreEqual(Constants.Decimal.value2, mule.DecimalArray[1]);
            Assert.AreEqual(Constants.Guid.value1, mule.GuidArray[0]);
            Assert.AreEqual(Constants.Guid.value2, mule.GuidArray[1]);
            Assert.AreEqual(Constants.Int.value1, mule.IntArray[0]);
            Assert.AreEqual(Constants.Int.value2, mule.IntArray[1]);
            Assert.AreEqual(Constants.String.value1, mule.StringArray[0]);
            Assert.AreEqual(Constants.String.value2, mule.StringArray[1]);

            Assert.AreEqual(Constants.Bool.value1, mule.BoolList[0]);
            Assert.AreEqual(Constants.Bool.value2, mule.BoolList[1]);
            Assert.AreEqual(Constants.DateTime.value1, mule.DateTimeList[0]);
            Assert.AreEqual(Constants.DateTime.value2, mule.DateTimeList[1]);
            Assert.AreEqual(Constants.Decimal.value1, mule.DecimalList[0]);
            Assert.AreEqual(Constants.Decimal.value2, mule.DecimalList[1]);
            Assert.AreEqual(Constants.Guid.value1, mule.GuidList[0]);
            Assert.AreEqual(Constants.Guid.value2, mule.GuidList[1]);
            Assert.AreEqual(Constants.Int.value1, mule.IntList[0]);
            Assert.AreEqual(Constants.Int.value2, mule.IntList[1]);
            Assert.AreEqual(Constants.String.value1, mule.StringList[0]);
            Assert.AreEqual(Constants.String.value2, mule.StringList[1]);
        }
    }
}