#pragma checksum "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/Pages/Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78eb0794e81550530d51067286a7d3ce4a2d9bfd"
// <auto-generated/>
#pragma warning disable 1591
namespace eCampus.WASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using eCampus.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/_Imports.razor"
using eCampus.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/Pages/Authentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/Pages/Authentication.razor"
                                  Action

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/home/mathews/Documents/GitHub/eCampus/eCampus.WASM/Pages/Authentication.razor"
      
    [Parameter] public string Action { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
