<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <script
  src="https://code.jquery.com/jquery-3.3.1.min.js"></script>

    <script>     

        listarAnimes();

        function listarAnimes() {
            
            $.ajax({
                "url": "Default.aspx/Listar",
                dataType: 'json',
                type: 'POST',
                contentType: 'application/json',
            }).done(function (data) {
                console.log(data);
            });
        };

        

    </script>
</body>
</html>
