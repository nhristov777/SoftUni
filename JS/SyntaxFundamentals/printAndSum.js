function sum(start, end)
{
    let sum = 0
    let numbers = []
    let counter = 0

    for(let i = start; i <= end; i++)
    {
        numbers[counter] = i
        sum += i
        counter++
    }

    console.log(numbers.join(' '))
    console.log('Sum: ' + sum)
    
}