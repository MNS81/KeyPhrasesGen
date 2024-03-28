using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace KeyPhrasesGen
{
    public partial class Form1 : Form
    {
        HashSet<string> first = new HashSet<string>();
        HashSet<string> second = new HashSet<string>();
        int listCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AuthorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://t.me/MNS81", UseShellExecute = true });
        }

        private void File1Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            File1Button.Text = path.Split(@"\")[^1];
            AddItemsToList(first, path);
            listCount++;
        }

        private void File2Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string path = openFileDialog1.FileName;
            File2Button.Text = path.Split(@"\")[^1];
            AddItemsToList(second, path);
            listCount++;
        }

        private void AddItemsToList(HashSet<string> list, string path)
        {
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
                list.Add(f.ReadLine());
            f.Close();
        }

        private void ClearAll()
        {
            first.Clear();
            second.Clear();
            listCount = 0;
            File1Button.Text = "Выбрать файл";
            File2Button.Text = "Выбрать файл";
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (listCount == 0 || listCount == 1)
                MessageBox.Show("Недостаточно данных для обработки!", "Внимание!");
            else
            {
                AddPhrases(first, second);
                AddPhrases(second, first);
                list.Sort();
                saveFileDialog1.DefaultExt = "txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string path = saveFileDialog1.FileName;
                StreamWriter f = new StreamWriter(path, false);
                foreach (string item in list)
                    f.WriteLine(item);
                f.Close();
                MessageBox.Show($"Список успешно сохранен в файл\n{path}", "Готово!");
            }
            ClearAll();

            void AddPhrases(HashSet<string> first, HashSet<string> second)
            {
                foreach (string item in first)
                    foreach (string item2 in second)
                    {
                        list.Add(item + " " + item2);
                    }
            }
        }
    }
}
