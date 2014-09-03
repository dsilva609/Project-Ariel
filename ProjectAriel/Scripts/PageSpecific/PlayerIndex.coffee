$('[id=player]').on "click", ->
	window.location.href = editURL + "/" + $(this).data "id"