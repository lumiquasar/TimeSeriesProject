using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject.Builders
{
    public class RealBuilder : TimeSeriesBuilder
    {
        RealTimeSeriesCalculation seriesCalculation;

        public RealBuilder()
        {
            seriesCalculation = new RealTimeSeriesCalculation();
        }

        public override TimeSeriesBuilder WithTimeSeries()
        {
            timeSeries = seriesCalculation.Calculate(this);
            return this;
        }

    }
}
