using App.Business;
using App.Interfaces.Business;
using App.Interfaces.Repositories;
using App.Repositories;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
