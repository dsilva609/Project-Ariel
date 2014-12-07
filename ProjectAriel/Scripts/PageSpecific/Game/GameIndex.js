(function() {
  Namespace("Views.Game");

  Views.Game.Index = function() {};

  Views.Game.Index = (function() {
    function Index() {}

    Index.prototype.init = function() {
      $("div#card").draggable({
        revert: true,
        cursor: "move"
      });
      $("div#droppable").draggable({
        revert: true,
        cursor: "move"
      });
      return $("#droppable").droppable({
        tolerance: "touch",
        accept: "#card",
        stack: "#card",
        drop: function(event, ui) {
          alert("dropped");
          return $("<li></li>", {
            "text": ui.draggable.text()
          }).appendTo(this);
        }
      });
    };

    return Index;

  })();

  $(document).ready(function() {
    var index;
    index = new Views.Game.Index;
    return index.init();
  });

}).call(this);
