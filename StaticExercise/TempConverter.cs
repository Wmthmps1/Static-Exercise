using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double temperature)
		{
            // °C = (°F - 32) × 5/9
            temperature = (temperature - 32.0) * (5.0 / 9.0);
            return temperature;
		}

        public static double CelsiusToFahrenheit(double temperature)
        {

            // °F = (°C × 9/5) + 32
            temperature = (temperature * (9.0 / 5.0)) + 32.0;
            return temperature;
        }

    }
}

