function printNames(names)
{
    names.sort()

    for (let index = 0; index < names.length; index++) 
    {
        console.log(`${++index}.${names[--index]}`)
    }
}

printNames(['John', 'Bob', 'Christina', 'Zoe'])