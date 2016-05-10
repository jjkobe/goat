<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

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
              <h2><select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
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
              <h2><select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
                <optgroup label="filter1">
                  <option>option1</option>
                  <option>option2</option>
                  <option>option3</option>
                  <option>option4</option>
                </optgroup>
              </select></h2>
            </div>

            <div class="col-md-2" style="padding-left: 5; padding-right: 0">
              <h2><select class="selectpicker" data-width="100%" data-style="#000000" multiple data-live-search="true" data-live-search-placeholder="Search" data-actions-box="true">
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
            <h2><button type="button" class="btn btn-warning btn-block dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">成为房东<span class="caret"></span></button>
              <ul class="dropdown-menu">
                <li><a href="stepCheck.aspx">添加房源</a></li>
                <li><a href="historyOrderHost.aspx">查看出租记录</a></li>
                <li role="separator" class="divider"></li>
                <li><a href="resource.aspx">查看我的房源</a></li>
              </ul>
            </h2>
          </div>
          <div class="col-md-1">
              <h2><button runat="server" type="button" id="center" class="btn btn-warning btn-block" onserverclick="center_ServerClick" >个人中心</button></h2>
          </div>
          <div class="col-md-1">
            <h2>
              <button runat="server" type="button" id="exit" class="btn btn-warning btn-block" onserverclick="exit_ServerClick" >退出登录</button></h2>
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
               <li><a href="profile.aspx" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">个人中心</a></li>
               <li><a href="resource.aspx" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">您的房源</a></li>
               <li><a href="historyOrder.aspx" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">您的旅程</a></li>
               <li><a href="likething.aspx" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">心愿单</a></li>
               <li><a href="management.aspx" style="padding-top: 6px; padding-bottom: 5px; font-size: 7px; color: #FFFFFF">账户管理</a></li>
            </ul>
         </div>
        </nav>

      </div>
    <form id="form1" runat="server">

    <div>
    <div class="container-fluid" style="margin-top: 80px; width: 90%">
    <div class=" col-md-3 col-md-offset-1">

        <div class="panel panel-warning" style="padding-right: 0px; padding-left: 0px;">
            <div class="panel-heading">
                <h3 class="panel-title" style="color: #FF606E">头像</h3>
            </div>
            <div class="panel-body">
                <div class="row row-condensed space-4">
                    <div class="col-md-12">
                        <div class="text-center" style="overflow:hidden">
                            <asp:Image ID="Image1" style="height: 250px; width: 250px; border-radius: 50%" runat="server" />
                        </div>
                    </div>
                </div>
                <hr style="width: 85%; margin-bottom: 0px"/>
                <div class="row row-condensed space-4">
                    <div class="col-md-6 col-md-offset-3">
                        <div class="text-center">
                            <asp:Label ID="Label1" style="color: #5e5e5e;" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                    <div class="col-md-6 col-md-offset-3">
                        <div class="text-center">
                            <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" />
                            <asp:Button ID="Button1" style="color: #ff606e" runat="server" Text="修改" OnClick="Button1_Click" Visible="false"/>
                            <asp:Button ID="Button2" style="color: #ff606e" runat="server" Text="修改个人头像" OnClick="Button2_Click" />
                            <asp:Button ID="Button3" style="color: #ff606e" runat="server" Text="完成" OnClick="Button3_Click" Visible="false" />
                        </div>
                    </div>
                    <div class="col-md-6 col-md-offset-3">
                        <div class="text-center">
                            <a href="profileContent.aspx" style="color: #ff606e">编辑个人资料</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="col-md-6">

        <div class="row">
            <div class="col-md-10">
                <h1><font color="#6c6c6c">您好,欢迎回来!</font></h1>
            </div>
        </div>


        <div class="row" style="height: 20px"></div>

        <div class="panel panel-warning" style="padding-right: 0px; padding-left: 0px;">
            <div class="panel-heading">
                <h3 class="panel-title" style="color: #FF606E">基本信息</h3>
            </div>
            <div class="panel-body">
                <div class="row row-condensed space-4">
                    <div class="col-md-3 col-md-offset-1">
                        <h5><font color="#6c6c6c">名字:&nbsp;</font>
                            <asp:Label ID="Label2" color="#ff606e" runat="server" Text="Label"></asp:Label></h5>
                    </div>
                </div>
                    <div class="row row-condensed space-4">
                    <div class="col-md-3 col-md-offset-1">
                        <h5><font color="#6c6c6c">性别:&nbsp;</font>
                            <asp:Label ID="Label5" color="#ff606e" runat="server" Text="Label"></asp:Label></h5>
                    </div>
                </div>
                <div class="row row-condensed space-4">
                    <div class="col-md-10 col-md-offset-1">
                        <h5><font color="#6c6c6c">电话号码:&nbsp;</font><asp:Label ID="Label3" color="#ff606e" runat="server" Text="Label"></asp:Label></h5>
                    </div>
                </div>
                <div class="row row-condensed space-4">
                    <div class="col-md-10 col-md-offset-1">
                        <h5><font color="#6c6c6c">个人描述:&nbsp;</font><asp:Label ID="Label4" color="#ff606e" runat="server" Text="Label"></asp:Label></h5>
                    </div>
                </div>
            </div>
        </div>

        <div class="panel panel-warning" style="padding-right: 0px; padding-left: 0px;">
            <div class="panel-heading">
                <h3 class="panel-title" style="color: #FF606E">工作邮箱</h3>
            </div>
            <div class="panel-body">
                <div class="row row-condensed space-4">
                    <div class="col-md-10 col-md-offset-1">
                        <h5><font color="#6c6c6c">工作邮箱:&nbsp;</font><asp:Label ID="Label6" color="#ff606e" runat="server" Text="Label"></asp:Label></h5>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
    </div>
    </form>
        <div class="footer">
      <div class="container-fluid">
        <p><span class="glyphicon glyphicon-heart"></span> CopyRight@GOAT Greatest of the Best</p>
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
