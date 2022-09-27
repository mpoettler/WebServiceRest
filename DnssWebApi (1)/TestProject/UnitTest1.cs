using System;
using Xunit;
using DnssWebApi;
using DnssWebApi.Controllers;

namespace TestProject
{
    public class UnitTest1
    {

        AdmaController controller = new AdmaController();

        [Fact]
        public void GetReturnName()
        {
            var value = controller.GetModel("Matthias");
            Assert.Equal("Matthias", (System.Collections.Generic.IEnumerable<char>) value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
