function leapYearCalculator(year)
{
    let trueLeap = false

    if((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0)
    { trueLeap = true }

    if(trueLeap) console.log('yes')
    else console.log('no')
}