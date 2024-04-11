using System;
using DemoApp.Services;
using DemoApp.ViewModels;
using DemoApp.Views;

namespace DemoApp
{
	public static class AppInitializer
	{
        public static MauiAppBuilder AppServices(this MauiAppBuilder builder)
        {
            builder.RegisterViews()
                   .RegisterViewModels()
                   .AppDataServices();
            return builder;
        }

        private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddSingleton<HomeView>();
            return builder;
        }
        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<HomeViewModel>();
            return builder;
        }
        private static MauiAppBuilder AppDataServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<IDataService, DataService>();

            return builder;
        }
    }
}

