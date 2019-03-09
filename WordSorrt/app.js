

console.log('Word Sorrt');

var firstWord = "hand";
var finalWord = "foot";
WordSort(firstWord, finalWord);

console.log('Press any key to exit');

function ValidateWords(currentWord, nextWord)
{
    var mismatch = 0;

    for (i = 0; i < currentWord.length; i++)
    {
        if (currentWord[i] != nextWord[i]) mismatch++;
        if (mismatch > 1)
            return false;
    }
    return mismatch == 1 ? true : false;
}

function WordSort(firstWord, finalWord)
{
    var wordSet = ["bear", "band", "bond", "cars", "fond", "food", "foot", "hand", "head"];
    wordSet = wordSet.filter(x => x !== firstWord);
    var currentWord = firstWord;
    console.log(currentWord);
    var nextWord = "";

    for (var i = 0; i < wordSet.length; i++) {

        nextWord = wordSet[i];
        if (ValidateWords(currentWord, nextWord)) {
            currentWord = nextWord;
            console.log(nextWord);

            if (nextWord == finalWord)
                i = wordSet.length;
        }
    }
}