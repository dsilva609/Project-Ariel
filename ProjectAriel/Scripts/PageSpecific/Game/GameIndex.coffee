#Usings	
Namespace("Views.Game")

#Initialization
Views.Game.Index = ->

##Implementation
class Views.Game.Index
	init: ->
		$("div#card").draggable
			revert: true
			cursor: "move"
			snap: true
			snapMode: "inner"
			stack: "#card"
	
		$("div#droppable").draggable
			revert: true
			cursor: "move"
			snap: true
			snapMode: 'inner'
			stack: "#card"

		$("div#card").droppable
			stack: "#card"
			drop: (event, ui) ->
				ui.draggable.appendTo this
						
		$("#droppable").droppable 
			tolerance: "touch"
			accept: "#card"
			stack: "#card"
			snap: true
			snapMode: "inner"
			drop: (event, ui) ->
				ui.draggable.appendTo this				     
                				
$(document).ready ->
	index = new Views.Game.Index
	
	index.init()	