$ ->
	disableAndEnableFields()
	
	$("#btnSubmit").on "click", (event) ->		
		if $("#cardTypeDropDown").val() > '0' and $("#cardTypeDropDown").val() < '8'
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
		$("#rankDropDown").attr "disabled", true
		$("#suitDropDown").attr "disabled", true
		$("#actionField").attr "disabled", true
		$("#rangeField").attr "disabled", true
	else
		$("#rankDropDown").attr "disabled", false
		$("#suitDropDown").attr "disabled", false
		$("#actionField").attr "disabled", false
		$("#rangeField").attr "disabled", false