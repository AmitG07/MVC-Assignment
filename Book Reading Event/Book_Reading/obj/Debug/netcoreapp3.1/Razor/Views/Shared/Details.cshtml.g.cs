#pragma checksum "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d17a4cdb8e8b9b341627492db819ebb1d71c293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Details), @"mvc.1.0.view", @"/Views/Shared/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\_ViewImports.cshtml"
using Book_Reading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\_ViewImports.cshtml"
using Book_Reading.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d17a4cdb8e8b9b341627492db819ebb1d71c293", @"/Views/Shared/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b17b6b0ae90ac6a41078cfd6a6ae5e272a5455", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row \">\r\n    <div class=\"offset-5\">\r\n        <h2>Title : ");
#nullable restore
#line 5 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p><b>Date</b> : ");
#nullable restore
#line 6 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                    Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Location</b> : ");
#nullable restore
#line 7 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                        Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Start Time</b> : ");
#nullable restore
#line 8 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                          Write(Model.StartTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Type</b> : ");
#nullable restore
#line 9 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                    Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Duration In Hours</b> : ");
#nullable restore
#line 10 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                                 Write(Model.DurationInHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Description</b> : ");
#nullable restore
#line 11 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Other Details</b> : ");
#nullable restore
#line 12 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                             Write(Model.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><b>Invite By Email</b> : ");
#nullable restore
#line 13 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Shared\Details.cshtml"
                               Write(Model.InviteByEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
