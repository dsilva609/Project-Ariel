(function() {
  $('[id=player]').on("click", function() {
    return window.location.href = redirectURL + "/" + $(this).data("id");
  });

  $('[id=delete]').on("click", function() {
    var ID;
    ID = $(this).data("id");
    bootbox.dialog({
      message: "Are you sure you want to remove this player?",
      buttons: {
        cancel: {
          label: "No"
        },
        confirm: {
          label: "Yes",
          className: "btn-danger",
          callback: function() {
            return window.location.href = deleteURL + "/" + ID;
          }
        }
      }
    });
    return false;
  });

}).call(this);
