// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Владислав\RiderProjects\blazor\blazor\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Владислав\RiderProjects\blazor\blazor\Pages\Index.razor"
using AntDesign.TableModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Владислав\RiderProjects\blazor\blazor\Pages\Index.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Владислав\RiderProjects\blazor\blazor\Pages\Index.razor"
       

    class Data
    {
        public Data(string name, string address, DateTime birthDate, bool isActive, string gender)
        {
            Name = name;
            Address = address;
            BirthDate = birthDate;
            IsActive = isActive;
            Gender = gender;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }
    }

    Data[] data =
    {
        new("John Brown","New York No. 1 Lake Park",new DateTime(1980,1,1),true,"Male"),
        new("Sara Green","London No. 1 Lake Park",new DateTime(1983,12,1),true,"Female"),
        new("Joe Black", "Sidney No. 1 Lake Park",new DateTime(1977,11,1),true,"Male"),
        new("Jim Red","London No. 2 Lake Park",new DateTime(1985,1,1),false,"Male"),
    };

    public TableFilter<string>[] genderFilters = new TableFilter<string>[] {
        new() { Text = "Male", Value = "Male" },
        new() { Text = "Female", Value = "Female" },
    };

    void OnChange(QueryModel<Data> query)
    {
        Console.WriteLine(JsonSerializer.Serialize(query));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
