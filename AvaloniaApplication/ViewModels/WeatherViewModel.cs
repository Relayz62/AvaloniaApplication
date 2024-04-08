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
            WeathersInfo = new ObservableCollection<WeatherModel>(service.GetWeathers());
        }
        
        public ObservableCollection<WeatherModel> WeathersInfo { get; private set; }
    }
}
