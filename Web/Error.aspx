<%@ Page Title="" Language="C#" MasterPageFile="~/Master.master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPPromoWeb_equipo_12A.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

      <div class="container mt-5">
        <div class="alert alert-danger" role="alert">
            <h4 class="alert-heading">¡Ha ocurrido un error!</h4>
            <p>Lo sentimos, algo salió mal. Por favor, inténtalo de nuevo más tarde.</p>
            <hr>
            <p class="mb-0">Si el problema persiste, contacta al administrador.</p>
        </div>
        <hr />
        <h4>Detalles del Error:</h4>
        <pre>
            <asp:Literal ID="ltlError" runat="server"></asp:Literal>
        </pre>
    </div>


</asp:Content>
