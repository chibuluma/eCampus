using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;
using eCampus.DAL.Repositories;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Linq.Expressions;
using eCampus.DAL.Services;
using System.Threading.Tasks;

namespace eCampus.Tests
{
    public class SchoolRepositoryTests
    {
        private readonly SchoolService _sut;
        private readonly Mock<IOperationResult> _operationResultMock = new Mock<IOperationResult>();
        private readonly Mock<IeCampusContext> _contextResultMock = new Mock<IeCampusContext>();
        private readonly Mock<ISchoolRepository> _schoolRepoMock = new Mock<ISchoolRepository>();

        public SchoolRepositoryTests()
        {
            _sut = new SchoolService(_contextResultMock.Object, _operationResultMock.Object, _schoolRepoMock.Object);
        }
        [Test]
        public async Task GetObjectByIdTest(){
            // Arrange
            var id = Guid.NewGuid().ToString();

            var _school=new School(){
                SchoolId = id.ToString(),  
                SchoolCode = "SICT", 
                SchoolDescription = "School of ICT"
            }; 

            //to be fixed 
            _schoolRepoMock.Setup(s=>s.GetObjectById(s=>s.SchoolId==id))
                .ReturnsAsync(_school);

            // Act
            var school = await _sut.GetByIdAsync(id);
            // Assert
            Assert.Equals(id, school.SchoolId);
        }
    }
}
