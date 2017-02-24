(function () {
	'use strict';
	var weightUrl = 'ShowWeight?';

	$('button#Show').click(function () {
		try{
		var depot = $('#DepotId').val();
		var type = $('#DrugType').val();

		var data = { depotId: depot, drugTypeId: type };
		if (depot != null && type != null)
			$('#results').load(weightUrl + $.param(data, true));
	}
		catch (e)
	{
			$.get(urlErrors + $.param({message:'name: '+e.name+' message: '+e.message},true));
}
	});
})();