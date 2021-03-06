﻿using Refit;
using ServiceStack.Auth;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REFITyoutube.Service
{
    //public static class Config
    //{
    //    public static string ApiKey = "AIzaSyDb0fEgyMvxmhIJO8kzR6AuOPcQak45ees";
    //}
    [Headers("Content-Type: application/json")]

    public interface IAPIser
    {

        [Get("/v3/search?part=snippet&maxResults=10&q=Xamarin&type=playlist&key=AIzaSyDb0fEgyMvxmhIJO8kzR6AuOPcQak45ees")]
        Task<HttpResponseMessage> GetPlaylist(string playlist);

    }
}
