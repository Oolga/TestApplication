(function () {
	var first = 0;
	var count = 10;
	var countDrugUntis;
	var constCountDrugUntis;

	var previousButton = $('button#previous');

	$(document).ready(function () {
		countDrugUntis = $("#results").attr("data-model");
		countDrugUntis -= 10;
		constCountDrugUntis = countDrugUntis;
		update();
		previousButton.hide();
	});

	$('button#next').click(function () {
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
			data: { first: first, count: count },
			url: 'DepotsContent',
			dataType: "html",
			success: function (result) {
				//$('#results').html(result);

				if (countDrugUntis > 0) {
					$('button#next').show();
				}
				else {
					$('button#next').hide();
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
});