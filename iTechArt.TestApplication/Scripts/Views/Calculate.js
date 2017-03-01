(function () {
	'use strict';
	var countDrugTypes = $('.count');
	var selectedDepotId = $('.DepotId');
	var results = $('.results');
	var urlUnitsSearch = '../Сalculate/UnitsSearch';
	var urlErrors = '../Home/MessageWindow?';
	var calculate = $('button.calculate');
	var tableTemplate = $("#calculateTableTemplate");

	function renderTable(model){
		results.empty();

		tableTemplate.tmpl(model)
		.appendTo(results);
	}


calculate.click(function () {
	try {
		var count = countDrugTypes.val();
		var depot = selectedDepotId.val();
		var numbers = [];

		for (var i = 1; i <= count; i++) {
			numbers.push($('.' + i).val());
		}
		var data = { depotId: depot, numbers: numbers };
		
		requests.requestGET(urlUnitsSearch,data,renderTable);
	}
	catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});

})();

