using TimeSeriesProject.Builders;
using TimeSeriesProject.Models;

internal class Program
{
    private static void Main(string[] args)
    {

        // Constructing the TimeSeries
        BuilderFactory builderFactory = new BuilderFactory();

        var startTime = new DateTime(2024, 7, 9, 6, 0, 0);
        var endTime = new DateTime(2024, 7, 9, 7, 0, 0); 
        var timeSpectrum = Enumerations.TimeSpectrum.EveryMinute;
        //1
        var sampleType = Enumerations.SampleType.Categorical;
        TimeSeries timeSeries = builderFactory.GetTimeSeries(startTime, endTime, sampleType, timeSpectrum);
        timeSeries.DisplayList(sampleType);
        //2
        sampleType = Enumerations.SampleType.Real;
        timeSeries = builderFactory.GetTimeSeries(startTime, endTime, sampleType, timeSpectrum);
        timeSeries.DisplayList(sampleType);
        //3
        sampleType = Enumerations.SampleType.Digital;
        timeSeries = builderFactory.GetTimeSeries(startTime, endTime, sampleType, timeSpectrum);
        timeSeries.DisplayList(sampleType);





        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}