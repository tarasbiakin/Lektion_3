// Условное разделение метов

//1 Ничего не принимет и ничего не выдает

void Method1()
{
Console.WriteLine("Автор текста...");
}

// Вызов метода
// Method1();

//1 Ничего не возвращает, но принимает некоторые аргументы

void Method2(string msg)
{
Console.WriteLine(msg);
}
//Method2("Текст сообщения");

//С именованным аргументом

void Method21(string msg,int count)
{
int i=0;
while(i<count)
{
Console.WriteLine(msg);
i++;
}

}
//Вызов с именованными аргументами, не обязательно их по порядку вызывать 
//Method21(msg:"Текст ",4);

//3. Возвращают, но ничео не принимают

int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//4. методы которые принимают и возвращают значения

string Method4(int count, string text)
{
int i =0;
string result = string.Empty;
while(i<count)
{
    result= result+text;
    i++;
}
return result;
}
string res =  Method4(10, "ттппр ");
Console.WriteLine(res);

