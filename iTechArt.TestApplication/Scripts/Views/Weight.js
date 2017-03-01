(function () {
	'use strict';
	var weightUrl = '../Weight/ShowWeight';
	var show = $('button.Show');
	var results = $(".results");
	var tableTemplate = $("#weightTableTemplate");

	function renderTable(model)
	{
		results.empty();

		tableTemplate.tmpl(model)
		.appendTo(results);
	}

	show.click(function () {
		try{
		var depot = $('.DepotId').val();
		var type = $('.DrugType').val();

		var data = { depotId: depot, drugTypeId: type };
		if (depot != null && type != null)
			requests.requestGET(weightUrl, data,renderTable);
		}
		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
})();