<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Get.aspx.cs" Inherits="Api_Student.Get" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
                .myTable{
             
            width: 125%;
            border: 2px solid black;
            border-collapse: collapse;
            margin-top: 50px;

        }

        .myTable td,
        .myTable th{
            border: 2px solid black;
          
            text-align: center;
            padding-top: 12px;
             padding-right: 15px;

             
        }

        .myTable th{
            background-color:darkcyan;
            color:#ffffff;
        }
        .myTable tbody tr:nth-child(even){
            background-color:#f5f5f5;
        }
 
        @media(max-width: 500px){
            .myTable thead{
                display:none;
            }
            .myTable , .myTable tbody , .myTable tr, .myTable td{
                display:block;
                width:100%;
            }

        }
        .button{
            text-align:center;
             margin-right:auto;
             margin-left:auto;
             
             position:absolute;
                top: 50%;
                left: 50%;


              

        }
        .button:hover {
  background: #ff9800;
  color: white;
}

/*                .button{
          
             position: absolute;
  top: -2147483648px;
  left: 49%;
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
            height: 55px;
            width: 91px;
        } */

 
 
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 67px; width: 1101px">
             <asp:Label ID="tb" runat="server" Text=""></asp:Label>
             <br />
&nbsp;<br />
                 

            
              
            <asp:Button ID="Button1" runat="server" Text="Get Data" onClick="display" Class="button"/>
              

        </div>
    </form>
</body>
</html>
