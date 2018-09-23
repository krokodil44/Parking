using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AccessDataBaseDemo
{
    public partial class MainForm : Form
    {
        private const int price = 300;

        // строка подключения к MS Access

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Parking.mdb;";
   
        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        private OleDbConnection myConnection;

        public MainForm()
        {
            InitializeComponent();
            
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }
               
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }

        // ----------------------------------------------обработка нажатия клавиши <<Заехать>>-------------

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxGosNum.Text != "")
            {
                try
                {// текст запроса
                    string query = "insert into Parking (fio, GosNum, BrandAuto, ModelAuto, DateIn,SumIn) values ('" + textBoxFio.Text + "', '" + textBoxGosNum.Text + "', '" + textBoxBrandAuto.Text + "', '" + textBoxModelAuto.Text + "' , NOW(), " + textBoxSumIn.Text + ")";

                    // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                    OleDbCommand command = new OleDbCommand(query, myConnection);

                    // выполняем запрос к MS Access
                    command.ExecuteNonQuery();

                    //выводим сообщение в окне
                    MessageBox.Show("Автомобиль с госномером <<" + textBoxGosNum.Text + ">> заехал на стоянку ");

                    //очищаем заполненые поля
                    textBoxFio.Text = textBoxGosNum.Text = textBoxBrandAuto.Text = textBoxModelAuto.Text = textBoxSumIn.Text = "";

                }
                catch (System.Data.OleDb.OleDbException) { MessageBox.Show("Заполните все поля. В поле оплачено вводим только число"); }
            }
                else 
                {
                    MessageBox.Show("Поле госномер не должно быть пустым");
                };
            
        }



        //-------------------------------------------------- обработка нажатия клавиши <<Найти>>-----------

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (textBoxGosNum.Text != "")
            {
                try
                {
                    string queryFind = $"SELECT fio, GosNum, BrandAuto, ModelAuto, DateIn, SumIn, ID FROM parking WHERE GosNum = '{textBoxGosNum.Text}' and Out=false";

                    // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                    OleDbCommand commandFind = new OleDbCommand(queryFind, myConnection);

                    // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
                    OleDbDataReader readerFind = commandFind.ExecuteReader();

                    // в цикле построчно читаем ответ от БД (строка должна быть возвращена одна по идее)
                    while (readerFind.Read())
                    {
                        // выводим данные столбцов текущей строки в текстбоксы
                        textBoxFio.Text = readerFind[0].ToString();
                        textBoxGosNum.Text = readerFind[1].ToString();
                        textBoxBrandAuto.Text = readerFind[2].ToString();
                        textBoxModelAuto.Text = readerFind[3].ToString();
                        textBoxDateIn.Text = readerFind[4].ToString();
                        textBoxSumIn.Text = readerFind[5].ToString();
                        textBoxID.Text = readerFind[6].ToString();
                    }
                    // закрываем OleDbDataReader
                    readerFind.Close();
                   
                    //производим расчеты
                    DateTime firstDate = Convert.ToDateTime(textBoxDateIn.Text);
                    DateTime currentDate = DateTime.Now;
                    TimeSpan span = currentDate.Subtract(firstDate);

                    //получаем количество дней на стоянке
                    int Days = (int)span.TotalDays + 1;

                    int SumItog = (price * Days);

                    //записываем значемние итоговой суммы и к оплате в текстбоксы 
                    textBoxSumItog.Text = SumItog.ToString();

                    int SumIn = Convert.ToInt32(textBoxSumIn.Text);

                    textBoxSumOut.Text = (SumItog - SumIn).ToString();

                    buttonPay.Enabled = true;
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("На стоянке нет автомобиля с таким номером");
                }
   
                
            }
            else
            {
                MessageBox.Show("Для поиска введите номер автомобиля");
            }
        }

        //---------------------------------------обработчик кнопки <<Оплатить>>---------------------
        private void buttonPay_Click(object sender, EventArgs e)
        {
            // текст запроса
            string query = $"UPDATE parking SET sumin ={Convert.ToInt32(textBoxSumOut.Text)}, dateout = NOW(), Sumout ={Convert.ToInt32(textBoxSumOut.Text)}, out = 1 WHERE id = {Convert.ToInt32(textBoxID.Text)}";

            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // выполняем запрос к MS Access
            command.ExecuteNonQuery();

            //говорим что тачка покидает стоянку
            MessageBox.Show($"Автомобиль {textBoxBrandAuto.Text} c номером <<{textBoxGosNum.Text}>> выехал со стоянки");

            //очищаем все текстбоксы
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
            buttonPay.Enabled = false;
        }

        private void ViewAllButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.Show();
        }
    }
}
