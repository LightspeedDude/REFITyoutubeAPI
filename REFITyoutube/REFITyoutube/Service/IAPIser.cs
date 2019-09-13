using Refit;
using ServiceStack.Auth;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace REFITyoutube.Service
{
    //public static class Config
    //{
    //    public static string ApiKey = "AIzaSyDb0fEgyMvxmhIJO8kzR6AuOPcQak45ees";
    //}
    public interface IAPIser
    {
        [Get("/v3/search?part=snippet&maxResults=10&q=Xamarin&type=playlist&key=AIzaSyDb0fEgyMvxmhIJO8kzR6AuOPcQak45ees")]
        Task<List<Snippet>> GetPlaylist(string brand);

        //[Post("/v3/search?part=snippet&maxResults=10&q=Xamarin&type=playlist&key=AIzaSyDb0fEgyMvxmhIJO8kzR6AuOPcQak45ees")]
        //Task<MakeUp> CreateMakeUp([Body] MakeUp makeUp, [Header("Authorization")] string token);
    }
}
