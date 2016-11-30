document.addEventListener("DOMContentLoaded", function () {

    let buttonAddtion = document.getElementById("btnAdd");
    buttonAddtion.addEventListener("click", function () {

        let firstValue = +(document.getElementById("txtValue1").value);
        let secondValue = +(document.getElementById("txtValue2").value);
        console.log(firstValue);
        console.log(secondValue);
        console.log(firstValue + secondValue);

        let arg = "firstNumber=" + firstValue + "&secondNumber=" + secondValue;

        let urlString = "/api/math/Add/?" + arg;

        $.ajax({
            url: urlString,
            type: "GET",
            dataType: "json",
            success: function (result) {
                $("#txtResult").val(result);

            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                $("#txtResult").val(err.Message)
            }
        });
    });

    let buttonSubstract = document.getElementById("btnMinus");
    buttonSubstract.addEventListener("click", function () {

        let firstValue = +(document.getElementById("txtValue1").value);
        let secondValue = +(document.getElementById("txtValue2").value);
        console.log(firstValue);
        console.log(secondValue);
        console.log(firstValue + secondValue);

        let arg = "firstNumber=" + firstValue + "&secondNumber=" + secondValue;

        let urlString = "/api/math/Substract/?" + arg;

        $.ajax({
            url: urlString,
            type: "GET",
            dataType: "json",
            success: function (result) {
                $("#txtResult").val(result);

            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                $("#txtResult").val(err.Message)
            }
        });
    });

    let buttonMultiply = document.getElementById("btnMultiply");
    buttonMultiply.addEventListener("click", function () {

        let firstValue = +(document.getElementById("txtValue1").value);
        let secondValue = +(document.getElementById("txtValue2").value);
        console.log(firstValue);
        console.log(secondValue);
        console.log(firstValue + secondValue);

        let arg = "firstNumber=" + firstValue + "&secondNumber=" + secondValue;

        let urlString = "/api/math/Multiply/?" + arg;

        $.ajax({
            url: urlString,
            type: "GET",
            dataType: "json",
            success: function (result) {
                $("#txtResult").val(result);

            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                $("#txtResult").val(err.Message)
            }
        });
    });


    let buttonDivide = document.getElementById("btnDivide");
    buttonDivide.addEventListener("click", function () {

        let firstValue = +(document.getElementById("txtValue1").value);
        let secondValue = +(document.getElementById("txtValue2").value);
        console.log(firstValue);
        console.log(secondValue);
        console.log(firstValue + secondValue);

        let arg = "firstNumber=" + firstValue + "&secondNumber=" + secondValue;

        let urlString = "/api/math/Divide/?" + arg;

        $.ajax({
            url: urlString,
            type: "GET",
            dataType: "json",
            success: function (result) {
                $("#txtResult").val(result);

            },
            error: function (xhr, status, error) {
                var err = eval("(" + xhr.responseText + ")");
                $("#txtResult").val(err.Message)
            }
        });
    });
});