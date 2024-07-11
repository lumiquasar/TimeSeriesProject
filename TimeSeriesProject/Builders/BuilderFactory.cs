using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject.Builders
{
    public class BuilderFactory
    {
        public TimeSeries GetTimeSeries(DateTime startTime, DateTime endTime, Enumerations.SampleType sampleType, Enumerations.TimeSpectrum timeSpectrum)
        {
            TimeSeriesBuilder builder = null;
            
            if (sampleType == Enumerations.SampleType.Real)
            {
                builder = new RealBuilder();
                builder.WithTimeDuration(startTime, endTime)
                    .WithSamplingRate(timeSpectrum)
                    .WithSampleCount()
                    .WithTimeSeries();                    
            }
            else if (sampleType == Enumerations.SampleType.Digital)
            {
                builder = new DigitalBuilder();
                builder.WithTimeDuration(startTime, endTime)
                    .WithSamplingRate(timeSpectrum)
                    .WithSampleCount()
                    .WithTimeSeries();
            }
            else if (sampleType == Enumerations.SampleType.Categorical)
            {
                builder = new CategoricalBuilder();
                builder.WithTimeDuration(startTime, endTime)
                    .WithSamplingRate(timeSpectrum)
                    .WithSampleCount()
                    .WithTimeSeries();
            }

            return builder.GetTimeSeries();

        }
    }
}
