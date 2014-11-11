﻿#Usings
Namespace "Views.Player"

#Implementation
Views.Player.Index = ->

#Implementation
class Views.Player.Index
	init: ->
		$('[id=player]').on "click", ->
			window.location.href = redirectURL + "/" + $(this).data "id"
	
		$('[id=delete]').on "click", ->
			ID = $(this).data "id"
	
			bootbox.dialog 
				message: "Are you sure you want to remove this player?",
				buttons: 
					cancel: 
						label: "No"
					confirm: 
						label: "Yes"
						className: "btn-danger"
						callback: ->
							window.location.href = deleteURL + "/" + ID
			return false
			
$ ->
	index = new Views.Player.Index
	
	index.init()