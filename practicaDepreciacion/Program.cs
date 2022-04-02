using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var unu = new ContainerBuilder();
            unu.RegisterType<BinaryEmpleadoRepository>().As<IEmpleadoModel>();
            unu.RegisterType<EmpleadoServices>().As<IEmpleadoServices>();
            var containerxd = unu.Build();
            //Application.Run(new FrmEmpleado(container.Resolve<EmpleadoServices>()));

            var builder = new ContainerBuilder();
            builder.RegisterType<BinaryActivoRepository>().As<IActivoModel>();
            builder.RegisterType<ActivoServices>().As<IActivoServices>();
            var container = builder.Build();
            Application.Run(new Form1(container.Resolve<IActivoServices>(),containerxd.Resolve<IEmpleadoServices>()));
        }
    }
}
