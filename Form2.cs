using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrshovayaa
{
    public partial class Form2 : Form
    {
        static Clientinf client = new Clientinf("Brestskaya","Balyshev", "343564", "no");
       Rent checky = new Rent("232","21",2);
        Restaurantdeliv rentalPoint = new Restaurantdeliv("le délice de Cupidon");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListBicycles();
            LoadListBox1();
        }
        private void ListBicycles() // заполняется "база" 
        {
           rentalPoint.Adddeli(new Food("цезарь", 15, 125,true));
            rentalPoint.Adddeli(new Food("Рататуй", 25, 375,true));
            rentalPoint.Adddeli(new Food("Луковый суп", 20, 150,true));
            rentalPoint.Adddeli(new Food("Консоме", 35, 190,true));
            rentalPoint.Adddeli(new Food("Вишисуаз ", 25, 170,true));
            rentalPoint.Adddeli(new Food("Потофе", 15, 170,true));
            rentalPoint.Adddeli(new Food("Тимбаль", 25, 180,true));
            rentalPoint.Adddeli(new Food("Салат Нисуаз", 10, 75,true));
            rentalPoint.Adddeli(new Food("Улитки", 45, 100,true));
            rentalPoint.Adddeli(new Food("Кофе", 5, 0.25, true));
            rentalPoint.Adddeli(new Food("Вино(Белое)", 25, 0.750, true));
            rentalPoint.Adddeli(new Food("Вино(Красное)", 25, 0.750, true));
            rentalPoint.Adddeli(new Food("Сок", 3, 0.3, true));



        }
        private void LoadListBox1() // заполняется бокс 
        {
            listBox1.Items.Clear();
            foreach (var item in rentalPoint.CheckList())
                listBox1.Items.Add($"{item.nameofbludo}, Цена:{item.cena}");
            button5.Visible = false;
        }
        private void LoadListBox2() // заполняется выбранное клиентом
        {
            listBox2.Items.Clear();
            foreach (var item in checky.CheckList())
                listBox2.Items.Add($"{item.nameofbludo}, Цена: {item.cena}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    checky.Adddeli((Food)rentalPoint.CheckList()[listBox1.SelectedIndex]);
                    rentalPoint.RefreshStatus((Food)rentalPoint.CheckList()[listBox1.SelectedIndex]);
                    LoadListBox1();
                    LoadListBox2();
                }
                catch (Exception)
                {

                    MessageBox.Show("Выберите блюдо");
                }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                rentalPoint.RefreshStatus((Food)checky.CheckList()[listBox2.SelectedIndex]);
                checky.Removedeli((Food)checky.CheckList()[listBox2.SelectedIndex]);
                LoadListBox1();
                LoadListBox2();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите блюдо");
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    client = new Clientinf(textBox1.Text, textBox2.Text, textBox3.Text,textBox9.Text);
                   // checky = new Rent((textBox1.Text), (textBox2.Text), double.Parse(textBox9.Text));
                    groupBox1.Visible = true;
                    groupBox3.Visible = true;
                    groupBox5.Visible = true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Неверно заполнены поля ");
                }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                textBox7.Text = checky.GetPrice().ToString();
            // textBox8.Text = rent.GetTimeReturn().ToString();
                 button5.Visible=true;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            employee employee = null;
            client.zapis2(checky.CheckList(), checky.GetPrice(), employee);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
