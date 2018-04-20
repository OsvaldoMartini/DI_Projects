using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Autofac;
//using Autofac.Configuration;
using NUnit.Framework;


namespace Mocking.IoC.DI
{
    [TestFixture]
    class AutoFac_Tests
    {

        [Test]
        public void Test_Calls_Autofac()
        {
            // Explicitly 
            var builder = new ContainerBuilder();
            builder.Register<UnitOfWork>(b => new UnitOfWork());
            builder.Register<Repository>(b => new Repository(b.Resolve<UnitOfWork>()));

            builder.Register(b => new Service(b.Resolve<Repository>(), b.Resolve<UnitOfWork>()));

            // Implicitly
            var typeBuilder = new ContainerBuilder();
            typeBuilder.RegisterType<UnitOfWork>();
            typeBuilder.RegisterType<Repository>();
            typeBuilder.RegisterType<Service>();

            // Config
            //var configBuilder = new ContainerBuilder();
            //configBuilder.RegisterModule(new ConfigurationSettingsReader("dependencies"));

            var container = builder.Build();
            var typeContainer = typeBuilder.Build();
            // var configContainer = configBuilder.Build();


            container.Resolve<Service>().DoAwesomeness();
            typeContainer.Resolve<Service>().DoAwesomeness();
            //configContainer.Resolve<Service>().DoAwesomeness();
            //Console.Read();
        }
    }


 }
