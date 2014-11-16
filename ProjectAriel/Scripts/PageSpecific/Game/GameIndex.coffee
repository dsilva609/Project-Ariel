#Usings	
Namespace("Views.Game")

#Initialization
Views.Game.Index = ->

#Implementation
class Views.Game.Index
	init: ->
		$("div#card").bind "dragend", (event) ->
		#	alert "clicked"
			
			$(this).css
				top: event.offsety,
				left: event.offsetx
		
		$("#droppable").droppable 
			tolerance: "touch",
			accept: "*",
			over: (event, ui) ->
				alert "dropped"
				
$ ->
	index = new Views.Game.Index
	
	index.init()