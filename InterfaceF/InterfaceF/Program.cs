namespace InterfaceF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    

    public interface ISensor
    {
        int Status { get;set; }
    }
    public class TemperatureSensor : ISensor { }
    public class UVSensor : ISensor { }
    public class LightSensor : ISensor { }
    

    public interface IMonitor
    {
        public int GetStatus(ISensor current);
    }


    public abstract class AlarmMonitor : IMonitor
    {
        public ISensor Sensor { get; set; }

        public int GetStatus(ISensor current)
        {
            return Sensor.Status;
        }
    }





    public class TemperaturMonitor : AlarmMonitor
    {
        public TemperaturMonitor()
        {
            Sensor = new TemperatureSensor();
        }
    }

    public class UVMonitor : AlarmMonitor
    {
        public UVMonitor()
        {
            Sensor = new UVSensor();
        }
    }



}