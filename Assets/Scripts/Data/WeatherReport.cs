public enum WeatherState
{
    Clear,
    Cloudy,
    Rain,
    Snow,
    Fallback
}

// Null values mean the field was missing from the response.
public class WeatherReport
{
    public string LocationLabel { get; set; }
    public string CoordinatesLabel { get; set; }
    public string Description { get; set; }
    public float? TemperatureC { get; set; }
    public int? Humidity { get; set; }
    public float? WindSpeed { get; set; }
    public int? CloudCoverage { get; set; }
    public bool? IsDay { get; set; }
    public string ObservedTime { get; set; }
    public int? TimezoneOffsetSeconds { get; set; }
    public WeatherState State { get; set; }
    public bool IsSample { get; set; }
    public string SourceLabel { get; set; }

    public static WeatherReport Neutral(bool isDay, WeatherState state = WeatherState.Fallback)
    {
        return new WeatherReport { IsDay = isDay, State = state, WindSpeed = 1f, CloudCoverage = 40 };
    }
}
