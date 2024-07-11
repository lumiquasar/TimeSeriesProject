using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject.Builders
{
    public class DigitalBuilder : TimeSeriesBuilder
    {
        DigTimeSeriesCalculation seriesCalculation;

        public DigitalBuilder()
        {
            seriesCalculation = new DigTimeSeriesCalculation();
        }

        public override TimeSeriesBuilder WithTimeSeries()
        {
            timeSeries = seriesCalculation.Calculate(this);
            return this;
        }



    }
}
