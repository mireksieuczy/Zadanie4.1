Console.WriteLine("Ile chcesz wpisać Liczb?");
int rozmiar = Convert.ToInt32(Console.ReadLine());
int[] liczby = new int[rozmiar];
for (int i = 0; i < liczby.Length; i++)
{
    Console.WriteLine("Podaj {0} liczbe", i + 1);
    liczby[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
for (int i = 0; i < liczby.Length; i++)
{

    Console.Write(liczby[i] + ", ");
}

Console.ReadKey();