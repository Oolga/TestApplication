
	$('button#calculate').click(function () {
		var count = $('#count').val();
		alert(count);
		var depot=$('#DepotId').val();
		var numbers = [];

		for (var i = 1; i <= count; i++)
		{
			numbers.push($('#' + i).val());
		}

		var data={depotId:depot, numbers:numbers};

		$('#results').load('UnitsSearch?' + $.param(data, true));

	});


