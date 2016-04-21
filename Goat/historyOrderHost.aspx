<%@ Page Language="C#" AutoEventWireup="true" CodeFile="historyOrderHost.aspx.cs" Inherits="historyOrderHost" %>

<!doctype html>
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
<body>
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
                    <button type="button" class="btn btn-warning btn-block dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">成为房东<span class="caret"></span></button>
                    <ul class="dropdown-menu">
                        <li><a href="#">Action</a></li>
                        <li><a href="#">Another action</a></li>
                        <li><a href="#">Something else here</a></li>
                        <li role="separator" class="divider"></li>
                        <li><a href="#">Separated link</a></li>
                    </ul>
                </h2>
            </div>
            <div class="col-md-1">
                <h2>
                    <button runat="server" type="button" id="center" class="btn btn-warning btn-block" onserverclick="center_ServerClick">个人中心</button></h2>
            </div>
            <div class="col-md-1">
                <h2>
                    <button runat="server" type="button" id="exit" class="btn btn-warning btn-block" onserverclick="exit_ServerClick">退出登录</button></h2>
            </div>
        </div>
    </div>

    <div class="container-fluid" style="padding-left: 0; padding-right: 0">
        <nav class="navbar navbar-default navbar-static-top" style="background-color: #FF606E; z-index: 0; min-height: 30px; margin-bottom: 0px; height: 31px;" role="navigation">
            <div class="navbar-header">
                <a class="navbar-brand" href="#"></a>
            </div>
            <div>
                <ul class="nav navbar-nav">
                    <li><a href="#/home" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">个人中心</a></li>
                    <li><a href="#/login" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">您的房源</a></li>
                    <li><a href="#/register" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">您的旅程</a></li>
                    <li><a href="#" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">心愿单</a></li>
                    <li><a href="#" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">账户管理</a></li>
                </ul>
            </div>
        </nav>

    </div>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" Width="100%">
                <ItemTemplate>
                    <div style="border: 1px solid #000000;background-color:#f0f0f0">
                        <div class="container-fluid">
                            <div class="row">
                                <div id="listDiv" style="height: 350px; background-color: #f0f0f0" class="col-md-8 col-md-offset-2">
                                    <div class="row" style="height: 350px">
                                        <div class="col-md-4" style="height: 330px; overflow: hidden; margin-top: 10px;">
                                            <asp:Image ID="Image1" runat="server" Height="330px"  ImageUrl='<%# Eval("housePic") %>' />
                                        </div>
                                        <div class="col-md-8" style="height: 380px; margin-top: 10px">
                                            <div class="row">
                                                <div class="col-md-8 col-md-offset-1">
                                                    <h2>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("houseName") %>'></asp:Label>&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text='<%# Eval("orderDate") %>'></asp:Label></h2>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-2 col-md-offset-1">
                                                    <h5><font color="#6c6c6c">入住时间：</font></h5>
                                                </div>
                                                <div class="col-md-2">
                                                    <h5>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("startDate") %>'></asp:Label></h5>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-2 col-md-offset-1">
                                                    <h5><font color="#6c6c6c">结束时间：</font></h5>
                                                </div>
                                                <div class="col-md-2">
                                                    <h5>
                                                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("price") %>'></asp:Label></h5>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-3 col-md-offset-1">
                                                    <h3>
                                                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("stateNameCustomer") %>'></asp:Label></h3>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-4 col-md-offset-1">
                                                    <h2>
                                                        <asp:Button ID='Button2' runat="server" Text='<%# Eval("stateHintCustomer") %>' CommandName='<%# Eval("state") %>' CommandArgument='<%# Eval("orderId") %>' Visible='<%#Convert.ToBoolean((int)Eval("isShowCustomer")==0?"False":"True")%>' OnClick="Button2_Click" /></h2>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
        </div>
    </form>
    <div class="row" style="height: 40px"></div>

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
