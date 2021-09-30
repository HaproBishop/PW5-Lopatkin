using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibPair;
/// <summary>
/// Практическая работа №5. Задание 8. Лопаткин Сергей ИСП-31.
/// Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. 
/// Определить метод вычисления произведения чисел. 
/// Создать перегруженный метод для вычисления произведения 2 пар чисел - (a,b)*(c,d) = (a*c), (b*d)"
/// </summary>
namespace PW5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа имеет следующие особенности:\n1) Необходимо вводить только четные числа для вычисления их произведения.\n2) Максимальное число для ввода в полях - пятизначное.\n3) Первое произведение - умножение первого числа на третье. Второе произведение - умножение второго числа на четвертое.", "Справка", MessageBoxButton.OK, MessageBoxImage.Information);            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5. Задание 8. Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. Определить метод вычисления произведения чисел. Создать перегруженный метод для вычисления произведения 2 пар чисел - (a,b)*(c,d) = (a*c), (b*d)", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void FirstValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            FirstResult.Clear();
            SecondResult.Clear();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {            
            bool ProveValue1 = int.TryParse(FirstValue.Text, out int value1);
            bool ProveValue2 = int.TryParse(SecondValue.Text, out int value2);
            bool ProveValue3 = int.TryParse(ThirdValue.Text, out int value3);
            bool ProveValue4 = int.TryParse(ForthValue.Text, out int value4);
            bool ProveValuesEven = Pair.ProveValuesEvenWithoutObject(value1, value2, value3, value4);
            if (ProveValue1 == true && ProveValue2 == true && ProveValue3 == true && ProveValue4 == true && ProveValuesEven == true)
            {
                int[] mas = new int[2];
                mas = Pair.PairCalculateWithoutObject(value1, value2, value3, value4);
                FirstResult.Text = mas[0].ToString();
                SecondResult.Text = mas[1].ToString();
            }
            else MessageBox.Show("У вас некорректно введены значения для проведения произведения! Подробности об особенностях работы программы написаны в справке!", "ОШИБКА!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
