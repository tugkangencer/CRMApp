using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using FluentValidation;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<CustomerAddressRepository>().As<ICustomerAddressRepository>().SingleInstance();
            builder.RegisterType<CustomerContactRepository>().As<ICustomerContactRepository>().SingleInstance();
            builder.RegisterType<CustomerDetailRepository>().As<ICustomerDetailRepository>().SingleInstance();
            builder.RegisterType<CustomerEducationRepository>().As<ICustomerEducationRepository>().SingleInstance();
            builder.RegisterType<CustomerHouseRepository>().As<ICustomerHouseRepository>().SingleInstance();
            builder.RegisterType<CustomerIdentityRepository>().As<ICustomerIdentityRepository>().SingleInstance();
            builder.RegisterType<CustomerProfessionRepository>().As<ICustomerProfessionRepository>().SingleInstance();
            builder.RegisterType<CustomerReferenceRepository>().As<ICustomerReferenceRepository>().SingleInstance();

            builder.RegisterType<DataManager>().As<IDataService>().SingleInstance();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().SingleInstance();
            builder.RegisterType<CityRepository>().As<ICityRepository>().SingleInstance();
            builder.RegisterType<DistrictRepository>().As<IDistrictRepository>().SingleInstance();
            builder.RegisterType<NeighborhoodRepository>().As<INeighborhoodRepository>().SingleInstance();
            builder.RegisterType<OccupationRepository>().As<IOccupationRepository>().SingleInstance();
            builder.RegisterType<SectorRepository>().As<ISectorRepository>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .Where(t => t.FullName.StartsWith("Business.Helpers"));

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .AsClosedTypesOf(typeof(IValidator<>));

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance().InstancePerDependency();
        }
    }
}