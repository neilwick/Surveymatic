#pragma checksum "C:\Y23\app\Surveymatic\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996876d64874b506fce9f05e5244726586c446fa"
// <auto-generated/>
#pragma warning disable 1591
namespace Surveymatic.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Y23\app\Surveymatic\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Y23\app\Surveymatic\_Imports.razor"
using Surveymatic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Y23\app\Surveymatic\_Imports.razor"
using Surveymatic.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav><ul id=\"wb-tphp\"><li class=\"wb-slc\"><a class=\"wb-sl\" href=\"#wb-cont\">Skip to main content</a></li>\r\n\t\t\t<li class=\"wb-slc visible-sm visible-md visible-lg\"><a class=\"wb-sl\" href=\"#wb-info\">Skip to \"About this site\"</a></li></ul></nav>\r\n\t");
            __builder.AddMarkupContent(1, "<header role=\"banner\"><div id=\"wb-bnr\"><div id=\"wb-bar\"><div class=\"container\"><div class=\"row\"><section id=\"wb-lng\" class=\"visible-md visible-lg\"><h2>Language selection</h2>\r\n\t\t\t\t\t\t\t<ul class=\"text-right\"><li><a lang=\"fr\" hreflang=\"fr\" href=\"index-fr.html\">Français</a></li>\r\n\t\t\t\t\t\t\t\t<li class=\"curr\">English&#32;<span>(current)</span></li></ul></section>\r\n\t\t\t\t\t\t<section class=\"wb-mb-links col-xs-12 visible-sm visible-xs\" id=\"wb-glb-mn\"><h2>Search and menus</h2>\r\n\t\t\t\t\t\t\t<ul class=\"pnl-btn list-inline text-right\"><li><a href=\"#mb-pnl\" title=\"Search and menus\" aria-controls=\"mb-pnl\" class=\"overlay-lnk btn btn-sm btn-default\" role=\"button\"><span class=\"glyphicon glyphicon-search\"><span class=\"glyphicon glyphicon-th-list\"><span class=\"wb-inv\">Search and\r\n\t\t\t\t\t\t\t\t\t\t\t\t\tmenus</span></span></span></a></li></ul>\r\n\t\t\t\t\t\t\t<div id=\"mb-pnl\"></div></section></div></div></div>\r\n\t\t\t<div class=\"container\"><div class=\"row\"><div id=\"wb-sttl\" class=\"col-md-8\"><a href=\"./index-en.html\"><img src=\"./theme-wet-boew/assets/logo.svg\" alt>\r\n\t\t\t\t\t\t\t<span>Web Experience Toolkit<span class=\"wb-inv\">, </span><small>Collaborative open source\r\n\t\t\t\t\t\t\t\t\tproject led by the Government of Canada</small></span></a></div>\r\n\t\t\t\t\t<section id=\"wb-srch\" class=\"col-md-4 visible-md visible-lg\"><h2>Search</h2>\r\n\t\t\t\t\t\t<form action=\"https://google.ca/search\" method=\"get\" role=\"search\" class=\"form-inline\"><div class=\"form-group\"><label for=\"wb-srch-q\">Search website</label>\r\n\t\t\t\t\t\t\t\t<input id=\"wb-srch-q\" class=\"form-control\" name=\"q\" type=\"search\" value size=\"27\" maxlength=\"150\">\r\n\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"q\" value=\"site:wet-boew.github.io OR site:github.com/wet-boew/\"></div>\r\n\t\t\t\t\t\t\t<button type=\"submit\" id=\"wb-srch-sub\" class=\"btn btn-default\">Search</button></form></section></div></div></div>\r\n\t\t<nav role=\"navigation\" id=\"wb-sm\" data-ajax-replace=\"./ajax/sitemenu-en.html\" data-trgt=\"mb-pnl\" class=\"wb-menu visible-md visible-lg\" typeof=\"SiteNavigationElement\"><div class=\"container nvbar\"><h2>Topics menu</h2>\r\n\t\t\t\t<div class=\"row\"><ul class=\"list-inline menu\"><li><a href=\"./index-en.html\">WET project</a></li>\r\n\t\t\t\t\t\t<li><a href=\"./docs/start-en.html#implement\">Implement WET</a></li>\r\n\t\t\t\t\t\t<li><a href=\"./docs/start-en.html\">Contribute to WET</a></li></ul></div></div></nav></header>\r\n\t");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "role", "main");
            __builder.AddAttribute(4, "property", "mainContentOfPage");
            __builder.AddAttribute(5, "resource", "#wb-main");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<h1 id=\"wb-cont\" property=\"name\">Web Experience Toolkit (WET)</h1>\r\n\t\t");
            __builder.OpenElement(8, "section");
            __builder.AddMarkupContent(9, "<h2 id=\"about\">What is the Web Experience Toolkit?</h2>\r\n            ");
            __builder.OpenComponent<Surveymatic.Shared.ShowYouTube>(10);
            __builder.AddAttribute(11, "Url", "https://www.youtube.com/watch?v=9znKJqnFuuY");
            __builder.AddAttribute(12, "Title", "CoolVideo");
            __builder.AddAttribute(13, "Caption", "This video has been embedded as a Blazor component");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\t\t\t");
            __builder.AddMarkupContent(15, @"<ul><li>An <a href=""docs/ref/accolades-en.html#awards"">award-winning</a> front-end framework for building
					websites that are <a href=""#accessibility"">accessible</a>, <a href=""#usability"">usable</a>, <a href=""#interoperability"">interoperable</a>, <a href=""#mobile-friendly-responsive-design"">mobile
						friendly</a> and <a href=""#multilingual"">multilingual</a></li>
				<li>A collection of <a href=""#themeable-and-reusable"">flexible and themeable templates and reusable
						components</a></li>
				<li>A <a href=""#collaborative-approach"">collaborative open source project led by the Government of
						Canada</a></li></ul>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\t\t");
            __builder.AddMarkupContent(17, "<section><h2 id=\"key\">Resources</h2>\r\n\t\t\t<div class=\"row wb-eqht\"><div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"demos/index-en.html\">Examples</a></h3>\r\n\t\t\t\t\t<p>Working examples of all WET plugin, including developer tools</p></div>\r\n\t\t\t\t<div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"docs/index-en.html\">Documentation</a></h3>\r\n\t\t\t\t\t<p>Technical documentation and plugins configuration specification.</p></div>\r\n\t\t\t\t<div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"docs/versions/dwnld-en.html\">Downloads</a></h3>\r\n\t\t\t\t\t<p>Binaries and release notes of WET-BOEW and Canada.ca theme</p></div>\r\n\t\t\t\t<div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"https://wet-boew.github.io/themes-dist/GCWeb/index-en.html\">Canada.ca theme\r\n\t\t\t\t\t\t\t(GCWeb)</a></h3>\r\n\t\t\t\t\t<p>Technical resources and reference implementation of the Canada.ca content and IA specification\r\n\t\t\t\t\t</p></div>\r\n\t\t\t\t<div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"https://github.com/wet-boew/\">WET-BOEW project on github</a></h3>\r\n\t\t\t\t\t<p>Source code and issue tracker for all wet-boew projects and specials projects dashboard</p></div>\r\n\t\t\t\t<div class=\"col-lg-4 col-md-6\"><h3 class=\"h5\"><a href=\"https://wet-boew.github.io/wet-boew-styleguide/index-en.html\">Style\r\n\t\t\t\t\t\t\tguide</a></h3>\r\n\t\t\t\t\t<p>Style, Writing, Design, and Accessibility Guide for Web Experience Toolkit (WET)</p></div></div>\r\n\t\t\t<div class=\"row\"><div class=\"col-md-6\"><h3>Design decision</h3>\r\n\t\t\t\t\t<p><em>(last updated: <time datetime=\"2020-09-11\">September 11, 2020</time>)</em></p>\r\n\t\t\t\t\t<ul><li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/1.html\">DD-1: Use SVG\r\n\t\t\t\t\t\t\t\twith img element instead of object</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/2.html\">DD-2: Browser\r\n\t\t\t\t\t\t\t\tsupported</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/3.html\">DD-3: WET\r\n\t\t\t\t\t\t\t\tAPI/Blueprint</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/4.html\">DD-4: Basic HTML\r\n\t\t\t\t\t\t\t\tmode and progressive enhancement</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/5.html\">DD-5: Repository\r\n\t\t\t\t\t\t\t\tmigration</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/6.html\">DD-6:\r\n\t\t\t\t\t\t\t\tVersioning</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/8.html\">DD-8: Dual\r\n\t\t\t\t\t\t\t\timplementation of structured data with JSON-LD and RDFa Lite in a single web page</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/9.html\">DD-9: Release\r\n\t\t\t\t\t\t\t\tearly, release often (<abbr title=\"Short-term release\">STR</abbr>)</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/10.html\">DD-10:\r\n\t\t\t\t\t\t\t\tProvisional feature</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/11.html\">DD-11: Resize\r\n\t\t\t\t\t\t\t\ttext testing methodology</a> (Approved)</li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/12.html\">DD-12: Double\r\n\t\t\t\t\t\t\t\tH1 on a single page</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/13.html\">DD-13: Reduce\r\n\t\t\t\t\t\t\t\taggressiveness of form validation plugin</a> (Approved)</li></ul>\r\n\t\t\t\t\t<p><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/index-en.html\">Consult all\r\n\t\t\t\t\t\t\tDesign decision</a></p></div>\r\n\t\t\t\t<div class=\"col-md-6\"><h3>Projects in the WET-BOEW family</h3>\r\n\t\t\t\t\t<ul><li><a href=\"https://github.com/wet-boew/wet-boew-dotnet-controls\">Web Control Library .NET</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://github.com/wet-boew/wet-boew-drupal\">Drupal WxT variant</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://cenw-wscoe.github.io/sgdc-cdts/docs/index-en.html\">CDTS - Centralized\r\n\t\t\t\t\t\t\t\ttemplate services</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://github.com/orgs/wet-boew/projects/1\">WCAG 2.1 Level AA review</a></li></ul>\r\n\t\t\t\t\t<p><small>(<a href=\"https://wet-boew.github.io/wet-boew-documentation/projects-en.html\">All\r\n\t\t\t\t\t\t\t\tprojects</a>)</small></p>\r\n\t\t\t\t\t<h3>Resources about the WET-BOEW project management</h3>\r\n\t\t\t\t\t<ul><li><a href=\"https://wet-boew.github.io/wet-boew-documentation/research-en.html\">Research and\r\n\t\t\t\t\t\t\t\tfindings</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/decision/index-en.html\">Design\r\n\t\t\t\t\t\t\t\tdecision</a></li>\r\n\t\t\t\t\t\t<li><a href=\"https://wet-boew.github.io/wet-boew-documentation/index-en.html\">Project\r\n\t\t\t\t\t\t\t\tdocumentations and design decision</a></li>\r\n\t\t\t\t\t\t<li><a href=\"docs/start-en.html#develop\">Contributing guidelines</a></li>\r\n\t\t\t\t\t\t<li><a href=\"License-en.html\">Terms and conditions</a> (MIT license)</li></ul></div></div></section>\r\n\t\t");
            __builder.AddMarkupContent(18, "<section><h2 id=\"benefits\">Benefits</h2>\r\n\t\t\t<section><h3 id=\"accessibility\">Accessibility</h3>\r\n\t\t\t\t<ul><li>Conforms to <a href=\"https://www.w3.org/TR/WCAG20/\">WCAG 2.0</a> level AA</li>\r\n\t\t\t\t\t<li>Leverages <a href=\"https://www.w3.org/TR/wai-aria/\">WAI-ARIA</a> to further enhance\r\n\t\t\t\t\t\taccessibility</li>\r\n\t\t\t\t\t<li>Assistive technology testing (Access Working Group)</li></ul></section>\r\n\t\t\t<section><h3 id=\"usability\">Usability</h3>\r\n\t\t\t\t<ul><li>Iterative approach to design</li>\r\n\t\t\t\t\t<li>Design patterns and usability testing (User Experience Working Group)</li></ul></section>\r\n\t\t\t<section><h3 id=\"interoperability\">Interoperability</h3>\r\n\t\t\t\t<ul><li><a href=\"https://www.w3.org/TR/html5/\">HTML5</a>-first approach (leveraging native HTML5 support\r\n\t\t\t\t\t\tand filling support gaps with “polyfills”)</li>\r\n\t\t\t\t\t<li>Supporting a wide variety of browsers (IE, Firefox, Chrome, Safari, Opera)</li>\r\n\t\t\t\t\t<li>Building support for HTML data (<a href=\"https://www.w3.org/TR/rdfa-lite/\">RDFa 1.1 Lite</a>, <a href=\"https://www.schema.org/\">Schema.org</a>)</li></ul></section>\r\n\t\t\t<section><h3 id=\"mobile-friendly-responsive-design\">Mobile friendly responsive design</h3>\r\n\t\t\t\t<ul><li>Adapts to different screen sizes and device capabilities</li>\r\n\t\t\t\t\t<li>Touchscreen support</li>\r\n\t\t\t\t\t<li>Optimized for performance</li>\r\n\t\t\t\t\t<li>Building support for device-based mobile applications</li></ul></section>\r\n\t\t\t<section><h3 id=\"multilingual\">Multilingual</h3>\r\n\t\t\t\t<ul><li>Currently supports 34 languages (including right-to-left languages)\r\n\t\t\t\t\t\t<ul><li>English</li>\r\n\t\t\t\t\t\t\t<li>French</li>\r\n\t\t\t\t\t\t\t<li>Afrikaans</li>\r\n\t\t\t\t\t\t\t<li>Albanian</li>\r\n\t\t\t\t\t\t\t<li>Arabic</li>\r\n\t\t\t\t\t\t\t<li>Armenian</li>\r\n\t\t\t\t\t\t\t<li>Bulgarian</li>\r\n\t\t\t\t\t\t\t<li>Chinese</li>\r\n\t\t\t\t\t\t\t<li>Chinese (Simplified)</li>\r\n\t\t\t\t\t\t\t<li>Czech</li>\r\n\t\t\t\t\t\t\t<li>Dutch</li>\r\n\t\t\t\t\t\t\t<li>Estonian</li>\r\n\t\t\t\t\t\t\t<li>German</li>\r\n\t\t\t\t\t\t\t<li>Greek</li>\r\n\t\t\t\t\t\t\t<li>Hindi</li>\r\n\t\t\t\t\t\t\t<li>Hungarian</li>\r\n\t\t\t\t\t\t\t<li>Icelandic</li>\r\n\t\t\t\t\t\t\t<li>Indonesian</li>\r\n\t\t\t\t\t\t\t<li>Inuktitut</li>\r\n\t\t\t\t\t\t\t<li>Italian</li>\r\n\t\t\t\t\t\t\t<li>Japanese</li>\r\n\t\t\t\t\t\t\t<li>Korean</li>\r\n\t\t\t\t\t\t\t<li>Latvian</li>\r\n\t\t\t\t\t\t\t<li>Lithuanian</li>\r\n\t\t\t\t\t\t\t<li>Polish</li>\r\n\t\t\t\t\t\t\t<li>Portuguese</li>\r\n\t\t\t\t\t\t\t<li>Portuguese (Brazilian)</li>\r\n\t\t\t\t\t\t\t<li>Russian</li>\r\n\t\t\t\t\t\t\t<li>Slovak</li>\r\n\t\t\t\t\t\t\t<li>Spanish</li>\r\n\t\t\t\t\t\t\t<li>Thai</li>\r\n\t\t\t\t\t\t\t<li>Turkish</li>\r\n\t\t\t\t\t\t\t<li>Ukranian</li>\r\n\t\t\t\t\t\t\t<li>Vietnamese</li></ul></li></ul></section>\r\n\t\t\t<section><h3 id=\"themeable-and-reusable\">Themeable and reusable</h3>\r\n\t\t\t\t<ul><li>Flexible framework that supports custom themes</li>\r\n\t\t\t\t\t<li>Includes support for <a href=\"docs/ref/themesstyle-en.html\">5 different themes</a> including a\r\n\t\t\t\t\t\t<a href=\"https://wet-boew.github.io/themes-dist/theme-base/docs/ref/theme-base/theme-base-en.html\">“Base”\r\n\t\t\t\t\t\t\ttheme</a> to use as a template\r\n\t\t\t\t\t</li>\r\n\t\t\t\t\t<li>Reusable templates, <a href=\"docs/ref/plugins-en.html\">plugins</a> and widgets</li>\r\n\t\t\t\t\t<li><a href=\"docs/ref/variants-en.html\">Adapted to various CMS and programming frameworks</a>\r\n\t\t\t\t\t\t(Drupal, WordPress, SharePoint (in development), DotNetNuke (in development), PHP, SSI and\r\n\t\t\t\t\t\tJava/Maven)\r\n\t\t\t\t\t</li></ul></section>\r\n\t\t\t<section><h3>Reduces costs by openly sharing and collaborating</h3>\r\n\t\t\t\t<ul><li>Drives down research and development costs</li>\r\n\t\t\t\t\t<li>Avoids duplication of effort</li>\r\n\t\t\t\t\t<li>Produces better quality results</li></ul></section>\r\n\t\t\t<section><h3 id=\"collaborative-approach\">Collaborative approach</h3>\r\n\t\t\t\t<ul><li>Project managed openly on GitHub, including discussion through the issues tracker</li>\r\n\t\t\t\t\t<li>Encouraging a free flow of ideas, dialogue and innovation including sharing of challenges and\r\n\t\t\t\t\t\tideas</li>\r\n\t\t\t\t\t<li>External contributions welcome\r\n\t\t\t\t\t\t<ul><li>Pull requests</li>\r\n\t\t\t\t\t\t\t<li>Design patterns</li>\r\n\t\t\t\t\t\t\t<li>Issues and suggestions</li>\r\n\t\t\t\t\t\t\t<li>Documentation</li>\r\n\t\t\t\t\t\t\t<li>Testing</li></ul></li>\r\n\t\t\t\t\t<li>Multi-level review process for contributions to ensure code integrity (combination of automated\r\n\t\t\t\t\t\tand manual reviews)</li></ul></section></section>\r\n\t\t");
            __builder.AddMarkupContent(19, "<dl id=\"wb-dtmd\"><dt>Date modified:&#32;</dt>\r\n\t\t\t<dd><time property=\"dateModified\">2020-12-07</time></dd></dl>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\t");
            __builder.AddMarkupContent(21, @"<footer role=""contentinfo"" id=""wb-info"" class=""visible-sm visible-md visible-lg wb-navcurr""><div class=""container""><nav role=""navigation"" class=""row""><h2>About this site</h2>
				<section class=""col-sm-3""><h3>Contact us</h3>
					<ul class=""list-unstyled""><li><a href=""https://github.com/wet-boew/wet-boew/issues/new"">Questions or comments?</a></li></ul></section>
				<section class=""col-sm-3""><h3>About</h3>
					<ul class=""list-unstyled""><li><a href=""./index-en.html#about"">About the Web Experience Toolkit</a></li>
						<li><a rel=""external"" href=""https://www.tbs-sct.gc.ca/ws-nw/index-eng.asp"">About the Web
								Standards</a></li></ul></section>
				<section class=""col-sm-3""><h3>News</h3>
					<ul class=""list-unstyled""><li><a href=""https://github.com/wet-boew/wet-boew/pulse"">Recent project activity</a></li>
						<li><a href=""https://github.com/wet-boew/wet-boew/graphs"">Project statistics</a></li></ul></section>
				<section class=""col-sm-3""><h3>Stay connected</h3>
					<ul class=""list-unstyled""><li><a rel=""external"" href=""https://twitter.com/WebExpToolkit"">Twitter</a></li></ul></section></nav></div></footer>

");
            __builder.OpenElement(22, "Counter");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
