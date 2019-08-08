using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Final.Controllers;
using Xunit;
using System.Linq; 

namespace TextProyect
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Fact]
        
        public void TestMethod1()
        {
            var controller = new EstudianteController();
            var result = controller.Get();
            Assert.Equals(0, result.Count()); 

        }
    }
}
