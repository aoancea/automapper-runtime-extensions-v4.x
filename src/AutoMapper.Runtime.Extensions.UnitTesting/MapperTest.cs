﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AutoMapper.Runtime.Extensions.UnitTesting
{
    [TestClass]
    public class MapperTest
    {
        [TestMethod]
        public void DeepCopyTo_SourceAndDestinationTypeAreTheSame_DestinationCopied()
        {
            Cow source = ScenarioHelper.Create_Cow();

            Cow destination = source.DeepCopyTo<Cow>();

            Assert.AreNotEqual(source, destination);

            ScenarioHelper.Assert_Cow(destination);
        }

        [TestMethod]
        public void DeepCopyTo_SourceAndDestinationAreDifferentTypeButContainTheSameProperties_DestinationCopied()
        {
            Cow source = ScenarioHelper.Create_Cow();

            Mule destination = source.DeepCopyTo<Mule>();

            Assert.AreNotEqual(source, destination);

            ScenarioHelper.Assert_Mule(destination);
        }

        [TestMethod]
        public void DeepCopyTo_ArrayToArrayOfSameType_DestinationCopied()
        {
            Cow[] source = new Cow[1]
            {
                 ScenarioHelper.Create_Cow()
            };

            Cow[] destination = source.DeepCopyTo<Cow[]>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Length);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Cow(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ArrayToArrayOfDifferentTypesButWithSameProperties_DestinationCopied()
        {
            Cow[] source = new Cow[1]
            {
                 ScenarioHelper.Create_Cow()
            };

            Mule[] destination = source.DeepCopyTo<Mule[]>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Length);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Mule(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ListToListOfSameType_DestinationCopied()
        {
            List<Cow> source = new List<Cow>
            {
                 ScenarioHelper.Create_Cow()
            };

            List<Cow> destination = source.DeepCopyTo<List<Cow>>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Count);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Cow(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ListToListOfDifferentTypesButWithSameProperties_DestinationCopied()
        {
            List<Cow> source = new List<Cow>
            {
                 ScenarioHelper.Create_Cow()
            };

            List<Mule> destination = source.DeepCopyTo<List<Mule>>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Count);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Mule(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ArrayToListOfSameType_DestinationCopied()
        {
            Cow[] source = new Cow[1]
            {
                 ScenarioHelper.Create_Cow()
            };

            List<Cow> destination = source.DeepCopyTo<List<Cow>>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Count);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Cow(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ArrayToListOfDifferentTypesButWithSameProperties_DestinationCopied()
        {
            Cow[] source = new Cow[1]
            {
                 ScenarioHelper.Create_Cow()
            };

            List<Mule> destination = source.DeepCopyTo<List<Mule>>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Count);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Mule(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ListToArrayOfSameType_DestinationCopied()
        {
            List<Cow> source = new List<Cow>
            {
                 ScenarioHelper.Create_Cow()
            };

            Cow[] destination = source.DeepCopyTo<Cow[]>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Length);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Cow(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_ListToArrayOfDifferentTypesButWithSameProperties_DestinationCopied()
        {
            List<Cow> source = new List<Cow>
            {
                 ScenarioHelper.Create_Cow()
            };

            Mule[] destination = source.DeepCopyTo<Mule[]>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(1, destination.Length);
            Assert.AreNotEqual(source[0], destination[0]);

            ScenarioHelper.Assert_Mule(destination[0]);
        }

        [TestMethod]
        public void DeepCopyTo_DictionaryToDictionaryOfSameType_DestinationCopied()
        {
            Dictionary<Guid, string> source = new Dictionary<Guid, string>()
            {
                { new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20"), "value1" },
                { new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1"), "value2" },
                { new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08"), "value3" },
            };

            Dictionary<Guid, string> destination = source.DeepCopyTo<Dictionary<Guid, string>>();

            Assert.AreEqual("value1", destination[new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20")]);
            Assert.AreEqual("value2", destination[new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1")]);
            Assert.AreEqual("value3", destination[new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08")]);
        }

        [TestMethod]
        public void DeepCopyTo_DictionaryToDictionaryOfSameTypeWithCustomValue_DestinationCopied()
        {
            Dictionary<Guid, Cow> source = new Dictionary<Guid, Cow>()
            {
                { new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20"), ScenarioHelper.Create_Cow() },
                { new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1"), ScenarioHelper.Create_Cow() },
                { new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08"), ScenarioHelper.Create_Cow() },
            };

            Dictionary<Guid, Cow> destination = source.DeepCopyTo<Dictionary<Guid, Cow>>();

            Cow destinationItem1 = destination[new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20")];
            Cow destinationItem2 = destination[new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1")];
            Cow destinationItem3 = destination[new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08")];

            Assert.AreNotEqual(source[new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20")], destinationItem1);
            Assert.AreNotEqual(source[new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1")], destinationItem2);
            Assert.AreNotEqual(source[new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08")], destinationItem3);

            ScenarioHelper.Assert_Cow(destinationItem1);
            ScenarioHelper.Assert_Cow(destinationItem2);
            ScenarioHelper.Assert_Cow(destinationItem3);
        }

        [TestMethod]
        public void DeepCopyTo_DictionaryToDictionaryDifferentTypesWithCustomValue_DestinationCopied()
        {
            Dictionary<Guid, Cow> source = new Dictionary<Guid, Cow>()
            {
                { new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20"), ScenarioHelper.Create_Cow() },
                { new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1"), ScenarioHelper.Create_Cow() },
                { new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08"), ScenarioHelper.Create_Cow() },
            };

            Dictionary<Guid, Mule> destination = source.DeepCopyTo<Dictionary<Guid, Mule>>();

            Mule destinationItem1 = destination[new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20")];
            Mule destinationItem2 = destination[new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1")];
            Mule destinationItem3 = destination[new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08")];

            Assert.AreNotEqual(source[new Guid("35B5042A-24B9-4308-91CA-806FDEFFCE20")], destinationItem1);
            Assert.AreNotEqual(source[new Guid("59236B13-AFBC-4C87-94DD-F0010A2319C1")], destinationItem2);
            Assert.AreNotEqual(source[new Guid("ADF639AB-4AB4-48BC-BAC0-E25DC9915F08")], destinationItem3);

            ScenarioHelper.Assert_Mule(destinationItem1);
            ScenarioHelper.Assert_Mule(destinationItem2);
            ScenarioHelper.Assert_Mule(destinationItem3);
        }

        [TestMethod]
        public void DeepCopyTo_WhenSourceAndDestinationHaveDifferentAggregatedTypes_ThenDestinationIsCopied()
        {
            A_BigClass source = new A_BigClass()
            {
                Bool = true,
                DateTime = new DateTime(2011, 01, 02),
                Decimal = 14.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"),
                Int = 4141,
                String = "1142",

                FirstClass = new A_FirstClass()
                {
                    Bool = true,
                    DateTime = new DateTime(2012, 01, 02),
                    Decimal = 66.10M,
                    Guid = new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"),
                    Int = 54,
                    String = "8567",

                    FirstClassFirstSubClass = new A_FirstClassFirstSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2013, 01, 02),
                        Decimal = 324.10M,
                        Guid = new Guid("8DA43611-A758-4EB7-A352-8D82FE84DBD9"),
                        Int = 7345,
                        String = "834"
                    },
                    FirstClassSecondSubClass = new A_FirstClassSecondSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2014, 01, 02),
                        Decimal = 523.10M,
                        Guid = new Guid("8DA4C611-A758-4EB7-A352-8482FE84DBD9"),
                        Int = 235,
                        String = "978"
                    }
                },

                SecondClass = new A_SecondClass()
                {
                    Bool = true,
                    DateTime = new DateTime(2015, 01, 02),
                    Decimal = 78.10M,
                    Guid = new Guid("8DA4C611-3758-4EB7-A352-8D82FE84DBD9"),
                    Int = 2346,
                    String = "5",

                    SecondClassFirstSubClass = new A_SecondClassFirstSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2016, 01, 02),
                        Decimal = 32.10M,
                        Guid = new Guid("8DA41611-A758-4EB7-A352-8D82FE84DBD9"),
                        Int = 8,
                        String = "7089"
                    },
                    SecondClassSecondSubClass = new A_SecondClassSecondSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2017, 01, 02),
                        Decimal = 56.10M,
                        Guid = new Guid("8DA44611-A758-4EB7-A352-8D82FE844BD9"),
                        Int = 5,
                        String = "887"
                    }
                }
            };

            B_BigClass destination = source.DeepCopyTo<B_BigClass>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(true, destination.Bool);
            Assert.AreEqual(new DateTime(2011, 01, 02), destination.DateTime);
            Assert.AreEqual(14.10M, destination.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"), destination.Guid);
            Assert.AreEqual(4141, destination.Int);
            Assert.AreEqual("1142", destination.String);

            Assert.AreNotEqual(source.FirstClass, destination.FirstClass);
            Assert.AreEqual(true, destination.FirstClass.Bool);
            Assert.AreEqual(new DateTime(2012, 01, 02), destination.FirstClass.DateTime);
            Assert.AreEqual(66.10M, destination.FirstClass.Decimal);
            Assert.AreEqual(new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"), destination.FirstClass.Guid);
            Assert.AreEqual(54, destination.FirstClass.Int);
            Assert.AreEqual("8567", destination.FirstClass.String);

            Assert.AreNotEqual(source.FirstClass.FirstClassFirstSubClass, destination.FirstClass.FirstClassFirstSubClass);
            Assert.AreEqual(true, destination.FirstClass.FirstClassFirstSubClass.Bool);
            Assert.AreEqual(new DateTime(2013, 01, 02), destination.FirstClass.FirstClassFirstSubClass.DateTime);
            Assert.AreEqual(324.10M, destination.FirstClass.FirstClassFirstSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA43611-A758-4EB7-A352-8D82FE84DBD9"), destination.FirstClass.FirstClassFirstSubClass.Guid);
            Assert.AreEqual(7345, destination.FirstClass.FirstClassFirstSubClass.Int);
            Assert.AreEqual("834", destination.FirstClass.FirstClassFirstSubClass.String);

            Assert.AreNotEqual(source.FirstClass.FirstClassSecondSubClass, destination.FirstClass.FirstClassSecondSubClass);
            Assert.AreEqual(true, destination.FirstClass.FirstClassSecondSubClass.Bool);
            Assert.AreEqual(new DateTime(2014, 01, 02), destination.FirstClass.FirstClassSecondSubClass.DateTime);
            Assert.AreEqual(523.10M, destination.FirstClass.FirstClassSecondSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8482FE84DBD9"), destination.FirstClass.FirstClassSecondSubClass.Guid);
            Assert.AreEqual(235, destination.FirstClass.FirstClassSecondSubClass.Int);
            Assert.AreEqual("978", destination.FirstClass.FirstClassSecondSubClass.String);

            Assert.AreNotEqual(source.SecondClass, destination.SecondClass);
            Assert.AreEqual(true, destination.SecondClass.Bool);
            Assert.AreEqual(new DateTime(2015, 01, 02), destination.SecondClass.DateTime);
            Assert.AreEqual(78.10M, destination.SecondClass.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-3758-4EB7-A352-8D82FE84DBD9"), destination.SecondClass.Guid);
            Assert.AreEqual(2346, destination.SecondClass.Int);
            Assert.AreEqual("5", destination.SecondClass.String);

            Assert.AreNotEqual(source.SecondClass.SecondClassFirstSubClass, destination.SecondClass.SecondClassFirstSubClass);
            Assert.AreEqual(true, destination.SecondClass.SecondClassFirstSubClass.Bool);
            Assert.AreEqual(new DateTime(2016, 01, 02), destination.SecondClass.SecondClassFirstSubClass.DateTime);
            Assert.AreEqual(32.10M, destination.SecondClass.SecondClassFirstSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA41611-A758-4EB7-A352-8D82FE84DBD9"), destination.SecondClass.SecondClassFirstSubClass.Guid);
            Assert.AreEqual(8, destination.SecondClass.SecondClassFirstSubClass.Int);
            Assert.AreEqual("7089", destination.SecondClass.SecondClassFirstSubClass.String);

            Assert.AreNotEqual(source.SecondClass.SecondClassSecondSubClass, destination.SecondClass.SecondClassSecondSubClass);
            Assert.AreEqual(true, destination.SecondClass.SecondClassSecondSubClass.Bool);
            Assert.AreEqual(new DateTime(2017, 01, 02), destination.SecondClass.SecondClassSecondSubClass.DateTime);
            Assert.AreEqual(56.10M, destination.SecondClass.SecondClassSecondSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA44611-A758-4EB7-A352-8D82FE844BD9"), destination.SecondClass.SecondClassSecondSubClass.Guid);
            Assert.AreEqual(5, destination.SecondClass.SecondClassSecondSubClass.Int);
            Assert.AreEqual("887", destination.SecondClass.SecondClassSecondSubClass.String);
        }

        [TestMethod]
        public void DeepCopyTo_WhenSourceAndDestinationHaveTheSameAggregatedType_ThenDestinationIsCopied()
        {
            A_BigClass source = new A_BigClass()
            {
                Bool = true,
                DateTime = new DateTime(2011, 01, 02),
                Decimal = 14.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"),
                Int = 4141,
                String = "1142",

                FirstClass = new A_FirstClass()
                {
                    Bool = true,
                    DateTime = new DateTime(2012, 01, 02),
                    Decimal = 66.10M,
                    Guid = new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"),
                    Int = 54,
                    String = "8567",

                    FirstClassFirstSubClass = new A_FirstClassFirstSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2013, 01, 02),
                        Decimal = 324.10M,
                        Guid = new Guid("8DA43611-A758-4EB7-A352-8D82FE84DBD9"),
                        Int = 7345,
                        String = "834"
                    },
                    FirstClassSecondSubClass = new A_FirstClassSecondSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2014, 01, 02),
                        Decimal = 523.10M,
                        Guid = new Guid("8DA4C611-A758-4EB7-A352-8482FE84DBD9"),
                        Int = 235,
                        String = "978"
                    }
                },

                SecondClass = new A_SecondClass()
                {
                    Bool = true,
                    DateTime = new DateTime(2015, 01, 02),
                    Decimal = 78.10M,
                    Guid = new Guid("8DA4C611-3758-4EB7-A352-8D82FE84DBD9"),
                    Int = 2346,
                    String = "5",

                    SecondClassFirstSubClass = new A_SecondClassFirstSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2016, 01, 02),
                        Decimal = 32.10M,
                        Guid = new Guid("8DA41611-A758-4EB7-A352-8D82FE84DBD9"),
                        Int = 8,
                        String = "7089"
                    },
                    SecondClassSecondSubClass = new A_SecondClassSecondSubClass()
                    {
                        Bool = true,
                        DateTime = new DateTime(2017, 01, 02),
                        Decimal = 56.10M,
                        Guid = new Guid("8DA44611-A758-4EB7-A352-8D82FE844BD9"),
                        Int = 5,
                        String = "887"
                    }
                }
            };

            A_BigClass destination = source.DeepCopyTo<A_BigClass>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(true, destination.Bool);
            Assert.AreEqual(new DateTime(2011, 01, 02), destination.DateTime);
            Assert.AreEqual(14.10M, destination.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"), destination.Guid);
            Assert.AreEqual(4141, destination.Int);
            Assert.AreEqual("1142", destination.String);

            Assert.AreNotEqual(source.FirstClass, destination.FirstClass);
            Assert.AreEqual(true, destination.FirstClass.Bool);
            Assert.AreEqual(new DateTime(2012, 01, 02), destination.FirstClass.DateTime);
            Assert.AreEqual(66.10M, destination.FirstClass.Decimal);
            Assert.AreEqual(new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"), destination.FirstClass.Guid);
            Assert.AreEqual(54, destination.FirstClass.Int);
            Assert.AreEqual("8567", destination.FirstClass.String);

            Assert.AreNotEqual(source.FirstClass.FirstClassFirstSubClass, destination.FirstClass.FirstClassFirstSubClass);
            Assert.AreEqual(true, destination.FirstClass.FirstClassFirstSubClass.Bool);
            Assert.AreEqual(new DateTime(2013, 01, 02), destination.FirstClass.FirstClassFirstSubClass.DateTime);
            Assert.AreEqual(324.10M, destination.FirstClass.FirstClassFirstSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA43611-A758-4EB7-A352-8D82FE84DBD9"), destination.FirstClass.FirstClassFirstSubClass.Guid);
            Assert.AreEqual(7345, destination.FirstClass.FirstClassFirstSubClass.Int);
            Assert.AreEqual("834", destination.FirstClass.FirstClassFirstSubClass.String);

            Assert.AreNotEqual(source.FirstClass.FirstClassSecondSubClass, destination.FirstClass.FirstClassSecondSubClass);
            Assert.AreEqual(true, destination.FirstClass.FirstClassSecondSubClass.Bool);
            Assert.AreEqual(new DateTime(2014, 01, 02), destination.FirstClass.FirstClassSecondSubClass.DateTime);
            Assert.AreEqual(523.10M, destination.FirstClass.FirstClassSecondSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8482FE84DBD9"), destination.FirstClass.FirstClassSecondSubClass.Guid);
            Assert.AreEqual(235, destination.FirstClass.FirstClassSecondSubClass.Int);
            Assert.AreEqual("978", destination.FirstClass.FirstClassSecondSubClass.String);

            Assert.AreNotEqual(source.SecondClass, destination.SecondClass);
            Assert.AreEqual(true, destination.SecondClass.Bool);
            Assert.AreEqual(new DateTime(2015, 01, 02), destination.SecondClass.DateTime);
            Assert.AreEqual(78.10M, destination.SecondClass.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-3758-4EB7-A352-8D82FE84DBD9"), destination.SecondClass.Guid);
            Assert.AreEqual(2346, destination.SecondClass.Int);
            Assert.AreEqual("5", destination.SecondClass.String);

            Assert.AreNotEqual(source.SecondClass.SecondClassFirstSubClass, destination.SecondClass.SecondClassFirstSubClass);
            Assert.AreEqual(true, destination.SecondClass.SecondClassFirstSubClass.Bool);
            Assert.AreEqual(new DateTime(2016, 01, 02), destination.SecondClass.SecondClassFirstSubClass.DateTime);
            Assert.AreEqual(32.10M, destination.SecondClass.SecondClassFirstSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA41611-A758-4EB7-A352-8D82FE84DBD9"), destination.SecondClass.SecondClassFirstSubClass.Guid);
            Assert.AreEqual(8, destination.SecondClass.SecondClassFirstSubClass.Int);
            Assert.AreEqual("7089", destination.SecondClass.SecondClassFirstSubClass.String);

            Assert.AreNotEqual(source.SecondClass.SecondClassSecondSubClass, destination.SecondClass.SecondClassSecondSubClass);
            Assert.AreEqual(true, destination.SecondClass.SecondClassSecondSubClass.Bool);
            Assert.AreEqual(new DateTime(2017, 01, 02), destination.SecondClass.SecondClassSecondSubClass.DateTime);
            Assert.AreEqual(56.10M, destination.SecondClass.SecondClassSecondSubClass.Decimal);
            Assert.AreEqual(new Guid("8DA44611-A758-4EB7-A352-8D82FE844BD9"), destination.SecondClass.SecondClassSecondSubClass.Guid);
            Assert.AreEqual(5, destination.SecondClass.SecondClassSecondSubClass.Int);
            Assert.AreEqual("887", destination.SecondClass.SecondClassSecondSubClass.String);
        }

        [TestMethod]
        public void DeepCopyTo_WhenSourceAndDestinationHaveSameTypeWithCircularReference_ThenDestinationIsCopied()
        {
            A_CircularReference source = new A_CircularReference()
            {
                Bool = true,
                DateTime = new DateTime(2011, 01, 02),
                Decimal = 14.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"),
                Int = 4141,
                String = "1142",

                CircularReferenceProperty = new A_CircularReference()
                {
                    Bool = true,
                    DateTime = new DateTime(2012, 01, 02),
                    Decimal = 66.10M,
                    Guid = new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"),
                    Int = 54,
                    String = "8567",
                }
            };

            A_CircularReference destination = source.DeepCopyTo<A_CircularReference>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(true, destination.Bool);
            Assert.AreEqual(new DateTime(2011, 01, 02), destination.DateTime);
            Assert.AreEqual(14.10M, destination.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"), destination.Guid);
            Assert.AreEqual(4141, destination.Int);
            Assert.AreEqual("1142", destination.String);

            Assert.AreNotEqual(source.CircularReferenceProperty, destination.CircularReferenceProperty);
            Assert.AreEqual(true, destination.CircularReferenceProperty.Bool);
            Assert.AreEqual(new DateTime(2012, 01, 02), destination.CircularReferenceProperty.DateTime);
            Assert.AreEqual(66.10M, destination.CircularReferenceProperty.Decimal);
            Assert.AreEqual(new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"), destination.CircularReferenceProperty.Guid);
            Assert.AreEqual(54, destination.CircularReferenceProperty.Int);
            Assert.AreEqual("8567", destination.CircularReferenceProperty.String);

            Assert.IsNull(destination.CircularReferenceProperty.CircularReferenceProperty);
        }

        [TestMethod]
        public void DeepCopyTo_WhenSourceAndDestinationHaveDifferentTypeWithCircularReference_ThenDestinationIsCopied()
        {
            A_CircularReference source = new A_CircularReference()
            {
                Bool = true,
                DateTime = new DateTime(2011, 01, 02),
                Decimal = 14.10M,
                Guid = new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"),
                Int = 4141,
                String = "1142",

                CircularReferenceProperty = new A_CircularReference()
                {
                    Bool = true,
                    DateTime = new DateTime(2012, 01, 02),
                    Decimal = 66.10M,
                    Guid = new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"),
                    Int = 54,
                    String = "8567",
                }
            };

            B_CircularReference destination = source.DeepCopyTo<B_CircularReference>();

            Assert.AreNotEqual(source, destination);
            Assert.AreEqual(true, destination.Bool);
            Assert.AreEqual(new DateTime(2011, 01, 02), destination.DateTime);
            Assert.AreEqual(14.10M, destination.Decimal);
            Assert.AreEqual(new Guid("8DA4C611-A758-4EB7-A352-8D12FE84DBD9"), destination.Guid);
            Assert.AreEqual(4141, destination.Int);
            Assert.AreEqual("1142", destination.String);

            Assert.AreNotEqual(source.CircularReferenceProperty, destination.CircularReferenceProperty);
            Assert.AreEqual(true, destination.CircularReferenceProperty.Bool);
            Assert.AreEqual(new DateTime(2012, 01, 02), destination.CircularReferenceProperty.DateTime);
            Assert.AreEqual(66.10M, destination.CircularReferenceProperty.Decimal);
            Assert.AreEqual(new Guid("8D24C611-A758-4EB7-A352-8D82FE84DBD9"), destination.CircularReferenceProperty.Guid);
            Assert.AreEqual(54, destination.CircularReferenceProperty.Int);
            Assert.AreEqual("8567", destination.CircularReferenceProperty.String);

            Assert.IsNull(destination.CircularReferenceProperty.CircularReferenceProperty);
        }
    }
}