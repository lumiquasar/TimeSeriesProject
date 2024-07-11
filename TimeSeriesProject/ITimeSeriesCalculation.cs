using TimeSeriesProject.Builders;
using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject
{
    public interface ITimeSeriesCalculation //<T> where T : class
    {
        public TimeSeries timeSeries { get; set; }

        public TimeSeries Calculate(TimeSeriesBuilder builder);

    
    }
}
