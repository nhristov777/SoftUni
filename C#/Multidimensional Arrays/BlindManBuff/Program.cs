int[] size = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];
char[,] playground = new char[rows, cols];
//B - me, O - obstacles, P - players (3x), - , free space
ReadMatrix(playground);
int opps = 0;
int moves = 0;
int row = 0;
int col = 0;
FindMyself(playground, ref row, ref col);

string direction = Console.ReadLine();
while (direction != "Finish" && opps < 3)
{
    switch (direction)
    {
        case "up":
            row--;
            break;
        case "down":
            row++;
            break;
        case "left":
            col--;
            break;
        case "right":
            col++;
            break;
    }
    if (row < rows && col < cols && row >= 0 && col >= 0)
    {
        if (playground[row, col] == 'O')
        {
            StayInsideField(direction,ref row,ref col);
        }
        else if (playground[row, col] == '-')
        { moves++; }
        else if (playground[row, col] == 'P')
        { moves++; opps++; playground[row, col] = '-'; }
    }
    else StayInsideField(direction, ref row, ref col);

    direction = Console.ReadLine();
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opps} Moves made: {moves}");

static void ReadMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string info = Console.ReadLine();
        string data = info.Replace(" ", "");
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = data[col];
        }
    }
}

static void FindMyself(char[,] matrix, ref int row, ref int col)
{
    for (row = 0; row < matrix.GetLength(0); row++)
    {
        for (col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col] == 'B')
            {
                matrix[row, col] = '-';
                return;
            }
        }
    }
}

static void StayInsideField(string direction, ref int row, ref int col)
{
    switch (direction)
    {
        case "up":
            row++;
            break;
        case "down":
            row--;
            break;
        case "left":
            col++;
            break;
        case "right":
            col--;
            break;
    }
}
