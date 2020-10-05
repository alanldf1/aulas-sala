<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Angular</title>
	</head>
	<body ng-app>

		<form name="myForm">
			<input type="email" name="myInput" ng-model="myInput" required>
		</form>

		<p>O estado do input é</p>
		<p>{{ myForm.myInput.$valid }}</p>

		<form name="myForm2">
			<p>Nome: <input name="myName" ng-model="myName" required> <span ng-show="myForm2.myName.$touched && myForm2.myName.$invalid">O nome é obrigatório</span></p>
		</form>

		<script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.8.0/angular.min.js"></script>

	</body>
</html>