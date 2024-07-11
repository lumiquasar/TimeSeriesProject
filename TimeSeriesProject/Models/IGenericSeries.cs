namespace TimeSeriesProject.Models
{
    public interface IGenericSeries<T> where T : class
    {
        public List<T> samples { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime{ get; set; }
        public TimeSpan Duration { get; set; }
        public double SamplingRate { get; set; }  //in seconds 
        public double SampleCount { get; set; } //logika tha prepei na kanw stroggylopoihsh sto Duration.totalseconds klp gia na einai to count typou int


        public void DisplayList(Enumerations.SampleType type);
    }
}
