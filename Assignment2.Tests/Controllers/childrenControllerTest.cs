using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment.Controllers;

namespace Assignment2.Tests.Controllers
{
    /// <summary>
    /// Summary description for childrenControllerTest
    /// </summary>
    [TestClass]
    public class childrenControllerTest
    {

        // arrange
        [TestMethod]
        public void IndexViewLoads() {
            childrenController controller = new childrenController();
            // act
            var actual = controller.Index();

            // assert
            Assert.IsNotNull(actual);

        }
      
    }
}
