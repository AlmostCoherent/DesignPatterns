using DesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.Tests
{
    public class FactoryPatternTests
    {
        [Theory]
        [InlineData(ReturnType.First)]
        [InlineData(ReturnType.Second)]
        [InlineData(ReturnType.Third)]
        [InlineData(ReturnType.Default)]
        public void CheckThatFactoryReturnsCorrectObject(ReturnType returnType)
        {
            IFactoryReturn factoryReturn = Factory.GetFactoryReturnObject(returnType);
            Assert.True(factoryReturn.GetValue() != null);
        }
    }
}
