using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Castle.MicroKernel;
using Castle.MicroKernel.Handlers;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    class WindsorMultiTenancy
    {
        [Test]
        public void RegisterTest()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IService>().ImplementedBy<Service1>().Named("Service1"));
            container.Register(Component.For<IService>().ImplementedBy<Service2>().Named("Service2"));
            container.Kernel.AddHandlerSelector(new HadlerSelector());
            var resolve = container.Resolve<IService>("olo");
            Assert.AreEqual(typeof(Service1),resolve.GetType());
            int i = 9;

        }
    }
    public interface IService
    {
        string Name { get;  }
    }
    public class Service1:IService
    {

        public string Name { get { return "Service1"; } }
    }
    public class Service2:IService
    {

        public string Name { get { return "service2"; } }
    }
    public class HadlerSelector: IHandlerSelector
{
        public bool HasOpinionAbout(string key, Type service)
        {
            return true;
        }

        public IHandler SelectHandler(string key, Type service, IHandler[] handlers)
        {
         return handlers.Where(handler=>handler.ComponentModel.Implementation.Name=="Service1").First();
        }
}
}