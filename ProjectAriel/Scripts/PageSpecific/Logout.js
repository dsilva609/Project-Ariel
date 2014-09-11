(function() {
  $(function() {
    return $("#logOffBtn").on("click", function(event) {
      bootbox.dialog({
        message: "Are you sure you want to log out?",
        buttons: {
          cancel: {
            label: "No",
            callback: function() {
              return event.preventDefault();
            }
          },
          confirm: {
            label: "Yes",
            className: "",
            callback: function() {
              return $("#logoutForm").submit();
            }
          }
        }
      });
      return event.preventDefault();
    });
  });

}).call(this);

//# sourceMappingURL=Logout.js.map
