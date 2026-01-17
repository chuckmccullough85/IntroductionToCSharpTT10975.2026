public enum TemperatureScale { Celsius, Fahrenheit, Kelvin }

public struct Temperature
{
    double celsius;

    public Temperature(double value, TemperatureScale scale = TemperatureScale.Celsius)
    {
        switch (scale)
        {
            case TemperatureScale.Celsius:
                celsius = value;
                break;
            case TemperatureScale.Fahrenheit:
                Fahrenheit = value;
                break;
            case TemperatureScale.Kelvin:
                Kelvin = value;
                break;
        }
    }
    public double Celsius
    {
        get { return celsius; }
        set { celsius = value; }
    }
    public double Fahrenheit
    {
        get { return celsius * 9 / 5 + 32; }
        set { celsius = 5.0f / 9.0f * (value - 32); }
    }
    public double Kelvin
    {
        get { return Celsius + 274.15; }
        set { Celsius = value - 274.15; }
    }

    public string Format()
    {
        return $"{Fahrenheit}F is {Celsius}C which is {Kelvin}K";
    }
}