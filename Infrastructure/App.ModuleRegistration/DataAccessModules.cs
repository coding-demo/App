using App.Data;
using App.Interfaces.DataAccess;
using Autofac;

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
