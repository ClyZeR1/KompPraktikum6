using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
//            Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции
//            Random random = new Random();
//            int chislo = random.Next(10, 99);
//            Console.WriteLine($"Случайное число = {chislo}");
//            string result = (chislo % 2 == 0) ? "четное" : "нечетное";
//            Console.WriteLine($"Число {chislo} - {result}.");

//            Дано целое число n, указывающее номер дня недели от 1 до 7.По указанному номеру n вывести название соответствующего дня недели
//                                    Console.WriteLine("Введите номер дня недели (1-7):");
//            int n = int.Parse(Console.ReadLine());

//            switch (n)
//            {
//                case 1:
//                    Console.WriteLine($"Понедельник ({n})");
//                    break;
//                case 2:
//                    Console.WriteLine($"Вторник ({n})");
//                    break;
//                case 3:
//                    Console.WriteLine($"Среда ({n})");
//                    break;
//                case 4:
//                    Console.WriteLine($"Четверг ({n})");
//                    break;
//                case 5:
//                    Console.WriteLine($"Пятница ({n})");
//                    break;
//                case 6:
//                    Console.WriteLine($"Суббота ({n})");
//                    break;
//                case 7:
//                    Console.WriteLine($"Воскресенье ({n})");
//                    break;
//                default:
//                    Console.WriteLine("Выберите номер от 1 до 7.");
//                    break;
//            }


//            Console.ReadKey();
//        }
//    }
//}
//Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели
//                                    Random random = new Random();
//int dayNumber = random.Next(1, 8);

//string dayName;

//switch (dayNumber)
//{
//    case 1:
//        dayName = "Понедельник";
//        break;
//    case 2:
//        dayName = "Вторник";
//        break;
//    case 3:
//        dayName = "Среда";
//        break;
//    case 4:
//        dayName = "Четверг";
//        break;
//    case 5:
//        dayName = "Пятница";
//        break;
//    case 6:
//        dayName = "Суббота";
//        break;
//    case 7:
//        dayName = "Воскресенье";
//        break;
//    default:
//        dayName = "Некорректный номер";
//        break;
//}

//Console.WriteLine($"Случайный день недели: {dayName}");
//Console.ReadKey();
//                                }
//                            }
//                        По номеру месяца вывести название времени года
//                                    Console.WriteLine("Введите номер месяца (от 1 до 12):");
//int month = int.Parse(Console.ReadLine());

//string season = "";

//if (month == 12 || month == 1 || month == 2)
//{
//    season = "Зима";
//}
//else if (month >= 3 && month <= 5)
//{
//    season = "Весна";
//}
//else if (month >= 6 && month <= 8)
//{
//    season = "Лето";
//}
//else if (month >= 9 && month <= 11)
//{
//    season = "Осень";
//}
//else
//{
//    Console.WriteLine("Ошибка: введите номер месяца от 1 до 12.");
//    return;
//}

//Console.WriteLine($"Время года: {season}");
//Console.ReadKey();
//                                }
//                            }
//                        }
//                                    Задание 5.Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.
//                        Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
//                                    try
//                                    {
//                                        Console.WriteLine("Введите т/с");
//string ts = Console.ReadLine();
//switch (ts)
//{
//    case "a":
//        Console.WriteLine("Автомобиль 200");
//        break;
//    case "b":
//        Console.WriteLine("Велосипед 20");
//        break;
//    case "m":
//        Console.WriteLine("Мотоцикл 60");
//        break;
//    case "c":
//        Console.WriteLine("Самолет 500");
//        break;
//    case "p":
//        Console.WriteLine("Поезд 150");
//        break;
//    default:
//        Console.WriteLine("Введите a-b-m-c-p");
//        break;
//}
//                                    }
//                                    catch (Exception ex)
//{
//    Console.WriteLine($"Исключение:{ex.Message}");
//}
//Console.ReadKey();
//                                }
//                            }
//                        }
//                         Задание 6.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
//                        try
//{
//    Console.WriteLine("Название предмета");
//    char n = char.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 'ф':
//            Console.WriteLine("Физика");
//            break;
//        case 'м':
//            Console.WriteLine("Математика");
//            break;
//        case 'и':
//            Console.WriteLine("История");
//            break;
//        case 'г':
//            Console.WriteLine("География");
//            break;
//        case 'б':
//            Console.WriteLine("Биология");
//            break;
//        default:
//            Console.WriteLine("Выберите ф-м-и-г-б");
//            break;
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Исключение:{ex.Message}");
//}
//Console.ReadKey();
//                    }
//                }
//            }
//            Дан признак геом. фигуры на плоскости
//            К - круг ((можем вводить и маленькую и большую)) П - Прямоугольник Т - Треугольник,
//            вывести на экран периметр и площадь фигуры, с учета, что данные необходимые запрашиваются у пользователя
//            Console.WriteLine("выберите фигуру:");
//char n = char.Parse(Console.ReadLine());
//switch (n)
//{
//    case 'К':
//    case 'к':
//        double pi = Math.PI;
//        Console.WriteLine($"Вы выбрали Круг!");
//        Console.WriteLine("Введите радиус:");
//        int p1 = int.Parse(Console.ReadLine());
//        double c = 2 * pi * p1;
//        Console.WriteLine("периметр");
//        double S = pi * (c * 2);
//        Console.WriteLine($"радиус = {c}, периметр = {S}");


//        break;
//    case 'П':
//    case 'п':
//        Console.WriteLine($"Вы выбрали прямоугольник");
//        Console.WriteLine($"Выберите сторону a:");
//        int storonaa = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Выберите сторону b:");
//        int storonab = int.Parse(Console.ReadLine());
//        int p = 2 * (storonaa + storonab);

//        int p3 = storonaa * storonab;
//        Console.WriteLine($"Периметр: {p} Площадь = {p3}");

//        break;
//    case 'Т':
//    case 'т':
//        Console.WriteLine($"Вы выбрали треугольник");
//        Console.WriteLine("Выберите сторону a:");
//        int a = int.Parse(Console.ReadLine());
//        Console.WriteLine("Выберите сторону b:");
//        int b = int.Parse(Console.ReadLine());
//        Console.WriteLine("Выберите сторону c:");
//        int c1 = int.Parse(Console.ReadLine());
//        int pt = a + b + c1;
//        int ptt = a * pt / 2;
//        Console.WriteLine($"периметр = {pt} площаль = {ptt}");

//        break;

//    default:
//        Console.WriteLine("выберите к-п-т");
//        break;
//}
//Console.ReadKey();
//        }
//    }
//}