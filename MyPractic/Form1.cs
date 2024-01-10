using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyPractic
{
    public partial class Form1 : Form
    {
        string input;
        string fileName;
        string newpath;
        string pathReport;
        string DirName;
        Thread MyThread; 
   
           
        public Form1()
        {
            InitializeComponent();
            progressBar.Step = 100;
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
            //using (var fbd = new FolderBrowserDialog())
            //{

            //    if (fbd.ShowDialog() == DialogResult.OK)
            //    {
            //        DirName = fbd.SelectedPath;
            //    }
            //}
        }


        public void searchWords()
        {
            //var contents = Directory.EnumerateFiles(DirName, "*.txt").Select(File.ReadAllLines).ToString(); //читать файлы только с таким расширением
            //string content = contents;// сложили в строку
            //Char[] Sep = { ' ', ',' };
            //string str = textBoxInput.Text;
            //string[] words = content.Split(Sep, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("Совпадений не найдено!"); //Выводим если совпадений не найдено
            //foreach (string word in words)
            //{
            //    if (str.Equals(word))
            //    {
            //        Console.WriteLine("Есть совпадение!"); //Выводим если совпадения найдены
            //        break;
            //    }
            //}
            FileInfo fileInf = new FileInfo(fileName);
            Char[] Sep = { ' ', ',' };
            string str = textBoxInput.Text;
            Regex regex = new Regex(str);
            string target = "*******";
            String[] arrString = str.Split(Sep);
            string fileText = File.ReadAllText(fileName);//считали строки из файла
            InfoMyFile();
            foreach (string s in arrString) { 
            if (fileText.Contains(s)) {
                    
                    fileInf.CopyTo(newpath, true);// копировали файл в новую папку
                 //либо создать новый
                StreamWriter file = new StreamWriter(newpath);
                string result = regex.Replace(fileText, target);//наши слова заменяются на звездочки
                //записать в него
                file.Write(result);
                //закрыть для сохранения данных
                file.Close();
                    Thread.Sleep(100);
                progressBar.PerformStep();
                  MessageBox.Show("Содержит данные слова");
                }      
                else MessageBox.Show("не содержит таких слов");
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
         MyThread = new Thread(delegate () {
            searchWords();
         });
            MyThread.Start();
        }

        private void labelNewpath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newpath = saveFileDialog1.FileName;
            }
        }

        public void InfoMyFile()
        {
            StreamWriter file = new StreamWriter(pathReport);//путь куда сохранить
            FileInfo files = new FileInfo(fileName);
          
            string directoryName = Path.GetDirectoryName(fileName);
            long size = files.Length;
            string namefile= files.Name;
            
            file.WriteLine($"Информация о файле {namefile}");
            file.WriteLine($"Путь к файлу {directoryName}");
            file.WriteLine($"Размер {size}");
            file.Close();
        }

        private void labelReport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathReport = saveFileDialog1.FileName;
            }
        }

        [Obsolete]
        private void buttonSuspend_Click(object sender, EventArgs e)// приостановка
        {
                if (MyThread.IsAlive)
                    MyThread.Suspend();
        }


        [Obsolete]
        private void buttonResume_Click(object sender, EventArgs e)//возобновление
        {
                if (MyThread.ThreadState == ThreadState.Suspended)
                MyThread.Suspend();
            

        }
        [Obsolete]
        private void buttonAbort_Click(object sender, EventArgs e)// завершение
        {
            progressBar.Value = 0;
      
                if (MyThread.IsAlive)
                MyThread.Abort();
            
        }
    }
}
