(function() {
  Namespace("Views.Card");

  Views.Card.Index = function() {};

  Views.Card.Index = (function() {
    function Index() {}

    Index.prototype.init = function() {
      $('[id=card]').on("click", function() {
        return window.location.href = redirectURL + "/" + $(this).data("id");
      });
      return $('[id=delete]').on("click", function() {
        var ID;
        ID = $(this).data("id");
        bootbox.dialog({
          message: "Are you sure you want to delete this card?",
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
    };

    return Index;

  })();

  $(function() {
    var index;
    index = new Views.Card.Index;
    return index.init();
  });

}).call(this);
