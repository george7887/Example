
//              0   1   2   3   4   5   6   7   8
int[] array = {11, 211, 4, 41, 18, 15, 4, 17, 18, 19};
int n = array.Length;
int find = 18;
for (int i = 0; i < n; i++)
{
    if (array[i] == find) {
        Console.WriteLine(i);
        break;
    }
}
