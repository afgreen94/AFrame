using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AFrame.Base.Contracts
{
    public interface IDriver
    {
        ValueTask<IDriveResult> DriveAsync(string[] args);
    }

    public interface IDriveResult
    {

    }

    public class DriveResult : IDriveResult { }

    public interface IServiceRegistrar
    {
        void RegisterSerivces(IServiceCollection serviceCollection, IConfiguration configuration);
    }

    public class ApplicationArgs : Dictionary<object, object> { }
    public interface ICommandLineParser { ApplicationArgs Parse(string[] args); }
    public interface IConfigurationProvider
    {
        IConfiguration GetConfiguration();
    }
}
