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
			var data ={ drugUnitId: id, depotId: depot };
			debugger;

			//$.ajax({
			//	type: "POST",
			//	url: urlUpdate,
			//	data: data,
				
			//	success:
			//		function (data) {
			//			debugger;
			//			$.ajax({
			//				type: "GET",
			//				traditional: true,
			//				url: urlModel,
			//				success: function (data) {
			//					debugger;
			//					dialogContent.html(data);
			//					modalDialog.modal('show');
			//				}

			//			});


			$.post(urlUpdate, $.param(data, true), function (data) {
				debugger;
				$.ajax({
					type: "GET",
					traditional: true,
					url: urlModel,
					success: function (data) {
						debugger;
						dialogContent.html(data);
						
					}
				});
				modalDialog.modal('show');
				//$.get(urlModel,true);
				//dialogContent.html(data);

			});
		}
		catch (e)
		{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
		}
	});
})();