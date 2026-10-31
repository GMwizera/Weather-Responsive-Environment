using System;
using System.Collections;

public interface IWeatherProvider
{
    IEnumerator FetchJson(WeatherRequest request, Action<RequestResult<string>> onComplete);
}
