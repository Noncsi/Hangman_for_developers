$("#definition-container").hide();
$("#man").children().hide();

// append letters
var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".split("");
$.each(alphabet, function (i, letter) {
    $("#letters-container").append("<button id='letter" + letter + "' class='letterToSelect'>" + letter + "</button>");
});

var lives = 6;
var randomWord = document.getElementById("script-for-data").getAttribute("data-word");
var definition = document.getElementById("script-for-data").getAttribute("data-definition");

// create blank lines
for (var i = 0; i < randomWord.length; i++) {
    if (randomWord.charAt(i) != " ") {
        $("#blank-lines").append("_");
    } else {
        $("#blank-lines").append("\u2002");
    }
};

var currentStateOfLines = document.getElementById("blank-lines").innerText;

$('.letterToSelect').click(function () {
    $(this).animate({
        opacity: 0,
    }, 300, function () { });
    $(this).css("cursor", "default");
    var guess = $(this).text();
    for (var i = 0; i < randomWord.length; i++) {
        if (randomWord[i].toUpperCase() == guess) { // success
            currentStateOfLines = currentStateOfLines.substring(0 - 1, i) + guess + currentStateOfLines.substring(i + 1, randomWord.length);
            $('#blank-lines').text(currentStateOfLines);
            if (currentStateOfLines.includes("_")) { }
            else {                 
                $("#definition").append(definition);
                $("#definition-container").show();
                $("#win-modal").modal({ backdrop: 'static', keyboard: false });
            }
        }
    }
    if (currentStateOfLines.includes(guess)) { }
    else { // fail
        lives--;
        $("ul").each(function (index) {
            $("ul").find("li:eq(" + Math.abs(lives - 5) + ")").show();
        });
        if (lives == 0) {
            $("#lose-word").append("The word is: " + randomWord);
            $("#game-over-modal").modal({ backdrop: 'static', keyboard: false });
        }
    }
});

