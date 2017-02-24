(function () {
	'use strict';
	var weightUrl = 'ShowWeight?';
	$('button#Show').click(function () {
		var depot = $('#DepotId').val();
		var type = $('#DrugType').val();

		var data = { depotId: depot, drugTypeId: type };
		if (depot != null && type != null)
			$('#results').load(weightUrl + $.param(data, true));
	});
})();