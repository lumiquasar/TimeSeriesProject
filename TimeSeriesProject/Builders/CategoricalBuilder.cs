using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject.Builders
{
    public class CategoricalBuilder : TimeSeriesBuilder
    {
        CategTimeSeriesCalculation seriesCalculation;

        public CategoricalBuilder()
        {
            seriesCalculation = new CategTimeSeriesCalculation();
        }

        public override TimeSeriesBuilder WithTimeSeries()
        {
            timeSeries = seriesCalculation.Calculate(this);
            return this;
        }



    }
}
