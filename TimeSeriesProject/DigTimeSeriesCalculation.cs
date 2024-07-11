using TimeSeriesProject.Builders;
using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject
{
    public class DigTimeSeriesCalculation : ITimeSeriesCalculation
    {
        public TimeSeries timeSeries { get; set; }

        public TimeSeries Calculate(TimeSeriesBuilder builder)
        {
            TimeSeries timeSeries = new TimeSeries();
            Random random = new Random();
            double addTime = builder.GetTimeSeries().SamplingRate;


            for (var i = 0; i < builder.GetTimeSeries().SampleCount; i++)
            {
                var sample = new DigitalSample()
                {
                    Value = Convert.ToBoolean(random.Next(0, 2)), //random generator between 0 and 1 and conversion to bool type
                    TimeStamp = builder.GetTimeSeries().StartTime.AddSeconds(addTime)
                };

                addTime += builder.GetTimeSeries().SamplingRate;
                timeSeries.samples.Add(sample);
            }
            return timeSeries;
        }
    }
}
