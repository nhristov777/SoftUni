namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                double fuelAmount = double.Parse(info[1]);
                double fuelRate = double.Parse(info[2]);
                Car car = new(model, fuelAmount, fuelRate);
                cars.Add(car);
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmd = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = cmd[1];
                double travel = double.Parse(cmd[2]);
                Drive(model, travel, cars);
                input = Console.ReadLine();
            }
            cars.ForEach(c => Console.WriteLine($"{c.Model} {c.FuelAmount:F2} {c.Distance}"));
        }
        static void Drive(string model, double travel, List<Car> cars)
        {
            foreach (var car in cars)
            {
                double kmsNeeded = car.FuelRate * travel;
                if (car.Model == model)
                {
                    if (car.FuelAmount < kmsNeeded)
                        Console.WriteLine("Insufficient fuel for the drive");
                    else
                    { car.FuelAmount -= kmsNeeded; car.Distance += travel; }
                }
            }
        }
    }
}
