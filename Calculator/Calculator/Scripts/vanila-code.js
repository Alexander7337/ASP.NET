document.addEventListener("DOMContentLoaded", function () {
    function Addition() {
        let firstValue = +(document.getElementById("first").value);
        let secondValue = +(document.getElementById("second").value);

        let result = firstValue + secondValue;

        let resultField = document.getElementById("result");

        resultField.value = result;
    }

    function Subtaction() {
        let firstValue = +(document.getElementById("first").value);
        let secondValue = +(document.getElementById("second").value);

        let result = firstValue - secondValue;

        let resultField = document.getElementById("result");

        resultField.value = result;
    }

    function Multiplication() {
        let firstValue = +(document.getElementById("first").value);
        let secondValue = +(document.getElementById("second").value);


        let result = firstValue * secondValue;

        let resultField = document.getElementById("result");

        resultField.value = result;
    }

    function Division() {
        let firstValue = +(document.getElementById("first").value);
        let secondValue = +(document.getElementById("second").value);

        let result = firstValue / secondValue;

        let resultField = document.getElementById("result");

        resultField.value = result;
    }

    let buttonStrategyAddtion = document.getElementById("additon");
    buttonStrategyAddtion.addEventListener("click", function () {
        Addition();
    });

    let buttonStrategySubtraction = document.getElementById("subtraction");
    buttonStrategySubtraction.addEventListener("click", function () {
        Subtaction();
    });

    let buttonStrategyMultiply = document.getElementById("multiplication");
    buttonStrategyMultiply.addEventListener("click", function () {
        Multiplication();
    });

    let buttonStrategyDivide = document.getElementById("division");
    buttonStrategyDivide.addEventListener("click", function () {
        Division();
    });
});
