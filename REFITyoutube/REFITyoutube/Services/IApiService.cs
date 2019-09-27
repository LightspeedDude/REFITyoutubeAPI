using System;
using System.Collections.Generic;
using System.Text;
using static Android.Renderscripts.RenderScript;

namespace REFITyoutube.Services
{
    interface IApiService<T>
    {
        T GetApi(Priority priority);
    }
}
