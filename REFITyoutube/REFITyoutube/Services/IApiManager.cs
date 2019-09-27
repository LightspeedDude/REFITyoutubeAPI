﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REFITyoutube.Services
{
    public interface IApiManager
    {
        Task<HttpResponseMessage> GetPlaylist(string playlist);
    }
}
