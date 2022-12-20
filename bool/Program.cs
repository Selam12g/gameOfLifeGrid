// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
Console.WriteLine("Hello, World!");
bool[,] gameOfLifeGrid = new bool[20, 20];
randomizeGrid(gameOfLifeGrid);
PrintGrid(gameOfLifeGrid);
void PrintGrid(bool[,] grid)
{
    for (int x = 0; x < grid.GetLength(0); x++)
    {
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            char charactertoprint = grid[x, y] ? 'x' : '.';
            Console.Write(charactertoprint);
        }
        Console.WriteLine();
    }
}

void randomizeGrid(bool[,] grid)
{
    Random random= new Random();
    for (int x = 0; x < grid.GetLength(0); x++)
    {
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            if (random.Next() % 2 == 0)
            {
                grid[x, y] = true;
            }
            else
            {
                grid[x, y] = false;
            }
        }

    }
}
int howManyNeighbours(bool[,] grid, int x, int y)
{
    int howManyNeighbours =0;
    int sizeX = grid.GetLength(0);
    int sizeY = grid.GetLength(1);
    for (int i = -1; i <= 1; i++)
    {
        for (int j = -1; j <= 1; j++)
        {
            if(i == 0 && j == 0)
            {
                continue;
            }
            int neighborX =(x + i + sizeX ) % sizeX;
            int neighborY =(y + j + sizeY ) % sizeY;
            if (grid[neighborX, neighborY])
            {
                howManyNeighbours++;
            }
        }
    }
    return howManyNeighbours;
}