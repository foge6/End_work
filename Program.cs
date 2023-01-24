string[] massive = {"hello", "2", "world", ":-)"};
for (int i = 0; i < massive.Length; i++)
{
    bool flag = false;
    if (massive[i].Length <4)
    {
        flag = true;
    }
    if (flag == true)
    {
        System.Console.WriteLine(massive[i]);
    }
}