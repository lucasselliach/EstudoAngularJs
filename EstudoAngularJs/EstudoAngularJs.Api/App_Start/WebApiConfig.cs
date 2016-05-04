using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using EstudoAngularJs.Api.Unity;
using EstudoAngularJs.Data.Repositories;
using EstudoAngularJs.Domain.Interfaces.Repositories;
using EstudoAngularJs.Domain.Interfaces.Services;
using EstudoAngularJs.Domain.Services;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EstudoAngularJs.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            //Remove a formatação XML
            var formatters = configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            //Modifica a identação
            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IClienteService, ClienteService>(new HierarchicalLifetimeManager());
            container.RegisterType<IFilmeService, FilmeService>(new HierarchicalLifetimeManager());
            container.RegisterType<IFilmeGeneroService, FilmeGeneroService>(new HierarchicalLifetimeManager());
            container.RegisterType<IFuncionarioService, FuncionarioService>(new HierarchicalLifetimeManager());
            container.RegisterType<ILocacaoService, LocacaoService>(new HierarchicalLifetimeManager());

            container.RegisterType<IClienteRepository, ClienteRepository>(new HierarchicalLifetimeManager());         
            container.RegisterType<IFilmeRepository, FilmeRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFilmeGeneroRepository, FilmeGeneroRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IFuncionarioRepository, FuncionarioRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ILocacaoRepository, LocacaoRepository>(new HierarchicalLifetimeManager());

            configuration.DependencyResolver = new UnityResolver(container);

            //EXCLUIR DEPOIS PARA GARANTIR O 'access-control-allow-origin'
            var cors = new EnableCorsAttribute("*", "*", "*");
            configuration.EnableCors(cors);

            // Web API routes
            configuration.MapHttpAttributeRoutes();

            configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
