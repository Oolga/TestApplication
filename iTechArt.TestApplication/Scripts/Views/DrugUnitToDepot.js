(function () {
	'use strict';
	var urlErrors = '../Home/MessageWindow?';
	var urlUpdate = 'http://localhost:520/api/DrugUnitToDepot/PostDrugUnitToDepot';
	var urlModel='../DrugUnitToDepot/UpdateDrugUnitToDepot';
	
	var dialogContent = $('.dialogContent');
	var modalDialog = $('.modDialog');
	var buttonSave = $('button.Save');

	modalDialog.hide();

	buttonSave.click(function () {
		try {
			var id = $(this).data("text1");
			var depot = $('select.' + id).val();
			var data = { drugUnitId: id, depotId: depot };


			$.ajax({
				type: "POST",
				url: urlUpdate,
				data:  data,	
				success:
					function () {

						$.ajax({
							type: "GET",
							traditional: true,
							url: urlModel,
							success: function (data) {

								dialogContent.html(data);
								modalDialog.modal('show');
							}

						});

						}
					});

				


			}

		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
})();