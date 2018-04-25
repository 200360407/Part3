using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment.Controllers;
using Moq;
using Assignment2.Models;
using Assignment.Models;
using System.Web.Mvc;

namespace Assignment2.Tests.Controllers
{
    /// <summary>
    /// Summary description for childrenControllerTest
    /// </summary>
    [TestClass]
    public class childrenControllerTest
    {

        childrenController children;
        Mock<MocKchildrenRepository> mock;
         List<child> childrens;
        

        [TestInitialize]
        public void TestInitialize() {
            // runs automatically before each unit test

            // initialize the mock object
            mock = new Mock<MocKchildrenRepository>();

            // initialize the mock children data
            children = new List<child>
            {
                new child {color2="color1", location="location1", Description="Description1"},
                new child {color2="color2", location="location2", Description="Description2"},
            };

            // bind the data to the mock
            mock.Setup(m => m.children).Returns(children.AsQueryable());

            //initialize the controller and inject the dependency
            children = new childrenController(mock.Object);
        }
        // arrange
        [TestMethod]
        public void IndexViewLoads() {
           
            // act
            var actual = children.Index();

            // assert
            Assert.IsNotNull(actual);

        }
        [TestMethod]
        public void IndexLoadschildren()
        {

            // act
            var actual = (List<child>)((ViewResult)children.Index()).Model;

            // assert
           CollectionAssert.AreEqual(childrens, actual);

        }
        [TestMethod]
        public void DetailsValidLocation()
        {

            // act
            var actual = (child)((ViewResult)children.Details(1)).Model;

            // assert
            Assert.AreEqual(childrens[0], actual);

        }
        [TestMethod]
        public void DetailsInvalidLocation()
        {

            // act
            var actual = (ViewResult)children.Details(4);

            // assert
            Assert.AreEqual("Error", actual.ViewName);

        }
        [TestMethod]
        public void DetailsNoLocation()
        {

            // act
            var actual = (ViewResult)children.Details(null);

            // assert
            Assert.AreEqual("Error", actual.ViewName);

        }
        // GET : EDIT
        [TestMethod]
        public void EditGetValidId() {
            // act
            var actual = ((ViewResult)children.Edit(1)).Model;
            // assert
            Assert.AreEqual(childrens[0], actual);

        }
        
        [TestMethod]
        public void EditGetInValidId()
        {
            // act
            var actual = (ViewResult)children.Edit(4); ;
            // assert
            Assert.AreEqual("Error", actual.ViewName);

        }
        [TestMethod]
        public void EditNoLocation()
        {
            int? ID = null;
            // act
            var actual = (ViewResult)children.Edit(null);

            // assert
            Assert.AreEqual("Error", actual.ViewName);

        }
    }
}
