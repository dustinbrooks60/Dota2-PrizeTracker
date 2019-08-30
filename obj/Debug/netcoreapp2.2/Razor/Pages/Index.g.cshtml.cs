#pragma checksum "c:\Users\Dustin Brooks\PrizeTracker\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da32767a425efd1478484332694d4bcd42ae45e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PrizeTracker.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(PrizeTracker.Pages.Pages_Index), null)]
namespace PrizeTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "c:\Users\Dustin Brooks\PrizeTracker\Pages\_ViewImports.cshtml"
using PrizeTracker;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da32767a425efd1478484332694d4bcd42ae45e5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b66f7fdd4dc6b1da2edab8446b74218bdd9b41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ti8", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ti7", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ti6", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ti5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ti4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\Dustin Brooks\PrizeTracker\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 5664, true);
            WriteLiteral(@"        <!-- Begin Page Content -->
        <div class=""container-fluid"">

          <!-- Page Heading -->
          <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
            <h1 class=""h3 mb-0 text-gray-800"">The International 2019 Prize Pool Information</h1>
            <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm""><i class=""fas fa-download fa-sm text-white-50""></i> Generate Report</a>
          </div>

          <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
          <h2 class=""h5 mb-0 text-gray-800"">""The top teams in the world compete to claim the ultimate prize--the Aegis of Champions.""</h2>
          </div>

          <!-- Content Row -->
          <div class=""row"">

            <!-- Base Prize Pool Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
              <div class=""card border-left-primary shadow h-100 py-2"">
                <div class=""card-body"">
                  <div class=");
            WriteLiteral(@"""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                      <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Base Prize Pool</div>
                      <div class=""h5 mb-0 font-weight-bold text-gray-800"">$1,600,000</div>
                    </div>
                    <div class=""col-auto"">
                      <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <!-- Contributed Prize Pool Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
              <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                  <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                      <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Contributed Prize Pool</div>
          ");
            WriteLiteral(@"            <div class=""h5 mb-0 font-weight-bold text-gray-800"">$31,480,264</div>
                    </div>
                    <div class=""col-auto"">
                      <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <!-- Percentage Increased Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
              <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                  <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                      <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Percentage Increased</div>
                      <div class=""row no-gutters align-items-center"">
                        <div class=""col-auto"">
                          <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">1967.52%</div>
      ");
            WriteLiteral(@"                  </div>
                        <div class=""col"">
                          <div class=""progress progress-sm mr-2"">
                            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                          </div>
                        </div>
                      </div>
                      <div class=""text-xs font-weight-bold text-info text-uppercase mb-1""></div>
                    </div>
                    <div class=""col-auto"">
                      <i class=""fas fa-percent fa-2x text-gray-300""></i>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <!-- Total Prize Pool Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
              <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                  <div class=""row no-gutters");
            WriteLiteral(@" align-items-center"">
                    <div class=""col mr-2"">
                      <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Total Prize Pool</div>
                      <div class=""h5 mb-0 font-weight-bold text-gray-800"">$33,080,264</div>
                    </div>
                    <div class=""col-auto"">
                      <i class=""fas fa-trophy fa-2x text-gray-300""></i>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <!-- Content Row -->

          <div class=""row"">

            <!-- Area Chart -->
            <div class=""col-xl-8 col-lg-7"">
              <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                  <h6 class=""m-0 font-weight-bold text-primary"">Monthly Prize Pool Tracking Comparison Graph</h6>
  ");
            WriteLiteral(@"                <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                      <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                      <div class=""dropdown-header"">Dropdown Header:</div>
                      ");
            EndContext();
            BeginContext(5735, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e511235", async() => {
                BeginContext(5778, 74, true);
                WriteLiteral("The International 2019: <i class=\"fa fa-circle\" style=\"color: purple\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5856, 24, true);
            WriteLiteral("\r\n                      ");
            EndContext();
            BeginContext(5880, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e512786", async() => {
                BeginContext(5921, 73, true);
                WriteLiteral("The International 2018: <i class=\"fa fa-circle\" style=\"color: green\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5998, 24, true);
            WriteLiteral("\r\n                      ");
            EndContext();
            BeginContext(6022, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e514336", async() => {
                BeginContext(6063, 72, true);
                WriteLiteral("The International 2017: <i class=\"fa fa-circle\" style=\"color: blue\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6139, 24, true);
            WriteLiteral("\r\n                      ");
            EndContext();
            BeginContext(6163, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e515885", async() => {
                BeginContext(6204, 71, true);
                WriteLiteral("The International 2016: <i class=\"fa fa-circle\" style=\"color: red\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6279, 24, true);
            WriteLiteral("\r\n                      ");
            EndContext();
            BeginContext(6303, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e517433", async() => {
                BeginContext(6344, 74, true);
                WriteLiteral("The International 2015: <i class=\"fa fa-circle\" style=\"color: yellow\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6422, 24, true);
            WriteLiteral("\r\n                      ");
            EndContext();
            BeginContext(6446, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da32767a425efd1478484332694d4bcd42ae45e518984", async() => {
                BeginContext(6487, 76, true);
                WriteLiteral("The International 2014: <i class=\"fa fa-circle\" style=\"color: deeppink\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6567, 6142, true);
            WriteLiteral(@"
                    </div>
                  </div>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                  <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                  </div>
                </div>
              </div>
            </div>

            <!-- Pie Chart -->
            <div class=""col-xl-4 col-lg-5"">
              <div class=""card shadow mb-4"">
                <!-- Card Header - Dropdown -->
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                  <h6 class=""m-0 font-weight-bold text-primary"">Prize Pool Distribution</h6>
                  <div class=""dropdown no-arrow"">
                    <a class=""dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                      <i class=""fas fa-ellipsis-v fa-sm fa-fw text-gray-400""></i>
      ");
            WriteLiteral(@"              </a>
                    <div class=""dropdown-menu dropdown-menu-right shadow animated--fade-in"" aria-labelledby=""dropdownMenuLink"">
                      <div class=""dropdown-header"">Dropdown Header:</div>
                      <a class=""dropdown-item"" href=""#"">Action</a>
                      <a class=""dropdown-item"" href=""#"">Another action</a>
                      <div class=""dropdown-divider""></div>
                      <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                  </div>
                </div>
                <!-- Card Body -->
                <div class=""card-body"">
                  <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""TI9PieChart""></canvas>
                  </div>
                  <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">

                    </span>
                    <span class=""mr-2"">

                    </span>
                  </div>");
            WriteLiteral(@"
                </div>
              </div>
            </div>
          </div>

          <!-- Content Row -->
          <div class=""row"">

            <!-- Content Column -->
            <div class=""col-lg-6 mb-4"">

              <!-- Project Card Example -->
              <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                  <h6 class=""m-0 font-weight-bold text-primary"">Prize Pool Progress</h6>
                </div>
                <div class=""card-body"">
                  <h4 class=""small font-weight-bold"">131.4% funded versus The International 2018: $25,532,177 <span class=""float-right""></span></h4>
                  <div class=""progress mb-4"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
                  </div>
                  <h4 class=""small font-weight-bold"">135.4% funded v");
            WriteLiteral(@"ersus The International 2017: $24,787,916 <span class=""float-right""></span></h4>
                  <div class=""progress mb-4"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated bg-info"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
                  </div>
                  <h4 class=""small font-weight-bold"">161.5% funded versus The International 2016: $20,770,460 <span class=""float-right""></span></h4>
                  <div class=""progress mb-4"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
                  </div>
                  <h4 class=""small font-weight-bold"">182.4% funded versus The International 2015: $18,429,613 <span class=""float-right""></span></h4>
                  <div class=""progress mb-4"">
                    <div class=""pro");
            WriteLiteral(@"gress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
                  </div>
                  <h4 class=""small font-weight-bold"">307% funded versus The International 2014: $10,931,105<span class=""float-right""></span></h4>
                  <div class=""progress"">
                    <div class=""progress-bar progress-bar-striped progress-bar-animated progress-purple"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"">100%</div>
                  </div>
                </div>
              </div>

              <!-- Color System -->


            </div>

            <div class=""col-lg-6 mb-4"">

              <!-- Bar Chart -->
              <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                  <h6 class=""m-0 font-weight-bold text-primary"">Total Prize Pool Comparison For Each Internationa");
            WriteLiteral(@"l</h6>
                </div>
                <div class=""card-body"">
                  <div class=""chart-bar"">
                    <canvas id=""myBarChart""></canvas>
                  </div>


                </div>
              </div>

            </div>

              <!-- Approach -->
              <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                  <h6 class=""m-0 font-weight-bold text-primary"">Development Approach</h6>
                </div>
                <div class=""card-body"">
                  <p>Dota 2 Prize Tracker was developed with the intention of being a personal web application used to track new and old Dota 2 tournaments.</p>
                  <p class=""mb-0"">Furthermore, this application was developed in order to provide up-to-date information related to The International (TI for short) -- the largest esports tournament in the world.</p>
                </div>
              </div>

            </div>
          </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
