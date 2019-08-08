using Proyecto_Final.Controllers;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var contro = new ProfesorController();
            var result = contro.Get();
            Assert.Equals(0, result.Count()); 

            

        }
    }
}
