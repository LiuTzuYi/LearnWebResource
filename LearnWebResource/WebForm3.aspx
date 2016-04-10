<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="LearnWebResource.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="<%=Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm3),"LearnWebResource.Resource.js11.js") %>"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <img alt ="" src="<%= Page.ClientScript.GetWebResourceUrl(typeof(LearnWebResource.WebForm3),"LearnWebResource.Resource.medical.png") %>" />
       
    </div>
    </form>
</body>
</html>
