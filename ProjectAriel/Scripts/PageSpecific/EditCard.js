(function() {
  var disableAndEnableFields;

  $(function() {
    disableAndEnableFields();
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
      return disableAndEnableFields();
    });
  });

  disableAndEnableFields = function() {
    if ($("#cardTypeDropDown").val() >= "8") {
      $("#rankDropDown").attr("disabled", true);
      $("#suitDropDown").attr("disabled", true);
      $("#actionField").attr("disabled", true);
      return $("#rangeField").attr("disabled", true);
    } else {
      $("#rankDropDown").attr("disabled", false);
      $("#suitDropDown").attr("disabled", false);
      $("#actionField").attr("disabled", false);
      return $("#rangeField").attr("disabled", false);
    }
  };

}).call(this);

//# sourceMappingURL=EditCard.js.map
