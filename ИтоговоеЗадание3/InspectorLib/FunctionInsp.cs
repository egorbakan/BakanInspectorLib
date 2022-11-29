using System;

namespace InspectorLib
{
    public class FunctionInsp
    {
        string[] AllEmployee = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Список всех сотрудников Автоинспекции
        string[] MainEmployee = { "Васильев Василий Иванович" };//ФИО главного инспектора

        public void GetInspector(string name)//Метод возвращает ФИО главного инспектора
        {
            Console.WriteLine($"Главный инспектор – {name}");//Выводит именя глав. инспектора
        }

        public void GetСarInspection(string TitleInspection)//Метод возвращает название автоинспекции
        {
            Console.WriteLine($"Название – {TitleInspection}");//Вывод названия автоинспекции
        }

        public string SetInspector(string MainIspector)//С помощью этого метода можно изменять ФИО главного автоинспектора
        {
            Console.WriteLine("Выберите имя инспектора (Напишите число от 1 - 4)");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                MainIspector = AllEmployee[0];
                AllEmployee = MainEmployee;
                Console.WriteLine($"Глав. инспектор - {MainIspector}");
                return MainIspector;
            }
            else if (a == 2)
            {
                MainIspector = AllEmployee[1];
                AllEmployee = MainEmployee;
                Console.WriteLine($"Глав. инспектор - {MainIspector}");
                return MainIspector;
            }
            else if (a == 3)
            {
                MainIspector = AllEmployee[2];
                AllEmployee = MainEmployee;
                Console.WriteLine($"Глав. инспектор - {MainIspector}");
                return MainIspector;
            }
            else if (a == 4)
            {
                MainIspector = AllEmployee[3];
                AllEmployee = MainEmployee;
                Console.WriteLine($"Глав. инспектор - {MainIspector}");
                return MainIspector;
            }
            else
            {
                Console.WriteLine("Напишите число от 1 - 4");//Вывод ошибки в консоль 
                return MainIspector;
            }
        }

        public string GenerateNumber(int govnumber, char symbols, int codeRegion = 75) //Метод возвращает сгенерированный госномер
        {
            string result = symbols + "";
            result = result.ToUpper() + "-" + govnumber + "-" + codeRegion;
            Console.WriteLine("Госномер:" + result);//Вывод госномера
            return result;//Возращение переменной result
        }

        public void GetWorker()//Метод возращает список всех сотрудников
        {
            string[] FullName = new string[] { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };//Объявляем массив
            Span<string> AllEmployeeSpan = AllEmployee;//Преобразование массива в Span

            foreach (var Employees in AllEmployeeSpan)
            {
                Console.WriteLine("Список всех сотрудников автоинспекции: " + Employees); //вывод всех сотрудников
            }
        }

        public void AddWorker()//добавление нового сотрудника
        {
            Console.WriteLine("Введите ФИО нового сотрудника");
            string Employee = Console.ReadLine();//Ввод ФИО нового сотрудника
            Array.Resize(ref AllEmployee, AllEmployee.Length + 1);
            AllEmployee[AllEmployee.Length - 1] = Employee;//Смена размера массива
            Console.WriteLine($"Сотрудник {Employee} добавлен");
        }
    }
}
