
using AvaloniaApplication.GeocodingUtility.Models;
using AvaloniaApplication.GeocodingUtility.Providers;
using ReactiveUI;

namespace AvaloniaApplication.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            DebugCommand = ReactiveCommand.Create(DebugMethod);
        }

        public IReactiveCommand DebugCommand { get; set; }


        private void DebugMethod()
        {
            var geocodingProvider = new GeocodingProvider();
            geocodingProvider.Get<GeocodingApiModel>("Рязань", 10);
        }
    }
}
