using System.Reflection;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Facts.Domain.Entities;

namespace Facts.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {

            Mvx.RegisterType<Facts.Domain.Repository.IFactRepository, Facts.Repository.CNRepository>();
           // Mvx.RegisterType<Facts.Domain.Repository.IFactRepository, Facts.Repository.JSFactRepository>();


            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            string assemblyName = "Facts.Domain";
#if(iOS)
            assemblyName="Facts.iOS.Domain";
#endif

            CreatableTypes(Assembly.Load(new AssemblyName(assemblyName)))
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            
            RegisterAppStart<ViewModels.FirstViewModel>();

         

        }
    }
}