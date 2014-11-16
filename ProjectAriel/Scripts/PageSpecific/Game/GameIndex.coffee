#Usings	
Namespace("Views.Game")

#Initialization
Views.Game.Index = ->

##Implementation
class Views.Game.Index
	init: ->
		$("div#carddsa").draggable()
	
		$("#droppable").draggable()
		
		$("#droppable").droppable 
			tolerance: "touch",
			accept: "*",
			drop: (event, ui) ->
				alert "dropped"
				
$(document).ready ->
	index = new Views.Game.Index
	
	index.init()	