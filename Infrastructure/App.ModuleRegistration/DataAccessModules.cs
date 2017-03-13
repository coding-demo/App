using App.Data;
using App.Interfaces.DataAccess;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ModuleRegistration
{
    public class DataAccessModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<SqlDatabase>().As<IDataBaseAccess>();


        }
    }
}
