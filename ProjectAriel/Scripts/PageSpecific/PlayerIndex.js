(function() {
  $('[id=player]').on("click", function() {
    return window.location.href = editURL + "/" + $(this).data("id");
  });

}).call(this);
