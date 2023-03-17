count = 0
for (var i = 0; i < 9; i++) {
    count = 9 * i;
    document.getElementsByClassName("box")[i].innerHTML = "<div class='cell'><input type='text' id='" + (count + 1) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 2) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 3) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 4) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 5) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 6) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 7) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 8) + "' class='input'></div><div class='cell'><input type='text' id='" + (count + 9) + "' class='input'></div>"
}

var choosen;

//hard level board create
hard_board = ['---789-----75-8-4---38-----8---1---6---7-9---2---7---1-----61---5-3-42-----439---', '-6------2---9-83----6--3-79----368---2-----4---461----75-8--4----51-7---2------8-', '-8-------4---15--3---69-----2-73-1----9-----2-6----------19--875--9-2-1--2-835---', '----578------3--19---3---75-5-2-8--4------6---1-7-24---7----6----142---3---9--3--', '--346-5-------------9-4-8--5-9---18----4-3--7-------7--4--------9--81--6-3-71----'];

hard = ['165789432297518346973821654847312596463729158284675931923546178851364297615439782', '861794532617948325156283479492536871928365147784619253753812496345127968239574681', '187256349428715963534691872924738156619483572861247395356194287573962418729835641', '143657892526738419984361275956238174843591627315782469872149635791426583267954318', '783461592318627954179246835569732184625493817246358971142958673497581326835719264'];


function start() {
    var hard_random = Math.floor(Math.random() * 5);
    choosen = hard_random;
    for (var i = 0; i < 81; i++) {
        if (hard_board[hard_random][i] != '-') {
            document.getElementById((i + 1).toString()).value = hard_board[hard_random][i];
            document.getElementById((i + 1).toString()).readOnly = true;
        }
    }
}

//Solve
function solve() {
    var curentValue = "";
    var isSuccess = true;
    for (var i = 0; i < 81; i++) {
        curentValue = document.getElementById((i + 1).toString()).value;
        if (curentValue !== "" && curentValue !== hard[choosen][i]) {
            isSuccess = false;
            document.getElementById((i + 1)).style.color = "red";
        }
        else { document.getElementById((i + 1).toString()).value = hard[choosen][i]; }
    }
    SaveResult(isSuccess);
    if (!isSuccess) {
        toastr.error("Cannot Resolve");
    }
    else {
        toastr.success('Success messages');
    }
}

//new game
function refersh() {
    for (var i = 0; i < 81; i++) {
        document.getElementById((i + 1).toString()).value = '';
        document.getElementById((i + 1)).style.color = "white";
    }
    start();
}


//Auto random number after dom ready
$(document).ready(function () {
    start();
});

function SaveResult(isSuccess) {

    fetch('http://localhost:5058/AddSolutionResult', {
        method: 'POST',
        body: isSuccess,
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(data => {
            console.log('Data saved successfully!');
        })
        .catch(error => {
            console.error(error);
        });
}