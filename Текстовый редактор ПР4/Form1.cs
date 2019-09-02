using Microsoft.Win32;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Текстовый_редактор_ПР4
{
    public partial class Form1 : Form
    {
        enum fr { Find, Replace} // перечисление

        INIManager ini = new INIManager(@"C:\Users\Demo\Desktop\Работа\ООП\Текстовый редактор ПР4\Текстовый редактор ПР4.ini"); // Инициализация ини-файла
        public Form1()
        {
            InitializeComponent(); // инициализация компонентов
            foreach (FontFamily fm in FontFamily.Families) toolStripComboBoxFonts.Items.Add(fm.Name); // цикл заполнения комбобокса
            toolStripComboBoxFonts.Items.RemoveAt(0); // удаление первого item`a комбобокса
            while ((string)Registry.GetValue(string.Format("HKEY_CURRENT_USER\\John\\{0}\\", "LicenseNew"), "InputData", null)
                != CreateMD5(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "John")) // проверка лицензии
            {
                MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name); 
                Registry.SetValue(string.Format("HKEY_CURRENT_USER\\John\\{0}\\", "LicenseNew"), "InputData",
                        Microsoft.VisualBasic.Interaction.InputBox("Введите ключ", "Активация", "", 540, 360).ToLower());
            }
            try
            {
                menuStrip1.BackColor = Color.FromArgb((int)Registry.GetValue(string.Format("HKEY_CURRENT_USER\\John\\{0}\\", "LicenseNew"), "Color", null));
                toolStripComboBoxFonts.SelectedItem = ini.GetPrivateString("Form","Font");
                numericUpDown1.Value = Convert.ToInt32(ini.GetPrivateString("Form","Num"));
            }
            catch { }
        }

        
        
        /// <summary>
        /// Создание нового файла
        /// </summary>
        public void NewFile(object sender, EventArgs e)
        {
            if (RTBMain.Lines.Length != 0) SaveFile(sender, e); // сохранение файла в случае текста
            RTBMain.Clear(); // очистка полей
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Users\\%UserName%\\Desktop"; // корневая директория - раб. стол
                openFileDialog.Filter = "txt files (*.txt)|*.txt|RTF files (*.RTF)|*.RTF"; // фильтер файлов
                openFileDialog.FilterIndex = 2; // стоковое значение фильтра
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RTBMain.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText); // сохранение файла
                }
            }
        }
        /// <summary>
        /// Сохранение файла
        /// </summary>
        private void SaveFile(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\Users\\%UserName%\\Desktop"; // корневая директория 
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|RTF files (*.RTF)|*.RTF"; // фильтр
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RTBMain.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText); // сохранение файла
                }
            }
        }
        /// <summary>
        /// Изменение приближения 
        /// </summary>
        private void toolStripZoom_Click(object sender, EventArgs e)
        {
            try
            {
                RTBMain.ZoomFactor *= ((sender as ToolStripButton).Text == "Увеличить" ? 2 : 0.2f); // изменение зума
                StatusZoom.Text = string.Format("Размерность: {0}", RTBMain.ZoomFactor); // вывод размерности
            }
            catch { }
        }
        /// <summary>
        /// Поиск по тексту
        /// </summary>
        private void TextFind(object sender, EventArgs e)
        {
            FindReplace findReplace = new FindReplace((byte)((sender is ToolStripMenuItem ? // инициализация экземпляра формы
                (sender as ToolStripMenuItem).Text == "Найти" : (sender as ToolStripButton).Text == "Найти") ? fr.Find : fr.Replace));
            findReplace.buttonFind.Click += (object s, EventArgs ev) => NextFind(findReplace.textBox1.Text);
            findReplace.buttonFind2.Click += (object s, EventArgs ev) => NextFind(findReplace.textBox2.Text);
            findReplace.buttonRepAll.Click += (object s, EventArgs ev) => RTBMain.Text = RTBMain.Text.Replace(findReplace.textBox2.Text, findReplace.textBox3.Text);
            findReplace.Show(); // показ формы
        }
        /// <summary>
        /// Поиск по тексту
        /// </summary>
        /// <param name="str"></param>
        private void NextFind(string str)
        {
            try
            {
                RTBMain.SelectionStart = RTBMain.Find(str, RTBMain.SelectionStart + 1 + str.Length >= RTBMain.TextLength ? 0 :
                    RTBMain.SelectionStart + 1, RTBMain.TextLength, RichTextBoxFinds.None); // начальный индекс выделения
                RTBMain.SelectionLength = str.Length; // длина выделения
                RTBMain.SelectionColor = Color.Yellow; // цвет выделения
            }
            catch { }
        }
        /// <summary>
        /// Копирование
        /// </summary>
        private void textCopy(object sender, EventArgs e)
        {
            RTBMain.Copy(); 
        }
        /// <summary>
        /// Вырезать
        /// </summary>
        private void TextCut(object sender, EventArgs e)
        {
            RTBMain.Cut();
        }
        /// <summary>
        /// Вставка текста
        /// </summary>
        private void TextPaste(object sender, EventArgs e)
        {
            RTBMain.Paste();
        }
        /// <summary>
        /// Изменение текста
        /// </summary>
        private void RTBMain_TextChanged(object sender, EventArgs e)
        {
            StatusText.Text = string.Format("Колличество символов: {0}", RTBMain.TextLength); // вывод кол-ва символов
        }
        /// <summary>
        /// Изменение значения
        /// </summary>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RTBMain.SelectionFont = new Font(toolStripComboBoxFonts.SelectedItem.ToString(), (float)numericUpDown1.Value, FontStyle.Regular);
            if(sender is ToolStripComboBox)
            ini.WritePrivateString("Form", "Font", toolStripComboBoxFonts.SelectedItem.ToString());
            if(sender is NumericUpDown)
            ini.WritePrivateString("Form", "Num", numericUpDown1.Value.ToString());
        }
        /// <summary>
        /// Изменение положения текста
        /// </summary>
        private void toolStripRigthAligment_Click(object sender, EventArgs e)
        {
            RTBMain.SelectionAlignment = (sender as ToolStripButton).Text == "Выравнивание текста слева" ? HorizontalAlignment.Left : 
                (sender as ToolStripButton).Text == "Выравнивание текста справа" ? HorizontalAlignment.Right : HorizontalAlignment.Center;
        }
        /// <summary>
        /// Изменение шрифта
        /// </summary>
        private void toolStripBol_Click(object sender, EventArgs e)
        {
            switch((sender as ToolStripButton).Text)
            {
                case "Жирный шрифт": RTBMain.SelectionFont = new Font(RTBMain.SelectionFont, FontStyle.Bold); break;
                case "Курсивный шрифт": RTBMain.SelectionFont = new Font(RTBMain.SelectionFont, FontStyle.Italic); break;
                case "Подчеркнутый шрифт": RTBMain.SelectionFont = new Font(RTBMain.SelectionFont, FontStyle.Underline); break;
                case "Зачеркнутый шрифт": RTBMain.SelectionFont = new Font(RTBMain.SelectionFont, FontStyle.Strikeout); break;
                case "Верхний регистр": RTBMain.SelectedText = RTBMain.SelectedText.ToUpper(); break;
                case "Нижний регистр": RTBMain.SelectedText = RTBMain.SelectedText.ToLower(); break;
            }
        }
        /// <summary>
        /// Вывод
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Выделить все
        /// </summary>
        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RTBMain.SelectAll();
        }
        /// <summary>
        /// Изменение цвета
        /// </summary>
        private void изменитьЦветПанелейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog1.Color;
            }
            Registry.SetValue(string.Format("HKEY_CURRENT_USER\\John\\{0}\\", "LicenseNew"), "Color", menuStrip1.BackColor.ToArgb());
        }
        /// <summary>
        /// Создание md5 хеша
        /// </summary>
        /// <param name="input">Исходный текст</param>
        /// <returns></returns>
        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }
    }
}
