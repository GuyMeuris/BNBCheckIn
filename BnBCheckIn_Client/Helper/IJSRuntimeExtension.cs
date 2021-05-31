using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime, string message )
        {
            await jsRuntime.InvokeVoidAsync("Window.ShowSwal", "success", message);
        }

        public static async ValueTask SweetAlertError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("Window.ShowSwal", "error", message);
        }
    }
}
