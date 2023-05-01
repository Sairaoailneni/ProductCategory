<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ProductCategory.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">   
                    <div class="col-sm-2"></div>
                    <div class="col-sm-8">
                        <h1>Product Details</h1>
                    </div>
                    <div class="col-sm-2">
                    </div>
                </div>
            </div>

            <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                    <asp:label ID="lblProductId" runat="server" Text="ProductId"></asp:label>
                    <asp:TextBox ID="txtProductId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
                 <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                       <asp:label ID="lblProduct" runat="server" Text="ProductName"></asp:label>
                    <asp:TextBox ID="txtProduct" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
            <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                     <asp:label ID="lblcategory" runat="server" Text="ProductCategory"></asp:label>
                    <asp:DropDownList ID="ddlCategory" AutoPostBack="true" runat="server" CssClass="form-control">
                     <asp:ListItem Value="">--Select--</asp:ListItem>
                        <asp:ListItem Value="Food">Food</asp:ListItem>
                        <asp:ListItem Value="Drinks">Drinks</asp:ListItem>
                    </asp:DropDownList> 
                    </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
                 <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                   <asp:label ID="lblprice" runat="server" Text="Price"></asp:label>
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox> 
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
                <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                   <asp:label ID="lbltax" runat="server" Text="Tax"></asp:label>
                    <asp:TextBox ID="txtTax" runat="server" CssClass="form-control"></asp:TextBox> 
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
                <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                   <asp:label ID="lbltaxtype" runat="server" Text="Tax Type"></asp:label>
                    <asp:RadioButton ID="txtInclusive" Text="Inclusive" runat="server" name="a"/>
                     <asp:RadioButton ID="txtExclusive" Text="Exclusive"  runat="server" name="a"/> 
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
                <div class="container">
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-8">
                   <asp:label ID="lblisActive" runat="server" Text="IsActive"></asp:label>
                    <asp:CheckBox ID="chkIsActive" runat="server" ></asp:CheckBox> 
                </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>
       
                    <div class="container">

            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-4">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="form-control" Text="Submit" BackColor="Black" BorderColor="Black" OnClick="btnSubmit_Click"></asp:Button>
                   </div>
                 <div class="col-sm-4">
                      <asp:Button ID="btnclear" runat="server" CssClass="form-control" Text="Clear"></asp:Button>
                                   </div>
                <div class="col-sm-2"></div>
                </div>
                 </div>  

            <div>
                <asp:label ID="lblOutput" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="X-Large"></asp:label>
            </div>
            <div class="row"> 
                <div class="col-sm-2"></div>
                <div class="col-sm-8">
                     <asp:GridView ID="gvProductDetails" runat="server" ></asp:GridView>
                </div>
                <div class="col-sm-2"></div>
               
            </div>
    </form>
</body>
</html>
