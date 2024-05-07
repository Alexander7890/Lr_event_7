using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Lr_event_7
{
    public partial class Form1 : Form
    {
        bool isButtonSubscribed = true; // Перевіряємо, чи підписаний кнопку
        bool isLabelSubscribed = true; // Перевіряємо, чи підписаний підпис
        bool isTextBoxSubscribed = true; // Перевіряємо, чи підписаний текстовий блок

        public Form1()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Form1_Resize); // Підписуємося на подію зміни розміру
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (isButtonSubscribed) // Якщо кнопка підписана, то змінюємо її положення
                button1.Location = new Point(this.ClientSize.Width - button1.Width, this.ClientSize.Height - button1.Height); // Зміна положення кнопки
            if (isLabelSubscribed)
                label1.Location = new Point(this.ClientSize.Width - label1.Width, this.ClientSize.Height - label1.Height - button1.Height); // Зміна положення підпису
            if (isTextBoxSubscribed)
                textBox1.Location = new Point(this.ClientSize.Width - textBox1.Width, this.ClientSize.Height - textBox1.Height - button1.Height - label1.Height); // Зміна положення текстового блоку
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            isButtonSubscribed = !isButtonSubscribed; // Зміна значення підписки на кнопку
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isLabelSubscribed = !isLabelSubscribed; // Зміна значення підписки на підпис
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isTextBoxSubscribed = !isTextBoxSubscribed; // Зміна значення підписки на текстовий блок
        }
    }
}
