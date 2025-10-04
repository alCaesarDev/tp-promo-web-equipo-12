<%@ Page Title="Formulario" Language="C#" MasterPageFile="~/Master.master"
    AutoEventWireup="true" CodeBehind="Paso1.aspx.cs" Inherits="TPPromoWeb_equipo_12A.Paso1" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="Estilos/Paso1.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container text-center">
        <h2 class="mb-4">Ingresa el código de tu voucher</h2>
        <div class="row">
            <asp:TextBox ID="txtVoucher" runat="server" class="mb-4" ></asp:TextBox>
            <asp:Label ID="lblVoucherMessage" runat="server" ForeColor="Red"  ></asp:Label>
        </div>
        <div>
            <asp:Button class="btn btn-primary mt-4" ID="btn_voucher" OnClick="btn_voucher_Click" runat="server" Text="Siguiente" />
        </div>


    </div>

    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function () {
            const voucherInput = document.getElementById('<%= txtVoucher.ClientID %>');
            const messageLabel = document.getElementById('<%= lblVoucherMessage.ClientID %>');
            let validVoucher = ''; 

            voucherInput.addEventListener('blur', function () {
                const voucherCode = voucherInput.value.trim();

                if (voucherCode === '') {
                    messageLabel.innerText = ''; 
                    validVoucher = ''; 
                    return;
                }

                const url = `/VoucherValidator.ashx?numero=${encodeURIComponent(voucherCode)}`;

                fetch(url)
                    .then(response => {
                        if (!response.ok) {
                            throw new Error('Error en la respuesta del servidor.');
                        }
                        return response.json();
                    })
                    .then(data => {
                        if (data.success) {
                            messageLabel.innerText = ''; 
                            validVoucher = voucherCode; 
                            console.log('Voucher válido:', validVoucher);
                            
                        } else {
                            messageLabel.style.color = 'red';
                            messageLabel.innerText = data.message; 
                            validVoucher = ''; 
                        }
                    })
                    .catch(error => {
                        console.error('Error en la petición fetch:', error);
                        messageLabel.style.color = 'red';
                        messageLabel.innerText = 'Error al contactar el servidor de validación.';
                        validVoucher = ''; 
                    });
            });
        });
    </script>

</asp:Content>
