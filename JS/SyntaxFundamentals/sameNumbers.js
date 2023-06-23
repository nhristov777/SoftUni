function sameNumbers(number)
{
    let digitString = number.toString()
    let sum = 0
    let identical = true

    for (let counter = 0; counter < digitString.length; counter++) 
    {
        sum += Number(digitString[counter])
    }

    for(let counter = 0; counter < digitString.length - 1;)
    {
        if(digitString[counter] !== digitString[++counter])
        { identical = false }
    }

    console.log(identical)
    console.log(sum)
}