#pragma checksum "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7472ed1aa0c27b9d4b986b0189c345983a971609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_eventsInvitedTo), @"mvc.1.0.view", @"/Views/Event/eventsInvitedTo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7472ed1aa0c27b9d4b986b0189c345983a971609", @"/Views/Event/eventsInvitedTo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8b17b6b0ae90ac6a41078cfd6a6ae5e272a5455", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_eventsInvitedTo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book_Reading.Models.CreateModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
  
    ViewData["Title"] = "eventsInvitedTo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h1 {
        color: rgb(255, 165, 0);
    }
</style>

<div class=""container"">
    <div class=""row"">
        <div class=""col-8 offset-2"" >
            <h1 class=""text-center"">Event record</h1>
            <table class=""table table-bordered"">
                <tr class=""text-center"">
                    <th>Title</th>
                    <th>Date</th>
                    <th>Location</th>
                    <th>StartTime</th>
                    <th>Type</th>
                    <th>Duration</th>
                    <th>Description</th>
                    <th>Others</th>
                </tr>
");
#nullable restore
#line 30 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                 foreach (var d in Model)
                {
                    string str = d.InviteByEmail;
                    string tempStr = "";
                    bool check = false;

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == ',')
                        {
                            if (@User.Identity.Name == tempStr)
                            {
                                check = true;
                                break;
                            }
                            tempStr = "";
                        }

                        else
                        {
                            tempStr = tempStr + str[i];
                        }
                    }

                    if (@User.Identity.Name == tempStr)
                    {
                        check = true;
                    }

                    tempStr = "";

                    if (check)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"text-center\">\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1955, 1);
#nullable restore
#line 64 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
WriteAttributeValue("", 1909, Url.Action("Details", new { Id = d.EventId }), 1909, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                                                                                    Write(d.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.StartTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.DurationInHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                           Write(d.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\amit04\source\repos\Book Reading Event\Book_Reading\Views\Event\eventsInvitedTo.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book_Reading.Models.CreateModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
