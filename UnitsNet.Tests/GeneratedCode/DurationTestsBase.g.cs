﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Duration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DurationTestsBase
    {
        protected abstract double DaysInOneSecond { get; }
        protected abstract double HoursInOneSecond { get; }
        protected abstract double MicrosecondsInOneSecond { get; }
        protected abstract double MillisecondsInOneSecond { get; }
        protected abstract double MinutesInOneSecond { get; }
        protected abstract double MonthsInOneSecond { get; }
        protected abstract double Months30InOneSecond { get; }
        protected abstract double NanosecondsInOneSecond { get; }
        protected abstract double SecondsInOneSecond { get; }
        protected abstract double WeeksInOneSecond { get; }
        protected abstract double YearsInOneSecond { get; }
        protected abstract double Years365InOneSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DaysTolerance { get { return 1e-5; } }
        protected virtual double HoursTolerance { get { return 1e-5; } }
        protected virtual double MicrosecondsTolerance { get { return 1e-5; } }
        protected virtual double MillisecondsTolerance { get { return 1e-5; } }
        protected virtual double MinutesTolerance { get { return 1e-5; } }
        protected virtual double MonthsTolerance { get { return 1e-5; } }
        protected virtual double Months30Tolerance { get { return 1e-5; } }
        protected virtual double NanosecondsTolerance { get { return 1e-5; } }
        protected virtual double SecondsTolerance { get { return 1e-5; } }
        protected virtual double WeeksTolerance { get { return 1e-5; } }
        protected virtual double YearsTolerance { get { return 1e-5; } }
        protected virtual double Years365Tolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void SecondToDurationUnits()
        {
            Duration second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.Days, DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.Hours, HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.Microseconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.Milliseconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.Minutes, MinutesTolerance);
            AssertEx.EqualTolerance(MonthsInOneSecond, second.Months, MonthsTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.Months30, Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.Nanoseconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.Weeks, WeeksTolerance);
            AssertEx.EqualTolerance(YearsInOneSecond, second.Years, YearsTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.Years365, Years365Tolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Day).Days, DaysTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Hour).Hours, HoursTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Microsecond).Microseconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Millisecond).Milliseconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Minute).Minutes, MinutesTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Month).Months, MonthsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Month30).Months30, Months30Tolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Nanosecond).Nanoseconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Second).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Week).Weeks, WeeksTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Year).Years, YearsTolerance);
            AssertEx.EqualTolerance(1, Duration.From(1, DurationUnit.Year365).Years365, Years365Tolerance);
        }

        [Fact]
        public void As()
        {
            var second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.As(DurationUnit.Day), DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.As(DurationUnit.Hour), HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.As(DurationUnit.Microsecond), MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.As(DurationUnit.Millisecond), MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.As(DurationUnit.Minute), MinutesTolerance);
            AssertEx.EqualTolerance(MonthsInOneSecond, second.As(DurationUnit.Month), MonthsTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.As(DurationUnit.Month30), Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.As(DurationUnit.Nanosecond), NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.As(DurationUnit.Second), SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.As(DurationUnit.Week), WeeksTolerance);
            AssertEx.EqualTolerance(YearsInOneSecond, second.As(DurationUnit.Year), YearsTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.As(DurationUnit.Year365), Years365Tolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Duration second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(1, Duration.FromDays(second.Days).Seconds, DaysTolerance);
            AssertEx.EqualTolerance(1, Duration.FromHours(second.Hours).Seconds, HoursTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMicroseconds(second.Microseconds).Seconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMilliseconds(second.Milliseconds).Seconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMinutes(second.Minutes).Seconds, MinutesTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMonths(second.Months).Seconds, MonthsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMonths30(second.Months30).Seconds, Months30Tolerance);
            AssertEx.EqualTolerance(1, Duration.FromNanoseconds(second.Nanoseconds).Seconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromSeconds(second.Seconds).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromWeeks(second.Weeks).Seconds, WeeksTolerance);
            AssertEx.EqualTolerance(1, Duration.FromYears(second.Years).Seconds, YearsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromYears365(second.Years365).Seconds, Years365Tolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Duration v = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(-1, -v.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration.FromSeconds(3)-v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration.FromSeconds(10)/5).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, Duration.FromSeconds(10)/Duration.FromSeconds(5), SecondsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Duration oneSecond = Duration.FromSeconds(1);
            Duration twoSeconds = Duration.FromSeconds(2);

            Assert.True(oneSecond < twoSeconds);
            Assert.True(oneSecond <= twoSeconds);
            Assert.True(twoSeconds > oneSecond);
            Assert.True(twoSeconds >= oneSecond);

            Assert.False(oneSecond > twoSeconds);
            Assert.False(oneSecond >= twoSeconds);
            Assert.False(twoSeconds < oneSecond);
            Assert.False(twoSeconds <= oneSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Equal(0, second.CompareTo(second));
            Assert.True(second.CompareTo(Duration.Zero) > 0);
            Assert.True(Duration.Zero.CompareTo(second) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Throws<ArgumentException>(() => second.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Throws<ArgumentNullException>(() => second.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Duration a = Duration.FromSeconds(1);
            Duration b = Duration.FromSeconds(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Duration v = Duration.FromSeconds(1);
            Assert.True(v.Equals(Duration.FromSeconds(1), Duration.FromSeconds(SecondsTolerance)));
            Assert.False(v.Equals(Duration.Zero, Duration.FromSeconds(SecondsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.False(second.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.False(second.Equals(null));
        }
    }
}
