using System;
using System.Collections.Generic;
using System.Text;

namespace Items
{
    public class daily
    {
        public string summary { set; get; }
        public string icon { set; get; }
        public List<datadaily> data { set; get; }
    }
    public class datadaily
    {
        public string time { set; get; }
        public string summary { set; get; }
        public string icon { set; get; }
        public string sunriseTime { set; get; }
        public string sunsetTime { set; get; }
        public string moonPhase { set; get; }
        public string precipIntensity { set; get; }
        public string precipIntensityMax { set; get; }
        public string precipIntensityMaxTime { set; get; }
        public string precipProbability { set; get; }
        public string precipType { set; get; }
        public string temperatureHigh { set; get; }
        public string temperatureHighTime { set; get; }
        public string temperatureLow { set; get; }
        public string temperatureLowTime { set; get; }
        public string apparentTemperatureHigh { set; get; }
        public string apparentTemperatureHighTime { set; get; }
        public string apparentTemperatureLow { set; get; }
        public string apparentTemperatureLowTime { set; get; }
        public string dewPoint { set; get; }
        public string humidity { set; get; }
        public string pressure { set; get; }
        public string windSpeed { set; get; }
        public string windGust { set; get; }
        public string windGustTime { set; get; }
        public string windBearing { set; get; }
        public string cloudCover { set; get; }
        public string uvIndex { set; get; }
        public string uvIndexTime { set; get; }
        public string visibility { set; get; }
        public string ozone { set; get; }
        public string temperatureMin { set; get; }
        public string temperatureMinTime { set; get; }
        public string temperatureMax { set; get; }
        public string temperatureMaxTime { set; get; }
        public string apparentTemperatureMin { set; get; }
        public string apparentTemperatureMinTime { set; get; }
        public string apparentTemperatureMax { set; get; }
        public string apparentTemperatureMaxTime { set; get; }
    }
}
