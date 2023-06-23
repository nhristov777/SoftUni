function digitsSum(number)
{
    let digitString = number.toString()
    let sum = 0

    for (let counter = 0; counter < digitString.length; counter++) 
    {
        sum += Number(digitString[counter])
    }

    console.log(sum)
}