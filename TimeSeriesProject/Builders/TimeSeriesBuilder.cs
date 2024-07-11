using TimeSeriesProject.Models;

namespace TimeSeriesProject.Builders
{
    public abstract class TimeSeriesBuilder
    {
        protected TimeSeries timeSeries = new TimeSeries();
        

        public TimeSeriesBuilder WithTimeDuration(DateTime startTime, DateTime endTime)
        {
            timeSeries.StartTime = startTime;
            timeSeries.EndTime = endTime;
            timeSeries.Duration = endTime - startTime;
            return this;
        }

        public TimeSeriesBuilder WithSamplingRate(Enumerations.TimeSpectrum timeSpectrum)
        {

            if (timeSpectrum == Enumerations.TimeSpectrum.EverySecond)
            {
                timeSeries.SamplingRate = 1;
            }
            else if (timeSpectrum == Enumerations.TimeSpectrum.EveryMinute)
            {
                timeSeries.SamplingRate = 60;
            }
            else if (timeSpectrum == Enumerations.TimeSpectrum.EveryHour)
            {
                timeSeries.SamplingRate = 3600;
            }
            return this;
        }

        public TimeSeriesBuilder WithSampleCount()
        {
            timeSeries.SampleCount = timeSeries.Duration.TotalSeconds / timeSeries.SamplingRate;
            return this;
        }

        public abstract TimeSeriesBuilder WithTimeSeries();

        public TimeSeries GetTimeSeries()
        {
            return timeSeries;
        }

    }
}
