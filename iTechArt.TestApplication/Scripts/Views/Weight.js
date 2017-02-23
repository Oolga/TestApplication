
    $('button#Show').click(function () {
    	var depot=$('#DepotId').val();
    	var type = $('#DrugType').val();

    	var data={depotId:depot, drugTypeId:type};
    	if (depot!=null && type!=null)
    		$('#results').load('ShowWeight?'+ $.param(data, true));
    });
