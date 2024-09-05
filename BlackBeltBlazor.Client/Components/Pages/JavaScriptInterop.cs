using Microsoft.JSInterop;

namespace BlackBeltBlazor
{
    public class JavaScriptInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public JavaScriptInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task ShowAlert()
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync(
                    "BlackBeltBlazor.JavaScriptInteractive.showAlert");
            }
            catch
            {
                // handle exception
            }
        }
    }
}

