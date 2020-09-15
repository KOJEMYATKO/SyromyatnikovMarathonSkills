using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //функция выполняющаяся при загрузке окна
        private void main_Load(object sender, EventArgs e)
        {
          
        }

        private void timer_event_Tick(object sender, EventArgs e)
        {
            //создаем новый экземпляр типа DAteTime для хранения время начала события
            DateTime finishdate = new DateTime(2020, 10, 1, 9, 0, 0);
            //Вычисляем текущее время и время начала события
            TimeSpan result = finishdate - DateTime.Now;
           /*Проверяем условие, если finishdate (время начало события) меньше или равно текущей дате.
            * то выводится сообщение что "событие уже началось", если нет то отображаем счетчик
           */
            if (finishdate <= System.DateTime.Now)
            {
                l_timer.Text = "Событие уже началось";
            }
            else
            {
                l_timer.Text = "До события осталось: " + result.Days + " дней " + result.Minutes + " минут " + result.Seconds + " секунд";
            }
        }
    }
}
