using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace BlackBeltBlazor.Client.Shared
{
    public static class Utilities
    {
        public static IComponentRenderMode GetRenderMode(string renderMode)
        {
            return GetRenderMode(renderMode, true);
        }

        public static IComponentRenderMode GetRenderMode(string renderMode, bool prerender)
        {
            switch (renderMode)
            {
                case "InteractiveServer":
                    return new InteractiveServerRenderMode(prerender: prerender);
                case "InteractiveWebAssembly":
                    return new InteractiveWebAssemblyRenderMode(prerender: prerender);
                case "InteractiveAuto":
                    return new InteractiveAutoRenderMode(prerender: prerender);
            }
            return null;
        }
    }
}
