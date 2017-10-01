/*Написать программу, вычисляющую сколько осталось времени до указанной даты (дата вводится с клавиатуры в Edit).
 *  Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах, секундах 
 *  (для первых двух вариантов ответ дробный). Для переключения между вариантами желательно использовать 
 *  переключатели (RadioButton).*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHW4
{
    public partial class MainWinForm : Form
    {
        public MainWinForm()
        {
            InitializeComponent();
        }

        DateTime dateNow = DateTime.Now;
        System.TimeSpan firstDifferent;
        int year;

        private void Button_Click(object sender, EventArgs e)
        {
            firstDateBox.Enabled = firstDate.Checked;
            secondDateBox.Enabled = secondDate.Checked;
            thirdDateBox.Enabled = thirdDate.Checked;
            DateTime dateInFirstBox;
            DateTime dateInSecondBox;
            DateTime dateInThirdBox;
            DateTime.TryParse(firstDateBox.Text, out dateInFirstBox);
            DateTime.TryParse(secondDate.Text, out dateInSecondBox);
            DateTime.TryParse(secondDate.Text, out dateInThirdBox);            
            if (firstDate.Checked)
            {
                if (dateNow < dateInFirstBox)
                {
                    DateTime firstDifferent = new DateTime((dateInFirstBox - dateNow).Ticks);
                    MessageBox.Show(String.Format("{0} - years, {1} - months, {2} - weeks, {3} - hours, {4} - minuts, {5}-seconds",
                        (firstDifferent.Year-1).ToString(), firstDifferent.Month.ToString(), firstDifferent.Day.ToString(),
                        firstDifferent.Hour.ToString(), firstDifferent.Month.ToString(), firstDifferent.Second.ToString()));
                }
                else
                    MessageBox.Show("Дата должна быть больше текущей ");
            }
            if (secondDate.Checked)
            {
                if (dateNow < dateInSecondBox)
                {
                    DateTime secondDifferent = new DateTime((dateInSecondBox - dateNow).Ticks);
                    MessageBox.Show(String.Format("{0} - years, {1} - months, {2} - weeks, {3} - hours, {4} - minuts, {5}-seconds",
                       (secondDifferent.Year - 1).ToString(), secondDifferent.Month.ToString(), secondDifferent.Day.ToString(),
                       secondDifferent.Hour.ToString(), secondDifferent.Month.ToString(), secondDifferent.Second.ToString()));
                }
                else
                    MessageBox.Show("Дата должна быть больше текущей ");
            }
            if (thirdDate.Checked)
            {
                if (dateNow < dateInThirdBox)
                {
                    DateTime thirdDifferent = new DateTime((dateInThirdBox - dateNow).Ticks);
                    MessageBox.Show(String.Format("{0} - years, {1} - months, {2} - weeks, {3} - hours, {4} - minuts, {5}-seconds",
                       (thirdDifferent.Year - 1).ToString(), dateInThirdBox.Month.ToString(), dateInThirdBox.Day.ToString(),
                       dateInThirdBox.Hour.ToString(), dateInThirdBox.Month.ToString(), dateInThirdBox.Second.ToString()));
                }
                else
                    MessageBox.Show("Дата должна быть больше текущей ");
            }
        }
    }
}
