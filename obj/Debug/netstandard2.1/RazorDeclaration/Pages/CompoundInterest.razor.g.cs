#pragma checksum "D:\dotNet\CICalc\Pages\CompoundInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9b8cb0a0e2f95b4a68ae1efac8cfbbec6c740a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CICalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dotNet\CICalc\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNet\CICalc\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNet\CICalc\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNet\CICalc\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNet\CICalc\_Imports.razor"
using CICalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNet\CICalc\_Imports.razor"
using CICalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompoundInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\dotNet\CICalc\Pages\CompoundInterest.razor"
      
    DateTime now = DateTime.Now;
    private double Principal { get; set; } = 5000;
    private double InterestRate { get; set; } = 5;
    private int Years { get; set; } = 10;
    private double total { get; set; } = 0;
    private string Total { get; set; }

    private void Calculate()
{
    var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
    Total = total.ToString("C");
}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
