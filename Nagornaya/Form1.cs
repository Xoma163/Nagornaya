using System;
using System.Collections;
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

        string currentFilename = "";
        public Form1()
        {
            InitializeComponent();
            myInit();
        }
        public void myInit()
        {
            loadPeopleFirstTime();
            //MaximumSize = new Size(900,Screen.PrimaryScreen.Bounds.Size.Height-25);//= 

            Column4.ValueType = typeof(int);
            Column2.ValueType = typeof(int);
            Column12.ValueType = typeof(int);

            Column6.ValueType = typeof(int);
            Column7.ValueType = typeof(int);
            Column8.ValueType = typeof(int);
            Column9.ValueType = typeof(int);
            Column14.ValueType = typeof(int);

            currentFilename = readLastFileName();
            if (currentFilename != "")
                openFile(currentFilename);
        }

        int maxNameSize = 0;

        private void loadPeopleFirstTime()
        {
            //dgvAlco.RowCount = 1;
            Column5.Items.Clear();
            Column10.Items.Clear();
            Column13.Items.Clear();
            Column5.Items.Add("");

            FileInfo fi1 = new FileInfo("Peoples.txt");
            if (!fi1.Exists)
                using (StreamWriter sw = fi1.CreateText()) ;

            int index = 0;
            using (StreamReader sr = new StreamReader("Peoples.txt"))
            {
                string sLine = "";
                while (sLine != null)
                {
                    sLine = sr.ReadLine();
                    if (sLine != null)
                    {
                        if (sLine.Length > maxNameSize)
                            maxNameSize = sLine.Length;
                        Column5.Items.Add(sLine);
                        Column10.Items.Add(sLine);
                        Column13.Items.Add(sLine);
                        index++;

                    }
                }
                sr.Close();
            }
        }

        #region newOpenSave
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFilename = "";
            saveLastFileName(currentFilename);

            dgvFood.RowCount = 1;
            dgvAlco.RowCount = 1;
            dgvMoney.RowCount = 1;
            // dgvBuy.ColumnCount = 0;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Файловый диалог
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Хавка|*.havka";
            ofd.Title = "Открыть хавку";

            //Открываем и ждём нажатия кнопки
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                currentFilename = new FileInfo(ofd.FileName).Name;
                saveLastFileName(currentFilename);

                readDGV(sr, dgvFood);
                readDGV(sr, dgvAlco);
                readDGV(sr, dgvMoney);
                sr.Close();
            }
            checkWrongPeoples();
        }
        private void openFile(string fileName)
        {
            if (fileName is null)
                return;

            FileInfo fi1 = new FileInfo(fileName);
            if (!fi1.Exists)
                using (StreamWriter sw = fi1.CreateText()) ;

            StreamReader sr = new StreamReader(fileName);

            currentFilename = fileName;
            saveLastFileName(fileName);
            readDGV(sr, dgvFood);
            readDGV(sr, dgvAlco);
            readDGV(sr, dgvMoney);

            sr.Close();

            //хз почему не работает
            checkWrongPeoples();
        }
        private void checkWrongPeoples()
        {
            if (addThisPeople.Count() > 0)
            {
                String peoples = "";
                StreamWriter sw = new StreamWriter("Peoples.txt", true);
                for (int i = 0; i < addThisPeople.Count; i++)
                {
                    sw.WriteLine(addThisPeople[i]);
                    peoples += addThisPeople[i] + "; ";
                }
                sw.Close();
                MessageBox.Show("Некоторые люди отсутстовали в файле Peoples.txt, Они были автоматически добавлены: " + peoples);
                addThisPeople.Clear();
                peoples = "";
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (currentFilename != "")
            {
                notNullDgv();
                StreamWriter sw = new StreamWriter(currentFilename);

                saveDGV(sw, dgvFood);
                saveDGV(sw, dgvAlco);
                saveDGV(sw, dgvMoney);

                sw.Close();
            }
            else
                MessageBox.Show("Открой или сохрани как файл сначала");
        }
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notNullDgv();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Хавка|*.havka";
            sfd.Title = "Сохранить хавку";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                currentFilename = new FileInfo(sfd.FileName).Name;

                saveDGV(sw, dgvFood);
                saveDGV(sw, dgvAlco);
                saveDGV(sw, dgvMoney);

                sw.Close();
            }
        }
        private void saveLastFileName(string filaname)
        {
            StreamWriter sw = new StreamWriter("Settings.txt");
            sw.WriteLine(filaname);
            sw.Close();
        }
        private string readLastFileName()
        {
            FileInfo fi1 = new FileInfo("Settings.txt");
            if (!fi1.Exists)
                using (StreamWriter sw = fi1.CreateText()) ;

            StreamReader sr = new StreamReader("Settings.txt");
            string fileName = sr.ReadLine();
            sr.Close();
            return fileName;
        }
        private void saveDGV(StreamWriter sw, DataGridView dgv)
        {
            sw.WriteLine(dgv.RowCount);
            sw.WriteLine(dgv.ColumnCount);
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                    sw.Write(dgv.Rows[i].Cells[j].Value + ";");
                if (i != dgv.RowCount - 1)
                    sw.WriteLine("");
            }
            sw.WriteLine();
            sw.WriteLine("----------");
        }
        private void readDGV(StreamReader sr, DataGridView dgv)
        {
            int a = Convert.ToInt32(sr.ReadLine()) - 1;
            int b = Convert.ToInt32(sr.ReadLine());
            dgv.Rows.Clear();
            dgv.Rows.Add(a);
            dgv.ColumnCount = b;
            for (int i = 0; i < a; i++)
            {
                //Считываем в массив строк
                string[] mas = sr.ReadLine().Split(';');

                for (int j = 0; j < b; j++)
                    if (mas[j] == "True")
                        dgv.Rows[i].Cells[j].Value = true;
                    else if (mas[j] == "False")
                        dgv.Rows[i].Cells[j].Value = false;
                    else
                        if (Int32.TryParse(mas[j], out int c))
                        dgv.Rows[i].Cells[j].Value = c;
                    else
                        dgv.Rows[i].Cells[j].Value = mas[j];


            }
            sr.ReadLine();
            sr.ReadLine();
        }
        #endregion

        private void notNullDgv()
        {
            for (int i = 0; i < dgvFood.RowCount - 1; i++)
                for (int j = 0; j < dgvFood.ColumnCount; j++)
                    if (j != 6)
                    {
                        if (dgvFood.Rows[i].Cells[j].Value is null)
                            dgvFood.Rows[i].Cells[j].Value = "";
                    }
                    else
                    if (!(dgvFood.Rows[i].Cells[j].Value is true) && !(dgvFood.Rows[i].Cells[j].Value is false))
                        dgvFood.Rows[i].Cells[j].Value = false;

            for (int i = 0; i < dgvMoney.RowCount - 1; i++)
                for (int j = 0; j < dgvMoney.ColumnCount; j++)
                    if (dgvMoney.Rows[i].Cells[j].Value is null)
                        dgvMoney.Rows[i].Cells[j].Value = "";
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //АнтиNull
            notNullDgv();
            if (testDgv())
            {
                int sumBuy = 0;
                int sumPeople = 0;
                int people = dgvMoney.RowCount - 1;
                int buy = dgvFood.RowCount - 1;

                //заполняем sumBuy
                for (int i = 0; i < buy; i++)
                    if (Int32.TryParse(dgvFood.Rows[i].Cells[4].Value.ToString(), out int a))
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
                    dgvMoney.Rows[i].Cells[2].Value = 0;
                    dgvMoney.Rows[i].Cells[3].Value = 0;

                    for (int j = 0; j < buy; j++)
                        if (dgvFood.Rows[j].Cells[5].Value.ToString() == dgvMoney.Rows[i].Cells[0].Value.ToString() && dgvFood.Rows[j].Cells[4].Value.ToString() != "")
                        {
                            dgvMoney.Rows[i].Cells[1].Value = Convert.ToInt32(dgvMoney.Rows[i].Cells[1].Value) + Convert.ToInt32(dgvFood.Rows[j].Cells[4].Value);
                            sumPeople += Convert.ToInt32(dgvFood.Rows[j].Cells[4].Value);
                        }
                }


                //Здесь считываю всю алкашку
                List<string> list = new List<string>();
                for (int i = 0; i < dgvAlco.RowCount - 1; i++)
                {
                    string readedString = dgvAlco.Rows[i].Cells[1].Value.ToString();
                    if (readedString != "")
                        list.AddRange(readedString.Split(','));
                }

                list.Sort();
                List<string> listDist = list.Distinct().ToList();
                int[] matrix = new int[listDist.Count()];

                //Тут я считаю количество вхождений
                for (int i = 0; i < matrix.Length; i++)
                    for (int j = 0; j < list.Count; j++)
                        if (listDist[i] == list[j])
                            matrix[i]++;

                int sumAlco = 0;
                //А тут среднюю цену в зависимости от количества человек
                for (int i = 0; i < matrix.Length; i++)
                    for (int j = 0; j < dgvFood.RowCount - 1; j++)
                        if (dgvFood.Rows[j].Cells[1].Value.ToString() == listDist[i])
                        {
                            matrix[i] = Convert.ToInt32(dgvFood.Rows[j].Cells[4].Value) / matrix[i];
                            sumAlco += Convert.ToInt32(dgvFood.Rows[j].Cells[4].Value);
                        }

                //Считаю долг и долгитог
                for (int i = 0; i < people; i++)
                {
                    dgvMoney.Rows[i].Cells[2].Value = (sumBuy - sumAlco) / people;
                    string currentName = dgvMoney.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < dgvAlco.RowCount - 1; j++)
                        if (dgvAlco.Rows[j].Cells[0].Value.ToString() == currentName)
                            if (dgvAlco.Rows[j].Cells[1].Value.ToString() != "")
                            {
                                string[] arr = dgvAlco.Rows[j].Cells[1].Value.ToString().Split(',');
                                dgvMoney.Rows[i].Cells[3].Value = 0;
                                for (int k = 0; k < matrix.Length; k++)
                                    for (int l = 0; l < arr.Length; l++)
                                        if (listDist[k] == arr[l])
                                            dgvMoney.Rows[i].Cells[3].Value = Convert.ToInt32(dgvMoney.Rows[i].Cells[3].Value) + matrix[k];
                            }
                    dgvMoney.Rows[i].Cells[5].Value = Convert.ToInt32(dgvMoney.Rows[i].Cells[2].Value) + Convert.ToInt32(dgvMoney.Rows[i].Cells[3].Value) - Convert.ToInt32(dgvMoney.Rows[i].Cells[4].Value) - Convert.ToInt32(dgvMoney.Rows[i].Cells[1].Value);
                }

                howTo howTo = new howTo(maxNameSize);
                howTo.StartPosition = FormStartPosition.CenterParent;

                howTo.clear();

                string mainBuyer = Column5.Items[1].ToString();

                for (int i = 0; i < people; i++)
                {
                    if (Convert.ToInt32(dgvMoney.Rows[i].Cells[5].Value) < 0)
                        if (dgvMoney.Rows[i].Cells[0].Value.ToString() != mainBuyer)
                            howTo.addRow(mainBuyer, " → ", dgvMoney.Rows[i].Cells[0].Value.ToString(), Math.Abs(Convert.ToInt32(dgvMoney.Rows[i].Cells[5].Value)) + " руб.");
                    if (Convert.ToInt32(dgvMoney.Rows[i].Cells[5].Value) > 0)
                        howTo.addRow(dgvMoney.Rows[i].Cells[0].Value.ToString(), " → ", mainBuyer, dgvMoney.Rows[i].Cells[5].Value + " руб.");
                }

                labelSumPeople_.Text = (sumBuy - sumAlco) + "";
                labelSumProduct_.Text = (sumPeople - sumAlco) + "";
                labelPeople_.Text = people + "";
                if (people != 0)
                {
                    labelAvgFood_.Text = (sumBuy - sumAlco) / people + "";
                    labelAvgTotal_.Text = sumBuy / people + "";
                    labelAvgAlco_.Text = sumAlco / people + "";
                }
                else
                {
                    labelAvgFood_.Text = "Не дели на ноль :(";
                    labelAvgTotal_.Text = "Не дели на ноль :(";
                    labelAvgAlco_.Text = "Не дели на ноль :(";

                }
                labelAlco_.Text = sumAlco + "";
                labelSumTotal_.Text = sumBuy + "";

                howTo.ShowDialog();
                howTo.Dispose();

            }
        }

        #region dgvClicks
        private int currentMouseOverRow;
        private int currentMouseOverColumn;
        private void dgvFood_MouseClick(object sender, MouseEventArgs e)
        {
            //label1.Text = "cmor " + currentMouseOverRow + " cmoc " + currentMouseOverColumn;
            currentMouseOverRow = dgvFood.HitTest(e.X, e.Y).RowIndex;
            currentMouseOverColumn = dgvFood.HitTest(e.X, e.Y).ColumnIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                if (currentMouseOverColumn == 0)
                {
                    MenuItem delete = new MenuItem("Удалить строку");
                    MenuItem id = new MenuItem("Задать #");
                    m.MenuItems.AddRange(new MenuItem[] { delete, id });
                    m.MenuItems[0].Click += new System.EventHandler(this.m_deleteFood);
                    m.MenuItems[1].Click += new System.EventHandler(this.m_id);
                }
                if (currentMouseOverRow >= 0 && currentMouseOverColumn == 0)
                    m.Show(dgvFood, new Point(e.X, e.Y));
            }
        }
        private void m_deleteFood(object sender, System.EventArgs e)
        {
            if (currentMouseOverRow < dgvFood.RowCount - 1)
                dgvFood.Rows.RemoveAt(currentMouseOverRow);
            else
                MessageBox.Show("Нельзя удалить последнюю строку");
        }
        private void m_id(object sender, System.EventArgs e)
        {
            for (int i = 0; i < dgvFood.RowCount - 1; i++)
                dgvFood.Rows[i].Cells[0].Value = i + 1;
        }

        private void dgvAlco_MouseClick(object sender, MouseEventArgs e)
        {
            currentMouseOverRow = dgvAlco.HitTest(e.X, e.Y).RowIndex;
            currentMouseOverColumn = dgvAlco.HitTest(e.X, e.Y).ColumnIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverColumn == 0)
                {
                    MenuItem delete = new MenuItem("Удалить строку");
                    MenuItem addAll = new MenuItem("Добавить всех");

                    m.MenuItems.AddRange(new MenuItem[] { delete, addAll });
                    m.MenuItems[0].Click += new System.EventHandler(this.m_deleteAlco);
                    m.MenuItems[1].Click += new System.EventHandler(this.m_addAllAlco);
                }
                if (currentMouseOverRow >= 0 && currentMouseOverColumn == 0)
                    m.Show(dgvAlco, new Point(e.X, e.Y));
            }
        }
        private void m_deleteAlco(object sender, System.EventArgs e)
        {
            if (currentMouseOverRow < dgvFood.RowCount - 1)
                dgvAlco.Rows.RemoveAt(currentMouseOverRow);
            else
                MessageBox.Show("Нельзя удалить последнюю строку");
        }
        private void m_addAllAlco(object sender, System.EventArgs e)
        {
            dgvAlco.RowCount = Column5.Items.Count;
            for (int i = 0; i < dgvAlco.RowCount - 1; i++)
                dgvAlco.Rows[i].Cells[0].Value = Column5.Items[i];
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
                    m.MenuItems[0].Click += new System.EventHandler(this.m_deleteMoney);
                    m.MenuItems[1].Click += new System.EventHandler(this.m_addAllMoney);
                }
                if (currentMouseOverRow >= 0 && currentMouseOverColumn == 0)
                    m.Show(dgvMoney, new Point(e.X, e.Y));
            }
        }
        private void m_deleteMoney(object sender, System.EventArgs e)
        {
            if (currentMouseOverRow < dgvMoney.RowCount - 1)
                dgvMoney.Rows.RemoveAt(currentMouseOverRow);
            else
                MessageBox.Show("Нельзя удалить последнюю строку");

        }
        private void m_addAllMoney(object sender, System.EventArgs e)
        {
            //Хз что я сделал, но всё работает так. Оставлю.
            dgvMoney.RowCount = Column5.Items.Count;
            int k = 0;
            for (int i = 0; i < dgvMoney.RowCount; i++)
            {
                if (Column5.Items[i].ToString() != "")
                {
                    dgvMoney.Rows[k].Cells[0].Value = Column5.Items[i];
                    k++;
                }
            }
        }
        #endregion

        private void пресетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = (sender as ToolStripMenuItem).Text;
            int count = Convert.ToInt32(toolStripMenuItem2.Text);
            switch (name)
            {
                case ("Шавуха"): addPreset("Огурец", 0.5 * count, "Шт"); addPreset("Помидора", 0.5 * count, "Шт"); addPreset("Филе курицы", 0.5 * count, "Шт"); addPreset("Сыр", 50 * count, "Гр"); addPreset("Лаваш", 0.5 * count, "Шт"); addPreset("Сметана", 30 * count, "Гр"); addPreset("Майонез", 15 * count, "Гр"); addPreset("Зубчик чеснока", 0.5 * count, "Шт"); addPreset("Приправа для шаурмы", 0 * count, " "); addPreset("Корейская морковка", 50 * count, "Гр"); break;
                case ("Пицца"): addPreset("Основа для пиццы", 1 * count, "Шт"); addPreset("Помидора", 2 * count, "Шт"); addPreset("Сыр", 100 * count, "Гр"); addPreset("Колбаса", 300 * count, "Гр"); addPreset("Майонез", 20 * count, "Гр"); addPreset("Кетчуп", 20 * count, "Гр"); break;
                case ("Пельмешки"): addPreset("Пельмени", 15 * 12 * count, "Гр"); break;
                case ("Оливье 6ч."): addPreset("Картошка", 3, "Шт"); addPreset("Морковь", 1.5, "Шт"); addPreset("Огурец", 2, "Шт"); addPreset("Яйцо", 4, "Шт"); addPreset("Ветчина", 300, "Гр"); addPreset("Зелёный горошек", 400, "Гр"); addPreset("Майонез", 100, "Гр"); break;
                case ("Крабовый 6ч."): addPreset("Крабовые палочки", 200, "Гр"); addPreset("Яйцо", 2, "Шт"); addPreset("Кукуруза", 140, "Гр"); addPreset("Майонез", 100, "Гр"); addPreset("Зелень", 15, "Гр"); break;
                case ("Цезарь 6ч."): addPreset("Яйца перепелинные", 20, "Шт"); addPreset("Капуста айсберг", 1, "Шт"); addPreset("Креветки", 400, "Гр"); addPreset("Сухарики XpycTeam сырные", 1, "Уп"); addPreset("Соус Цезарь", 1, "Уп"); addPreset("Помидора Черри", 1, "Уп"); break;
                case ("С чипсами и морковкой 6ч."): addPreset("Говядина", 700, "Гр"); addPreset("Чипсы с беконом", 1, "Уп"); addPreset("Корейская морковка", 200, "Гр"); addPreset("Майонез", 200, "Гр"); break;
                case ("Роллы"): addPreset("Роллы", 10 * count, "Шт"); break;
                case ("Огурцы 6ч."): addPreset("Огурец", 2, "Шт"); break;
                case ("Помидоры 6ч."): addPreset("Помидора", 2, "Шт"); break;
                case ("Лимоны 6ч."): addPreset("Лимон", 2, "Шт"); break;
                case ("Наггетсы 6ч."): addPreset("Наггетсы", 2, "Уп"); break;
            }
        }
        private void addPreset(string product, double count, string kgsht)
        {
            for (int i = 0; i < dgvFood.RowCount - 1; i++)
                if (dgvFood.Rows[i].Cells[1].Value.ToString().ToLower() == product.ToLower() && dgvFood.Rows[i].Cells[3].Value.ToString() == kgsht)
                {
                    dgvFood.Rows[i].Cells[2].Value = Convert.ToInt32(dgvFood.Rows[i].Cells[2].Value) + count;
                    return;
                }
            dgvFood.RowCount += 1;
            dgvFood.Rows[dgvFood.RowCount - 2].Cells[1].Value = product;
            dgvFood.Rows[dgvFood.RowCount - 2].Cells[2].Value = count;
            dgvFood.Rows[dgvFood.RowCount - 2].Cells[3].Value = kgsht;
        }

        private void раанародToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peoples peoples = new Peoples();

            peoples.addPeople();
            peoples.ShowDialog();

            List<string> peopleBefore = peoples.peopleBefore;
            List<string> peopleAfter = peoples.peopleAfter;

            string[] both = peopleBefore.Intersect(peopleAfter).ToArray();
            string[] deleted = peopleBefore.Except(peopleAfter).ToArray();
            string[] added = peopleAfter.Except(peopleBefore).ToArray();

            peoples.Dispose();

            notNullDgv();

            //Удаляем
            for (int i = 0; i < deleted.Count(); i++)
            {
                //Удаляю вхождения в еде
                for (int j = 0; j < dgvFood.RowCount - 1; j++)
                    if (dgvFood.Rows[j].Cells[5].Value.ToString() == deleted[i])
                        dgvFood.Rows[j].Cells[5].Value = "";

                //бабле
                for (int j = 0; j < dgvMoney.RowCount - 1; j++)
                    if (dgvMoney.Rows[j].Cells[0].Value.ToString() == deleted[i])
                    {
                        dgvMoney.Rows.RemoveAt(j);
                        break;
                    }

                //алкашке
                for (int j = 0; j < dgvAlco.RowCount - 1; j++)
                    if (dgvAlco.Rows[j].Cells[0].Value.ToString() == deleted[i])
                    {
                        dgvAlco.Rows.RemoveAt(j);
                        break;
                    }
                Column5.Items.Remove(deleted[i]);
                Column10.Items.Remove(deleted[i]);
                Column13.Items.Remove(deleted[i]);
            }
            StreamWriter sw = new StreamWriter("Peoples.txt");

            //Добавляем в файл
            for (int i = 0; i < peopleAfter.Count; i++)
                sw.WriteLine(peopleAfter[i]);
            sw.Close();

            //Добавляем в столбцы
            for (int i = 0; i < added.Length; i++)
            {
                Column5.Items.Add(added[i]);
                Column10.Items.Add(added[i]);
                Column13.Items.Add(added[i]);
            }

        }

        List<String> addThisPeople = new List<String>();
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            String value = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (!Column5.Items.Contains(value))
            {

                Column5.Items.Add(value);
                Column10.Items.Add(value);
                Column13.Items.Add(value);

                addThisPeople.Add(value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkWrongPeoples();
        }

        private void хлепToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рассчёты людей проводятся относительно первого человека в списке. Не рекомендуется изменять файлы вручную.");
        }
    }
}