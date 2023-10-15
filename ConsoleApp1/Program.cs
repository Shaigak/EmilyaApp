//#region task 1
//int[] numbers = {1, 2, 3};
//int sum=0;
////for (int i=0; i<numbers.Length;i++) 
////{
////    sum+=numbers[i];

////}
////Console.WriteLine(sum);

//foreach (int num in numbers)
//{
//    sum += num;
//}
//Console.WriteLine(sum);
//#endregion

//#region task 2
//int[] numbers = { 1, 15, 3, 30 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] >= 10)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}
//#endregion
//#region task 3

//int[] numbers = {1,2,3,4,5};
//int sum=0;

//foreach (int num in numbers)
//{
//    sum += num;
//}
//Console.WriteLine(sum/numbers.Length);

//#endregion
//#region task4
//string[] seazon = { "January", "March", "May", "Yuly" };

//foreach (string item in seazon)
//{
//    if (item == "March" || item == "April" || item == "May")
//    {
//        Console.WriteLine("Qis aylaridir");
//    }


//}

//#endregion 

//#region/15.10.23 task 1

//int[] array = { 1, 3, 55, 6, 33 };
//int result = 1;

//foreach (var item in array)
//{
//    if (item <= 20 & item > 1)
//    {
//        result *= item;

//    }

//}
//Console.WriteLine(result);

//#endregion

//#region/15.10.23 task 2

//int[] array = { 1, 3, 55, 6, 33, 12 };
//int cemi = 0;
//int kvadrat = 0;

//foreach (var item in array)
//{
//    if (item %2 == 0)
//    {
//        cemi += item;
//        kvadrat= cemi*cemi;  
//    }  
//}
//Console.WriteLine(kvadrat);

//#endregion

//#region/15.10.23 task 3

//int n = 2;
//int m = 35;
//int result = 0;

//if (n % 2 == 0 && m % 2 == 0)
//{
//    result = n + m;
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Cud deyil");
//}
//#endregion

#region/15.10.2023 task4

int n = 5;
int sum = 1;

for (int i = 1; i <= n; i++)
{
    sum *= i;  
}
Console.WriteLine(sum);

#endregion
