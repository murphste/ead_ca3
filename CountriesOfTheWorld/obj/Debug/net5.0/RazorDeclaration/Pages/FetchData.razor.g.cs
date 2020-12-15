// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CountriesOfTheWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Non Repo\CountriesOfTheWorld\Pages\FetchData.razor"
      


    private string country = "ireland";
    private string errorMsg;
    private Root[] data;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            string apiLinkEurope = "https://restcountries.eu/rest/v2/region/europe";
            //string apiLink = "https://restcountries.eu/rest/v2/name/" + country + "?fullText=true";
            data = await Http.GetFromJsonAsync<Root[]>(apiLinkEurope);
            errorMsg = String.Empty;
        }
        catch (Exception e)
        {
            errorMsg = e.Message;
        }

    }

    // Base classes
    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Language
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }

    public class Translations
    {
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string it { get; set; }
        public string br { get; set; }
        public string pt { get; set; }
        public string nl { get; set; }
        public string hr { get; set; }
        public string fa { get; set; }
    }

    public class RegionalBloc
    {
        public string acronym { get; set; }
        public string name { get; set; }
        public List<object> otherAcronyms { get; set; }
        public List<object> otherNames { get; set; }
    }

    public class Root
    {
        public string name { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public int population { get; set; }
        public List<double> latlng { get; set; }
        public string demonym { get; set; }
        public double area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        public string nativeName { get; set; }
        public string numericCode { get; set; }
        public List<Currency> currencies { get; set; }
        public List<Language> languages { get; set; }
        public Translations translations { get; set; }
        public string flag { get; set; }
        public List<RegionalBloc> regionalBlocs { get; set; }
        public string cioc { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591