using salador.Core;

int[] check = { 2, 2, 1, 5 };
List<int> repeats = ClassRepeats.FindRepeat(check);
foreach (int i in repeats)
{
    Console.WriteLine(i);
}
