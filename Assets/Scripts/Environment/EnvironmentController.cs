using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    [SerializeField] WeatherService weatherService;

    IWeatherEffect[] effects;
    WeatherReport current;

    void Awake()
    {
        effects = GetComponentsInChildren<IWeatherEffect>(true);
    }

    void OnEnable()
    {
        weatherService.WeatherUpdated += HandleWeatherUpdated;
        weatherService.WeatherFailed += HandleWeatherFailed;
    }

    void OnDisable()
    {
        weatherService.WeatherUpdated -= HandleWeatherUpdated;
        weatherService.WeatherFailed -= HandleWeatherFailed;
    }

    void Start()
    {
        ApplyReport(WeatherReport.Neutral(true, WeatherState.Clear), true);
    }

    public void ApplyReport(WeatherReport report, bool instant = false)
    {
        if (effects == null)
            effects = GetComponentsInChildren<IWeatherEffect>(true);

        current = report;
        foreach (IWeatherEffect effect in effects)
            effect.Apply(report, instant);
    }

    void HandleWeatherUpdated(WeatherReport report) => ApplyReport(report);

    void HandleWeatherFailed(string error)
    {
        bool wasDay = current == null || current.IsDay != false;
        ApplyReport(WeatherReport.Neutral(wasDay));
    }
}
