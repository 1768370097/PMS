﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teaCenter.aspx.cs" Inherits="PMS.Web.admin.teaCenter" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>个人中心</title>
        <link rel="stylesheet" href="../css/bootstrap.min.css" />
        <link rel="stylesheet" href="../css/zwh.css" />
    </head>

    <body>
        <form id="form1">
            <div class="box">
                <div class="center col-xs-8 col-xm-5 col-md-6 col-lg-4 col-xs-push-2 col-sm-push-2 col-md-push-3 col-lg-push-4">
                    <table class="table table-hover">
                        <tbody>
                            <tr>
                                <td class="centerLable">账号：</td>
                                <td></td>
                                <td id="ID">166122001</td>
                            </tr>
                            <tr>
                                <td class="centerLable">姓名：</td>
                                <td></td>
                                <td id="userName">刘备</td>
                            </tr>
                            <tr>
                                <td class="centerLable">性别：</td>
                                <td></td>
                                <td id="gender">男</td>
                            </tr>
                            <tr>
                                <td class="centerLable">职称：</td>
                                <td></td>
                                <td id="ProfTitles">教授</td>
                            </tr>
                            <tr>
                                <td class="centerLable">学院：</td>
                                <td></td>
                                <td id="college">信息工程学院</td>
                            </tr>
                            <tr>
                                <td class="centerLable">联系电话：</td>
                                <td></td>
                                <td id="telNum">8008208820</td>
                            </tr>
                            <tr>
                                <td class="centerLable">电子邮箱：</td>
                                <td></td>
                                <td id="email">123456789@qq.com</td>
                            </tr>
                            <tr>
                                <td class="centerLable">
                                    <button type="button" class="btn btn-info" id="editMessage" onclick="edit()">编辑信息</button>
                                    <button type="button" class="btn btn-info" id="okMessage" onclick="ok()">确定</button>
                                </td>
                                <td></td>
                                <td id="email">
                                    <a href="#"><button type="button" class="btn btn-info">修改密码</button></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </form>
    </body>
    <script src="../js/jquery-3.3.1.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
    <script src="../js/zwh.js"></script>

    </html>