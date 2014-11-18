#Usings	
Namespace("Views.Game")

#Initialization
Views.Game.Index = ->

##Implementation
class Views.Game.Index
	init: ->
		$("div#card").draggable
			revert: true,
			cursor: "move"	
	
		$("#droppable").draggable()
		
		$("#droppable").droppable 
			tolerance: "touch",
			accept: "#card",
			drop: (event, ui) ->
				alert "dropped"
				
$(document).ready ->
	index = new Views.Game.Index
	
	index.init()	