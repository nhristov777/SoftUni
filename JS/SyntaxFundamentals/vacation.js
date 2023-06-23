function vacationPrice(people, groupType, day)
{
    let price = 0
    let totalPrice = 0
    
    switch(groupType)
    {
        case 'Students':
            if(day === 'Friday')
            {
                price = 8.45
            }
            else if(day === 'Saturday')
            {
                price = 9.80
            }
            else if(day === 'Sunday')
            {
                price = 10.46
            }

            totalPrice = people * price

            if(people >= 30)
            {
                totalPrice *= 0.85
            }
        break;

        case 'Business':
            if(day === 'Friday')
            {
                price = 10.9
            }
            else if(day === 'Saturday')
            {
                price = 15.6
            }
            else if(day === 'Sunday')
            {
                price = 16
            }

            totalPrice = people * price

            if(people >= 100)
            {
                totalPrice -= price * 10
            }
        break;

        case 'Regular':
            if(day === 'Friday')
            {
                price = 15
            }
            else if(day === 'Saturday')
            {
                price = 20
            }
            else if(day === 'Sunday')
            {
                price = 22.5
            }

            totalPrice = people * price

            if(people >= 10 && people <= 20)
            {
                totalPrice *= 0.95
            }       

        break;
        }

        console.log('Total price: ' + totalPrice.toFixed(2))
}