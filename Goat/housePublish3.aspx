<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="housePublish3.aspx.cs" Inherits="housePublish3" %>

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
    <script src="http://libs.baidu.com/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript">
        function getLoaction() {
            var lat;
            var log;
            var locationarray = new Array(2);
            var proText = $("#province").val();
            var cityText = $("#city").val();
            var streetText = $("#street").val();
            var loaText = proText + cityText + streetText;
            var consulturl = "http://restapi.amap.com/v3/geocode/geo?address=" + loaText + "&output=json&key=f99b365cbdcc9dcb80324c7dee05ee61";
            $.getJSON(consulturl, function (data, textStatus, jqXHR) {
                locationarray = data.geocodes[0].location.split(",");
                lat = locationarray[1];
                log = locationarray[0];
                $.ajax({
                    url: "housePublish3.aspx/processLoaction",
                    type: "post",
                    dataType: "json",
                    contentType: "application/json;charset=utf-8",
                    data: JSON.stringify({ "resultlog": log, "resultlat": lat }),
                    success: function (data) {
   
                    }
                });
            });
            return true;
        }
        
    </script>
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
              <li><asp:HyperLink ID="HyperLink1" runat="server" Target="_top">基本信息</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink2" runat="server" Target="_top">描述</asp:HyperLink></li>
              <li style="background-color: #020203"><asp:HyperLink ID="HyperLink3" runat="server" Target="_top">地点</asp:HyperLink></li>
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

    <div class="row" style="height: 750px; background-color: #F0F0F0; margin-left: 300px; margin-top: 66px; width: 78%">
      <div class="row" style="background-color: #FFFFFF; height: 750px; width: 65%">
        <div class="row" style="margin-top: 50px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">帮助房客找到您的房源</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">旅行者会使用此信息来寻找地点合适的房源。</font></h5>
          </div>
        </div>
        <hr width="80%"/>
        <div class="row" style="height: 20px"></div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1">
            <h5><font color="#6c6c6c">省份</font></h5>
          </div>
          <div class="col-md-4 col-md-offset-3">
            <h5><font color="#6c6c6c">城市</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-5 col-md-offset-1">
            <h5><asp:TextBox ID="province" AutoPostBack="false" runat="server" Height="31px" Width="300px"></asp:TextBox>例：江苏省</h5>
          </div>
          <div class="col-md-5">
            <h5><asp:TextBox ID="city" AutoPostBack="false" runat="server" Height="31px" Width="300px"></asp:TextBox>例：苏州市</h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">邮政编码</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h5><asp:TextBox ID="postCode" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox>例：10048</h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">街道地区</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h5><asp:TextBox ID="street" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox>例：曹安公路4800号</h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">公寓、套房、大厦（可选）</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h5><asp:TextBox ID="department" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox>例：学生公寓6号楼</h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-8" style="margin-top: -15px" runat="server">
            <h2><asp:Button ID="next3" runat="server" Text="下一步"  class="btn btn-warning btn-block" OnClientClick="return getLoaction();" OnClick="next3_Click"/></h2>
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
    </form>
</body>
</html>
