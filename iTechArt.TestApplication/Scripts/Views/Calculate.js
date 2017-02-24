(function () {
	'use strict';
	var countDrugTypes = $('#count');
	var selectedDepotId = $('#DepotId');
	var results = $('#results');
	var urlUnitsSearch = 'UnitsSearch?';
	var urlErrors = 'Home/MessageWindow?';

	$('button#calculate').click(function () {
		try {
			var count = countDrugTypes.val();
			var depot = selectedDepotId.val();
			var numbers = [];

			for (var i = 1; i <= count; i++) {
				numbers.push($('#' + i).val());
			}
			var data = { depotId: depot, numbers: numbers };
			results.load(urlUnitsSearch + $.param(data, true));
		}
		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
})();

