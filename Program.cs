string[] massive = {"hello", "2", "world", ":-)"};
int count =0;
for (int i = 0; i < massive.Length; i++)
{
    bool flag = false;
    if (massive[i].Length <4)
    {
        flag = true;
    }
    if (flag == true)
    {
        count++;
    }
}

string[] massive1 = new string [count];
count=0;
for (int i = 0; i < massive.Length; i++)
{
    bool flag = false;
    if (massive[i].Length <4)
    {
        flag = true;
    }
    if (flag == true)
    {
        massive1[count] = massive[i];
        count++;
    }
}

for (int i = 0; i < count; i++)
{
    System.Console.WriteLine(massive1[i]);    
}