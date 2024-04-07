using AvaloniaApplication.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace AvaloniaApplication.ViewModels;

public class MainViewModel : ViewModelBase
{

    public MainViewModel()
    {
        InitializeSideMenu();

        OpenPaneCommand = ReactiveCommand.Create(OpenPane);
        CurrentView = new HomeViewModel();
    }

    private bool _isPaneOpen = false;

    private ViewModelBase _currentView;
    private SideMenuItem _selectedSideMenuItem;

    #region Properties
    public ObservableCollection<SideMenuItem> SideMenuItems { get; private set; }

    public SideMenuItem SelectedSideMenuItem
    {
        get => _selectedSideMenuItem;
        set 
        { 
            this.RaiseAndSetIfChanged(ref _selectedSideMenuItem, value);
            OnSelectedSideMenuItemChanged(_selectedSideMenuItem);
        }
    }
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
    #endregion

    #region Commands and Implementations
    public IReactiveCommand OpenPaneCommand { get; private set; }

    private void OpenPane()
    {
        IsPaneOpen = !IsPaneOpen;
    }
    #endregion


    private void InitializeSideMenu()
    {
        SideMenuItems = new()
        {
            new SideMenuItem(typeof(HomeViewModel),"Главная","Home"),
            new SideMenuItem(typeof(WeatherViewModel),"Погода","Weather"),
        };
    }

    private void OnSelectedSideMenuItemChanged(SideMenuItem? sideMenuItem)
    {
        if (sideMenuItem is null)
            return;

        var instance = Activator.CreateInstance(sideMenuItem.Type);
        if (instance is null)
            return;

        CurrentView = (ViewModelBase)instance;
    }
}
