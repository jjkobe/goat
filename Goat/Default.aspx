w<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableEventValidation="false" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>Greatest of the Best</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width">

    <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.css" />
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/bootstrap-select.css">
</head>

<body ng-app="nodejsApp">
    <form runat="server"></form>
    <div class="container-fluid" style="background-color: #F0F0F0">
        <div class="row">
            <div class="col-md-1">
                <h2><font color="#FF606E">Goat</font></h2>
            </div>
            <div class="col-md-2" style="padding-left: 5; padding-right: 0">
                <h2>
                    <select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
                        <optgroup label="filter1">
                            <option>option1</option>
                            <option>option2</option>
                            <option>option3</option>
                            <option>option4</option>
                        </optgroup>
                        <optgroup label="filter2">
                            <option>option1</option>
                            <option>option2</option>
                            <option>option3</option>
                            <option>option4</option>
                        </optgroup>
                    </select></h2>
            </div>

            <div class="col-md-2" style="padding-left: 5; padding-right: 0">
                <h2>
                    <select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
                        <optgroup label="filter1">
                            <option>option1</option>
                            <option>option2</option>
                            <option>option3</option>
                            <option>option4</option>
                        </optgroup>
                    </select></h2>
            </div>

            <div class="col-md-2" style="padding-left: 5; padding-right: 0">
                <h2>
                    <select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
                        <optgroup label="filter1">
                            <option>option1</option>
                            <option>option2</option>
                            <option>option3</option>
                            <option>option4</option>
                        </optgroup>
                    </select></h2>
            </div>

            <div class="col-md-1" style="padding-left: 1">
                <h2>
                    <button class="btn" style="background-color: #FF606E" type="submit"><i class="glyphicon glyphicon-search" style="color: #FFFFFF"></i></button>
                </h2>
            </div>
            <div class="col-md-1 col-md-offset-1">
                <h2>
                    <button type="button" runat="server" id="tobehost" class="btn btn-warning btn-block dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">成为房东<span class="caret"></span></button>
                    <ul class="dropdown-menu">
                <li><a href="stepCheck.aspx">添加房源</a></li>
                <li><a href="historyOrderHost.aspx">查看出租记录</a></li>
                <li role="separator" class="divider"></li>
                <li><a href="resource.aspx">查看我的房源</a></li>
                    </ul>
                </h2>
            </div>
            <div class="col-md-1">
                <h2>
                    <button runat="server" type="button" id="register" class="btn btn-warning btn-block" data-toggle="modal" data-target="#regModal">注册</button></h2>
                <h2>
                    <button runat="server" type="button" id="center" class="btn btn-warning btn-block" onserverclick="center_ServerClick">个人中心</button></h2>
            </div>
            <div class="col-md-1">
                <h2>
                    <button runat="server" type="button" id="login" class="btn btn-warning btn-block" data-toggle="modal" data-target="#loginModal">登录</button></h2>
                <button runat="server" type="button" id="exit" class="btn btn-warning btn-block" onserverclick="exit_ServerClick">退出登录</button></h2>
            </div>
        </div>
    </div>

    <div class="modal fade" id="regModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color: #FF7575">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">关闭</span></button>
                    <h3 class="modal-title text-center" id="myModalLabel" style="color: #FFFFFF">立刻注册</h3>
                </div>
                <div class="modal-body">
                    <form role="form" class="regform" method="post" action="doRegister.aspx">
                        <div class="form-group">
                            <label for="exampleInputEmail1">电话号码</label>
                            <input type="tel" class="form-control" name="registerInputPhone" placeholder="电话号码">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">输入密码</label>
                            <input type="password" class="form-control" name="registerInputPassword" placeholder="输入登录密码">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">再次输入</label>
                            <input type="password" class="form-control" name="registerInputPassword1" placeholder="重复输入登录密码">
                        </div>
                        <div>
                            <label for="exampleInputPassword1">请输入图中验证码!</label>
                            <input type="password" class="form-control" name="validationNum" placeholder="请输入途中验证码!" />
                            <asp:Image ID="Image1" runat="server" Height="22px" Width="58px" ImageUrl="~/ValidationNum.aspx" />
                        </div>
                        <div class="form-group text-center">
                            <input type="submit" id="btn_Register" value="注册" class="btn btn-default btn-lg" style="width: 60%; background-color: #FF7575; color: #FFFFFF" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="loginModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header" style="background-color: #FF7575">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">关闭</span></button>
                    <h3 class="modal-title text-center" id="myModalLabelLogin" style="color: #FFFFFF">登录</h3>
                </div>
                <div class="modal-body">
                    <form role="form" class="regform" method="post" action="doLogin.aspx">
                        <div class="form-group">
                            <label for="exampleInputEmail1">电话号码</label>
                            <input type="tel" class="form-control" name="LoginInputPhone" ng-model="account" ng-init="account=''" placeholder="电话号码">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">输入密码</label>
                            <input type="password" class="form-control" name="LoginInputPassword" ng-model="password" ng-init="password=''" placeholder="输入登录密码">
                        </div>
                        <div class="form-group text-center">
                            <input type="submit" value="登录" id="btn_Login" class="btn btn-default btn-lg" style="width: 60%; background-color: #FF7575; color: #FFFFFF" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid" style="padding-left: 0; padding-right: 0">
        <div ui-view="head"></div>
    </div>

    <div class="container-fluid">
        <div ui-view="content"></div>
    </div>

    <div class="footer">
        <div class="container-fluid">
            <p><span class="glyphicon glyphicon-heart"></span>CopyRight@GOAT Greatest of the Best</p>
        </div>
    </div>

    <script src="bower_components/jquery/dist/jquery.js"></script>
    <script src="bower_components/angular/angular.js"></script>
    <script src="bower_components/bootstrap/dist/js/bootstrap.js"></script>
    <script src="bower_components/angular-animate/angular-animate.js"></script>
    <script src="bower_components/angular-cookies/angular-cookies.js"></script>
    <script src="bower_components/angular-resource/angular-resource.js"></script>
    <script src="bower_components/angular-ui-router/release/angular-ui-router.js"></script>
    <script src="bower_components/angular-sanitize/angular-sanitize.js"></script>
    <script src="bower_components/angular-touch/angular-touch.js"></script>
    <script src="js/bootstrap-select.js"></script>


    <script src="scripts/app.js"></script>

    <script src="scripts/controllers/main.js"></script>
    <script src="scripts/controllers/about.js"></script>
    <script src="scripts/controllers/login.js"></script>

</body>

</html>

