using System;
using System.Collections.Generic;

namespace AutoMapper.Runtime.Extensions.UnitTesting
{
    internal class BaseClass
    {
        public int Int { get; set; }

        public decimal Decimal { get; set; }

        public string String { get; set; }

        public DateTime DateTime { get; set; }

        public Guid Guid { get; set; }

        public bool Bool { get; set; }

        public Dictionary<Guid, string> Dictionary { get; set; }

        #region Array of primitives
        public int[] IntArray { get; set; }

        public decimal[] DecimalArray { get; set; }

        public string[] StringArray { get; set; }

        public DateTime[] DateTimeArray { get; set; }

        public Guid[] GuidArray { get; set; }

        public bool[] BoolArray { get; set; }
        #endregion

        #region List of primitives
        public List<int> IntList { get; set; }

        public List<decimal> DecimalList { get; set; }

        public List<string> StringList { get; set; }

        public List<DateTime> DateTimeList { get; set; }

        public List<Guid> GuidList { get; set; }

        public List<bool> BoolList { get; set; }
        #endregion
    }

    internal class Cow : BaseClass
    {

    }

    internal class Mule : BaseClass
    {

    }


    #region A
    internal class A_BigClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public A_FirstClass FirstClass { get; set; }

        public A_SecondClass SecondClass { get; set; }
    }

    internal class A_FirstClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public A_FirstClassFirstSubClass FirstClassFirstSubClass { get; set; }

        public A_FirstClassSecondSubClass FirstClassSecondSubClass { get; set; }
    }

    internal class A_FirstClassFirstSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class A_FirstClassSecondSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class A_SecondClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public A_SecondClassFirstSubClass SecondClassFirstSubClass { get; set; }

        public A_SecondClassSecondSubClass SecondClassSecondSubClass { get; set; }
    }

    internal class A_SecondClassFirstSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class A_SecondClassSecondSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class A_CircularReference : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public A_CircularReference CircularReferenceProperty { get; set; }
    }
    #endregion

    #region B
    internal class B_BigClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public B_FirstClass FirstClass { get; set; }

        public B_SecondClass SecondClass { get; set; }
    }

    internal class B_FirstClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public B_FirstClassFirstSubClass FirstClassFirstSubClass { get; set; }

        public B_FirstClassSecondSubClass FirstClassSecondSubClass { get; set; }
    }

    internal class B_FirstClassFirstSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class B_FirstClassSecondSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class B_SecondClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public B_SecondClassFirstSubClass SecondClassFirstSubClass { get; set; }

        public B_SecondClassSecondSubClass SecondClassSecondSubClass { get; set; }
    }

    internal class B_SecondClassFirstSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class B_SecondClassSecondSubClass : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {

    }

    internal class B_CircularReference : AutoMapper.Runtime.Extensions.UnitTesting.BaseClass
    {
        public B_CircularReference CircularReferenceProperty { get; set; }
    }
    #endregion
}