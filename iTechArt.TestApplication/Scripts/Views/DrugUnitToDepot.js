(function () {
	'use strict';
	var urlErrors = 'Home/MessageWindow?';
	var dialogContent = $('#dialogContent');
	var modalDialog = $('#modDialog');
	var buttonSave = $('button#Save');

	buttonSave.click(function () {
		try {
			var id = $(this).data("text1");
			var depot = $('select#' + id).val();
			var data = { DrugUnitId: id, DepotId: depot };

			$.post('UpdateDrugUnitToDepot', $.param(data, true), function (data) {
				dialogContent.html(data);
				modalDialog.modal("show");
			});
		}
		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
});