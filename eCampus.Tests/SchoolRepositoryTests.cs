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
using System.Collections.Generic;

namespace eCampus.Tests
{
    public class SchoolRepositoryTests
    {        
        private readonly SchoolService _sut;
        private readonly Mock<IOperationResult> _operationResultMock = new Mock<IOperationResult>();
        private readonly Mock<ISchoolRepository> _schoolRepoMock = new Mock<ISchoolRepository>();

        public SchoolRepositoryTests()
        {
            _sut = new SchoolService(_schoolRepoMock.Object,_operationResultMock.Object);
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

            var school = await _sut.GetObjectById(s=>s.SchoolId==id);
            // Assert

            // Actid
            Assert.AreEqual(id, school.SchoolId);
        }
        [Test]
        public async Task GetAllObjectsTest(){
            // Arrange
            var id = Guid.NewGuid().ToString();

            var _school=new School(){
                SchoolId = id.ToString(),  
                SchoolCode = "SICT", 
                SchoolDescription = "School of ICT"
            };

             
            var _school1=new School(){
                SchoolId = Guid.NewGuid().ToString(),  
                SchoolCode = "SB", 
                SchoolDescription = "School of Business"
            };

            var schools = new List<School>()
                {_school, _school1};
            
            //to be fixed sc
            _schoolRepoMock.Setup(s=>s.GetAllObjects())
                .ReturnsAsync(schools);
            // Act
            var school = await _sut.GetAllObjects();
            // Assert
            Assert.AreEqual(2, school.Count);
        }
    }
}
