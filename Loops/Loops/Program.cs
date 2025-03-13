// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of column: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ENter a symbol: ");
string symbol = Console.ReadLine();

for(int i = 0; i < rows; i++)
{
    for (int j = 0; j < column; j++)
    {

    Console.Write(symbol);
    }
Console.WriteLine(); 
}


