namespace TimeSeriesProject.Models
{
    public class Enumerations
    {
        public enum State
        {
            Starting = 0,
            Running = 1,
            Slowing = 2,
            Closing = 3
        }

        public enum TimeSpectrum
        {
            EverySecond = 1,
            EveryMinute = 60,
            EveryHour = 3600
        }

        public enum SampleType
        {
            Real,
            Digital,
            Categorical
        }

    }
}
