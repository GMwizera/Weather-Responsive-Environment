
public static class WeatherClassifier
{
    public static WeatherState Classify(WeatherCondition condition)
    {
        if (condition == null)
            return WeatherState.Fallback;

        int id = condition.id;
        if (id >= 200 && id < 600) return WeatherState.Rain;
        if (id >= 600 && id < 700) return WeatherState.Snow;
        if (id == 800) return WeatherState.Clear;
        if (id > 800 && id < 900) return WeatherState.Cloudy;
        return WeatherState.Fallback;
    }


    public static bool? IsDaytime(WeatherCondition condition, WeatherResponse data)
    {
        string icon = condition != null ? condition.icon : null;
        if (!string.IsNullOrEmpty(icon))
        {
            char suffix = icon[icon.Length - 1];
            if (suffix == 'd') return true;
            if (suffix == 'n') return false;
        }

        if (data.sys != null && data.dt > 0 && data.sys.sunrise > 0 && data.sys.sunset > 0)
            return data.dt >= data.sys.sunrise && data.dt < data.sys.sunset;

        return null;
    }
}
