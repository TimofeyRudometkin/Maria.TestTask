using Autofac;
using Maria.TestTask.MeasurementPlanner.UI.Data;
using Maria.TestTask.MeasurementPlanner.UI.ViewModel;

namespace Maria.TestTask.MeasurementPlanner.UI.Startup
{
    class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<MeasurementRepository>().As<IMeasurementRepository>();
            builder.RegisterType<PlansForTheDaysRepository>().As<IPlansForTheDaysRepository>();

            return builder.Build();
        }
    }
}
