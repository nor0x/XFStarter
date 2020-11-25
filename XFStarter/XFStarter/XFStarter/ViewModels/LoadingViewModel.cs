using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TinyMvvm;

namespace XFStarter.ViewModels
{
    public class LoadingViewModel : ViewModelBase
    {
        public async override Task OnAppearing()
        {
            await Task.Delay(2000);
            await Navigation.NavigateToAsync("//main");
        }
    }
}
