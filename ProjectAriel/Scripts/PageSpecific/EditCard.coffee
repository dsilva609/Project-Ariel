$ ->
	disableAndEnableFields()
	
	$("#btnSubmit").on "click", (event) ->		
		if $("#cardTypeDropDown").val() > '0' and $("#cardTypeDropDown").val() < '8' and ($("#rankDropDown").val() is '0' or $("#suitDropDown").val() is '0')
			bootbox.alert "Rank and suit must be selected"
			event.preventDefault()
			
		if $("#cardTypeDropDown").val() is '0'
			bootbox.alert "Card type must be selected"
			event.preventDefault()		
		
		if $("#expansionDropDown").val() is '0'
			bootbox.alert "Expansion must be selected"
			event.preventDefault()
	
	$("#cardTypeDropDown").on "change", ->
		disableAndEnableFields()
			
disableAndEnableFields = ->
	if $("#cardTypeDropDown").val() >= "8"
		$("#rankDropDown").val(0)
		$("#rankDropDown").attr "readonly", true
		$("#suitDropDown").val(0)
		$("#suitDropDown").attr "readonly", true
		$("#actionField").attr "readonly", true
		$("#actionField").val(null)
		$("#rangeField").attr "disabled", true
	else
		$("#rankDropDown").attr "readonly", false
		$("#suitDropDown").attr "readonly", false
		$("#actionField").attr "readonly", false
		$("#rangeField").attr "disabled", false