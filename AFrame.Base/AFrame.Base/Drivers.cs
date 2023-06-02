using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AFrame.Base.Contracts;
using System.Runtime.CompilerServices;

namespace AFrame.Base
{
    public abstract class Driver : IDriver
    {

        protected ICommandLineParser commandLineParser;
        protected Base.Contracts.IConfigurationProvider configurationProvider;
        protected IServiceRegistrar serviceRegistrar;

        protected ApplicationArgs applicationArgs;

        protected IConfiguration configuration;
        protected IServiceProvider serviceProvider;

        public Driver(ICommandLineParser commandLineParser,
                      Base.Contracts.IConfigurationProvider configurationProvider,
                      IServiceRegistrar serviceRegistrar)
        {
            this.commandLineParser = commandLineParser;
            this.configurationProvider = configurationProvider;
            this.serviceRegistrar = serviceRegistrar;
        }

        public async ValueTask<IDriveResult> DriveAsync(string[] args)
        {
            this.applicationArgs = this.commandLineParser.Parse(args);
            this.configuration = this.configurationProvider.GetConfiguration();

            var sc = new ServiceCollection();

            sc.AddSingleton(this.configuration);

            this.serviceRegistrar.RegisterSerivces(sc, this.configuration);

            this.serviceProvider = sc.BuildServiceProvider();

            return await this.DriveCoreAsync().ConfigureAwait(false);
        }
        protected abstract ValueTask<IDriveResult> DriveCoreAsync();
    }
}
