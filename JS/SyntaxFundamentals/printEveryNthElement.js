function printEveryNthElement(array, n)
{
    let nArray = []
    let nIndex = 0

    for(let index = 0; index < array.length; index+=n, nIndex++)
    {
        nArray[nIndex] = array[index]
    }

    return nArray
}

printEveryNthElement(['1','2','3','4','5','6'], 6)