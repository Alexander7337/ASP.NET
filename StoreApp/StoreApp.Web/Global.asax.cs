namespace StoreApp.Web
{
    using AutoMapper;
    using Models.BindingModels;
    using Models.ViewModels.Admin;
    using StoreApp.Models.StoreEntities;
    using StoreApp.Models.ViewModels.Customer;
    using StoreApp.Models.ViewModels.Product;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMappings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMappings()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<IEnumerable<Product>, IEnumerable<ProductViewModel>>();
                expression.CreateMap<Product, ProductViewModel>();
                    //.ForMember(vm => vm.Name, expr => expr.MapFrom(p => p.Name))
                    //.ForMember(vm => vm.Model, expr => expr.MapFrom(p => p.Model))
                    //.ForMember(vm => vm.Description, expr => expr.Ignore())
                    //.ForMember(vm => vm.ImageUrl, expr => expr.Ignore())
                    //.ForMember(vm => vm.Id, expr => expr.Ignore());

                expression.CreateMap<ApplicationUser, ProfileViewModel>();
                expression.CreateMap<Product, CustomerProductsVm>();
                expression.CreateMap<ApplicationUser, CustomerEditProfileVm>();
                expression.CreateMap<Customer, AdminPageUsersVm>()
                .ForMember(vm => vm.Name, configurationExpression => configurationExpression
                    .MapFrom(customer => customer.User.Name));
                expression.CreateMap<AddProductBindingModel, Product>()
                .ForMember(vm => vm.Customers, expr => expr.Ignore());
            });
        }
    }
}
