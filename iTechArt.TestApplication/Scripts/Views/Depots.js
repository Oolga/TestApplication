﻿var first=-10;
var count=10;

$('button#show').click(function () {
	first += 10;
	$.get('Depots/DepotsContent', {first:first ,count:count}, function (data) {
		$('#results').html(data);
	});
});