using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using OpenTK;
using OpenTK.Windowing.Desktop;

using AFrame.Base;
using AFrame.Base.Contracts;
using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Abstractions;


namespace AFrame.Gaming.Drivers
{
    public class DefaultDriver : Driver, IDriver
    {

        public DefaultDriver() : base(new CommandLineParser(), new ConfigurationProvider(), new ServiceRegistrar()) { }

        public DefaultDriver(ICommandLineParser commandLineParser, 
                             Base.Contracts.IConfigurationProvider configurationProvider, 
                             IServiceRegistrar serviceRegistrar) : base(commandLineParser, configurationProvider, serviceRegistrar)
        {
        }

        protected override async ValueTask<IDriveResult> DriveCoreAsync()
        {
            using var scope = this.serviceProvider.CreateScope();

            using var window = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default);
            window.Run();

            return new DriveResult();
        }

        public class CommandLineParser : ICommandLineParser
        {
            public ApplicationArgs Parse(string[] args)
            {
                return new ApplicationArgs();
            }
        }

        public class ConfigurationProvider : Base.Contracts.IConfigurationProvider
        {
            public IConfiguration GetConfiguration()
            {
                return new ConfigurationBuilder().Build();
            }
        }

        public class ServiceRegistrar : IServiceRegistrar
        {
            public void RegisterSerivces(IServiceCollection serviceCollection, IConfiguration configuration)
            {
            }
        }
    }
}
