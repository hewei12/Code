<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="PayForWeiXin.Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script type="text/javascript" src="../js/jquery-1.8.2.min.js"></script>
    <script type="text/javascript">
        $(function () {
            test();
        });

        function test() {
            alert(1);
            $.ajax({
                type: "post", //URL方式为POST 
                url: "PayForWeiXin.ashx", //这里是指向兑奖验证的页面 
                data: 'openId=oFIYdszuDXVqVCtwZ-yIcbIS262k&amount=100', //把要验证的参数传过去 
                dataType: 'json', //数据类型为JSON格式的验证 
                success: function (data) {
                    alert(data);
                },
                error: function () {
                    return false;
                }
            });
        }


    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
