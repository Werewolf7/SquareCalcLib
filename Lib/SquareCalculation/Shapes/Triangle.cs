using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lib.Shapes
{
    public class Triangle : Lib.Interfaces.IShape
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_a">Сторона A</param>
        /// <param name="_b">Сторона B</param>
        /// <param name="_c">Сторона C</param>
        /// <exception cref="ArgumentException">Если ввели невалидное значение для сторон</exception>
        public Triangle(
            double _a = default(double), 
            double _b = default(double), 
            double _c = default(double)
            )
        {
            SideA = _a;
            SideB = _b;
            SideC = _c;
            if (!ValidateShape())
            {
                throw new ArgumentException(new StackTrace(false).GetFrame(0)!.GetMethod()!.Name,
                    "\nНеверно введены параметры для треугольника");
            }
        }
        #endregion

        #region Перечисления
        /// <summary>
        /// Методы расчёта площади
        /// </summary>
        public enum AreaFormulas
        {
            ByThreeSides = 0
        }
        #endregion

        #region Методы
        /// <summary>
        /// Метод расчёта площади
        /// </summary>
        /// <param name="_method">Выбор метода для расчёта площади(если захотим добавить другие)</param>
        /// <returns>Площадь</returns>
        public double Square(int _method)
        {
            switch (_method)
            {
                case (int)AreaFormulas.ByThreeSides:
                    {
                        double p = (SideA + SideB + SideC) / 2;
                        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
                    }
                default:
                    return 0;
            }
        }
        /// <summary>
        /// Проверка корректности вводимых параметров треугольника
        /// </summary>
        /// <returns>Корректно введены данные или нет</returns>
        public bool ValidateShape()
        {
            if (SideA < 0 || SideB < 0 || SideC < 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Метод проверки является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Прямоугольный или нет</returns>
        public bool IsRectangular()
        {
            return
                (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                ||
                (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                ||
                (Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Сторона A
        /// </summary>
        private double SideA { get; } = default(double);
        /// <summary>
        /// Сторона B
        /// </summary>
        private double SideB { get; } = default(double);
        /// <summary>
        /// Сторона C
        /// </summary>
        private double SideC { get; } = default(double);
        #endregion
    }
}
