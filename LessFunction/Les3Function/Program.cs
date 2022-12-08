// Урок 3 функции в  програмировании. метод
// Методы. Вид 1. Не принимают не возвращают.
// void Method1()
{
    Console.WriteLine("Автор...");
}

// Как вызвать метод

// Method1();


// вид 2 Метод принимает но не возвращает 

 void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
Method21(msg:"Текст", count:4);

//вид 3 Метод который что то возвращает но не принимает. Указываем тип данных значение которого ты ожидаем int


int Method3()
{

    return DateTime.Now.Year;
}

// Вызвать метод можно набрав идентификатор  (int) 

int year = Method3 ();
Console.WriteLine(year);


// Вид 4 что-то принмимают и возвращают
string Method4 (int count, string text)


{

int i = 0;
string result = String.Empty;

 while (i < count)
  {
    result = result + text;
    i++;
  }
return result;

}

string res = Method4(10, "z");
Console.WriteLine(res);

