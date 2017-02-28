(function () {
	'use strict';
	var countDrugTypes = $('#count');
	var selectedDepotId = $('#DepotId');
	var results = $('#results');
	var urlUnitsSearch = '../Сalculate/UnitsSearch';
	var urlErrors = '../Home/MessageWindow?';

	$('button#calculate').click(function () {
		try {
			var count = countDrugTypes.val();
			var depot = selectedDepotId.val();
			var numbers = [];

			for (var i = 1; i <= count; i++) {
				numbers.push($('#' + i).val());
			}
			var data = JSON.stringify( { depotId: depot, numbers: numbers });
			$.ajax({
				type: "GET",
				dataType: "json",
				traditional: true,
				data: { depotId: depot, numbers: numbers },
				url: urlUnitsSearch,
				success: function (data) {
					var model = JSON.parse(data);

					var table = $("<table></table>").addClass("table table-hover");
					var trThed = $("<tr></tr>");

					trThed.append($("<th></th>").text("Drug Unit Id"));
					trThed.append($("<th></th>").text("Pick Number"));
					trThed.append($("<th></th>").text("Drug Type Name"));
					trThed.append($("<th></th>").text("Depot Name"));

					table.append(trThed);

					var tbody = $("<tbody></tbody>");

					if (model.RenderDrugUnits == true) {
						$.each(model.DrugUnits, function (item) {
							var tr = $("<tr></tr>");

							tr.append($("<td></td>").text(model.DrugUnits[item].Id));
							tr.append($("<td></td>").text(model.DrugUnits[item].PickNumber));
							tr.append($("<td></td>").text(model.DrugUnits[item].DrugTypeName));
							tr.append($("<td></td>").text(model.DrugUnits[item].DepotName));

							tbody.append(tr);
						});
					}
					table.append(tbody);

					$('#results').html(table);
				}
			});
		}
		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
})();

