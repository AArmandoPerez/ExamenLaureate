var app = angular.module("Homeapp", []);

app.controller("HomeController", function ($scope, $http) {
    $scope.btntext = "Guardar";
    // Add record
    $scope.savedata = function () {
        $scope.btntext = "Porfavor espere ....";
        $http(
            {
                method: 'POST',
                url: '/Home/Add_record', 
                data: $scope.Contacts 
            }).then(function successCallback(response) {
                $scope.btntext = "Guardar";
                $scope.Contacts = null;
                alert("Contacto insertado");

                window.location.href = '/Home/index';

            }, function errorCallback(response) {
                    alert('Failed');

            });
    };
    // Display all record
    $http.get("/Home/Get_data").then(function (d) {
        $scope.records = d.data;
    }, function (error) {
        alert('Failed');
    });
    // Display record by id


    $scope.loadrecord = function (id) {
        $http.get("/Home/Get_databyid?id="+id).then(function (d) {
            $scope.Contacts = d.data[0];
        }, function errorCallback (error) {
            alert('Failed');
        });
    };

    // Delete record 
    $scope.deleterecord = function (id) {
        $http.get("/Home/delete_record?id=" + id).then(function (d) {
            alert(d.data);
            $http.get("/Home/Get_data").then(function (d) {
                $scope.record = d.data;
                window.location.href = '/Home/index';
            }, function (error) {
                alert('Failed');
            });
        }, function (error) {
            alert('Failed');
        });
    };

    // Update record
    $scope.updatedata = function () {
        $scope.btntext = "Porfavor espere ..";

        $http(
            {
                method: 'POST',
                url: '/Home/update_record',
                data: $scope.Contacts
            }).then(function successCallback(response) {
                $scope.btntext = "Actualizar";
                $scope.Contacts = null;
                alert("Contacto Actualizado");

                window.location.href = '/Home/index';

            }, function errorCallback(response) {
                alert('Failed');

            });

     
    };



});