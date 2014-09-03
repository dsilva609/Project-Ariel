(function() {
  $('[id=card]').on("click", function() {
    return window.location.href = editURL + "/" + $(this).data("id");
  });

}).call(this);

//# sourceMappingURL=CardIndex.js.map
