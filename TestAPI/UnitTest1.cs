using System;
using Xunit;
using WebApplication1.Controllers;

namespace TestAPI
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ValuesController control = new ValuesController();
            var result = control.Get(2000);
            Assert.Equal("Leap Year",result);
        }
    }
}
