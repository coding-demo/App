using App.Business;
using App.Interfaces.Business;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
