<?php 
	$url = $this->helpers['URLHelper']->getURL();
	$location = $this->helpers['URLHelper']->getLocation();
?>

<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<meta name="keywords"	 content="HTML, CSS, JS, PHP">
		<meta name="description" content="Descrição do site">
		<meta name="author"		 content="Code Universe">
		<meta name="viewport"	 content="width=device-width, initial-scale=1.0">
		<meta name="robots"		 content="index, follow">
		<title>Project One</title>
		<link rel="stylesheet" type="text/css" href="<?php echo $url; ?>/assets/libs/bootstrap/css/bootstrap.min.css">
		<link rel="stylesheet" type="text/css" href="<?php echo $url; ?>/assets/css/site/layout.css">
		
	</head>
	<body>

		<header>
			<?php require 'header.php'; ?>
		</header>

		<main>
			<?php require $file; ?>
		</main>

		<footer>
			<?php require 'footer.php'; ?>
		</footer>

		<script type="text/javascript">
			var URL = "<?php echo $url; ?>";
			var helpers = {}
		</script>
		<script type="text/javascript" src="<?php echo $url; ?>/assets/libs/jquery/jquery-3.4.1.min.js"></script>
		<script type="text/javascript" src="<?php echo $url; ?>/assets/libs/popper/popper.min.js"></script>
		<script type="text/javascript" src="<?php echo $url; ?>/assets/libs/bootstrap/js/bootstrap.min.js"></script>
		
	</body>
</html>