using App.Business;
using App.Interfaces.Business;
using Autofac;

namespace App.ModuleRegistration
{
    public class BusinessModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<VehicleManagment>().As<IVehicleManagment>();
        }
    }
}
