<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Bootstrap</title>
	<link rel="stylesheet" href="assets/libs/bootstrap-4.3.1-dist/css/bootstrap.min.css">

</head>
<body> 

	<div class="row">
		<div class="col-3 ml-3">
			<button type="button" class="btn btn-success" title="Título" data-toggle="popover">Botão</button>
		</div>
	</div>

	<script type="text/javascript" src="assets/libs/jquery.js"></script>
	<script type="text/javascript" src="assets/libs/popper.js"></script>
	<script type="text/javascript" src="assets/libs/bootstrap-4.3.1-dist/js/bootstrap.min.js"></script>
		<script type="text/javascript">
		$(function(){
			$('[data-toggle="popover"]').popover()
		})
		
	</script>
	
</body>
</html>