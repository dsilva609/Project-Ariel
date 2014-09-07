$ ->
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
		alert "changed"
		#$("#rankDropDown").attr "disabled" , true