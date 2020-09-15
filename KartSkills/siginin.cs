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
    public partial class siginin : template
    {
        public siginin()
        {
            InitializeComponent();
        }

        private void siginin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Создаем новый экхемпляр для окна main и отображаем его
            new main().Show();
            //Скрываем текущее окно
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tb_mail.Text == "admin") && (tb_pass.Text == "123"))
            {
                MessageBox.Show("Вы авторизовались");

            }
            else {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
