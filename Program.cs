// 1. Создать базовый массив
// 2. Создать основной массив
// 3. Заполнить основной массив случайными элементами из базового
// 4. Решить основную задачу (по блок-схеме)
// 5. Вывести результат в консоль

string[] baseArray = new string[]
{
    "Самара", "Омск", "Казань", "Челябинск", "Ростов-на-Дону", "Уфа",
    "Волгоград", "Пермь", "арм", "бел", "боп", "газ", "дук", "ева",
    "зов", "орс", "чаж", "эра", "Красноярск", "Воронеж", "Саратов",
    "Краснодар", "Тольятти", "Ижевск", "Ульяновск", "Барнаул",
    "Владивосток", "бег", "гад", "ира", "лях", "мит", "мод", "сад",
    "уок", "хек", "циф", "аш", "ло", "но", "од", "он", "ра", "ре",
    "хи", "цы", "ял", "Томск", "Пенза", "Липецк", "Тула", "Киров",
    "Брянск", "Курск", "Иваново", "Сочи", "Курган", "Смоленск"
};

string[] CreateArray(int count)
{
    return new string[count];
}

void FillArray(string[] array, string[] basic, int min, int max)
{
    int length = array.Length;
    Random randomElement = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = basic[randomElement.Next(min, max)];
    }
}

string[] SolutionMainTask(string[] createdArray)
{
    int lengthOutputArray = 0;
    int lengthCreatedArray = createdArray.Length;

    for (int i = 0; i < lengthCreatedArray; i++)
    {
        if (createdArray[i].Length <= 3) lengthOutputArray++;
    }

    string[] outputArray = new string[lengthOutputArray];

    int index = 0;
    for (int j = 0; j < lengthCreatedArray; j++)
    {
        if (createdArray[j].Length <= 3)
        {
            outputArray[index] = createdArray[j];
            index++;
        }
    }

    return outputArray;
}

string PrintArray(string[] array)
{
    string result = "[";
    int lengthArray = array.Length;
    for (int i = 0; i < lengthArray; i++)
    {
        result += $"{array[i]}, ";
    }

    if (lengthArray == 0) result += "00";
    int lengthResult = result.Length;
    result = result.Remove(lengthResult - 2, 2);
    result += "]";
    return result;
}

var createdArray = CreateArray(5);
FillArray(createdArray, baseArray, 1, baseArray.Length);
var outputArray = SolutionMainTask(createdArray);
Console.WriteLine($"Основной массив -> {PrintArray(createdArray)}");
Console.WriteLine($"Сформированный массив -> {PrintArray(outputArray)}");
