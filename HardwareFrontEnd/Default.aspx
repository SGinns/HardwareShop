<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>

    </style>
    <title>Test</title>
    <!-- Bootstrap Import -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body style="height: 621px">
<body>
    <!-- Jquery Import -->
    <script src="https://code.jquery.com/jquery-3.4.1.js" integrity="sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=" crossorigin="anonymous"></script>
    
    <script>
        $('document').ready(function () {
            $(".button").click(function () {
                $(".Anima").toggle(500);
            });
        });
    </script>


    <br />

    <div class="Anima">
    <h1 class="col-md-12 text-center" style="font-size:12rem;">Hello, World!</h1>
        </div>
        <button class="button col-6 offset-md-3 btn btn-success" style="font-size:3rem;">Yayy</button>
</body>
</html>
