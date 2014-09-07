(function() {
  $(function() {
    $("#btnSubmit").on("click", function(event) {
      if ($("#cardTypeDropDown").val() === '0' || $("#rankDropDown").val() === '0' || $("#suitDropDown").val() === '0' || $("#expansionDropDown").val() === '0') {
        $("#validationModal").modal();
        return event.preventDefault();
      }
    });
    return $("#cardTypeDropDown").on("change", function() {
      return alert("changed");
    });
  });

}).call(this);

//# sourceMappingURL=EditCard.js.map
