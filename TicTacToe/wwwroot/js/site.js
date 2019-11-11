// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var turn = "X";
var cells = document.getElementsByClassName("square");
for (i = 0; i < cells.length; i++) {
    cells[i].addEventListener("click", onCLick);
}
setTurn();
function setTurn() {
    var turnElement = document.getElementById("turn");
    turnElement.innerText = "It is player " + turn + "'s turn";
}
function setWinner(winner) {
    var turnElement = document.getElementById("turn");
    turnElement.innerText = "Player " + winner + "'s the winner";

}
function checkForwin() {
    var cells = document.getElementsByClassName("square");
    //check horizanlta
    for (var i = 0; i < 9; i += 3) {
        if (cells[0 + i].innerText && cells[1 + i].innerText === cells[2 + i].innerText) {
            setWinner(cells[i].innerText);
            return true;
        }
    }
    //ceck vertical
    for (var i = 0; i < 9; i += 3) {
        if (cells[0 + i].innerText && cells[3 + i].innerText === cells[6 + i].innerText) {
            setWinner(cells[i].innerText);
            return true;
        }
    }
    //check diagenal
    for (var i = 0; i < 9; i += 3) {
        if (cells[0 + i].innerText && cells[4 + i].innerText === cells[8 + i].innerText) {
            setWinner(cells[i].innerText);
            return true;
        }
    }

}



function onCLick(event) {
    event.preventDefault();//good practice for buttons makes you stay here
    if (!event.target.innerText) {
        event.target.innerText = turn;
        if (turn === "X") {//===is the more stricker of the two use this one.
            turn = "O";
        }
        else {
            turn = "X"
        }
        if(!checkForwin()) setTurn();
    }

}
