#pragma checksum "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55e92c20df76c8eaccb347e690b4cdd9cb05124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendances_Index), @"mvc.1.0.view", @"/Views/Attendances/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendances/Index.cshtml", typeof(AspNetCore.Views_Attendances_Index))]
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
#line 1 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\_ViewImports.cshtml"
using Hospital_Managmnt;

#line default
#line hidden
#line 2 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\_ViewImports.cshtml"
using Hospital_Managmnt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55e92c20df76c8eaccb347e690b4cdd9cb05124", @"/Views/Attendances/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb5cabb7f0c56f66119181c6a6143d219d30015", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendances_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hospital_Managmnt.Models.Attendance>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(102, 1442, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        Attendances
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""https://localhost:44360/""><i class=""fa fa-dashboard""></i>Home</a></li>
        <li class=""active"">Doctors</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Manage Attendances</h3>
                    <div class=""card pull-right"">
                        <a href=""Attendances/Create"" class=""btn btn-success""><i class=""fa fa-plus""></i> Add Attendances</a>
                    </div>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""attendance"" class=""table table-hover table-striped"">
                        <thead>
                            <tr>
                                <th>PatientID</th>
   ");
            WriteLiteral(@"                             <th>Date</th>
                                <th>Hospital Remarks</th>
                                <th>Diagnosis</th>
                                <th>Second Diagnosis</th>
                                <th>Theraphy</th>
                                <th>Action</th>

                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 44 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1633, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1704, 44, false);
#line 47 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PatientId));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1792, 39, false);
#line 48 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1875, 50, false);
#line 49 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.HospitalRemarks));

#line default
#line hidden
            EndContext();
            BeginContext(1925, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1969, 44, false);
#line 50 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(2013, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2057, 50, false);
#line 51 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SecondDiagonsis));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2151, 43, false);
#line 52 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Theraphy));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 47, true);
            WriteLiteral("</td>\r\n\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2241, "\"", 2275, 2);
            WriteAttributeValue("", 2248, "Attendances/Update/", 2248, 19, true);
#line 54 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
WriteAttributeValue("", 2267, item.Id, 2267, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2276, 24, true);
            WriteLiteral(">Update</a> | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2300, "\"", 2328, 3);
            WriteAttributeValue("", 2310, "Delete(\'", 2310, 8, true);
#line 54 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
WriteAttributeValue("", 2318, item.Id, 2318, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2326, "\')", 2326, 2, true);
            EndWriteAttribute();
            BeginContext(2329, 53, true);
            WriteLiteral(">Delete</a></td>\r\n                            </tr>\r\n");
            EndContext();
#line 56 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2413, 246, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n                <!-- /.box-body -->\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n\r\n<!-- DataTables -->\r\n");
            EndContext();
            BeginContext(2659, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0491b84c3f2b46028adef932478a5fd8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2744, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2746, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b014ca6ebe7146c4b911476b609a0bdb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2837, 326, true);
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        $('#attendance').DataTable();
    });
    function Delete(id){
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(3164, 35, false);
#line 84 "E:\Asp.Net Core\Hospital_Managmnt\Hospital_Managmnt\Views\Attendances\Index.cshtml"
                 Write(Url.Action("Delete", "Attendances"));

#line default
#line hidden
            EndContext();
            BeginContext(3199, 577, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl =""/Attendances"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        }
    }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hospital_Managmnt.Models.Attendance>> Html { get; private set; }
    }
}
#pragma warning restore 1591
