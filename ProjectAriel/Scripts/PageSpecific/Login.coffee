$ ->
	$("#logOffBtn").on "click", (event) ->
		bootbox.dialog 
			message: "Are you sure you want to log out?",
			buttons: 
				cancel: 
					label: "No"
					callback: ->
						event.preventDefault()
				confirm: 
					label: "Yes"
					className: ""
					callback: ->
						$("#logoutForm").submit()
		event.preventDefault()
						