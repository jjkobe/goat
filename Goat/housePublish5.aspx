<%@ Page Language="C#" AutoEventWireup="true" CodeFile="housePublish5.aspx.cs" Inherits="housePublish5" %>

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
              <li><asp:HyperLink ID="HyperLink3" runat="server" Target="_top">地点</asp:HyperLink></li>
              <li><asp:HyperLink ID="HyperLink4" runat="server" Target="_top">便利设施</asp:HyperLink></li>
              <li style="background-color: #020203"><asp:HyperLink ID="HyperLink5" runat="server" Target="_top">居家安全</asp:HyperLink></li>
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
    <form id="form1" runat="server">
    <div>
    <div class="row" style="height: 1400px; background-color: #F0F0F0; margin-left: 300px; margin-top: 66px; width: 78%">
      <div class="row" style="background-color: #FFFFFF; height: 1400px; width: 65%">
        <div class="row" style="margin-top: 50px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">居家安全</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">虽然紧急情况很罕见，但有时也会发生。帮助您的房客做好准备。进一步了解安全方面的信息。</font></h5>
          </div>
        </div>
        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">安全检查清单</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="smokeAlert" runat="server" Text="烟雾报警器" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="coAlert" runat="server" Text="一氧化碳报警器" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="aid" runat="server" Text="急救包" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="aidCard" runat="server" Text="安全卡" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="fire" runat="server" Text="灭火器" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="lock" runat="server" Text="卧室门装锁" />
                </label>
              </div>
          	</div>
          </div>
        </div>

        <hr width="80%"/>

        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">安全卡</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">可以在房源里为房客准备的便利资源。房客行程单里也有一份。</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#ff606e">安全设施的位置在哪里？</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">灭火器</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="fireLocation" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-7 col-md-offset-3">
            <h5 style="font-size: 60%; margin-top: -5px;"><font color="#6c6c6c">例如）厨房，炉子的右边</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">火灾报警器</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="fireAlertLocation" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-7 col-md-offset-3">
            <h5 style="font-size: 60%; margin-top: -5px;"><font color="#6c6c6c">例如）走廊，前门的左边</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">煤气截止阀</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="coEnd" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-7 col-md-offset-3">
            <h5 style="font-size: 60%; margin-top: -5px;"><font color="#6c6c6c">例如）车库，油漆房的下方</font></h5>
          </div>
        </div>
        <div class="row" style="height: 40px"></div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#ff606e">紧急出口说明</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h5><asp:TextBox ID="exitLocation" AutoPostBack="false" TextMode="MultiLine" runat="server" Height="132px" Width="581px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-7 col-md-offset-1">
            <h5 style="font-size: 60%; margin-top: -5px;"><font color="#6c6c6c">离开您房源最安全迅速的方式是什么。</font></h5>
          </div>
        </div>
        <div class="row" style="height: 40px"></div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#ff606e">紧急电话号码</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">医疗服务</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="aidCall" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">火警</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="fireCall" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-1" style="padding-top: 9px;">
            <h5><font color="#6c6c6c">警察</font></h5>
          </div>
          <div class="col-md-7">
            <h5><asp:TextBox ID="policeCall" AutoPostBack="false" runat="server" Height="31px" Width="345px"></asp:TextBox></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-2 col-md-offset-8">
            <h2><asp:Button ID="next5" runat="server" Text="下一步"  class="btn btn-warning btn-block" OnClick="next5_Click" /></h2>
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
    <script src="scripts/index.js"></script>

    <script src="scripts/controllers/main.js"></script>
    <script src="scripts/controllers/about.js"></script>
    <script src="scripts/controllers/login.js"></script>
</body>
</html>
