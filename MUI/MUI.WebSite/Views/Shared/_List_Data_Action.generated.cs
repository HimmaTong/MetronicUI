﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MUI.WebSite;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 1 "..\..\Views\Shared\_List_Data_Action.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Action.cshtml")]
    public partial class _Views_Shared__List_Data_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Action_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Data_Action.cshtml"
  
    var entity = Model as IEntity;

    var rv = entity.GetRouteKey();

            
            #line default
            #line hidden
WriteLiteral("\r\n<!--双击打开添加样式 .editcell 即可-->\r\n");

            
            #line 8 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (this.Has(PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 185), Tuple.Create("\"", 215)
            
            #line 10 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 192), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", rv)
            
            #line default
            #line hidden
, 192), false)
);

WriteLiteral(" class=\"btn btn-outline-hover-primary text-primary btn-sm p-0 pr-2 pl-2 pt-1 edit" +
"cell\"");

WriteLiteral(" title=\"编辑\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"flaticon2-edit text-primary\"");

WriteLiteral("></i>\r\n    </a>\r\n");

            
            #line 13 "..\..\Views\Shared\_List_Data_Action.cshtml"
}
else if (this.Has(PermissionFlags.Detail))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 435), Tuple.Create("\"", 467)
            
            #line 16 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 442), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", rv)
            
            #line default
            #line hidden
, 442), false)
);

WriteLiteral(" class=\"btn btn-outline-hover-primary text-primary btn-sm p-0 pr-2 pl-2 pt-1\"");

WriteLiteral(" title=\"查看\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"flaticon2-document text-primary\"");

WriteLiteral("></i>\r\n    </a>\r\n");

            
            #line 19 "..\..\Views\Shared\_List_Data_Action.cshtml"
}

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (this.Has(PermissionFlags.Delete))
{
    var fact = ViewBag.Factory as IEntityOperate;
    var fi = (fact == null || fact.Fields == null) ? null : fact.Fields.FirstOrDefault(e => e.Name.EqualIgnoreCase("Deleted", "IsDelete", "IsDeleted"));
    if (fi != null && fi.Type == typeof(Boolean) && (Boolean)entity[fi.Name])
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" title=\"恢复\"");

WriteLiteral(" class=\"btn btn-outline-hover-success btn-sm p-0 pr-1 pl-2 pt-1 swal_tip\"");

WriteLiteral(" data-url=\"");

            
            #line 26 "..\..\Views\Shared\_List_Data_Action.cshtml"
                                                                                                    Write(Url.Action("Delete", rv));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-type=\"warning\"");

WriteLiteral(" data-title=\"确认恢复？\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"flaticon-layer text-danger\"");

WriteLiteral("></i>\r\n        </a>\r\n");

            
            #line 29 "..\..\Views\Shared\_List_Data_Action.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" title=\"删除\"");

WriteLiteral(" class=\"btn btn-outline-hover-success btn-sm p-0 pr-1 pl-2 pt-1 swal_tip\"");

WriteLiteral(" data-url=\"");

            
            #line 32 "..\..\Views\Shared\_List_Data_Action.cshtml"
                                                                                                    Write(Url.Action("Delete", rv));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-type=\"error\"");

WriteLiteral(" data-title=\"确认删除？\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"flaticon-delete text-danger\"");

WriteLiteral("></i>\r\n        </a>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data_Action.cshtml"
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
