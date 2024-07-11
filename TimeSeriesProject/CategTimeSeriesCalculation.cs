using TimeSeriesProject.Builders;
using TimeSeriesProject.Models;
using TimeSeriesProject.Models.SampleModels;

namespace TimeSeriesProject
{
    public class CategTimeSeriesCalculation : ITimeSeriesCalculation
    {
        public TimeSeries timeSeries { get; set; }

        public TimeSeries Calculate(TimeSeriesBuilder builder)
        {
            TimeSeries timeSeries = new TimeSeries();

            Random random = new Random();
            int randomState;

            Enumerations.State state=0;
            double addTime = builder.GetTimeSeries().SamplingRate;


            for (var i = 0; i < builder.GetTimeSeries().SampleCount; i++)
            {
                randomState = random.Next(0, 3);   //random int number generator between 0 and 3 (these values correspond to a specific state from the State enum)

                var sample = new CategoricalSample()
                {
                    Value = Convert.ToString(state + randomState),    //kanei antistoixish sto value tou State enum me bash thn timh toy pointer (0 gia starting, 1 gia running, 2 gia slowing, 3 gia closing)
                    TimeStamp = builder.GetTimeSeries().StartTime.AddSeconds(addTime)
                };
                addTime += builder.GetTimeSeries().SamplingRate;
                timeSeries.samples.Add(sample);
            }
            return timeSeries;
        }
    }
}
