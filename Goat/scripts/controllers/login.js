angular.module('nodejsApp').controller('LoginCtrl',['$scope','$http','$cookies','$rootScope','check',
function($scope,$http, $cookies, $rootScope, check){
	$scope.needSaveCookie = false;
	var url = $rootScope.url;
		$scope.login= function(){
			var that = this;
			if(that.account == ""){
					alertMsg("账号不能为空");
			}
			else if(that.password==""){
					alertMsg('密码不能为空')
			} else {
				console.log("Login......");
				// console.log("Name: " + that.account);
				// console.log("Pass: " + that.password);
				$http.post(url + "front/user/login",
				{
					"username": that.account,
					"password": that.password
				}).success(function(response){
					if(check.checkErrCode(response.errCode) === true){
						alertMsg('登陆成功')
					} else {
							alertMsg('登陆失败')
					}
				}).error(function(response){
					console.log(response);
					alertMsg('登陆失败')
				});
			}
		}
}]);
