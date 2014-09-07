$ ->
	$("#btnSubmit").on "click", (event) ->
		if $("#cardTypeDropDown").val() == '0' or $("#rankDropDown").val() == '0' or $("#suitDropDown").val() == '0' or $("#expansionDropDown").val() == '0'
			$("#validationModal").modal()
			event.preventDefault()