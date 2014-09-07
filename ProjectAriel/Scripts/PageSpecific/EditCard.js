(function() {
  $(function() {
    $("#btnSubmit").on("click", function(event) {
      if ($("#cardTypeDropDown").val() > '0' && $("#cardTypeDropDown").val() < '8') {
        bootbox.alert("Rank and suit must be selected");
        event.preventDefault();
      }
      if ($("#cardTypeDropDown").val() === '0') {
        bootbox.alert("Card type must be selected");
        event.preventDefault();
      }
      if ($("#expansionDropDown").val() === '0') {
        bootbox.alert("Expansion must be selected");
        return event.preventDefault();
      }
    });
    return $("#cardTypeDropDown").on("change", function() {
      return alert("changed");
    });
  });

}).call(this);
