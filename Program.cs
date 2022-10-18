
void PrintArray (string[] arr)
{
    int cnt = 0;
    int length = arr.Length;
    while (cnt < length)
    {
            
        Console.Write ($"{arr[cnt]}, ");
        cnt = cnt +1;
    }
}
void FillArray(string[] array)
{
   

    //  Объявление переменных
    string[] arraystr; // ссылка на массив строк
    int count; // текущее количество строк в массиве
    string str;
    string[] arraystr2; // дополнительная переменная-ссылка - сохраняет старый массив строк

    
    Console.WriteLine("Enter strings:");

    count = 0; // обнулить количество строк
    arraystr = new string[count]; // выделить память для 0 строк
        //Цикл ввода строк
    do
    {
        // Ввести строку
        str = Console.ReadLine();

        // Проверка, пустая ли строка
        if (str != "")
        {
            // если строка не пустая, то добавить строку в массив
            count++;

            // предварительно выделить память для нового массива
            // в котором на 1 элемент больше
            arraystr2 = new string[count];
            
            // скопировать старый массив в новый
            for (int i = 0; i < arraystr2.Length - 1 ; i++)
              
                arraystr2[i] = arraystr[i];
                
            // добавить последнюю введенную строку в массив arraystr2
            arraystr2[count - 1] = str;

            // перенаправить ссылку arraystr на arraystr2
           arraystr = arraystr2;
             
             
        }

    } while (str != "");

    Console.WriteLine("Source array: ");
    
    PrintArray (arraystr);// Вывод массива строк arraystr 
    //  Объявление переменных
    string [] arraystr3; // ссылка на массив строк
    int count1; // текущее количество строк в массиве
    Console.WriteLine();
    Console.WriteLine("Modified array:");

    count1 = 0; // обнулить количество строк
    arraystr3 = new string[count1]; // выделить память для 0 строк
    string [] arraystr4; // дополнительная переменная-ссылка - сохраняет старый массив строк
            
            
       
    for(int j=0; j<arraystr.Length; j++)
    {
       
        if ( arraystr[j].Length <= 3)
        {
            string str1 = arraystr[j];    
            count1++;
             // предварительно выделить память для нового массива
             // в котором на 1 элемент больше
            arraystr4 = new string[count1];
           
            // скопировать старый массив в новый
            for (int k = 0; k <  arraystr4.Length-1; k++)
            {
                if(arraystr4.Length > 1)
                { 
                arraystr4[k] = arraystr3[k];
                                              
                }
                else{
                  arraystr4[0] = str1;  
                } 
               
            }
            // добавить последнюю найденную строку в массив arraystr4
                arraystr4[arraystr4.Length-1] = str1;
            // перенаправить ссылку arraystr3 на arraystr4
                arraystr3 = arraystr4;
           
        }

    }
    PrintArray (arraystr3);
}   
int countstrings =0;
string [] array;
 array= new string[countstrings];

FillArray(array);


