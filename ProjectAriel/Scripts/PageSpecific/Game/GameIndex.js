(function() {
  Namespace("Views.Game");

  Views.Game.Index = function() {};

  Views.Game.Index = (function() {
    function Index() {}

    Index.prototype.init = function() {
      $("div#card").bind("dragend", function(event) {
        return $(this).css({
          top: event.offsety,
          left: event.offsetx
        });
      });
      return $("#droppable").droppable({
        tolerance: "touch",
        accept: "*",
        over: function(event, ui) {
          return alert("dropped");
        }
      });
    };

    return Index;

  })();

  $(function() {
    var index;
    index = new Views.Game.Index;
    return index.init();
  });

}).call(this);

//# sourceMappingURL=GameIndex.js.map
