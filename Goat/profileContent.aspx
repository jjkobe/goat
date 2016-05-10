<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profileContent.aspx.cs" Inherits="profileContent" %>

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
<div class="panel panel-warning">
   <div class="panel-heading">
      <h3 class="panel-title" style="color: #FF606E">必填</h3>
   </div>
   <div class="panel-body">

      <div class="row row-condensed space-4">
        <div class="col-md-3 text-right">
          <h5>名字</h5>
        </div>
        <div class="col-md-6">
          <input runat="server" type="text" class="form-control" id="name" placeholder="请输入名字">
        </div>
      </div>

      <div class="row" style="height: 20px"></div>

      <div class="row row-condensed space-4">
        <div class="col-md-3 text-right">
          <h5>性别</h5>
        </div>
        <div class="col-md-6" style="margin-top:7px">
          <input runat="server" id="male" value="1" name="gender" type="radio" >男&nbsp
           <input runat="server" id="female" value="0" name="gender" type="radio" >女
        </div>
      </div>

      <div class="row" style="height: 20px"></div>

      <div class="row row-condensed space-4">
        <div class="col-md-3 text-right">
          <h5>电话号码</h5>
        </div>
        <div class="col-md-6">
          <input runat="server" id="phone" type="text" class="form-control" placeholder="请输入电话号码">
        </div>
      </div>
      <div class="row row-condensed space-4">
        <div class="col-md-6 col-md-offset-3">
          <h6 style="color: #9D9D9D">该电话能在咨询、订购或者紧急情况是通讯畅通。</h6>
        </div>
      </div>

      <div class="row" style="height: 20px"></div>

      <div class="row row-condensed space-4">
        <div class="col-md-3 text-right">
          <h5>您住的地方</h5>
        </div>
        <div class="col-md-6">
          <input runat="server" id="place" type="text" class="form-control" placeholder="例如：上海/苏州/杭州">
        </div>
      </div>

      <div class="row" style="height: 20px"></div>

      <div class="row row-condensed space-4">
        <div class="col-md-3 text-right">
          <h5>描述一下你自己</h5>
        </div>
        <div class="col-md-6">
          <textarea runat="server" id="description" class="form-control" rows="3"></textarea>
        </div>
        <div class="row" style="height: 10px"></div>
        <div class="col-md-6 col-md-offset-3">
          <h6 style="color: #9D9D9D">Goat是网上建立联系的网站。</h6>
          <h6 style="color: #9D9D9D">告诉他们你喜欢什么：离开了什么就活不了，最讨厌什么，什么会给你惊喜！</h6>
          <h6 style="color: #9D9D9D">告诉他们你是一个什么样的房东，你将如何对待房客。</h6>
          <h6 style="color: #9D9D9D">最后再加一句你的人生信条！</h6>
        </div>
      </div>

    </div>
</div>
<div class="panel panel-warning"/>

    <div class="panel-heading">
       <h3 class="panel-title" style="color: #FF606E">可选</h3>
    </div>
    <div class="panel-body">

       <div class="row row-condensed space-4">
         <div class="col-md-3 text-right">
           <h5>学校</h5>
         </div>
         <div class="col-md-6">
           <input runat="server" id="school" type="text" class="form-control" placeholder="请输入学校名字">
         </div>
       </div>

       <div class="row" style="height: 20px"></div>

       <div class="row row-condensed space-4">
         <div class="col-md-3 text-right">
           <h5>工作</h5>
         </div>
         <div class="col-md-6">
           <input runat="server" id="work" type="text" class="form-control" placeholder="例如：苹果/谷歌/阿里">
         </div>
       </div>

</div>
<div class="panel panel-warning">

     <div class="panel-heading">
        <h3 class="panel-title" style="color: #FF606E">商务差旅</h3>
     </div>
     <div class="panel-body">

       <div class="row row-condensed space-4">
         <div class="col-md-3 text-right">
           <h5>工作邮箱</h5>
         </div>
         <div class="col-md-6">
           <input runat="server" id="email" type="text" class="form-control">
         </div>
       </div>

       <div class="row row-condensed space-4">
         <div class="col-md-6 col-md-offset-3">
           <h6 style="color: #9D9D9D">轻松为商务差旅付款，查看商务差旅就绪房源。</h6>
         </div>
       </div>

    </div>

</div>

<div class="row">
  <div class="col-md-2 col-md-offset-9">
    <asp:Button runat="server" ID="save" class="btn btn-warning btn-block" Text="保存" OnClick="save_Click"></asp:Button>
  </div>
</div>

<div class="row" style="height: 20px"></div>

 </form>
</body>
</html>
