using System;
using Microsoft.Extensions.DependencyInjection;
using RESTfulstructure.Domain.Repositories;
using RESTfulstructure.Domain.Services;
using RESTfulstructure.Domain.Services.Interfaces;
using RESTfulstructure.Infra.Repositories;

namespace RESTfulstructure.IoC
{
    public class InjectorDependencies
    {
        public static void Registrar(IServiceCollection serviceCollection)
        {
            //Aplicação            
            // serviceCollection.AddScoped<IGuicheApp, GuicheApp>();
            // serviceCollection.AddScoped<ITipoAtendimentoApp, TipoAtendimentoApp>();

            //Domínio            
            serviceCollection.AddScoped<ICategoryService, CategoryService>();
            serviceCollection.AddScoped<IProductService, ProductService>();

            //Repositorio
            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
