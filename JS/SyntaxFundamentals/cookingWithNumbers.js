function cooking(number, ...operations)
{
    for (let index = 0; index < operations.length; index++) 
    {
        let operation = operations[index]

        switch(operation)
        {
            case 'chop':
                number /= 2
                break
            case 'dice':
                number = Math.sqrt(number)
                break
            case 'spice':
                number++
                break
            case 'bake':
                number *= 3
                break
            case 'fillet':
                number *= 0.80
                break
        }
        console.log(number)
    }
}

cooking(9, 'dice', 'spice', 'chop', 'bake', 'fillet')