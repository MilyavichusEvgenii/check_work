
(string[], int) GoodEnterMass(string massage)
{
    Console.WriteLine(massage);
    int count = 0;
    string text = Console.ReadLine() ?? "";
    char[] separator = {',', ' '};
    string[] result = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < result.Length; i++)
    {
        if(result[i].Length <= 3){
            count++;
        }
    }
    return (result, count);
}

void RecSelectMethod(string[] array, string[] temp, int a, int count)
{
    if(a == array.Length){
        return;
    } else if(array[a].Length <= 3){
        temp[count] = array[a];
        RecSelectMethod(array, temp, a + 1, count + 1);
    } else {
        RecSelectMethod(array, temp, a + 1, count);
    }
    
}

void Print(string[] array, string massage)
{
    if(array.Length == 0){
        Console.WriteLine("Массив строк не содержит элементов, включающих в себя от 1 до 3 символов");
    } else {
        Console.WriteLine(massage);
        for (int i = 0; i < array.Length; i++)
        {
            if(i == array.Length - 1){
                 Console.Write($"{array[i]}");
            } else {
                 Console.Write($"{array[i]},");
            }
           
        }
    }
}
int value = 0;
int count = 0;
(string[] getMassage, int size) = GoodEnterMass("Введите несколько строк, разделенные запятой или пробелом");
string[] result = new string[size];
RecSelectMethod(getMassage, result, value, count);
Print(result, "Массив строк содержит элементы, включающие в себя от 1 до 3 символов");