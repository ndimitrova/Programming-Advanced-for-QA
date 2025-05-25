using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class StringLengthCalculatorTests
{
    [Test]
    public void Test_Calculate_EmptyString_ReturnsZero()
    {
        // Arrange 

        string input = "";
        int expected = 0;

        // Act

        int result = StringLengthCalculator.Calculate(input);

        // Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Calculate_SingleEvenLengthWord_ReturnsCorrectInteger()
    {
        // Arrange 

        string input = "test";
        int expected = 896;

        // Act

        int result = StringLengthCalculator.Calculate(input);

        // Assert

        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_Calculate_SingleOddLengthWord_ReturnsCorrectInteger()
    {
        // Arrange 

        string input = "SoftUni";
        int expected = 356;

        // Act

        int result = StringLengthCalculator.Calculate(input);

        // Assert

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Calculate_WholeSentenceString_ReturnsCorrectInteger()
    {
        // Arrange 

        string input = "SoftUni is the best!";
        int expected = 3624;

        // Act

        int result = StringLengthCalculator.Calculate(input);

        // Assert

        Assert.AreEqual(expected, result);
    }

}

