using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject.Models
{
    public class TimeSeries : ITimeSeries
    {
        public List<Sample> samples { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public double SamplingRate { get; set; }
        public double SampleCount { get; set; }

        public TimeSeries()
        {
            samples = new List<Sample>();
        }

        public void DisplayList(Enumerations.SampleType type)
        {
            foreach (var sample in samples)
            {   
                if (type == Enumerations.SampleType.Real)
                    Console.WriteLine("[" + sample.TimeStamp +", " + ((RealSample)sample).Value + "]");
                
                else if (type == Enumerations.SampleType.Digital)
                    Console.WriteLine("[" + sample.TimeStamp + ", " + ((DigitalSample)sample).Value + "]");
                
                else if (type == Enumerations.SampleType.Categorical)
                    Console.WriteLine("[" + sample.TimeStamp + ", " + ((CategoricalSample)sample).Value + "]");
            }
        }
    }
}
