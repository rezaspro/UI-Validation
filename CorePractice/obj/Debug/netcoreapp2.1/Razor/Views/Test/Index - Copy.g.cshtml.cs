#pragma checksum "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3141d513d6d07770d77a3b079b36ff7e23115164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index___Copy), @"mvc.1.0.view", @"/Views/Test/Index - Copy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Index - Copy.cshtml", typeof(AspNetCore.Views_Test_Index___Copy))]
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
#line 1 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\_ViewImports.cshtml"
using CorePractice;

#line default
#line hidden
#line 2 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\_ViewImports.cshtml"
using CorePractice.Models;

#line default
#line hidden
#line 1 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
using j = Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3141d513d6d07770d77a3b079b36ff7e23115164", @"/Views/Test/Index - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0209a11b53432d8fd91f1d6aa292a4972ccf917d", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Index___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
  




    var xsha = "";



#line default
#line hidden
            BeginContext(65, 51, true);
            WriteLiteral("    <script>\r\n\r\n        xsha = \"\";\r\n    </script>\r\n");
            EndContext();
#line 14 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"

    foreach (var item in @ViewBag.Data)
    {
        xsha = "<option value=" + @item.Id + " data-amount=" + @item.Amount + ">" + @item.Dura + "</option>";
    }


#line default
#line hidden
            BeginContext(289, 1312, true);
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""col-md-8"">
        <div class=""row"">
            <table class=""table table-bordered"" id=""initialTable"">
                <thead>
                    <tr hidden>
                        <th style=""text-align:center; width:49%"">Name</th>
                        <th style=""text-align:center; width:16%"">Duration</th>
                        <th style=""text-align:center; width:16%"">Amount</th>
                        <th style=""text-align:center; width:14%"">Duration</th>
                        <th style=""text-align:center; width:5%""></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th style=""text-align:center; width:49%""><input type=""text"" class=""form-control"" id=""name"" name=""name"" /></th>
                        <th style=""text-align:center; width:16%""><input type=""text"" class=""form-control"" id=""duration"" name=""duration"" onkeypress=""return isNumberKey(event,this)"" /></th>
   ");
            WriteLiteral(@"                     <th style=""text-align:center; width:16%""><input type=""text"" class=""form-control"" id=""amount"" name=""amount"" onkeypress=""return isNumberKey(event,this)"" /></th>
                        <th style=""width:14%"">
                            <select class=""form-control"">
");
            EndContext();
#line 42 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                                  
                                    foreach (var item in @ViewBag.Data)
                                    {

#line default
#line hidden
            BeginContext(1749, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1789, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79fda78adb4b4cde95729748cb586677", async() => {
                BeginContext(1842, 9, false);
#line 45 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                                                                                       Write(item.Dura);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 45 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 45 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                                                                         Write(item.Amount);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-amount", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1860, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(1936, 939, true);
            WriteLiteral(@"                            </select>
                        </th>
                        <th style=""text-align:center; width:5%;padding-bottom: 10px""><button type=""button"" class=""btn btn-primary btn-sm newItem"">+</button></th>
                    </tr>
                </tbody>
            </table>
        </div>

        <div class=""row"">
            <table class=""table table-bordered"" id=""assignTable"">
                <tr>
                    <th style=""text-align:center; width:49%"">Name</th>
                    <th style=""text-align:center; width:16%"">Duration</th>
                    <th style=""text-align:center; width:16%"">Amount</th>
                    <th style=""text-align:center; width:14%"">Duration</th>
                    <th style=""text-align:center; width:5%""></th>
                </tr>
                <tbody><tr hidden></tr></tbody>
            </table>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2892, 699, true);
                WriteLiteral(@"
    
<script type=""text/javascript"">
        function isNumberKey(evt, obj) {

            var charCode = (evt.which) ? evt.which : event.keyCode
            var value = obj.value;
            var dotcontains = value.indexOf(""."") != -1;
            if (dotcontains)
                if (charCode == 46) return false;
            if (charCode == 46) return true;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }

        function isEmpty(value) {
            return (value == null || value.length === 0) ? true : false;
        }

        $(document).ready(function () {

            var inc = '");
                EndContext();
                BeginContext(3592, 67, false);
#line 93 "E:\03. TEST PROJECT\CorePractice\CorePractice\Views\Test\Index - Copy.cshtml"
                  Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewBag.Data)));

#line default
#line hidden
                EndContext();
                BeginContext(3659, 3093, true);
                WriteLiteral(@"';
            inc = JSON.parse(inc);
            console.log(inc);

            var ss = """";
            for (i = 0; i < inc.length; i++) {
                ss+= '<option value=""' + inc[i].Id + '"" data-amount=""'+inc[i].Amount+'"">' + inc[i].Dura + '</option>'
            }

            console.log(ss);

            $("".newItem"").click(function () {
                var name = $(""#name"").val();
                var duration = $(""#duration"").val();
                var amount = $(""#amount"").val();

                if (isEmpty(name) == true) {
                    $('#name').css('border-color', 'red');
                    return;
                }
                else {
                    $('#name').css('border-color', '');
                }

                if (isEmpty(duration) == true) {
                    $('#duration').css('border-color', 'red');
                    return;
                }
                else {
                    $('#duration').css('border-color', '');
       ");
                WriteLiteral(@"         }

                if (isEmpty(amount) == true) {
                    $('#amount').css('border-color', 'red');
                    return;
                }
                else {
                    $('#amount').css('border-color', '');
                }

                $(""#assignTable"").append('<tr>' +
                    '<th style = ""text-align:center; width:49%""> <input type=""text"" class=""form-control"" id=""name"" name=""name"" disabled value=""' + name + '"" /></th >' +
                    '<th style=""text-align:center; width:16%""><input type=""text"" class=""form-control"" id=""duration"" name=""duration"" disabled value=""' + duration + '"" /></th>' +
                    '<th style=""text-align:center; width:16%""><input type=""text"" class=""form-control"" id=""amount"" name=""amount"" disabled value=""' + amount + '"" /></th>' +
                    '<th style=""text-align:center; width:14%""><select class=""form-control"">""'+ss+'""</select></th>'+
                    '<th style=""text-align:center; width:5% ");
                WriteLiteral(@";padding-bottom: 10px""><button type=""button"" class=""btn btn-primary btn-sm removeItem"">-</button></th>' +
                    '</tr>');
                $(""#name"").val('');
                $(""#duration"").val('');
                $(""#amount"").val('');

            });

            $(""#assignTable"").on('click', '.removeItem', function () {
                $(this).parent().parent().remove();
            });

            //$("".newItem"").click(function () {

            //    var $initialBody = $('#initialTable').find(""tbody"");
            //        $initialTrLast = $initialBody.find(""tr:last"");
            //        $trNew1 = $initialTrLast.clone();

            //    var $tableBody = $('#assignTable').find(""tbody"");
            //    $trLast = $tableBody.find(""tr:last"");
            //    console.log(""last"", $trLast);
            //        //$trNew = $initialTrLast.clone();
            //    $trLast.after($trNew1);
            //    console.log(""calling"", $trNew1);
            //});
     ");
                WriteLiteral("   });\r\n\r\n</script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591