#pragma checksum "C:\hackaton\proy_movies\proyFinal_g63\Client\Pages\Movie\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "311cd5f5d66d230b16357ddebfe2fe847a3ace5b"
// <auto-generated/>
#pragma warning disable 1591
namespace proyFinal_g63.Client.Pages.Movie
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using proyFinal_g63.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using proyFinal_g63.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using proyFinal_g63.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\hackaton\proy_movies\proyFinal_g63\Client\_Imports.razor"
using proyFinal_g63.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\hackaton\proy_movies\proyFinal_g63\Client\Pages\Movie\EditMovie.razor"
using proyFinal_g63.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{Id:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<proyFinal_g63.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<proyFinal_g63.Shared.Model.Movie>(
#nullable restore
#line 6 "C:\hackaton\proy_movies\proyFinal_g63\Client\Pages\Movie\EditMovie.razor"
                    Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 6 "C:\hackaton\proy_movies\proyFinal_g63\Client\Pages\Movie\EditMovie.razor"
                                            Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\hackaton\proy_movies\proyFinal_g63\Client\Pages\Movie\EditMovie.razor"
      

    [Parameter] public int Id{get;set;}
    private Movie Movie = new Movie();



        protected override void OnInitialized()
        {
           Movie = new Movie(){
                Id=Id,
                Name = "Los Juegos del Hambre"
            };
        }


    

    
    void Edit(){
        Console.WriteLine(Movie.Name);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
