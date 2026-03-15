using System.ComponentModel.Design;

int i = 1;
while (i <= 100)
{
	if (i % 2 == 0 && i % 7 == 0)
	{
		Console.WriteLine(i + " ParSiete");
	}
	else if (i % 2 == 0)
	{
		Console.WriteLine(i + " Par");
	}
	else if (i % 7 == 0)
	{
		Console.WriteLine(i + " Siete");
	}
	else {
		Console.WriteLine(i);
    }
    i++;
}