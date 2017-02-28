(function () {
	'use strict';
	var weightUrl = '../Weight/ShowWeight';

	$('button#Show').click(function () {
		try{
		var depot = $('#DepotId').val();
		var type = $('#DrugType').val();

		var data = { depotId: depot, drugTypeId: type };
		if (depot != null && type != null)
			$.ajax({
				type: "GET",
				dataType: "json",
				traditional: true,
				data: data,
				url: weightUrl,
				success: function (data) {
					var model = JSON.parse(data);

					var table = $("<table></table>").addClass("table table-hover");
					var trThed = $("<tr></tr>");

					trThed.append($("<th></th>").text("Drug Unit Id"));
					trThed.append($("<th></th>").text("Pick Number"));
					trThed.append($("<th></th>").text("Drug Type Name"));
					trThed.append($("<th></th>").text("Depot Name"));
					trThed.append($("<th></th>").text("Weight, kg"));

					table.append(trThed);

					var tbody = $("<tbody></tbody>");

					if (model.RenderDrugUnits == true) {
						$.each(model.DrugUnits, function (item) {
							var tr = $("<tr></tr>");

							tr.append($("<td></td>").text(model.DrugUnits[item].Id));
							tr.append($("<td></td>").text(model.DrugUnits[item].PickNumber));
							tr.append($("<td></td>").text(model.DrugUnits[item].DrugType.DrugTypeName));
							tr.append($("<td></td>").text(model.DrugUnits[item].Depot.DepotName));
							tr.append($("<td></td>").text(model.DrugUnits[item].DrugType.Weight));

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