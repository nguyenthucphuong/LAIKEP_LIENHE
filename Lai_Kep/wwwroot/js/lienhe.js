$(document).ready(function () {
  handleFormSubmit();
});

function handleFormSubmit() {
    $('#myForm').submit(function (event) {
        if (!this.checkValidity()) {
            return;
        }
        event.preventDefault();
        $('#myForm input').prop('readonly', true);
    });
}
