using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper.Runtime.Extensions.UnitTesting
{
    internal class ScenarioHelper
    {
        public static Cow Create_Cow()
        {
            return new Cow()
            {
                Bool = true,
                DateTime = new DateTime(2010, 01, 02),
                Decimal = 10.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"),
                Int = 123,
                String = "123",
                Dictionary = new Dictionary<Guid, string>() { { new Guid("46A93CC8-64A0-4D77-9600-4B694E40DEBF"), "value1" } },

                // Array of primitives
                BoolArray = new bool[] { true, false },
                DateTimeArray = new DateTime[] { new DateTime(2010, 01, 02), new DateTime(2011, 01, 02) },
                DecimalArray = new decimal[] { 10.10M, 20.20M },
                GuidArray = new Guid[] { new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9") },
                IntArray = new int[] { 123, 234 },
                StringArray = new string[] { "123", "234" },

                // List of primitives
                BoolList = new List<bool>() { true, false },
                DateTimeList = new List<DateTime>() { new DateTime(2010, 01, 02), new DateTime(2011, 01, 02) },
                DecimalList = new List<decimal>() { 10.10M, 20.20M },
                GuidList = new List<Guid>() { new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9") },
                IntList = new List<int>() { 123, 234 },
                StringList = new List<string>() { "123", "234" }
            };
        }

        public static void Assert_Cow(Cow cow)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, cow.Bool);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), cow.DateTime);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, cow.Decimal);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), cow.Guid);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, cow.Int);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", cow.String);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("value1", cow.Dictionary[new Guid("46A93CC8-64A0-4D77-9600-4B694E40DEBF")]);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, cow.BoolArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, cow.BoolArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), cow.DateTimeArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2011, 01, 02), cow.DateTimeArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, cow.DecimalArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20.20M, cow.DecimalArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), cow.GuidArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9"), cow.GuidArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, cow.IntArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(234, cow.IntArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", cow.StringArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("234", cow.StringArray[1]);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, cow.BoolList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, cow.BoolList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), cow.DateTimeList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2011, 01, 02), cow.DateTimeList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, cow.DecimalList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20.20M, cow.DecimalList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), cow.GuidList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9"), cow.GuidList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, cow.IntList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(234, cow.IntList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", cow.StringList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("234", cow.StringList[1]);
        }

        public static Mule Create_Mule()
        {
            return new Mule()
            {
                Bool = true,
                DateTime = new DateTime(2010, 01, 02),
                Decimal = 10.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"),
                Int = 123,
                String = "123",
                Dictionary = new Dictionary<Guid, string>() { { new Guid("46A93CC8-64A0-4D77-9600-4B694E40DEBF"), "value1" } },

                // Array of primitives
                BoolArray = new bool[] { true, false },
                DateTimeArray = new DateTime[] { new DateTime(2010, 01, 02), new DateTime(2011, 01, 02) },
                DecimalArray = new decimal[] { 10.10M, 20.20M },
                GuidArray = new Guid[] { new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9") },
                IntArray = new int[] { 123, 234 },
                StringArray = new string[] { "123", "234" },

                // List of primitives
                BoolList = new List<bool>() { true, false },
                DateTimeList = new List<DateTime>() { new DateTime(2010, 01, 02), new DateTime(2011, 01, 02) },
                DecimalList = new List<decimal>() { 10.10M, 20.20M },
                GuidList = new List<Guid>() { new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9") },
                IntList = new List<int>() { 123, 234 },
                StringList = new List<string>() { "123", "234" }
            };
        }

        public static void Assert_Mule(Mule mule)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, mule.Bool);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), mule.DateTime);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, mule.Decimal);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), mule.Guid);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, mule.Int);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", mule.String);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("value1", mule.Dictionary[new Guid("46A93CC8-64A0-4D77-9600-4B694E40DEBF")]);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, mule.BoolArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, mule.BoolArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), mule.DateTimeArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2011, 01, 02), mule.DateTimeArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, mule.DecimalArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20.20M, mule.DecimalArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), mule.GuidArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9"), mule.GuidArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, mule.IntArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(234, mule.IntArray[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", mule.StringArray[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("234", mule.StringArray[1]);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, mule.BoolList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, mule.BoolList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2010, 01, 02), mule.DateTimeList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new DateTime(2011, 01, 02), mule.DateTimeList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(10.10M, mule.DecimalList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(20.20M, mule.DecimalList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D82FE84DBD9"), mule.GuidList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-9D82FE84DBD9"), mule.GuidList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(123, mule.IntList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(234, mule.IntList[1]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("123", mule.StringList[0]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("234", mule.StringList[1]);
        }
    }
}
