using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application;
using Restaurants.Application.Interface;
using Restaurants.Data.Factory;
using Restaurants.Data.Repositories;
using Restaurants.Data.Services;
using Restaurants.Domain;

namespace Restaurants.Kernel
{
    public class Bootstrapper
    {
        public static void Configure(IServiceCollection services)
        {
            //Application
            services.AddTransient<IMenuAppService, MenuAppService>();
            services.AddTransient<IRestaurantAppService, RestaurantAppService>();
            services.AddTransient<IOrderAppService, OrderAppService>();
            services.AddTransient<IOrderItemAppService, OrderItemAppService>();
            services.AddTransient<IPaymentOptionAppService, PaymentOptionAppService>();
            services.AddTransient<IReviewAppService, ReviewAppService>();
            services.AddTransient<ICustomerAppService, CustomerAppService>();

            //Services
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderItemService, OrderItemService>();
            services.AddTransient<IPaymentOptionService, PaymentOptionService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ICustomerService, CustomerService>();

            //Repository
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderItemRepository, OrderItemRepository>();
            services.AddTransient<IPaymentOptionRepository, PaymentOptionRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            //Context
            services.AddTransient<IContextFactory, ContextFactory>();
        }
    }
}