#pragma checksum "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b447ab00733e76d97bf3c6865d97b9b0b8e64b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UserListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UserListViewPartial.cshtml")]
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
#line 1 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\_ViewImports.cshtml"
using TechTree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\_ViewImports.cshtml"
using TechTree.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b447ab00733e76d97bf3c6865d97b9b0b8e64b", @"/Areas/Admin/Views/Shared/_UserListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8519f4f7bdc7908b79e12d455ba2cab4b26f1d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__UserListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTree.Areas.Admin.Models.UsersCategoryListModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th></th>\r\n\t\t\t<th>First Name</th>\r\n\t\t\t<th>Last Name</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 12 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
         if(Model.Users != null){
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
             foreach (var user in Model.Users)
		   {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t   <tr>\n\t\t\t\t   <td>\r\n\t\t\t\t\t   <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 372, "\"", 388, 1);
#nullable restore
#line 17 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
WriteAttributeValue("", 380, user.Id, 380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t   </td>\r\n\t\t\t\t   <td>");
#nullable restore
#line 19 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
                  Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t   <td>");
#nullable restore
#line 20 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
                  Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t   </tr>\n");
#nullable restore
#line 22 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
		   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "F:\1\mrmr\Microsoft-stack\C#\C#\projects\TechTree\TechTree\Areas\Admin\Views\Shared\_UserListViewPartial.cshtml"
            
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTree.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
