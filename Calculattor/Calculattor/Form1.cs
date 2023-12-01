using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculattor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          // метод для форм в дизайнере форм VS
          InitializeComponent();
        }
        // Метод,  будет вызываться на кнопку клика "ОК"
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Получаем значения роста, веса и возраста из форм куда пользователь писал данные
            double height = double.Parse(heightTextBox.Text);
            double weight = double.Parse(weightTextBox.Text);
            int age = int.Parse(ageNumericUpDown.Text);

            // Делаю ограничения
            // Рост должен быть больше 145 и меньше 210
            if (height < 145 || height > 210)
            {
                MessageBox.Show("Рост должен быть больше 145 и меньше 210");
                return;
            }

            // Вес должен быть больше 40 и меньше 200
            if (weight < 40 || weight > 200)
            {
                MessageBox.Show("Вес должен быть больше 40 и меньше 200");
                return;
            }

            // Возраст должен быть больше 12 и меньше 100
            if (age < 12 || age > 100)
            {
                MessageBox.Show("Возраст должен быть больше 12 и меньше 100");
                return;
            }

            // Расчет калорийности на основе роста, веса и возраста
            double calorieResult = 655.1 + (9.563 * weight) + (1.85 * height) - (4.676 * age);

            // Вывод результата расчета на форму
            resultLabel.Text = $"Ваша суточная норма калорийности: {calorieResult} калорий";
        }

        
    }
}