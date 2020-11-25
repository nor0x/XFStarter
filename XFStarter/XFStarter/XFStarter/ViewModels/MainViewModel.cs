using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TinyMvvm;
using XFStarter.Helpers;

namespace XFStarter.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand ChangeThemeCommand { get; set; }
        public MainViewModel()
        {
            ChangeThemeCommand = new TinyCommand(() =>
            {
                ResourcesHelper.ToggleTheme();
            });
        }
    }
}