using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lib.Shapes
{
    public class Circle : Lib.Interfaces.IShape
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_radius">Радиус Круга</param>
        /// <exception cref="ArgumentException">Если ввели невалидное значение для радиуса</exception>
        public Circle(
            double _radius = default(double)
            )
        {
            Radius = _radius;
            if (!ValidateShape())
            {
                throw new ArgumentException(new StackTrace(false).GetFrame(0)!.GetMethod()!.Name, 
                    "\nНеверно введены параметры для круга");
            }
        }
        #endregion

        #region Перечисления
        /// <summary>
        /// Методы расчёта площади
        /// </summary>
        public enum AreaFormulas
        {
            ByRadius = 0
        }
        #endregion

        #region Методы
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="_method">Выбор метода для расчёта площади(если захотим добавить другие)</param>
        /// <returns>Площадь круга(-1 в случае отсутствия метода расчёта)</returns>
        public double Square(int _method)
        {
            switch (_method)
            {
                case (int)AreaFormulas.ByRadius:
                    return Math.Pow(Radius, 2) * Math.PI;
                default:
                    return -1;
            }
        }
        /// <summary>
        /// Проверка корректности вводимых параметров круга
        /// </summary>
        /// <returns>Корректно введены данные или нет</returns>
        public bool ValidateShape()
        {
            if (Radius < 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Радиус круга
        /// </summary>
        private double Radius { get; } = default(double);
        #endregion
    }
}
