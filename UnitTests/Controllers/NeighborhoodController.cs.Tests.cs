﻿using LetsGoSEA.WebSite.Controllers;
using NUnit.Framework;

namespace UnitTests.Controllers
{
    /// <summary>
    /// Unit test for NeighborhoodController
    /// </summary>
    class NeighborhoodControllerTests
    {

        #region Constructor

        /// <summary>
        /// Tests that a NeighborhoodController's constructor creates a new NeighborhoodController
        /// instance when called and valid input parameter is provided.
        /// </summary>
        [Test]
        public void NeighborhoodController_Valid_New_Controller_Not_Null_Should_Return_True()
        {
            //Arrange

            //Act
            var controller = new NeighborhoodController(TestHelper.NeighborhoodServiceObj);

            //Assert
            Assert.NotNull(controller);
        }

        #endregion Constructor

        #region PrivateNeighborhoodService

        /// <summary>
        /// Tests the NeighborhoodController's property is not null upon instantiation 
        /// </summary>
        [Test]
        public void NeighborhoodController_Valid_New_Controller_Property_Not_Null_Should_Return_True()
        {
            //Arrange
            var controller = new NeighborhoodController(TestHelper.NeighborhoodServiceObj);

            //Act
            var service = controller.neighborhoodService;

            //Assert 
            Assert.NotNull(service);
        }

        #endregion PrivateNeighborhoodService
    }
}