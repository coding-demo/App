using App.DataModels;
using App.Interfaces.Repositories.Mappers;
using App.Repositories.Mappers;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
