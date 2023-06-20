string[] input = Console.ReadLine().Split(",");
var bank = new Dictionary<string, decimal>();
foreach (var account in input)
{
    string[] split = account.Split("-");
    string bankName = split[0];
    decimal bankBalance = decimal.Parse(split[1]);
    bank.Add(bankName, bankBalance);
}
string cmdInput = Console.ReadLine();
while (cmdInput != "End")
{
    string[] cmd = cmdInput.Split(" ");
    string command = cmd[0];
    string accNumber = cmd[1];
    decimal accBalance = decimal.Parse(cmd[2]);
    try
    {
        switch (command)
        {
            case "Deposit":
                Deposit(accNumber, accBalance, bank);
                Console.WriteLine($"Account {accNumber} has new balance: {bank[accNumber]:F2}");
                break;
            case "Withdraw":
                Withdraw(accNumber, accBalance, bank);
                Console.WriteLine($"Account {accNumber} has new balance: {bank[accNumber]:F2}");
                break;
            default:
                Console.WriteLine("Invalid command!");
                break;
        }
    }
    catch (KeyNotFoundException)
    { Console.WriteLine("Invalid account!"); }
    catch (ArgumentException ex)
    { Console.WriteLine(ex.Message); }
    finally { Console.WriteLine("Enter another command"); }
    cmdInput = Console.ReadLine();
}


static void Deposit(string accNumber, decimal balance, Dictionary<string, decimal> bank)
{ bank[accNumber] += balance; }
static void Withdraw(string accNumber, decimal balance, Dictionary<string, decimal> bank)
{
    if (bank[accNumber] < balance)
    { throw new ArgumentException("Insufficient balance!"); }
    bank[accNumber] -= balance;
}