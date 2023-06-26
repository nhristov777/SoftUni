function extractHashtags(sentence)
{
    let sentenceArray = sentence.split(' ')

    let numbers = ['1', '2', '3','4' , '5', '6','7' ,'8', '9', '0']

    for(let index = 0; index < sentenceArray.length; index++)
    {
        

        if(sentenceArray[index].includes('#') && sentenceArray[index].length > 1 && sentenceArray[index].match(/#[a-zA-Z]+/))
        {
            let specialWord = sentenceArray[index].substring(1)
            console.log(specialWord)
        }
    }
}

extractHashtags('# #sex #13da')