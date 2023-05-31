$(document).ready(function () {
    var solan = $('#langui').val();
    getDecimal();
    resetOnChange();
    getOption(solan);
});

function resetOnChange() {
    $('input[name="soLanGui"], select[name="soLanGui"], input[type="radio"], input[type="checkbox"]').change(function () {
        var solan = $(this).val();
        /*
        // Ràng buộc chỉ có một phần tử duy nhất được checked/selected là true tại một thời điểm
        $('input[name="soLanGui"]').prop('checked', false);
        $('input[type="radio"]').prop('checked', false);
        $('input[type="checkbox"]').prop('checked', false);
        */
        getOption(solan);
    });
}

function getOption(solan) {
    /*
    $("select[name='soLanGui'] option[value='" + solan + "']").prop("selected", true);
    $("input[type='radio'][value='" + solan + "']").prop("checked", true);
    $("input[type='checkbox'][value='" + solan + "']").prop("checked", true);
    */
    $("select[name='soLanGui'] option").each(function () {
        if ($(this).val() === solan) {
            $(this).prop("selected", true);
        }
    });
    $("input[type='radio']").each(function () {
        if ($(this).val() === solan) {
            $(this).prop("checked", true);
        }
    });
    $("input[type='checkbox']").each(function () {
        if ($(this).val() === solan) {
            $(this).prop("checked", true);
        }
    });
}

function getDecimal() {
    const inputField = $("#soTien");
    inputField.on("input", function () {
        let inputValue = $(this).val().replaceAll(",", "").replaceAll(/[^0-9]/g, "");
        let number = 0;
        if (inputValue !== "") {
            number = parseFloat(inputValue);
        }
        $(this).val(number.toLocaleString("en-US"));
    });
}
