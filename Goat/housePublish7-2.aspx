<%@ Page Language="C#" AutoEventWireup="true" CodeFile="housePublish7-2.aspx.cs" Inherits="housePublish7_2" %>

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
          <div class="container-fluid" style="background-color: #F0F0F0; position: fixed; width: 100%; z-index: 1; margin-top: -66px">
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
                <li><a href="#">Action</a></li>
                <li><a href="#">Another action</a></li>
                <li><a href="#">Something else here</a></li>
                <li role="separator" class="divider"></li>
                <li><a href="#">Separated link</a></li>
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
              <li><a href="housePublish1.aspx">基本信息</a></li>
              <li><a href="housePublish2.aspx">描述</a></li>
              <li><a href="housePublish3.aspx">地点</a></li>
              <li><a href="housePublish4.aspx">便利设施</a></li>
              <li><a href="housePublish5.aspx">居家安全</a></li>
              <li><a href="Service.aspx">额外服务</a></li>
              <li><a href="iamge.aspx">照片</a></li>
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
              <li><a href="housePublish6.aspx">价格</a></li>
              <li><a href="housePublish7.aspx">预定</a></li>
              <li>日历</li>
              <li>个人资料</li>
            </ul>

          </ul>
        </div>
      </div>
    <form id="form1" runat="server">
    <div>
    <div class="row" style="height: 800px; background-color: #F0F0F0; margin-left: 300px; margin-top: 66px; width: 78%">
      <div class="row" style="background-color: #FFFFFF; height: 800px; width: 65%">
        <div class="row" style="margin-top: 50px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">即时预订</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">房客不用发申请就可以预订。</font><a href="housePublish7.aspx" style="color: #ff606e">返回</a></h5>
          </div>
        </div>
        <hr width="80%"/>
        <div class="row" style="margin-top: 20px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h3><font color="#6c6c6c">谁可以预定</font></h3>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group radio">
              <div class="radio">
                <label>
                  <input name="option" type="radio"> 社区中的任何人
                </label>
              </div>
            </div>
          </div>
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group radio">
              <div class="radio">
                <label>
                  <input name="option" type="radio"> 仅限其他房东推荐的房客
                </label>
              </div>
            </div>
          </div>
        </div>
        <div class="row" style="margin-top: 40px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h3><font color="#6c6c6c">《房屋守则》（可选）</font></h3>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h5><textarea class="form-control" rows="5"></textarea></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-7 col-md-offset-1">
            <h5 style="font-size: 60%; margin-top: -5px;"><font color="#6c6c6c">您希望房客有什么样的言行举止。</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-8">
            <h2><asp:Button ID="next72" runat="server" Text="下一步"  class="btn btn-warning btn-block" OnClick="next72_Click"/></h2>
          </div>
        </div>
      </div>
    </div>
    </div>
    </form>
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
