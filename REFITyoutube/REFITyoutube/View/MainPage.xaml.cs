using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Refit;
using REFITyoutube.Service;
using Xamarin.Essentials;
using REFITyoutube.ViewModel;

namespace REFITyoutube
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PlayViewModel();
        }
        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await CallApi();
        //}

        //async void PlayClicked(object sender, System.EventArgs e)
        //{
        //    var current = Connectivity.NetworkAccess;
        //    if (current == NetworkAccess.Internet)
        //    {
        //        await App.Current.MainPage.DisplayAlert("Connection Status", "Yey, you have a connection.", "Ok");
        //        var apiresponse = RestService.For<IAPIser>("https://www.googleapis.com");
        //        var playlist = await apiresponse.GetPLaylist();

        //        PlayList.ItemsSource = playlist;
        //    }
        //    else
        //    {
        //        await App.Current.MainPage.DisplayAlert("Connection Status", "Welp, you ain't got internet", "Ok");
        //    }
           
        //}

    }
}
