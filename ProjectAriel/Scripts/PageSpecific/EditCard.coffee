$("#btnSubmit").on "click", (event) ->
	if $("#cardTypeDropDown").val() == '0' or $("#rankDropDown").val() == '0' or $("#suitDropDown").val() == '0'
		alert "Card type, rank, and suit must be selected"
		event.preventDefault()