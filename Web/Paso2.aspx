<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/Master.master"
    AutoEventWireup="true" CodeBehind="Paso2.aspx.cs"
    Inherits="TPPromoWeb_equipo_12A.Paso2" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-4">
        <h1>Elige tu Premio!</h1>
        <hr />

        <div class="row">
            <asp:Repeater ID="rptArticulos" runat="server" OnItemCommand="rptArticulos_ItemCommand">
                <ItemTemplate>
                    <div class="col-md-4 mb-4">
                              <div class="card h-100 shadow-sm">
                                  <div class="d-flex flex-nowrap overflow-auto mb-3" style="max-height: 270px;">
                                      <asp:Repeater ID="rptImagenes" runat="server" DataSource='<%# Eval("Imagenes") %>'>
                                          <ItemTemplate>
                                              <div class="d-flex justify-content-center flex-shrink-0 me-2">
                                                  <img src="<%# Eval("ImagenUrl") %>"
                                                       class="img-fluid rounded"
                                                       alt="<%# Eval("ImagenUrl") %>"
                                                       style="height: 250px; width: 250px; object-fit: contain;" />
                                              </div>
                                          </ItemTemplate>
                                      </asp:Repeater>
                                  </div>

                              <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                <p class="card-text text-muted">
                                    <%#
    Eval("Marca.Descripcion") %>
                                </p>
                                  <div class="d-flex justify-content-center align-items-center mt-3">
                                      <asp:Button ID="btnElegir" runat="server" Text="Quiero Este!" CommandName="ElegirPremio"
                                          CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-success" />
                                  </div>


                            </div>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>


        <asp:Panel ID="pnlNoHayArticulos" runat="server" Visible="false" CssClass="alert
  alert-warning mt-4"
            role="alert">
            En este momento no hay premios para mostrar.
        </asp:Panel>

    </div>

</asp:Content>
