namespace RepositoryPatterns.service.WeatherService
{
    public interface WeathserServiceInterface
    {
        IEnumerable<WeatherForecast> Get();
    }
}
