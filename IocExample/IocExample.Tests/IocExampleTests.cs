using System;
using NUnit.Framework;

namespace IocExample.Tests
{
    [TestFixture]
    public class IocExampleTests
    {
        Container container;

        [SetUp]
        public void Init()
        {
            //Arrange
            container = new Container();
        }

        [Test]
        public void CanCreateAContainer()
        {
            //Assert
            Assert.IsNotNull(container);
        }

        [Test]
        public void CanRegisterAndResolveTypes()
        {
            //Arrange
            container.Register<IRepository, Repository>();

            //Act
            IRepository repository = container.Resolve<IRepository>();

            //Assert
            Assert.IsNotNull(repository);
        }

        [Test]
        [ExpectedException(typeof(UnknownTypeException))]
        public void UnknownTypeThrowsException()
        {
            //Act
            IRepository repository = container.Resolve<IRepository>();
        }

        [Test]
        [ExpectedException(typeof(TypeExistsException))]
        public void DuplicateTypeThrowsException()
        {
            //Arrange
            container.Register<IRepository, Repository>();
            container.Register<IRepository, Repository>();
        }

        [Test]
        public void ContainerDefaultIsTransient()
        {
            //Arrange
            container.Register<IRepository, Repository>();

            //Act
            IRepository one = container.Resolve<IRepository>();
            IRepository two = container.Resolve<IRepository>();

            //Assert
            Assert.AreNotSame(one, two);

            //Could I check the iocObject._type against the LifestyleType enum?  perhaps...
            //Assert.AreEqual(container.iocObjects[Instance]._type, LifestyleType.Transient);
        }

        [Test]
        public void SingletonReturnsSameInstance()
        {
            //Arrange
            container.Register<IRepository, Repository>(LifestyleType.Singleton);

            //Act
            IRepository one = container.Resolve<IRepository>();
            IRepository two = container.Resolve<IRepository>();

            //Assert
            Assert.AreSame(one, two);
        }

        [Test]
        public void TransientReturnsDifferentInstance()
        {
            //Arrange
            container.Register<IRepository, Repository>();

            //Act
            IRepository one = container.Resolve<IRepository>();
            IRepository two = container.Resolve<IRepository>();

            //Assert
            Assert.AreNotSame(one, two);
        }
    }
}
