// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();

// int NumberOfDigits (int number) {
//     int numOfDigits = 0;
//     while (true)
//     {
//         if(number < 10) {
//             Console.WriteLine("Вы ввели число меньше 10. Попробуйте ещё раз.");
//             Console.Write("Введите целое число большее 9: ");
//             number = Convert.ToInt32(Console.ReadLine());
//         } 
//         if(number > 9) break;       
//     }
//     int originnumber = number;
//     if(number > 9) {
//         while (true)
//         {
//             if(number < 10) {
//                 break;
//             }
//             number = number / 10;
//             numOfDigits++;
//         }
//         numOfDigits++;
//         Console.WriteLine($"Количество цифр в числе {originnumber} = {numOfDigits}");
//     }
//     return numOfDigits;
// }

// bool CheckNum(int number, int numofdigits) {
//     int n1 = 0;
//     int n2 = 0;
//     int n3 = 0;
//     int i = 1;
//     if(numofdigits % 2 == 0) {
//         n1 = number / Convert.ToInt32(Math.Pow(10, numofdigits / 2));
//         Console.WriteLine($"Первая половина числа n1 = {n1}");
//         n2 = number % Convert.ToInt32(Math.Pow(10, numofdigits / 2)); 
//         Console.WriteLine($"Вторая половина числа n2 = {n2}");
//         while(i <= numofdigits/2) {
//         n3 = n3 + n2%10*Convert.ToInt32(Math.Pow(10,numofdigits/2-i));
//         Console.WriteLine(n3);
//         n2 = n2/10;
//         i++;
//         }
//     }
//         if(numofdigits % 2 != 0) {
//         n1 = number / Convert.ToInt32(Math.Pow(10, (numofdigits + 1) / 2));
//         Console.WriteLine($"Первая половина числа n1 = {n1}");
//         n2 = number % Convert.ToInt32(Math.Pow(10, (numofdigits - 1)/ 2)); 
//         Console.WriteLine($"Вторая половина числа n2 = {n2}");
//         while(i <= numofdigits/2) {
//         n3 = n3 + n2%10*Convert.ToInt32(Math.Pow(10,numofdigits/2-i));
//         Console.WriteLine(n3);
//         n2 = n2/10;
//         i++;
//         }
//     }
//     Console.WriteLine($"Обратная правая половина числа {number} для проверки = {n3}");
//     if(n1 == n3) {
//         return true;
//     } else return false;
   
// }

// Console.Write("Введите целое число большее 9: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numofdigits = NumberOfDigits(number);

// bool result = CheckNum(number,numofdigits);
// Console.WriteLine(result);
// if(result == true) { 
//     Console.WriteLine($"Число {number} является палиндромом!");
// } else {
//     Console.WriteLine($"Число {number} не является полиндромом!");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// int[] a = {0,0,0};
// int[] b = {0,0,0};
// for(int i = 0; i < 3; i++) {
//     Console.Write("Введите координаты x,y,z точки a:");
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0; i < 3; i++) {
//     Console.Write("Введите координаты x,y,z точки b:");
//     b[i] = Convert.ToInt32(Console.ReadLine());
// }

// void Distance(int[] a, int[] b) {
//     double summa = 0;
//     for(int i = 0; i < 3; i++) {
//         summa = summa + Math.Pow((a[i] - b[i]),2);
//     }
//     double distance = Math.Sqrt(summa);
//     Console.WriteLine($"Растояние между точками a и b в 3D пространстве = {distance}");
// }

// Distance(a, b);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите положительное целое число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void CubeTable(int n) {
//     for(int i = 1; i <= n; i++) {
//         Console.WriteLine($"{i} в кубе = {Math.Pow(i,3)}");
//     }
// }

// CubeTable(n);