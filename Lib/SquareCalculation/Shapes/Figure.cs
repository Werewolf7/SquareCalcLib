using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lib.Shapes
{
    internal class Figure : Lib.Interfaces.IShape
    {
        #region Конструкторы
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_shape">Фигура</param>
        /// <param name="_methodCalculation">Метод расчёта площади</param>
        public Figure(Interfaces.IShape _shape)
        {
            Shape = _shape;
            if (!ValidateShape())
            {
                throw new ArgumentException(new StackTrace(false).GetFrame(0)!.GetMethod()!.Name,
                    "\nНеверно введены параметры для фигуры");
            }
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Фигура
        /// </summary>
        public Interfaces.IShape Shape { get; }
        #endregion

        #region Методы
        /// <summary>
        /// Метод расчёта площади
        /// </summary>
        /// <param name="_method">Выбор метода</param>
        /// <returns>Площадь</returns>
        public double Square(int _method)
        {
            return Shape.Square(_method);
        }
        /// <summary>
        /// Метод валидации фигуры
        /// </summary>
        /// <returns>Валидные значения или нет</returns>
        public bool ValidateShape()
        {
            return Shape.ValidateShape();
        }
        #endregion
    }
}
