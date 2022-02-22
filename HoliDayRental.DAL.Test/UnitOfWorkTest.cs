using HoliDayRental.DAL.Entities;
using HoliDayRental.DAL.Interfaces;
using HoliDayRental.DAL.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HoliDayRental.DAL.Test
{
    public class UnitOfWorkTest
    {
        Mock<IDbTransaction> _transaction= new Mock<IDbTransaction>();
        Mock<IUnitOfWork> _unitOfWorkMock;
        Mock<MembreRepository> _mockRepo;
          [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<MembreRepository>(_transaction.Object);
            _mockRepo.Setup(x => x.GetAll()).Returns(new List<MembreEntity>()
            { new MembreEntity()
                                {
                                    Email="test@test.be" ,
                                    IdMembre=1,
                                    Login="test",
                                    Nom="Doe",
                                    Prenom="John",
                                    Password="test1234=",
                                    Pays=1,
                                    Telephone="071717171"
                                }
            }) ;
            _unitOfWorkMock = new Mock<IUnitOfWork>();
             _unitOfWorkMock.Setup(x => x.MembreRepository).Returns(_mockRepo.Object);
        }

        [Test]
        public void GetAllTest()
        {

            IEnumerable < MembreEntity > rep = (_unitOfWorkMock.Object as IUnitOfWork).MembreRepository.GetAll();

            Assert.IsNotNull(rep);
            Assert.AreEqual(1, rep.ToList().Count());
        }
    }
}