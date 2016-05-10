<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false"  CodeFile="housePublish1.aspx.cs" Inherits="housePublish1" %>

<!doctype html>
<html>
  <head>
    <meta charset="utf-8">
    <title>Greatest of the Best</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width">

    <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.css" />
      <link rel='stylesheet prefetch' href='http://libs.useso.com/js/font-awesome/4.2.0/css/font-awesome.min.css'>
    <link rel="stylesheet" href="styles/main.css">
    <link rel="stylesheet" href="styles/sidebar.css">
    <link rel="stylesheet" href="styles/bootstrap-select.css">
  </head>
<body>

    <div class="container-fluid" style="background-color: #F0F0F0; position: fixed; width: 100%;z-index:1;margin-top:-66px">
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

        <form id="form1" runat="server">
    <div>
      <div class="nav-side-menu">
        <div class="brand">成为房东&nbsp&nbsp&nbsp</div>
        <i class="fa fa-bars fa-2x toggle-btn" data-toggle="collapse" data-target="#menu-content"></i>
        <div class="menu-list">
          <ul id="menu-content" class="menu-content collapse out">
            <li>
              <a href="#">
                <i class="glyphicon glyphicon-th-list"></i> 按照顺序添加信息
              </a>
            </li>

            <li  data-target="#products">
              <a href="#">
                <div class="row menu-content">
                  <div class="col-md-6 text-left">
                    &nbsp房源
                  </div>
                  <div class="col-md-1 col-md-offset-4">
                    <span class="glyphicon glyphicon-align-right"></span>
                  </div>
                </div>
              </a>
            </li>
            <ul class="sub-menu" id="products">
              <li style="background-color: #020203"><asp:HyperLink ID="HyperLink1" runat="server" Target="_top">基本信息</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink2" runat="server" Target="_top">描述</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink3" runat="server" Target="_top">地点</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink4" runat="server" Target="_top">便利设施</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink5" runat="server" Target="_top">居家安全</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink6" runat="server" Target="_top">额外服务</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink7" runat="server" Target="_top">照片</asp:HyperLink></li>
            </ul>


            <li data-target="#service">
              <a href="#">
                <div class="row menu-content">
                  <div class="col-md-6 text-left">
                    &nbsp出租
                  </div>
                  <div class="col-md-1 col-md-offset-4">
                    <span class="glyphicon glyphicon-align-right"></span>
                  </div>
                </div>
              </a>
            </li>
            <ul class="sub-menu" id="service">
              <li><asp:HyperLink ID="HyperLink8" runat="server" Target="_top">价格</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink9" runat="server" Target="_top">预定</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink10" runat="server" Target="_top">日历</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink11" runat="server" Target="_top">个人资料</asp:HyperLink></li>
            </ul>

          </ul>
        </div>
      </div>

    <div class="row" style="height: 700px; background-color: #F0F0F0; margin-left: 300px; margin-top: 66px; width: 78%">
      <div class="row" style="background-color: #FFFFFF; height: 700px; width: 65%">
        <div class="row" style="margin-top: 50px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">帮助旅行者找到合适的房源</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">用户在Airbnb上面搜索房源时可以根据房源的基本情况进行筛选，从而找到符合他们需求的房源。</font></h5>
          </div>
        </div>
        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">房源</font></h2>
          </div>
        </div>
        <div class="row" style="height: 20px"></div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">房源类型</font></h5>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">房屋类型</font></h5>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">可住</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="style" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>公寓</asp:ListItem>
                    <asp:ListItem>独立屋</asp:ListItem>
                    <asp:ListItem>住宿加早餐</asp:ListItem>
                    <asp:ListItem>LOFT</asp:ListItem>
                    <asp:ListItem>别墅</asp:ListItem>
                    <asp:ListItem>宿舍</asp:ListItem>
                    <asp:ListItem>房车</asp:ListItem>
                    <asp:ListItem>蒙古包</asp:ListItem>
                    <asp:ListItem>岛屿</asp:ListItem>
                    <asp:ListItem>帐篷</asp:ListItem>
                    <asp:ListItem>平房</asp:ListItem>
                    <asp:ListItem>小木屋</asp:ListItem>
                    <asp:ListItem>其他</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="type" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>整套房子/公寓</asp:ListItem>
                    <asp:ListItem>独立房间</asp:ListItem>
                    <asp:ListItem>合住房间</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="limit" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8+</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
        </div>
        <div class="row" style="height: 20px"></div>
        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">房间和床位</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">卧室</font></h5>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">床</font></h5>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">卫生间</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="bedroom" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5+</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="bed" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5+</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
          <div class="col-md-2 col-md-offset-1">
            <h2>
                <asp:DropDownList ID="restroom" runat="server" Font-Size="24px" Width="170%" Height="40px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3+</asp:ListItem>
                </asp:DropDownList>
            </h2>
          </div>
        </div>
        <div class="row" style="200px"></div>
        <div class="row">
          <div class="col-md-2 col-md-offset-8">
            <h2>
                <asp:Button ID="next" runat="server" Text="下一步" class="btn btn-warning btn-block" OnClick="next_Click" /></h2>
          </div>
        </div>
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
    </div>
    </form>
</body>
</html>
