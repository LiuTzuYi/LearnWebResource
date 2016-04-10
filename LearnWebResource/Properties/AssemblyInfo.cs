using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web.UI;

// 有关程序集的常规信息通过下列特性集
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("LearnWebResource")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("LearnWebResource")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 会使此程序集中的类型
// 对 COM 组件不可见。如果需要
// 从 COM 访问此程序集中的某个类型，请针对该类型将 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于 typelib 的 ID
[assembly: Guid("9518a7c8-3d81-4a2a-bdc8-4cd5e13eb54a")]

// 程序集的版本信息由下列四个值组成:
//
//      主版本
//      次版本
//      内部版本号
//      修订版本
//
// 可以指定所有值，也可以使用“修订号”和“内部版本号”的默认值，
// 方法是按如下所示使用 "*":
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: WebResource("LearnWebResource.Resource.Y37.jpg","image/jpeg")]
[assembly: WebResource("LearnWebResource.Resource.giraffe.gif","image/gif")]
[assembly:WebResource("LearnWebResource.Resource.medical.png","image/png")]
[assembly:WebResource("LearnWebResource.Resource.fyle.ico","image/ico")]
[assembly:WebResource("LearnWebResource.Resource.05_ok.bmp","image/bmp")]

[assembly:WebResource("LearnWebResource.Resource.js10.js","text/javascript",PerformSubstitution =true)]
[assembly:WebResource("LearnWebResource.Resource.js11.js","text/javascript", PerformSubstitution = false)]

[assembly:WebResource("LearnWebResource.Resource.HtmlPage1.html","text/html")]
[assembly:WebResource("LearnWebResource.Resource.StyleSheet1.css","text/css")]
[assembly:WebResource("LearnWebResource.Resource.WebForm2.aspx","text/aspx")]




