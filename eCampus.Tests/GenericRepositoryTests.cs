using System;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;
using eCampus.DAL.Repositories;
using Moq;
using NUnit.Framework;

namespace eCampus.Tests
{
    public class GenericRepositoryTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void GetObjectByIdTest(){
            //var mock = new Mock<GenericRepository<School>>();
            //mock.Setup(foo => foo.DoSomething("ping")).Returns(true);
        }
    }
}
