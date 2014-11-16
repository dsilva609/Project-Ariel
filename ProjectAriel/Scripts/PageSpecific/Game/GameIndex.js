(function() {
  Namespace("Views.Game");

  Views.Game.Index = function() {};

  Views.Game.Index = (function() {
    function Index() {}

    Index.prototype.init = function() {
      $("div#card").draggable();
      $("#droppable").draggable();
      return $("#droppable").droppable({
        tolerance: "touch",
        accept: "#card",
        drop: function(event, ui) {
          return alert("dropped");
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

//# sourceMappingURL=GameIndex.js.map
