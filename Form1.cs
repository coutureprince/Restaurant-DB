namespace kyrshovayaa
{
    public partial class Form1 : Form
    {
       static Clientinformation client = new Clientinformation("Dima",2,"no");
        Check check = new Check(client);
        Menu menu = new Menu();

        Restaurant restaurant = new Restaurant("le délice de Cupidon");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listdishes();
            LoadListBox1();

        }   
        private void Listdishes()
        {
           restaurant.Addbludo(new Menu("Цезарь", 15, 125));
           restaurant.Addbludo(new Menu("Рататуй", 25, 375));
           restaurant.Addbludo(new Menu("Луковый суп", 20, 150));
           restaurant.Addbludo(new Menu("Консоме", 35, 190));
           restaurant.Addbludo(new Menu("Вишисуаз ", 25, 170));
           restaurant.Addbludo(new Menu("Потофе", 15, 170));
           restaurant.Addbludo(new Menu("Тимбаль", 25, 180));
           restaurant.Addbludo(new Menu("Салат Нисуаз", 10, 75));
           restaurant.Addbludo(new Menu("Улитки", 45, 100));
           restaurant.Addbludo(new Menu("Кофе", 5, 0.25));
           restaurant.Addbludo(new Menu("Чай", 4, 0.25));
           restaurant.Addbludo(new Menu("Вино(Белое)", 25, 0.750));
           restaurant.Addbludo(new Menu("Вино(Красное)", 25, 0.750));
           restaurant.Addbludo(new Menu("Сок", 3, 0.3));
        }
        private void LoadListBox1() // заполняется бокс блюд
        {
            listBox1.Items.Clear();
            foreach (var item in restaurant.CheckList())
            listBox1.Items.Add($"{item.namebluda}, Цена: {item.Price}, Грамм: {item.gramm}");
            button5.Visible = false;
        }
        private void LoadListBox2() // заполняется выбранное клиентом
        {
            listBox2.Items.Clear();
            foreach (var item in check.CheckList())
                listBox2.Items.Add($"{item.namebluda}, цена: {item.Price}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                client= new Clientinformation(textBox1.Text,int.Parse(textBox2.Text), textBox3.Text);
                //check = new Check(client, DateTime.Parse(textBox6.Text), DateTime.Parse(textBox5.Text), double.Parse(textBox4.Text));
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox5.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Неверно заполнены поля");
            }
        }
        private void button2_Click(object sender, EventArgs e) // список доступных блюд
        {
            try
            {
         
                        check.Addbludo(restaurant.CheckList()[listBox1.SelectedIndex]);
                       
                        LoadListBox1();
                        LoadListBox2();
                  
            }
            catch (Exception)
            {

                MessageBox.Show("Выделите блюдо");
            }
        }
        private void button3_Click(object sender, EventArgs e) // список блюд которые взял клиент
        {
            try
            {
               
                check.Removebludo(check.CheckList()[listBox2.SelectedIndex]);
                LoadListBox1();
                LoadListBox2();
            }
            catch (Exception)
            {
                MessageBox.Show("Выделите блюдо");
            }

        }
        private void button4_Click(object sender, EventArgs e) // посчитать
        {
            textBox7.Text = check.GetPrice().ToString();
            //    textBox8.Text = check.GetTimeReturn().ToString();
            button5.Visible = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            employee employee = null;
            client.zapis(check.CheckList(),check.GetPrice(),employee);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}