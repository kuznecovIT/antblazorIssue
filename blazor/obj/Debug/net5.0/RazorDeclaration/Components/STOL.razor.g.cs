// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor.Components
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
#line 1 "C:\Users\Владислав\RiderProjects\blazor\blazor\Components\STOL.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Владислав\RiderProjects\blazor\blazor\Components\STOL.razor"
using AntDesign.TableModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Владислав\RiderProjects\blazor\blazor\Components\STOL.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Владислав\RiderProjects\blazor\blazor\Components\STOL.razor"
using blazor.Models;

#line default
#line hidden
#nullable disable
    public partial class STOL : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Владислав\RiderProjects\blazor\blazor\Components\STOL.razor"
 

    List<TemplateModel> _templateModels = new List<TemplateModel>();
    IEnumerable<TemplateModel> selectedRows;
    
    ITable table;

    int _pageIndex = 1;
    int _pageSize = 10;
    int _total = 0;

    protected override async Task OnInitializedAsync()
    {
        _templateModels = templateModels;
        _total = _templateModels.Count;
    }
    
    public static List<TemplateModel> templateModels = new List<TemplateModel>()
    {
        new TemplateModel() {Id = 1, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 2},
        new TemplateModel() {Id = 2, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 3},
        new TemplateModel() {Id = 3, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 25},
        new TemplateModel() {Id = 4, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 2},
        new TemplateModel() {Id = 5, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 6},
        new TemplateModel() {Id = 6, CreationDate = DateTime.Now, DueDate = DateTime.Now, FileExists = true, UpdateDate = DateTime.Now, TemplateTypeId = 27},
    };
    

    public async Task OnChange(QueryModel<TemplateModel> queryModel)
    {
        Console.WriteLine(JsonSerializer.Serialize(queryModel));
    }
    
    public void RemoveSelection(long id)
    {
        var selected = selectedRows.Where(x => x.Id != id);
        selectedRows = selected;
    }

    private void Delete(long id)
    {
        _templateModels = _templateModels.Where(x => x.Id != id).ToList();
        _total = _templateModels.Count;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
