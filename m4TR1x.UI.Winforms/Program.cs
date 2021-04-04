using m4TR1x.Business.Winforms.Interfaces;
using m4TR1x.Business.Winforms.Services;
using IContainer = Autofac.IContainer;
using m4TR1x.Data.Repository.Context;
using System.Globalization;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Linq;
using Autofac;
using System;
using m4TR1x.Business.Services;
using m4TR1x.Business.Interfaces;

namespace m4TR1x.Ui.Winforms
{
    static class Program
    {
        public static IContainer Container { get; set; }

        static string namespaceName => string.Join("",Assembly.GetExecutingAssembly().GetName().Name.Take(18));

        static string mutexName => "m4TR1x:" + namespaceName + ":w4TR1x";
        static Mutex mutex = new Mutex(true, mutexName);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using mutex for single instance app, remove if needed
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                //var startupInfo = ApplicationStartupModel.Parse(args, namespaceName);

                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("tr");

                //Dirty Fix
                //Control.CheckForIllegalCrossThreadCalls = false;

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Startup();

                using (var scope = Container.BeginLifetimeScope())
                {
                    //var updateService = Container.Resolve<IApplicationUpdateService>();
                    //if (startupInfo.Args.Contains("-updated") || !updateService.HasUpdate(startupInfo, false))
                    //{
                    using (var mainForm = Container.Resolve<MainForm>())
                    {
                        Application.Run(mainForm);
                    }
                    //}
                }

                mutex.ReleaseMutex();
            }
        }

        private static void Startup()
        {
            Container = createContainer();
        }

        private static IContainer createContainer()
        {
            var builder = new ContainerBuilder();

            //Form Factory Service
            builder.RegisterType<FormFactoryService>().As<IFormFactoryService>()
                .SingleInstance();

            //Mail Service
            builder.RegisterType<MailService>().As<IMailService>();

            //Daily Message Service
            builder.RegisterType<DailyMessageService>().As<IDailyMessageService>()
               .SingleInstance();

            //Weater Api Reader Service
            builder.RegisterType<WeatherApiReaderService>().As<IWeatherApiReaderService>()
               .SingleInstance();

            //Unit Of Work
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            //Appliction main form
            builder.RegisterType<MainForm>();

            return builder.Build();
        }
    }
}
