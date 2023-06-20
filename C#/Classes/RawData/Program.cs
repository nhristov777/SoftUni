namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            /*•	The speed, power, weight, and tire age are integers.
              • The tire pressure is a floating point number. */
            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure}
            //{tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure}
            //{tire4Age}"
            List<Car> cars = new();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //car
                string model = info[0];
                //engine
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                //cargo
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];
                //tires
                double pressure1 = double.Parse(info[5]);
                int age1 = int.Parse(info[6]);
                double pressure2 = double.Parse(info[7]);
                int age2 = int.Parse(info[8]);
                double pressure3 = double.Parse(info[9]);
                int age3 = int.Parse(info[10]);
                double pressure4 = double.Parse(info[11]);
                int age4 = int.Parse(info[12]);
                //initialize
                Car car = new(model, engineSpeed, enginePower, cargoWeight, cargoType
             , pressure1, age1, pressure2, age2, pressure3, age3, pressure4, age4);
                cars.Add(car);
            }
            string cmd = Console.ReadLine();
            if (cmd == "flammable")
                Flammable(cars);
            else if (cmd == "fragile")
                Fragile(cars);
        }
        static void Fragile(List<Car> cars)
        {
            bool fragile = false;
            cars.ForEach(c =>
            {
                if (c.Cargo.Type == "fragile")
                {
                    foreach (var tire in c.Tires)
                    {
                        if(tire.Pressure < 1)
                            fragile = true;
                    }
                }
                if (fragile) Console.WriteLine(c.Model);
            });
        }
        static void Flammable(List<Car> cars)
        {
            cars.ForEach(c =>
            {
                if (c.Cargo.Type == "flammable")
                {
                    if (c.Engine.Power > 250)
                        Console.WriteLine(c.Model);
                }
            });
        }
    }
}
