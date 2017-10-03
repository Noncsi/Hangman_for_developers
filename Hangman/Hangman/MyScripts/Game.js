var lives = 5;

// append letters
var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".split("");
$.each(alphabet, function (i, letter) {
    $("#letters-container").append("<button id='letter" + letter + "' class='letterToSelect'>" + letter + "</button>");
});

// get random word
var randomPair = testObject[Math.floor(Math.random() * testObject.length)];
var randomWord = randomPair[0];
var definition = randomPair[1];
$('#word').append(randomWord);

// create blank lines
for (var i = 0; i < randomWord.length; i++) {
    if (randomWord.charAt(i) != " ") {
        $("#blank-lines").append("_");
    } else {
        $("#blank-lines").append("\u2002");
    }
};

var currentStateOfLines = $("#blank-lines").text();

// put letter to the right place
$('.letterToSelect').click(function () {
    $(this).animate({
        opacity: 0,
    }, 300, function () { });
    $(this).css("cursor", "default");
    var guess = $(this).text();
    for (var i = 0; i < randomWord.length; i++) {
        if (randomWord[i].toUpperCase() == guess) {
            currentStateOfLines = currentStateOfLines.substring(0-1, i) + guess + currentStateOfLines.substring(i+1, randomWord.length);
            $('#blank-lines').text(currentStateOfLines);
        }
    }
});

