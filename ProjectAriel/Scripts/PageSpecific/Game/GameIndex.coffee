﻿#Usings	
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
	
#		$("div#droppable").draggable
#			revert: true
#			cursor: "move"
#			snap: true
#			snapMode: 'inner'
#			stack: "#card"


		$("div#card").droppable
			stack: "#card"
			drop: (event, ui) ->
				ui.draggable.appendTo this
						
		$("div#droppable").droppable 
			tolerance: "touch"
			accept: "#card"
			stack: "#card"
			snap: true
			snapMode: "inner"
			drop: (event, ui) ->
				alert "qwefghj"
				ui.draggable.appendTo this	
		
		$(".deck").on "click", ->
			alert "new card"
			
		$(".discard").on "click", ->
			alert "Send 'em to the brig!"
					     			     
                				
$(document).ready ->
	index = new Views.Game.Index
	
	index.init()	