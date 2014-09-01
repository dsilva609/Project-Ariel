(function() {
  $("#btnSubmit").on("click", function(event) {
    if ($("#cardTypeDropDown").val() === '0' || $("#rankDropDown").val() === '0' || $("#suitDropDown").val() === '0') {
      alert("Card type, rank, and suit must be selected");
      return event.preventDefault();
    }
  });

}).call(this);
