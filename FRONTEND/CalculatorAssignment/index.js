function add() {
    let a = parseFloat(document.getElementById("num1").value);
    let b = parseFloat(document.getElementById("num2").value);

    document.getElementById("result").innerText = "Result: " + (a + b);
}

function subtract() {
    let a = parseFloat(document.getElementById("num1").value);
    let b = parseFloat(document.getElementById("num2").value);

    document.getElementById("result").innerText = "Result: " + (a - b);
}

function multiply() {
    let a = parseFloat(document.getElementById("num1").value);
    let b = parseFloat(document.getElementById("num2").value);

    document.getElementById("result").innerText = "Result: " + (a * b);
}

function divide() {
    let a = parseFloat(document.getElementById("num1").value);
    let b = parseFloat(document.getElementById("num2").value);

    if (b === 0) {
        document.getElementById("result").innerText = "Cannot divide by zero";
    } else {
        document.getElementById("result").innerText = "Result: " + (a / b);
    }
}