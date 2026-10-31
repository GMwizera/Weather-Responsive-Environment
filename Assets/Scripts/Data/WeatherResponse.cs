using System;

[Serializable]
public class WeatherResponse
{
    public Coord coord;
    public WeatherCondition[] weather;
    public MainData main;
    public int visibility;
    public Wind wind;
    public Clouds clouds;
    public long dt;
    public SysData sys;
    public int timezone;
    public string name;
    public int cod;
}

[Serializable]
public class Coord
{
    public float lon;
    public float lat;
}

[Serializable]
public class WeatherCondition
{
    public int id;
    public string main;
    public string description;
    public string icon;
}

[Serializable]
public class MainData
{
    public float temp;
    public float feels_like;
    public float temp_min;
    public float temp_max;
    public int pressure;
    public int humidity;
}

[Serializable]
public class Wind
{
    public float speed;
    public int deg;
    public float gust;
}

[Serializable]
public class Clouds
{
    public int all;
}

[Serializable]
public class SysData
{
    public string country;
    public long sunrise;
    public long sunset;
}

[Serializable]
public class ApiError
{
    public string message;
}
