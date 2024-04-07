using ReactiveUI;

namespace AvaloniaApplication.ViewModels;

public class MainViewModel : ViewModelBase
{

    public MainViewModel()
    {
        OpenPaneCommand = ReactiveCommand.Create(OpenPane);
        CurrentView = new HomeViewModel();
    }

    private bool _isPaneOpen = false;

    private ViewModelBase _currentView;

    public ViewModelBase CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }

    public bool IsPaneOpen
    {
        get => _isPaneOpen;
        set => this.RaiseAndSetIfChanged(ref _isPaneOpen, value);
    }

    public IReactiveCommand OpenPaneCommand { get; private set; }

    private void OpenPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
}
