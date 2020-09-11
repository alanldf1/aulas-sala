/**
*
*Script da página de contato
*
*@author Code Universe
*
**/
(function($, URL,Helpers){

	var submitContact = function() {

		$('body').on('click', '#btnSubmitContact', function() {


			var name 	= $('input[name="name"]').val();
			var email 	= $('input[name="email"]').val();
			var phone 	= $('input[name="phone"]').val();
			var message	= $('textarea[name="message"]').val();

			console.log(name + ' ' + email + ' ' + phone + ' ' + message);

		})
	}

	$( document ).ready(function() {
		submitContact();
	});

})($,URL,Helpers)