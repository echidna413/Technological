using System.Web.Http;
using AutoMapper;
using Tadb.DAL;
using Tadb.WebApi.Models;

namespace Tadb.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(cfg => cfg.CreateMap<Employee, LoginModel>());
        }
    }
}