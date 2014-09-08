(function() {
  var disableAndEnableFields;

  $(function() {
    disableAndEnableFields();
    $("#btnSubmit").on("click", function(event) {
      if ($("#cardTypeDropDown").val() > '0' && $("#cardTypeDropDown").val() < '8' && ($("#rankDropDown").val() === '0' || $("#suitDropDown").val() === '0')) {
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
      return disableAndEnableFields();
    });
  });

  disableAndEnableFields = function() {
    if ($("#cardTypeDropDown").val() >= "8") {
      $("#rankDropDown").val(0);
      $("#rankDropDown").attr("readonly", true);
      $("#suitDropDown").val(0);
      $("#suitDropDown").attr("readonly", true);
      $("#actionField").attr("readonly", true);
      $("#actionField").val(null);
      return $("#rangeField").attr("disabled", true);
    } else {
      $("#rankDropDown").attr("readonly", false);
      $("#suitDropDown").attr("readonly", false);
      $("#actionField").attr("readonly", false);
      return $("#rangeField").attr("disabled", false);
    }
  };

}).call(this);

//# sourceMappingURL=EditCard.js.map
