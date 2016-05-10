<%@ Page Language="C#" AutoEventWireup="true" CodeFile="housePublish4.aspx.cs" Inherits="housePublish4" %>

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
              <li style="background-color: #020203"><asp:HyperLink ID="HyperLink4" runat="server" Target="_top">便利设施</asp:HyperLink></li>
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
    <form id="form1" runat="server">
    <div>
     <div class="row" style="height: 1400px; background-color: #F0F0F0; margin-left: 300px; margin-top: 66px; width: 78%">
      <div class="row" style="background-color: #FFFFFF; height: 1400px; width: 65%">
        <div class="row" style="margin-top: 50px"></div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">向旅行者介绍您的空间</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">每一个房源都与众不同。突出描述您房源的受欢迎之处，给想要租住您所在地区房源的房客留下深刻的印象。</font></h5>
          </div>
        </div>
        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">一般便利设施</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="must" runat="server" Text="生活必需品(洗发水，衣架，电吹风，熨斗）" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="TV" runat="server" Text="有线电视" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="airCondition" runat="server" Text="空调" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="kiction" runat="server" Text="厨房" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="net" runat="server" Text="网络" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="wifi" runat="server" Text="无线网络" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="time" runat="server" Text="24h随时入住" AutoPostBack="false" />
                </label>
              </div>
          	</div>
          </div>
        </div>

        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">其他便利设施</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="bath" runat="server" Text="热水浴缸" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="wash" runat="server" Text="洗衣机" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="swimmingPool" runat="server" Text="游泳池" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="breakfast" runat="server" Text="早餐" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="carPark" runat="server" Text="内部提供免费停车" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="workout" runat="server" Text="健身房" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="lift" runat="server" Text="电梯" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="guard" runat="server" Text="门卫" AutoPostBack="false" />
                </label>
              </div>
          	</div>
          </div>
        </div>

        <hr width="80%"/>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <h2><font color="#6c6c6c">特殊功能</font></h2>
          </div>
        </div>
        <div class="row">
          <div class="col-md-8 col-md-offset-1">
            <h5><font color="#6c6c6c">您房源为有特定需求的房客提供的功能。</font></h5>
          </div>
        </div>
        <div class="row">
          <div class="col-md-10 col-md-offset-1">
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="children" runat="server" Text="欢迎儿童/家庭入住" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="smoke" runat="server" Text="允许吸烟" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="party" runat="server" Text="适合举办活动" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="pet" runat="server" Text="允许携带宠物" AutoPostBack="false" />
                </label>
              </div>
          	</div>
            <div class="form-group checkbox">
              <div class="checkbox">
                <label>
                    <asp:CheckBox ID="disable" runat="server" Text="无障碍设施" AutoPostBack="false" />
                </label>
              </div>
          	</div>
          </div>
        </div>

        <div class="row" style="height: 40px"></div>

        <div class="row">
          <div class="col-md-2 col-md-offset-8" style="margin-top: -15px">
            <h2><asp:Button ID="next4" runat="server" Text="下一步"  class="btn btn-warning btn-block" OnClick="next4_Click"/></h2>
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
    </div>
</body>
</html>
