function rotateArray(array, rotations)
{//1 2 3 4 5 6
    for(let rotation = 1; rotation <= rotations; rotation++)
    {
            let firstElement = array.shift()
            array.push(firstElement)
    }
    
    console.log(array.join(' '))
}

rotateArray([32, 21, 61, 1], 4)