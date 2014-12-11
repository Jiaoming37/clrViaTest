﻿using System;
using BanKai.Basic.Common;
using FluentAssertions;
using Xunit;

namespace BanKai.Basic
{
    public class ArrayOperations
    {
        [Fact]
        public void should_access_certain_element_by_position()
        {
            var array = new[] {'a', 'e', 'i', 'o', 'u'};
            char elementAtIndex2 = array[2];

            // change "default(char)" to correct value.
            const char expectedResult = default (char);

            elementAtIndex2.Should().Be(expectedResult);
        }

        [Fact]
        public void should_throw_if_index_is_out_of_range()
        {
            var array = new[] { 'a', 'e', 'i', 'o', 'u' };

            // change "typeof(FormatException)" to correct value.
            Type expectedExceptionType = typeof(FormatException);
            
            expectedExceptionType.Should().NotBe(typeof(ArgumentException));
            expectedExceptionType.Should().NotBe(typeof(SystemException));
            expectedExceptionType.Should().NotBe(typeof(Exception));
            Assert.Throws(expectedExceptionType, () => array[99]);
        }

        [Fact]
        public void should_return_index_number_if_found()
        {
            var array = new[] { 'a', 'e', 'i', 'o', 'u' };
            int indexOfCharacterO = Array.IndexOf(array, 'o');

            // change "default(char)" to correct value.
            const int expectedResult = default(char);

            indexOfCharacterO.Should().Be(expectedResult);
        }

        [Fact]
        public void should_initialize_to_default_value()
        {
            var arrayWithValueType = new int[10];
            var arrayWithRefType = new string[10];

            // change the variable values in the following 2 lines to correct value.
            const int intAtPostion3 = 1;
            const string stringAtPosition3 = "";

            arrayWithValueType[3].Should().Be(intAtPostion3);
            arrayWithRefType[3].Should().Be(stringAtPosition3);
        }

        [Fact]
        public void should_return_shallow_copy_of_an_array_using_clone()
        {
            var array = new[] {new RefTypeClass(1)};
            var cloned = (RefTypeClass[])array.Clone();

            array[0].Value = 5;

            // change the variable value to correct one.
            const int expectedResult = 1;

            cloned[0].Value.Should().Be(expectedResult);
        }
    }
}