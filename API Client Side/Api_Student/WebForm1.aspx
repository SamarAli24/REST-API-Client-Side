<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Api_Student.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
 
                form{
            padding:14px 18px;
            border:5px solid black;
            display:inline-block;
            text-align:center;
        }
        body {
            text-align: center;
            background-color: #ECF0F1
        }
                h1{
            text-align:center;
            color:black;
        }





 
    </style>
</head>
<body>
    <h1>API Methods</h1>
    <form id="form1" runat="server">
        <div>
       

            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <br />

           <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
        <br />
        <asp:TextBox ID="course" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Marks"></asp:Label>
        <br />
        <asp:TextBox ID="marks" runat="server" ></asp:TextBox>

          <br />
   
         
            
          <asp:Button ID="Button4" runat="server" Text="Put Data" OnClick="Put_btn" Width="88px" />

          <asp:Button ID="Button5" runat="server" Text="Delete Data " OnClick="Delete_btn" />

            <asp:Button ID="Button2" runat="server" Text="Post Data" class="button" OnClick="Post_btn"/>



                 
            <br />
            <br />
            <br />

                                    
                 

 
 
        </div>
    </form>
    </body>
</html>
