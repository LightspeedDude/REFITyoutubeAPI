using Refit;
using REFITyoutube.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace REFITyoutube.ViewModel
{
    class PlayViewModel: INotifyPropertyChanged
    {
        public ICommand Play { get; set; }
        public ObservableCollection<PlayView> PlayList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public PlayViewModel()
        {
            Play = new Command(async () =>
           {
               var current = Connectivity.NetworkAccess;
               if (current == NetworkAccess.Internet)
               {
                   await App.Current.MainPage.DisplayAlert("Connection Status", "Yey, you have a connection.", "Ok");
                   var apiresponse = RestService.For<IAPIser>("https://www.googleapis.com");
                   var playlist = await apiresponse.GetPLaylist();

                   //PlayList.ItemsSource = playlist;
               }
               else
               {
                   await App.Current.MainPage.DisplayAlert("Connection Status", "Welp, you ain't got internet", "Ok");
               }
           });
        }
    }
}
