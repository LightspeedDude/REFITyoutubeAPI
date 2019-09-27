using Newtonsoft.Json;
using Refit;
using REFITyoutube.Service;
using REFITyoutube.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace REFITyoutube.ViewModel
{
    class PlayViewModel : BaseViewModel
    {
        public ICommand Play { get; set; }
        public ObservableCollection<Snippet> Playlist { get; set; }


        public PlayViewModel()
        {
            Play = new Command(async () => await RunSafe(GetData()));

        }
        async Task GetData()
        {

            var makeUpsResponse = await ApiManager.GetPlaylist("xamarin");

            if (makeUpsResponse.IsSuccessStatusCode)
            {
                var response = await makeUpsResponse.Content.ReadAsStringAsync();
                var json = await Task.Run(() => JsonConvert.DeserializeObject<List<Snippet>>(response));
                Playlist = new ObservableCollection<Snippet>(json);
            }
            else
            {
                await PageDialog.AlertAsync("Unable to get data", "Error", "Ok");
            }
        }
    }
}
