
    $('button#Save').click(function () {
    	var id = $(this).data("text1");
    	var depot = $('select#' + id).val();
    	var data = { DrugUnitId: id, DepotId: depot };

    	$.post('UpdateDrugUnitToDepot', $.param(data, true), function (data) {
    		$('#dialogContent').html(data);
    		$('#modDialog').modal("show");
    	});

    });
   