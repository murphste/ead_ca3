#pragma checksum "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26f555592498d569daa464a215d2ffafeb8944b"
// <auto-generated/>
#pragma warning disable 1591
namespace CountriesOfTheWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using CountriesOfTheWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\_Imports.razor"
using CountriesOfTheWorld.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h5>Geoogle</h5>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mb-5 row");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(3);
            __builder.AddAttribute(4, "Placeholder", "Search Query");
            __builder.AddAttribute(5, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                                         SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SearchTerm = __value, SearchTerm))));
            __builder.AddAttribute(7, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SearchTerm));
            __builder.CloseComponent();
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(8);
            __builder.AddAttribute(9, "Text", "Search");
            __builder.AddAttribute(10, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                                                                                                        GetQueryDataAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
 if (string.IsNullOrWhiteSpace(SearchTerm))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"mt-5 countryLookupMessage\"><h5>To Use Country Lookup... Please search for a country!</h5></div>");
#nullable restore
#line 29 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "h5");
            __builder.AddContent(13, "Here is the resulting information for ");
            __builder.AddContent(14, 
#nullable restore
#line 32 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                               SearchTerm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Native Name</th>\r\n                <th>Capital City</th>\r\n                <th>Region</th>\r\n                <th>Sub-Region</th>\r\n                <th>Population</th></tr></thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 45 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
             foreach (var d in data)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 48 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                     d.nativeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 49 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                     d.capital

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 50 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                     d.region

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                     d.subregion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                     d.population

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"

 //Second row of 4 tables to show collections

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "mt-5 row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-3");
            __builder.OpenElement(38, "table");
            __builder.AddMarkupContent(39, "<thead><tr><th>Timezones</th></tr></thead>\r\n            ");
            __builder.OpenElement(40, "tbody");
            __builder.OpenElement(41, "tr");
            __builder.OpenElement(42, "td");
#nullable restore
#line 70 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                         foreach (var d in data)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                             foreach (var t in d.timezones)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.AddContent(44, 
#nullable restore
#line 74 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                             t

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                         
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-sm-3");
            __builder.OpenElement(48, "table");
            __builder.AddMarkupContent(49, "<thead><tr><th>Currencies</th></tr></thead>\r\n                    ");
            __builder.OpenElement(50, "tbody");
            __builder.OpenElement(51, "tr");
            __builder.OpenElement(52, "td");
#nullable restore
#line 94 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                 foreach (var d in data)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                     foreach (var t in d.currencies)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "tr");
            __builder.AddContent(54, 
#nullable restore
#line 98 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                     t.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                             
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-sm-3");
            __builder.OpenElement(58, "table");
            __builder.AddMarkupContent(59, "<thead><tr><th>Spoken Languages</th></tr></thead>\r\n                            ");
            __builder.OpenElement(60, "tbody");
            __builder.OpenElement(61, "tr");
            __builder.OpenElement(62, "td");
#nullable restore
#line 116 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                         foreach (var d in data)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                             foreach (var t in d.languages)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "tr");
            __builder.AddContent(64, 
#nullable restore
#line 120 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                             t.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                     
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-sm-3");
            __builder.OpenElement(68, "table");
            __builder.AddMarkupContent(69, "<thead><tr><th>Borders</th></tr></thead>\r\n                                    ");
            __builder.OpenElement(70, "tbody");
            __builder.OpenElement(71, "tr");
            __builder.OpenElement(72, "td");
#nullable restore
#line 138 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                 foreach (var d in data)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                     foreach (var t in d.borders)
                                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "tr");
            __builder.AddContent(74, 
#nullable restore
#line 142 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                     t

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 143 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                                 
                                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 150 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                                       //End collections row











}

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
 if (data == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<p><em>Loading.....</em></p>");
#nullable restore
#line 168 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
}
else
{



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\Index.razor"
                       


    // Need instance of Root as data (response obj) needs to contain an IEnumerable to iterate over
    // Set this up to contain objects of the model class CountryData as below
    public class Root
    {
        public List<CountryData> MyArray { get; set; }
    }








    // Used for searching by user
    // Initalised to prevent null
    private string SearchQuery { get; set; }

    // Boolean method to display whether or not user enters letters in either upper or lowercase
    public bool IsVisible(CountryData country)
    {
        if (string.IsNullOrEmpty(SearchQuery))
            return true;

        if (country.name.Contains(SearchQuery, StringComparison.OrdinalIgnoreCase))
            return true;

        if (country.name.ToString().StartsWith(SearchQuery))
            return true;

        return false;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
