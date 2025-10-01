<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/Master.master"
    AutoEventWireup="true" CodeBehind="Paso3.aspx.cs" Inherits="TPPromoWeb_equipo_12A.Paso3" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Estilos/Paso3.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-sm mx-auto">
    <h2>Ingresá tus datos</h2>

    <div class="mb-3">
        <label for="dni" class="form-label">DNI</label>
        <asp:TextBox ID="dni" runat="server" CssClass="form-control" />
    </div>

    <div class="row">
        <div class="col-md-6 mb-3">
            <label for="nombre" class="form-label">Nombre</label>
            <asp:TextBox ID="nombre" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-6 mb-3">
            <label for="apellido" class="form-label">Apellido</label>
            <asp:TextBox ID="apellido" runat="server" CssClass="form-control" />
        </div>
    </div>

    <div class="mb-3">
        <label for="email" class="form-label">Email</label>
        <asp:TextBox ID="email" runat="server" CssClass="form-control" />
    </div>

    <div class="row">
        <div class="col-md-6 mb-3">
            <label for="direccion" class="form-label">Dirección</label>
            <asp:TextBox ID="direccion" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-4 mb-3">
            <label for="ciudad" class="form-label">Ciudad</label>
            <asp:TextBox ID="ciudad" runat="server" CssClass="form-control" />
        </div>
        <div class="col-md-2 mb-3">
            <label for="codigoPostal" class="form-label">CP</label>
            <asp:TextBox ID="codigoPostal" runat="server" CssClass="form-control" />
        </div>
    </div>

    <div class="form-check mb-3">
        <asp:CheckBox ID="aceptaTerminos" runat="server" CssClass="form-check-input" />
        <label class="form-check-label" for="aceptaTerminos">Acepto los términos y condiciones.</label>
    </div>

    <asp:Button ID="participar" runat="server" Text="¡Participar!" CssClass="btn btn-primary w-100"
        OnClick="ParticiparClick" />
    </div>
</asp:Content>