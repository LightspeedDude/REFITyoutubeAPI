using Acr.UserDialogs;
using REFITyoutube.Service;
using REFITyoutube.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace REFITyoutube.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IUserDialogs PageDialog = UserDialogs.Instance;
        public IApiManager ApiManager;
        IApiService<IAPIser> Apiplay = new APIservice<IAPIser>(Config.ApiUrl);
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsBusy { get; set; }
        public BaseViewModel()
        {
            ApiManager = new ApiManager(Apiplay);

        }

        public async Task RunSafe(Task task, bool ShowLoading = true, string loadinMessage = null)
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;

                if (ShowLoading) UserDialogs.Instance.ShowLoading(loadinMessage ?? "Loading");

                await task;
            }
            catch (Exception e)
            {
                IsBusy = false;
                UserDialogs.Instance.HideLoading();
                Debug.WriteLine(e.ToString());
                await App.Current.MainPage.DisplayAlert("Eror", "Check your internet connection", "Ok");

            }
            finally
            {
                IsBusy = false;
                if (ShowLoading) UserDialogs.Instance.HideLoading();
            }
        }

    }
}
