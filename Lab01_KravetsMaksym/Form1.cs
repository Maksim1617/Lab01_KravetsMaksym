using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab01_KravetsMaksym
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
            textBox_Login.Text = "Введите логин";
            textBox_Login.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Password.Text = "Введите пароль";
            textBox_Password.ForeColor = Color.Gray; //Делает текст  серым
            textBox_Password.UseSystemPasswordChar = false; //Устанавливает свойство скрывать введенный текст в поле для пароля символом в значение false

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox_Login.Text == "Maksym" && textBox_Password.Text == "qwerty")
                {
                    MessageBox.Show("Hello Maksym");
                    label_OK.BackColor = Color.Green;
                }
                else if(textBox_Login.Text == "" || textBox_Login.Text == "Введите логин")
                {
                    MessageBox.Show("Введіть логін");
                    label_OK.BackColor = Color.Red;
                }
                else if (textBox_Password.Text == "" || textBox_Password.Text == "Введите пароль")
                {
                    MessageBox.Show("Введіть пароль");
                    label_OK.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Невірний логін чи пароль");
                    label_OK.BackColor = Color.Red;
                    textBox_Login.Text = "";
                    textBox_Password.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Функция которая позволяет двигать окно при зажатой левой клавише мыши
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Х
                this.Top += e.Y - lastPoint.Y; //Добавляет к координатам положения окна значения на которое мышь (с зажатой левой кнопкой) была перемещена по Оси Y
            }
        }

        //Функция записывающая последние координаты окна в переменную lastPoint
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //При наведении на кнопку (CloseButton) меняет фон кнопки
        private void label_Close_MouseEnter(object sender, EventArgs e)
        {
            label_Close.BackColor = Color.Red;
        }

        //При выводе мишки за предел кнопки (CloseButton) меняет фон кнопки
        private void label_Close_MouseLeave(object sender, EventArgs e)
        {
            label_Close.BackColor = Color.White;
        }

        private void label_Hide_Click(object sender, EventArgs e)
        {
            // свернуть
            this.WindowState = FormWindowState.Minimized;
            // Развернуть
            //this.WindowState = FormWindowState.Maximized;
        }

        //При наведении на кнопку (CloseButton) меняет фон кнопки
        private void label_Hide_MouseEnter(object sender, EventArgs e)
        {
            label_Hide.BackColor = Color.FromArgb(206, 210, 217);
        }

        //При выводе мишки за предел кнопки (CloseButton) меняет фон кнопки
        private void label_Hide_MouseLeave(object sender, EventArgs e)
        {
            label_Hide.BackColor = Color.White;
        }

        //Если значение в поле ввода логина пользователя равно начальному значению ("Введите логин") то оно становиться пустым при нажатии на него ЛКМ
        private void textBox_Login_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода логина пользователя равно начальному значению ("Введите логин") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Login.Text == "Введите логин")
            {
                textBox_Login.Text = ""; //Делает поле для ввода логина пользователя пустым
                textBox_Login.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода логина пользователя, когда курсор миши в нём не установлен
        private void textBox_Login_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода логина пользователя равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите логин") при нажатии ЛКМ на другое активное поле
            if (textBox_Login.Text == "")
            {
                textBox_Login.Text = "Введите логин"; //Делает поле для ввода логина пользователя равным начальному значению ("Введите логин")
                textBox_Login.ForeColor = Color.Gray; //Делает цвет текста серым
            }
        }

        //Функция которая описывает поведения поля для ввода пароля пользователя, когда курсор миши в нём установлен
        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            //Если значение в поле ввода пароля пользователя равно начальному значению ("Введите пароль") то оно становиться пустым при нажатии на него ЛКМ
            if (textBox_Password.Text == "Введите пароль")
            {
                textBox_Password.Text = ""; //Делает поле для ввода пароля пользователя пустым
                textBox_Password.UseSystemPasswordChar = true; //Устанавливает свойство скрывать введенный текст в поле для пароля символом в значение true
                textBox_Password.ForeColor = Color.Black; //Делает цвет текста который будет введён черным
            }
        }

        //Функция которая описывает поведения поля для ввода пароля пользователя, когда курсор миши в нём не установлен
        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            //Если значение в поле ввода пароля пользователя равно пустоте (Пользователь не ввёл значения) то оно становиться равным ("Введите пароль") при нажатии ЛКМ на другое активное поле
            if (textBox_Password.Text == "")
            {
                textBox_Password.UseSystemPasswordChar = false; //Устанавливает свойство скрывать введенный текст в поле для пароля символом в значение false
                textBox_Password.Text = "Введите пароль"; //Делает поле для ввода пароля пользователя равным начальному значению ("Введите пароль")
                textBox_Password.ForeColor = Color.Gray; //Делает цвет текста серым
            }
        }
    }
}
