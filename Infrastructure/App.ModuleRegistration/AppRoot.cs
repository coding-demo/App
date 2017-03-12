using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace App.ModuleRegistration
{

    public interface IAppRoot
    {
        ContainerBuilder ContainerBuilder { get; }
        IContainer Container { get; }
        IContainer GetContainer();
    }

    /// <summary>
    /// Registering all the classes in the Composition Root.
    /// </summary>
    public class AppRoot : IAppRoot
    {
        private readonly ContainerBuilder _builder;
        private readonly Assembly _assembly;
        private IContainer _container;



        public AppRoot()
        {
            _builder = new ContainerBuilder();
            _assembly = typeof(IAssemblyMarker).Assembly;
        }

        public ContainerBuilder ContainerBuilder
        {
            get { return _builder; }

        }

        public IContainer Container
        {
            get { return _container; }
        }

        public IContainer GetContainer()
        {
            _builder.RegisterAssemblyModules(_assembly);

            _container = _builder.Build();

            return _container;
        }
    }
}
