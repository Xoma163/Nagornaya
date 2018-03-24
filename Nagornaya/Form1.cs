using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagornaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvBuy.RowCount = 1;
            dgvMoney.RowCount = 1;
            // dgvBuy.ColumnCount = 0;
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Файловый диалог
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Хавка|*.havka";
            ofd.Title = "Открыть алгоритм";

            //Открываем и ждём нажатия кнопки
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Открываем поток с нашим файлом
                StreamReader sr = new StreamReader(ofd.FileName);

                //длина и ширина
                int a = 0;
                int b = 0;
                //Считываем длину и ширину
                a = Convert.ToInt32(sr.ReadLine()) - 1;
                b = Convert.ToInt32(sr.ReadLine());
                //Создаём новые размеры
                dgvBuy.Rows.Clear();
                dgvBuy.Rows.Add(a);
                dgvBuy.ColumnCount = b;

                for (int i = 0; i < a; i++)
                {
                    //Считываем в массив строк
                    string[] mas = sr.ReadLine().Split(';');

                    for (int j = 0; j < b; j++)
                        if (j == b - 1)
                            if (mas[j] == "True")
                                dgvBuy.Rows[i].Cells[j].Value = true;
                            else
                                dgvBuy.Rows[i].Cells[j].Value = false;
                        else
                            dgvBuy.Rows[i].Cells[j].Value = mas[j];


                }
                sr.ReadLine();
                sr.ReadLine();
                {
                    a = Convert.ToInt32(sr.ReadLine()) - 1;
                    b = Convert.ToInt32(sr.ReadLine());

                    dgvMoney.Rows.Clear();
                    dgvMoney.Rows.Add(a);
                    dgvMoney.ColumnCount = b;

                    for (int i = 0; i < a; i++)
                    {
                        //Считываем в массив строк
                        string[] mas = sr.ReadLine().Split(';');
                        for (int j = 0; j < b; j++)
                            dgvMoney.Rows[i].Cells[j].Value = mas[j];
                    }
                }
                sr.Close();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Хавка|*.havka";
            sfd.Title = "Сохранить как";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.WriteLine(dgvBuy.RowCount);
                sw.WriteLine(dgvBuy.ColumnCount);

                for (int i = 0; i < dgvBuy.RowCount; i++)
                {
                    for (int j = 0; j < dgvBuy.ColumnCount; j++)
                        sw.Write(dgvBuy.Rows[i].Cells[j].Value + ";");
                    if (i != dgvBuy.RowCount - 1)
                        sw.WriteLine("");
                }
                sw.WriteLine();
                sw.WriteLine("----------");
                sw.WriteLine(dgvMoney.RowCount);
                sw.WriteLine(dgvMoney.ColumnCount);

                for (int i = 0; i < dgvMoney.RowCount; i++)
                {
                    for (int j = 0; j < dgvMoney.ColumnCount; j++)
                        sw.Write(dgvMoney.Rows[i].Cells[j].Value + ";");
                    if (i != dgvMoney.RowCount - 1)
                        sw.WriteLine("");
                }

                sw.Close();
            }
        }
        private void notNullDgv()
        {
            for(int i=0;i<dgvBuy.RowCount-1;i++)
                for(int j=0; j<dgvBuy.ColumnCount; j++)
                {
                    if(j!=6)
                    if(dgvBuy.Rows[i].Cells[j].Value is null)
                    dgvBuy.Rows[i].Cells[j].Value = "";
                }

            for (int i = 0; i < dgvMoney.RowCount - 1; i++)
                for (int j = 0; j < dgvMoney.ColumnCount; j++)
                {
                    if (dgvMoney.Rows[i].Cells[j].Value is null)
                        dgvMoney.Rows[i].Cells[j].Value = "";
                }
        }
        private bool testDgv()
        {
            for (int i = 0; i < dgvMoney.RowCount - 1; i++)
                for (int j = 0; j < dgvMoney.RowCount - 1; j++)
                    if (i != j)
                        if (dgvMoney.Rows[i].Cells[0].Value.ToString() == dgvMoney.Rows[j].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Не может быть более двух людей в списке бабла");
                            dgvMoney.CurrentCell = dgvMoney.Rows[j].Cells[0];
                                return false;
                        }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //АнтиNull
            notNullDgv();
            if (testDgv())
            {

                int sumBuy = 0;
                int sumPeople = 0;
                int people = dgvMoney.RowCount - 1;
                int buy = dgvBuy.RowCount - 1;

                //заполняем sumBuy
                for (int i = 0; i < buy; i++)
                    if (Int32.TryParse(dgvBuy.Rows[i].Cells[4].Value.ToString(), out int a))
                        sumBuy += a;

                //Заполняем нулями money, если пустота
                for (int i = 0; i < people; i++)
                    for (int j = 1; j <= 4; j++)
                        if (dgvMoney.Rows[i].Cells[j].Value.ToString() == "")
                            dgvMoney.Rows[i].Cells[j].Value = 0;

                //Суммируем расходы людей
                for (int i = 0; i < people; i++)
                {
                    dgvMoney.Rows[i].Cells[1].Value = 0;
                    for (int j = 0; j < buy; j++)
                        if (dgvBuy.Rows[j].Cells[5].Value.ToString() == dgvMoney.Rows[i].Cells[0].Value.ToString() && dgvBuy.Rows[j].Cells[4].Value.ToString() != "")
                        {
                            dgvMoney.Rows[i].Cells[1].Value = Convert.ToInt32(dgvMoney.Rows[i].Cells[1].Value) + Convert.ToInt32(dgvBuy.Rows[j].Cells[4].Value);
                            sumPeople += Convert.ToInt32(dgvBuy.Rows[j].Cells[4].Value);
                        }
                }

                label5.Text = sumBuy + "";
                label6.Text = sumPeople + "";
                label7.Text = people + "";
                if (people != 0)
                    label8.Text = sumBuy / people + "";
                else
                    label8.Text = "Не дели на ноль :(";
                //Считаю долг и долгитог
                for (int i = 0; i < people; i++)
                {
                    dgvMoney.Rows[i].Cells[2].Value = sumBuy / people - Convert.ToInt32(dgvMoney.Rows[i].Cells[1].Value);
                    dgvMoney.Rows[i].Cells[4].Value = Convert.ToInt32(dgvMoney.Rows[i].Cells[2].Value) - Convert.ToInt32(dgvMoney.Rows[i].Cells[3].Value);
                }


                howTo howTo = new howTo();
                howTo.StartPosition = FormStartPosition.CenterParent;

                howTo.clear();
                for (int i = 0; i < people; i++)
                {
                    if (Convert.ToInt32(dgvMoney.Rows[i].Cells[4].Value) < 0)
                        if (dgvMoney.Rows[i].Cells[0].Value.ToString() != "Ктап")
                            howTo.addRow("Ктап", " → ", dgvMoney.Rows[i].Cells[0].Value.ToString(), Math.Abs(Convert.ToInt32(dgvMoney.Rows[i].Cells[4].Value)) + " руб.");
                    if (Convert.ToInt32(dgvMoney.Rows[i].Cells[4].Value) > 0)
                        howTo.addRow(dgvMoney.Rows[i].Cells[0].Value.ToString(), " → ", "Ктап", dgvMoney.Rows[i].Cells[4].Value + " руб.");
                }
                howTo.ShowDialog();
            }
        }

        private int currentMouseOverRow;
        private int currentMouseOverColumn;
        private void dgvBuy_MouseClick(object sender, MouseEventArgs e)
        {
            currentMouseOverRow = dgvBuy.HitTest(e.X, e.Y).RowIndex;
            currentMouseOverColumn = dgvBuy.HitTest(e.X, e.Y).ColumnIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverColumn == 0)
                {
                    MenuItem delete = new MenuItem("Удалить строку");
                    MenuItem id = new MenuItem("Задать #");
                    m.MenuItems.AddRange(new MenuItem[] { delete, id });
                    m.MenuItems[0].Click += new System.EventHandler(this.m_delete1);
                    m.MenuItems[1].Click += new System.EventHandler(this.id);
                }
                if (currentMouseOverRow == 0 || currentMouseOverColumn == 0)
                    m.Show(dgvBuy, new Point(e.X, e.Y));
            }
        }
        private void m_delete1(object sender, System.EventArgs e)
        {
            if (currentMouseOverRow < dgvBuy.RowCount - 1)
                dgvBuy.Rows.RemoveAt(currentMouseOverRow);
            else
                MessageBox.Show("Нельзя удалить последнюю строку");
        }
        private void id(object sender, System.EventArgs e)
        {
            for (int i = 0; i < dgvBuy.RowCount - 1; i++)
                dgvBuy.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvMoney_MouseClick(object sender, MouseEventArgs e)
        {
            currentMouseOverRow = dgvMoney.HitTest(e.X, e.Y).RowIndex;
            currentMouseOverColumn = dgvMoney.HitTest(e.X, e.Y).ColumnIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverColumn == 0)
                {
                    MenuItem delete = new MenuItem("Удалить строку");
                    MenuItem addAll = new MenuItem("Добавить всех");
                    m.MenuItems.AddRange(new MenuItem[] { delete, addAll });
                    m.MenuItems[0].Click += new System.EventHandler(this.m_delete2);
                    m.MenuItems[1].Click += new System.EventHandler(this.m_addAll);
                }
                if (currentMouseOverRow == 0 || currentMouseOverColumn == 0)
                    m.Show(dgvMoney, new Point(e.X, e.Y));
            }
        }
        private void m_delete2(object sender, System.EventArgs e)
        {
            if (currentMouseOverRow < dgvMoney.RowCount - 1)
                dgvMoney.Rows.RemoveAt(currentMouseOverRow);
            else
                MessageBox.Show("Нельзя удалить последнюю строку");

        }
        private void m_addAll(object sender, System.EventArgs e)
        {
            dgvMoney.RowCount = 9;
            for (int i = 0; i < dgvMoney.RowCount-1; i++)
                dgvMoney.Rows[i].Cells[0].Value = Column10.Items[i];
        }

        private void пресетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = (sender as ToolStripMenuItem).Text;
            int count = Convert.ToInt32(toolStripMenuItem2.Text);
           switch (name)
            {
                case ("Шавуха"): addPreset("Огурец",0.5* count, "Шт"); addPreset("Помидора", 0.5* count, "Шт"); addPreset("Филе курицы", 0.5* count, "Шт"); addPreset("Сыр", 50* count, "Гр"); addPreset("Лаваш", 0.5* count, "Шт"); addPreset("Сметана", 30 * count, "Гр"); addPreset("Майонез", 15 * count, "Гр"); addPreset("Зубчик чеснока", 0.5 * count, "Шт"); addPreset("Приправа для шаурмы", 0 * count, " "); break;
                case ("Пицца"): addPreset("Основа для пиццы",1* count, "Шт"); addPreset("Помидора", 2* count, "Шт"); addPreset("Сыр", 100* count, "Гр"); addPreset("Колбаса", 300* count, "Гр"); addPreset("Майонез", 20* count, "Гр"); addPreset("Кетчуп", 20* count, "Гр"); break;
                case ("Пельмешки"): addPreset("Пельмени", 15*12 * count, "Гр"); break;
                case ("Оливье 6ч."): addPreset("Картошка", 3, "Шт"); addPreset("Морковь", 1.5, "Шт"); addPreset("Огурец", 2, "Шт"); addPreset("Яйцо", 4, "Шт"); addPreset("Ветчина", 300, "Гр"); addPreset("Зелёный горошек", 400, "Гр"); addPreset("Майонез", 100, "Гр"); break;
                case ("Крабовый 6ч."): addPreset("Крабовые палочки", 200, "Гр"); addPreset("Яйцо", 2, "Шт"); addPreset("Кукуруза", 140, "Гр"); addPreset("Майонез", 100, "Гр"); addPreset("Зелень", 15, "Гр"); break;
                case ("Цезарь 6ч."): addPreset("Яйца перепелинные", 20, "Шт"); addPreset("Капуста айсберг", 1, "Шт"); addPreset("Креветки", 400, "Гр"); addPreset("Сухарики XpycTeam сырные", 1, "Уп"); addPreset("Соус Цезарь", 1, "Уп"); addPreset("Помидора Черри", 1, "Уп"); break;
                case ("Роллы"): addPreset("Роллы", 10*count, "Шт"); break;
                case ("Огурцы 6ч."): addPreset("Огурцы", 2, "Шт"); break;
                case ("Помидоры 6ч."): addPreset("Помидора", 2, "Шт"); break;
                case ("Лимоны 6ч."): addPreset("Лимон", 2, "Шт"); break;
                case ("Наггетсы 6ч."): addPreset("Наггетсы", 2, "Уп"); break;
            }
        }
        private void addPreset(String product,double count, String kgsht)
        {
            for(int i=0;i< dgvBuy.RowCount-1;i++)
                if(dgvBuy.Rows[i].Cells[1].Value.ToString().ToLower() == product.ToLower() && dgvBuy.Rows[i].Cells[3].Value.ToString()==kgsht)
                {
                    dgvBuy.Rows[i].Cells[2].Value = Convert.ToDouble(dgvBuy.Rows[i].Cells[2].Value) + count;
                    return;
                }
            dgvBuy.RowCount += 1;
            dgvBuy.Rows[dgvBuy.RowCount-2].Cells[1].Value = product;
            dgvBuy.Rows[dgvBuy.RowCount-2].Cells[2].Value = count;
            dgvBuy.Rows[dgvBuy.RowCount-2].Cells[3].Value = kgsht;
        }

        private void dgvBuy_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvResize();
        }
        private void dgvBuy_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvResize();
        }
        private void dgvResize()
        {
            if (dgvBuy.RowCount > 15)
                dgvBuy.Width = 460;
            else
                dgvBuy.Width = 443;
        }

        private void dgvMoney_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}