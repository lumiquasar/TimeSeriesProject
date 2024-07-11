using TimeSeriesProject.Builders;
using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject
{
    public class RealTimeSeriesCalculation : ITimeSeriesCalculation
    {
        public TimeSeries timeSeries { get; set; }

        public TimeSeries Calculate(TimeSeriesBuilder builder)
        {
            TimeSeries timeSeries = new TimeSeries();
            Random random = new Random();
            double addTime = builder.GetTimeSeries().SamplingRate;


            for (var i = 0; i < builder.GetTimeSeries().SampleCount; i++)
            {
                var sample = new RealSample()
                {                                       // na orisw enum gia tis apodektes times sta diafora types?
                    Value = random.NextDouble() * (30 - 10) + 10, //(maxValue - minValue) + minValue, //random double number generator between 0.0 and 1.0 and then multiplying with (maxValue - minValue) + minValue
                    TimeStamp = builder.GetTimeSeries().StartTime.AddSeconds(addTime)
                };
                addTime += builder.GetTimeSeries().SamplingRate;
                timeSeries.samples.Add(sample);
            }

            return timeSeries;
        }
    }
}
