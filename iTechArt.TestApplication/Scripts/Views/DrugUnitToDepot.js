
    $('button#Save').click(function () {
    	var id = $(this).data("text1");
    	var depot = $('select#' + id).val();
    	var data = {DrugUnitId:id, DepotId:depot};

    	$('#dialogContent').load('UpdateDrugUnitToDepot?' + $.param(data, true));
    	$('#modDialog').modal("show");
    });
