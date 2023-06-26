function revealSentence(words, sentence)
{
    let wordsArray = words.split(', ')

    let sentenceArray = sentence.split(' ')
    let revealIndex = 0
    let revealLength = 0

    for(let index = 0; index < sentenceArray.length; index++)
    {
        if(sentenceArray[index].includes('*'))
        {
            revealIndex = index
            revealLength = sentenceArray[index].length

            for(let index2 = 0; index2 < wordsArray.length; index2++)
        {
            if(wordsArray[index2].length === revealLength)
            {
                sentenceArray[revealIndex] = wordsArray[index2]
            }
        }
        }

    }

    console.log(sentenceArray.join(' '))
}