using CommunityToolkit.Mvvm.ComponentModel;
using MauiTest.Services.Navigation;
using MauiTest.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.ViewModels
{
    public abstract partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private bool isInitialized;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;
        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
        //private bool _disposedValue;
        public INavigationService NavigationService { get; private set; }

        public ViewModelBase(INavigationService navigationService, ISettingsService settingsService)
        {
            NavigationService = navigationService;
        }

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
