<%@ Page Title="Home" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPPromoWeb_equipo_12A.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2 class="mb-4">Bienvenido a la promo web</h2>
        <asp:Button ID="Comenzar" runat="server" Text="¡Participar!" CssClass="btn btn-primary w-100" OnClick="Start" />
    </div>
</asp:Content>
