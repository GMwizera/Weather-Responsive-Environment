using System;

[Serializable]
public class Location
{
    public string name;
    public float latitude;
    public float longitude;

    public Location(string name, float latitude, float longitude)
    {
        this.name = name;
        this.latitude = latitude;
        this.longitude = longitude;
    }
}

public class SampleScenario
{
    public string Label { get; }
    public string FileName { get; }
    public long HttpStatus { get; }

    public SampleScenario(string label, string fileName, long httpStatus = 200)
    {
        Label = label;
        FileName = fileName;
        HttpStatus = httpStatus;
    }
}

public class WeatherRequest
{
    public string Label { get; }
    public float Latitude { get; }
    public float Longitude { get; }
    public SampleScenario Sample { get; }
    public bool IsSample => Sample != null;

    public WeatherRequest(string label, float latitude, float longitude, SampleScenario sample = null)
    {
        Label = label;
        Latitude = latitude;
        Longitude = longitude;
        Sample = sample;
    }
}
