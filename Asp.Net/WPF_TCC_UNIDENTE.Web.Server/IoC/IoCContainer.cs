using WPF_TCC_UNIDENTE.Web.Server.Data;
using Microsoft.Extensions.DependencyInjection;

namespace WPF_TCC_UNIDENTE.Web.Server
{
    /// <summary>
    /// A shorthand acces class to get DI services with nice clean short code 
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The scoped instance of the <see cref="ApplicationDbContext"/>
        /// </summary>
        public static ApplicationDbContext ApplicationDbContext => IoCContainer.Provider.GetService<ApplicationDbContext>();
    }

    /// <summary>
    /// THe dependency injection container making use of the build in .Net Core service provider
    /// </summary>
    public static class IoCContainer
    {
        /// <summary>
        /// The service provider for this application
        /// </summary>
        public static ServiceProvider Provider { get; set; }
    }
}
