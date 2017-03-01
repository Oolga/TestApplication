(function () {

	'use strict';
	var first = 0;
	var count = 10;
	var countDrugUntis;
	var constCountDrugUntis;

	var previousButton = $('button.previous');
	var nextButton = $('button.next');
	var results = $(".results");
	var tableTemplate = $("#depotsTableTemplate");

	var urlGetDepots = '../Depots/DepotsContent';

	$(document).ready(function () {
		countDrugUntis = results.attr("data-model");
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

	function renderTable(model) {

		results.empty();

		tableTemplate.tmpl(model)
		.appendTo(results);

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

	};

	function update() {
		var data={ first: first, count: count };
		requests.requestGET(urlGetDepots, data, renderTable);
	};
})();