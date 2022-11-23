using static System.Console;
using static System.Math;
using System.Windows;
using System.Numerics;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Serialization;

public class Program
{

    static void Main(string[] args)
    {
        try
        {
            throw new DeviceNotReadyException(DeviceStatus.Disconnected);
        }
        catch (DeviceNotReadyException x)
        {
            WriteLine(x.Message);
            WriteLine(x.Status);
        }




    }





}

[Serializable]
public class DeviceNotReadyException : InvalidOperationException
{
    public DeviceNotReadyException(DeviceStatus status)
        : this("Device status must be ready", status)
    { }

    public DeviceNotReadyException(string message, DeviceStatus status)
        : base(message)
    {
        Status = status;
    }

    public DeviceNotReadyException(string message, DeviceStatus status, Exception innerException)
        : base(message, innerException)
    {
        Status = status;
    }


    public DeviceStatus Status { get; }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("Status", Status);
    }

    protected DeviceNotReadyException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        Status = (DeviceStatus?) info.GetValue("Status", typeof(DeviceStatus)) ?? DeviceStatus.Initializing;
    }
}


public enum DeviceStatus
{
    Disconnected,
    Initializing,
    Failed,
    Ready
}