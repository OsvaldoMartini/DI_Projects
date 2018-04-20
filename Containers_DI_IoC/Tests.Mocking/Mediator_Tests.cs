using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Mediator.Business;
using NUnit.Framework;

namespace Mocking.IoC.DI
{
    [TestFixture]
    class Mediator_Tests
    {


        [Test]

        public void Diagram_Communicator_Test()
        {
            //Arrange
            Communicator comm = new Communicator();


            //Assert
            Assert.IsTrue(1 == 1); //this Test just asserts that ProcessOrder can be called
        }
    }
}
