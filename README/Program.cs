namespace README
{
    using System;

    namespace Lab7
    {
        /// <summary>
        /// Класс для расчёта скидок в системе заказов компании «Обувь-Маг»[cite: 3, 14].
        /// </summary>
        public class DiscountCalculator
        {
            /// <summary>
            /// Рассчитывает цену со скидкой 25%, если по товару не было заказов в прошлом месяце[cite: 3, 14].
            /// </summary>
            /// <param name="basePrice">Базовая цена товара.</param>
            /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
            /// <returns>Цена со скидкой или базовая цена[cite: 3].</returns>
            public decimal GetDiscountedPrice(decimal basePrice, bool hasOrdersLastMonth)
            {
                if (hasOrdersLastMonth)
                    return basePrice;

                return basePrice * 0.75m;
            }

            /// <summary>
            /// Свойство, возвращающее текущий процент скидки для компании «Обувь-Маг» (25%)[cite: 3, 14].
            /// </summary>
            public decimal DiscountRate
            {
                get { return 0.25m; }
            }
        }

        /// <summary>
        /// Главный класс программы для запуска консольного приложения[cite: 4].
        /// </summary>
        class Program
        {
            /// <summary>
            /// Точка входа в консольное приложение[cite: 4].
            /// </summary>
            /// <param name="args">Аргументы командной строки[cite: 4].</param>
            static void Main(string[] args)
            {
                var calculator = new DiscountCalculator();
                decimal price = 1000m;
                decimal discounted = calculator.GetDiscountedPrice(price, false);

                Console.WriteLine($"Базовая цена: {price}");
                Console.WriteLine($"Цена со скидкой: {discounted}");
                Console.WriteLine("Автор: Анисимова");

                Console.ReadKey();
            }
        }
    }
}
