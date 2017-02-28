(function () {

	'use strict';
	var first = 0;
	var count = 10;
	var countDrugUntis;
	var constCountDrugUntis;

	var previousButton = $('button#previous');
	var nextButton = $('button#next');

	$(document).ready(function () {
		countDrugUntis = $("#results").attr("data-model");
		countDrugUntis -= 10;
		constCountDrugUntis = countDrugUntis;
		if (!isNaN(countDrugUntis)) 
			update();

		previousButton.hide();
	});

	nextButton.click(function () {

		if (countDrugUntis > 0) {
			first += 10;
			countDrugUntis -= 10;
			update();
		}
	});

	previousButton.click(function () {
		if (constCountDrugUntis != countDrugUntis) {
			first -= 10;
			countDrugUntis += 10;
			update();
		}
	});

	function update() {
		$.ajax({
			type: "GET",
			dataType: "json",
			data: { first: first, count: count },
			url: '../Depots/DepotsContent',
			success: function (data) {
				var model = JSON.parse(data);

				var table = $("<table></table>").addClass("table table-hover");
				var trThed = $("<tr></tr>");

				trThed.append($("<th></th>").text("Depot Name"));
				trThed.append($("<th></th>").text("Country Name"));
				trThed.append($("<th></th>").text("Drug Type Name"));
				trThed.append($("<th></th>").text("Drug Unit Id"));
				trThed.append($("<th></th>").text("Pick Number"));


				table.append(trThed);

				var tbody = $("<tbody></tbody>");

				if (model.RenderDepots == true) {
					$.each(model.Depots, function (item) {
						if (model.RenderDrugUnits==true) {

							$.each(model.DrugUnits, function (unit) {
								var tr = $("<tr></tr>");
								if (model.DrugUnits[unit].DepotId == model.Depots[item].Id) {
									tr.append($("<td></td>").text(model.Depots[item].DepotName));
									tr.append($("<td></td>").text(model.Depots[item].CountryName));
									tr.append($("<td></td>").text(model.DrugUnits[unit].DrugTypeName));
									tr.append($("<td></td>").text(model.DrugUnits[unit].Id));
									tr.append($("<td></td>").text(model.DrugUnits[unit].PickNumber));
								}

								tbody.append(tr);
							})
						}
						else {
							var tr = $("<tr></tr>");
							tr.append($("<td></td>").text(model.Depots[item].DepotName));
							tr.append($("<td>empty</td>"));
							tr.append($("<td>empty</td>"));
							tr.append($("<td>empty</td>"));
							tr.append($("<td>empty</td>"));
							tr.append($("<td>empty</td>"));
							tbody.append(tr);
						}
					})

				}
				table.append(tbody);

				$('#results').html(table);


				if (countDrugUntis > 0) {
					nextButton.show();
				}
				else {
					nextButton.hide();
				}

				if (constCountDrugUntis == countDrugUntis) {
					previousButton.hide();
				}
				else {
					previousButton.show();
				}
			}
		});
	};
})();