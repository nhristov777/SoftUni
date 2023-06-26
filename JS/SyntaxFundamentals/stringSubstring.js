function solve(input, text)
{
    let sentence = text.split(' ')

    for (let index = 0; index < sentence.length; index++) 
    {
        let word = sentence[index].toLowerCase()
        if (word == input)
        {
            console.log(word)
            return
        }
    }
    console.log(`${input} not found!`)
}

solve('javascript', 'JavaScript is the best language in the world')