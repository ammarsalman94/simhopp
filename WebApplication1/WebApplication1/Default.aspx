<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Simhopp</h1>
        <p class="lead">Diving Competition</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">New Competition&raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">View Competitions&raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Help&raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
           
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Judge&raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
