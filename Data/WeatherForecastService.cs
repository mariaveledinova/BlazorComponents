using BlazorComponents.Data.DBData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponents.Data
{
    public class WeatherForecastService
    {
        public Task<List<WeatherForecast>> GetForecastAsync()
        {
            List<WeatherForecast> colWeatherForcasts = new List<WeatherForecast>();
            // Get Weather Forecasts  
            using (var context = new BlazordemodbContext())
            {
                colWeatherForcasts = context.WeatherForecast.ToList();
            }
            return Task.FromResult(colWeatherForcasts);
        }

        public Task<WeatherForecast> CreateForecastAsync(WeatherForecast objWeatherForecast)
        {
            using (var context = new BlazordemodbContext())
            {
                context.WeatherForecast.Add(objWeatherForecast);
                context.SaveChanges();
            }
            return Task.FromResult(objWeatherForecast);
        }

        public void UpdateForecast(WeatherForecast updatedItem)
        {
            using (var context = new BlazordemodbContext())
            {
                context.WeatherForecast.FirstOrDefault(w => w.Id == updatedItem.Id);
                context.Entry(updatedItem).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Task<bool> UpdateForecastAsync(WeatherForecast objWeatherForecast)
        {
            using (var context = new BlazordemodbContext())
            {
                var ExistingWeatherForecast =
                    context.WeatherForecast
                    .Where(x => x.Id == objWeatherForecast.Id)
                    .FirstOrDefault();

                if (ExistingWeatherForecast != null)
                {
                    ExistingWeatherForecast.Date =
                        objWeatherForecast.Date;
                    ExistingWeatherForecast.Summary =
                        objWeatherForecast.Summary;
                    ExistingWeatherForecast.TemperatureC =
                        objWeatherForecast.TemperatureC;
                    ExistingWeatherForecast.TemperatureF =
                        objWeatherForecast.TemperatureF;

                    context.Attach(ExistingWeatherForecast);
                    context.Entry(ExistingWeatherForecast).State = EntityState.Modified;

                    context.SaveChanges();
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
            return Task.FromResult(true);
        }
    }
}
