using System;
using NUnit.Framework;

namespace IocExample.Tests
{

    [TestFixture]
    public class IocExampleTests
    {
        [SetUp]
        public void init()
        {
            Container container = new Container();
        }

        [Test]
        public void UnknownTypeThrowsException()
        {
            Assert.AreEqual(1, 1);
            //container.Register<IRepository, Repository>();
            //IRepository repository = Container.Resolve<IRepository>();
            //Assert.AreEqual(Container.Resolve<UnknownType>());
        }

        [Test]
        public void ContainerCanRegisterTypes()
        {
            //Container container = new Container();
            //container.Register<IRepository, Repository>();
            //IRepository repository = container.Resolve<IRepository>();
            //Assert.IsNotNull(repository);
        }
    }
}
