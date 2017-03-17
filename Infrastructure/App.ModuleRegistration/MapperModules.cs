using App.DataModels;
using App.Interfaces.Repositories.Mappers;
using App.Repositories.Mappers;
using Autofac;

namespace App.ModuleRegistration
{
    public class MapperModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType(typeof(VehicleMapper)).As(typeof(IDataMapper<Vehicle>));
        }
    }
}
