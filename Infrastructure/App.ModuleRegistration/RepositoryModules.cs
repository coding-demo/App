using App.Interfaces.Repositories;
using App.Repositories;
using Autofac;

namespace App.ModuleRegistration
{
    public class RepositoryModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<VehicleRepository>().As<IVehicleRepository>();


        }
    }
}
