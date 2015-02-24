var OperacionesApp = angular.module('OperacionesApp', []);

OperacionesApp.controller('OperacionesCtrl', function ($scope, $http) {
    $scope.numero1 = '';
    $scope.numero2 = '';
    $scope.operador = 'suma';
    $scope.resultado = '0';
 
    $scope.go = function () {

        $http.post('/Home/GetOperacion?num1=' + $scope.numero1 + "&num2=" + $scope.numero2 + "&oper=" + $scope.operador).success(function (data) {
            $scope.resultado = data;
            if ($scope.resultado === 'No puedes ingresar letras solo números')
                $scope.myClass = 'alert alert-danger';
            else
                $scope.myClass = 'alert alert-success';
        });
    }
    $scope.validarRaiz = function () {
        if ($scope.operador === "raiz") {
            $scope.activoTextBox = true;
            $scope.numero2 = '';
        } else
        {
            $scope.activoTextBox = false;
        }
    }
   
    
  
    $scope.activoTextBox = false;

 
});