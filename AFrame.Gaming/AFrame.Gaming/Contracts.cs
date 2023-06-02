using AFrame.Base.Contracts.Abstractions;

namespace AFrame.Gaming    //-ag move to contracts 
{


    /*
     * Drivers
        * CLP
     * Interfacing
        * 
        * 
     * and thats p much it .
     */

    #region General 

    public interface IDeviceDescription : IGSSDescribable { }
    public interface ISystemDescription : IGSSDescribable { }
    public interface IEnvironmentDescription : IGSSDescribable { }
    public interface IUserDescription : IGSSDescribable { }

    public interface IDevice
    {
        IDeviceDescription Description { get; }
    }

    public interface ISystem
    {
        ISystemDescription Description { get; }
    }

    public interface IEnvironment
    {
        IEnvironmentDescription Description { get; }
    }

    public interface IUser 
    {
        IUserDescription Description { get; }
    }    

    #endregion General 

    #region Input

    public interface IInputPeriphery : IDevice { }

    public interface IKeyboard : IInputPeriphery { }
    public interface IMouse : IInputPeriphery { }
    public interface IController : IInputPeriphery { }


    #endregion Input

    #region Output

    public interface IOutputPeriphery : IDevice { }

    public interface IAudioOutput : IOutputPeriphery { }
    public interface IVideoOutput : IOutputPeriphery { }

    public interface ISpeakers : IOutputPeriphery { }
    public interface IMonitor : IOutputPeriphery { }

    #endregion Output







}