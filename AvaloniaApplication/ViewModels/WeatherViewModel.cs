using System.Collections.ObjectModel;
using System.Linq;
using AvaloniaApplication.Models;
using AvaloniaApplication.Services;

namespace AvaloniaApplication.ViewModels
{
    public class WeatherViewModel : ViewModelBase
    {
        public WeatherViewModel()
        {
            var service = new WeatherService();
            WeathersInfo = new ObservableCollection<Weather>(service.GetWeathers());
        }
        
        public ObservableCollection<Weather> WeathersInfo { get; private set; }
    }
}
