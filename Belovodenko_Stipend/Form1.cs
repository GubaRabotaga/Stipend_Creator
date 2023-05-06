using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Xceed.Document.NET;
using Novacode;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belovodenko_Stipend
{
  
    public partial class Form1 : Form
    {
       
        FolderBrowserDialog fbd;
        string ChosedBut = "";
        string GoodChoose = "";
        string path = @"c:\Games\Глонасс\Glonass.txt";
        string doc1 = @"c:\Games\Ресурсы\Оглавление.rtf";
        string doc2 = @"c:\Games\Ресурсы\Введение.rtf";
        string doc3 = @"c:\Games\Ресурсы\Глава 1.rtf";
        string doc4 = @"c:\Games\Ресурсы\Лабораторная работа 1.rtf";
        string doc5 = @"c:\Games\Ресурсы\Глава 2.rtf";
        string doc6 = @"c:\Games\Ресурсы\Лабораторная работа 2.rtf";
        string doc7 = @"c:\Games\Ресурсы\Глава 3.rtf";
        string doc8 = @"c:\Games\Ресурсы\Лабораторная работа 3.rtf";
        string doc9 = @"c:\Games\Ресурсы\Презентация.rtf";
        string doc10 = @"c:\Games\Ресурсы\Примеры.rtf";
        string doc11 = @"c:\Games\Ресурсы\Заключение.rtf";
        string doc12 = @"c:\Games\Ресурсы\Источники.rtf";
        string doc13 = @"c:\Games\Ресурсы\Приложение А.rtf";
        string doc14 = @"c:\Games\Ресурсы\Приложение Б.rtf";
        string doc15 = @"c:\Games\Ресурсы\Приложение В.rtf";
        string l1 = @"c:\Games\Ресурсы\Лабораторная работа 1.rtf";
        string l2 = @"c:\Games\Ресурсы\Лабораторная работа 2.rtf";
        string l3 = @"c:\Games\Ресурсы\Лабораторная работа 3.rtf";
        string l4 = @"c:\Games\Ресурсы\Лабораторная работа 4.rtf";
        string l5 = @"c:\Games\Ресурсы\Лабораторная работа 5.rtf";
        string l6 = @"c:\Games\Ресурсы\Лабораторная работа 6.rtf";
        string l7 = @"c:\Games\Ресурсы\Лабораторная работа 7.rtf";
        string l8 = @"c:\Games\Ресурсы\Лабораторная работа 8.rtf";
        string l9 = @"c:\Games\Ресурсы\Лабораторная работа 9.rtf";
        string l10 = @"c:\Games\Ресурсы\Лабораторная работа 10.rtf";
        string l11 = @"c:\Games\Ресурсы\Лабораторная работа 11.rtf";
        string l12 = @"c:\Games\Ресурсы\Лабораторная работа 12.rtf";
        string l13 = @"c:\Games\Ресурсы\Лабораторная работа 13.rtf";
        string l14 = @"c:\Games\Ресурсы\Лабораторная работа 14.rtf";
        string l15 = @"c:\Games\Ресурсы\Лабораторная работа 15.rtf";
        string b1 = @"c:\Games\Ресурсы\Книга 1.rtf";
        string b2 = @"c:\Games\Ресурсы\Книга 2.rtf";
        string b3 = @"c:\Games\Ресурсы\Книга 3.rtf";
        string b4 = @"c:\Games\Ресурсы\Книга 4.rtf";
        string b5 = @"c:\Games\Ресурсы\Книга 5.rtf";
        string b6 = @"c:\Games\Ресурсы\Книга 6.rtf";
        string b7 = @"c:\Games\Ресурсы\Книга 7.rtf";
        string b8 = @"c:\Games\Ресурсы\Книга 8.rtf";
        string b9 = @"c:\Games\Ресурсы\Книга 9.rtf";
        string b10 = @"c:\Games\Ресурсы\Книга 10.rtf";
        string b11 = @"c:\Games\Ресурсы\Книга 11.rtf";
        string b12 = @"c:\Games\Ресурсы\Книга 12.rtf";
        string b13 = @"c:\Games\Ресурсы\Книга 13.rtf";
        string b14 = @"c:\Games\Ресурсы\Книга 14.rtf";
        string b15 = @"c:\Games\Ресурсы\Книга 15.rtf";
        string test1 = @"c:\Games\Тесты\Тест 1.txt";
        string test2 = @"c:\Games\Тесты\Тест 2.txt";
        string test3 = @"c:\Games\Тесты\Тест 3.txt";
        string test4 = @"c:\Games\Тесты\Тест 4.txt";
        string test5 = @"c:\Games\Тесты\Тест 5.txt";
        string test6 = @"c:\Games\Тесты\Тест 6.txt";
        string test7 = @"c:\Games\Тесты\Тест 7.txt";
        string test8 = @"c:\Games\Тесты\Тест 8.txt";
        string test9 = @"c:\Games\Тесты\Тест 9.txt";
        string test10 = @"c:\Games\Тесты\Тест 10.txt";
        List<string> GlossValue = File.ReadLines(@"c:\Games\Глонасс\Glonass.txt").ToList();
        List<string> NewGlossValue = new List<string>();
        bool addglos = true;
        bool[] exist;
        public Form1()
        {
            
            InitializeComponent();
      
        }

        public void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = false;
            ChosedBut = "Глоссарий";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            textBox1.Visible = true;
            button31.Visible = true;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;
            label1.Visible = true;
            textBox4.Visible = true;
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
            exist = new bool[1000];
            textBox1.Visible = false;
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < GlossValue.Count; i++)
            {
                
                textBox1.Text = textBox1.Text  + GlossValue[i] + "\r\n";

            }
            
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "А" || a0 == "а")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i]  + "\r\n";
                }
               

            }

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Б" || a0 == "б")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

        
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ж" || a0 == "ж")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "В" || a0 == "в")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Г" || a0 == "г")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

          
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Д" || a0 == "д")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Е" || a0 == "е")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


           
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "З" || a0 == "з")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "И" || a0 == "и")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button13_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "К" || a0 == "к")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Л" || a0 == "л")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


          
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "М" || a0 == "м")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


          
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Н" || a0 == "н")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

          
        }

        private void button17_Click(object sender, EventArgs e)
        {
       
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "О" || a0 == "о")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "П" || a0 == "п")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

          
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Р" || a0 == "р")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "С" || a0 == "с")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

          
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Т" || a0 == "т")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "У" || a0 == "у")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ф" || a0 == "ф")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

          
        }

        private void button24_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Х" || a0 == "х")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ц" || a0 == "ц")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button26_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ч" || a0 == "ч")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button27_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ш" || a0 == "ш")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Э" || a0 == "э")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }

           
        }

        private void button29_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Ю" || a0 == "ю")
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


           
        }

        private void button30_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";


            for (int i = 0; i < GlossValue.Count; i++)
            {
                string a0 = "";
                char[] a = GlossValue[i].ToCharArray();
                try
                {
                    a0 = a[0].ToString();
                }
                catch
                {

                }
                if (a0 == "Я" || a0 == "я" )
                {
                    textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                }


            }


          
        }

      

        private void button31_Click(object sender, EventArgs e)
        {
            if (label1.Visible == true)
            {
                label1.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                label1.Visible = true;
                textBox4.Visible = true;
            }
            textBox1.Text = "";
           
            if (addglos == true)
            {
                textBox1.Visible = false;
   
                addglos = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
            }
            else if (addglos == false)
            {
                textBox2.Visible = false;
                textBox3.Visible = false;
                button32.Visible = false;
                button33.Visible = false;
                textBox1.Visible = true;

                button31.Visible = true;
                addglos = true;
            }
    
        }

        public void button32_Click(object sender, EventArgs e)
        {
            NewGlossValue.Add(textBox2.Text.ToString());
            GlossValue.Add(textBox2.Text.ToString());
            textBox2.Text = "";
            File.WriteAllLines(path, GlossValue);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = "";
                for (int i = 0; i < GlossValue.Count; i++)
                {

                    NewGlossValue[i] = GlossValue[i];
                }
                GlossValue = GlossValue.Except(NewGlossValue).ToList();
            }
            catch
            {

            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            for (int i = 0; i < GlossValue.Count; i++)
            {

                textBox3.Text = textBox3.Text + GlossValue[i] + "\r\n";

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            label1.Visible = true;
            textBox4.Visible = true;
            ChosedBut = "Тесты";
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            richTextBox2.Text = "";
            textBox2.Visible = false;
            textBox3.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            textBox1.Visible = false;
            button31.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
            button43.Visible = false;
            button44.Visible = false;
            button45.Visible = false;
            button46.Visible = false;
            button47.Visible = false;
            button48.Visible = false;
            button49.Visible = false;
            button50.Visible = false;

            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;


            string del = ".txt";
            button38.Text = Path.GetFileName(test1);
            try
            {
                button38.Text = button38.Text.Remove(button38.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button39.Text = Path.GetFileName(test2);
            try
            {
                button39.Text = button39.Text.Remove(button39.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button40.Text = Path.GetFileName(test3);
            try
            {
                button40.Text = button40.Text.Remove(button40.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button41.Text = Path.GetFileName(test4);
            try
            {
                button41.Text = button41.Text.Remove(button41.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button42.Text = Path.GetFileName(test5);
            try
            {
                button42.Text = button42.Text.Remove(button42.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button43.Text = Path.GetFileName(test6);
            try
            {
                button43.Text = button43.Text.Remove(button43.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button44.Text = Path.GetFileName(test7);
            try
            {
                button44.Text = button44.Text.Remove(button44.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button45.Text = Path.GetFileName(test8);
            try
            {
                button45.Text = button45.Text.Remove(button45.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button46.Text = Path.GetFileName(test9);
            try
            {
                button46.Text = button46.Text.Remove(button46.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button47.Text = Path.GetFileName(test10);
            try
            {
                button47.Text = button47.Text.Remove(button47.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }

          
           
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            textBox4.Visible = true;
            ChosedBut = "Лабораторные работы";
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            richTextBox1.Visible = true;
            textBox1.Visible = false;

            button31.Visible = false;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
            button49.Visible = true;
            button50.Visible = true;
   
            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            string del = ".rtf";
            button36.Text = Path.GetFileName(l13);
            try
            {
                button36.Text = button36.Text.Remove(button36.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button37.Text = Path.GetFileName(l14);
            try
            {
                button37.Text = button37.Text.Remove(button37.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button38.Text = Path.GetFileName(l1);
            try
            {
                button38.Text = button38.Text.Remove(button38.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button39.Text = Path.GetFileName(l2);
            try
            {
                button39.Text = button39.Text.Remove(button39.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button40.Text = Path.GetFileName(l3);
            try
            {
                button40.Text = button40.Text.Remove(button40.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button41.Text = Path.GetFileName(l4);
            try
            {
                button41.Text = button41.Text.Remove(button41.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button42.Text = Path.GetFileName(l5);
            try
            {
                button42.Text = button42.Text.Remove(button42.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button43.Text = Path.GetFileName(l6);
            try
            {
                button43.Text = button43.Text.Remove(button43.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button44.Text = Path.GetFileName(l7);
            try
            {
                button44.Text = button44.Text.Remove(button44.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button45.Text = Path.GetFileName(l8);
            try
            {
                button45.Text = button45.Text.Remove(button45.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button46.Text = Path.GetFileName(l9);
            try
            {
                button46.Text = button46.Text.Remove(button46.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button47.Text = Path.GetFileName(l10);
            try
            {
                button47.Text = button47.Text.Remove(button47.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button48.Text = Path.GetFileName(l11);
            try
            {
                button48.Text = button48.Text.Remove(button48.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button49.Text = Path.GetFileName(l12);
            try
            {
                button49.Text = button49.Text.Remove(button49.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button50.Text = Path.GetFileName(l15);
            try
            {
                button50.Text = button50.Text.Remove(button50.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }

           
            if (button36.Text == "")
            {
                button36.Visible = false;
            }
            if (button37.Text == "")
            {
                button37.Visible = false;
            }
            if (button38.Text == "")
            {
                button38.Visible = false;
            }
            if (button39.Text == "")
            {
                button39.Visible = false;
            }
            if (button40.Text == "")
            {
                button40.Visible = false;
            }
            if (button41.Text == "")
            {
                button41.Visible = false;
            }
            if (button42.Text == "")
            {
                button42.Visible = false;
            }
            if (button43.Text == "")
            {
                button43.Visible = false;
            }
            if (button44.Text == "")
            {
                button44.Visible = false;
            }
            if (button45.Text == "")
            {
                button45.Visible = false;
            }
            if (button46.Text == "")
            {
                button46.Visible = false;
            }
            if (button47.Text == "")
            {
                button47.Visible = false;
            }
            if (button48.Text == "")
            {
                button48.Visible = false;
            }
            if (button49.Text == "")
            {
                button49.Visible = false;
            }
            if (button50.Text == "")
            {
                button50.Visible = false;
            }
        
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;

            button31.Visible = false;
    
        }



        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            label1.Visible = true;
            textBox4.Visible = true;
            ChosedBut = "Оглавление";
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            richTextBox1.Visible = true;
            textBox1.Visible = false;
            button3.Visible = true;
            button31.Visible = false;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
            button49.Visible = true;
            button50.Visible = true;

            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            string del = ".rtf";
            button36.Text = Path.GetFileName(doc13);
            try
            {
                button36.Text = button36.Text.Remove(button36.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button37.Text = Path.GetFileName(doc14);
                try
                {
                    button37.Text = button37.Text.Remove(button37.Text.IndexOf(del), del.Length);
                }
                catch
                {

                }
            button38.Text = Path.GetFileName(doc1);
                    try
                    {
                        button38.Text = button38.Text.Remove(button38.Text.IndexOf(del), del.Length);
                    }
                    catch
                    {

                    }
            button39.Text = Path.GetFileName(doc2);
                        try
                        {
                            button39.Text = button39.Text.Remove(button39.Text.IndexOf(del), del.Length);
                        }
                        catch
                        {

                        }
            button40.Text = Path.GetFileName(doc3);
                            try
                            {
                                button40.Text = button40.Text.Remove(button40.Text.IndexOf(del), del.Length);
                            }
                            catch
                            {

                            }
            button41.Text = Path.GetFileName(doc4);
                                try
                                {
                                    button41.Text = button41.Text.Remove(button41.Text.IndexOf(del), del.Length);
                                }
                                catch
                                {

                                }
            button42.Text = Path.GetFileName(doc5);
                                    try
                                    {
                                        button42.Text = button42.Text.Remove(button42.Text.IndexOf(del), del.Length);
                                    }
                                    catch
                                    {

                                    }
            button43.Text = Path.GetFileName(doc6);
                                        try
                                        {
                                            button43.Text = button43.Text.Remove(button43.Text.IndexOf(del), del.Length);
                                        }
                                        catch
                                        {

                                        }
            button44.Text = Path.GetFileName(doc7);
                                            try
                                            {
                                                button44.Text = button44.Text.Remove(button44.Text.IndexOf(del), del.Length);
                                            }
                                            catch
                                            {

                                            }
            button45.Text = Path.GetFileName(doc8);
                                                try
                                                {
                                                    button45.Text = button45.Text.Remove(button45.Text.IndexOf(del), del.Length);
                                                }
                                                catch
                                                {

                                                }
            button46.Text = Path.GetFileName(doc9);
                                                    try
                                                    {
                                                        button46.Text = button46.Text.Remove(button46.Text.IndexOf(del), del.Length);
                                                    }
                                                    catch
                                                    {

                                                    }
            button47.Text = Path.GetFileName(doc10);
                                                        try
                                                        {
                                                            button47.Text = button47.Text.Remove(button47.Text.IndexOf(del), del.Length);
                                                        }
                                                        catch
                                                        {

                                                        }
            button48.Text = Path.GetFileName(doc11);
                                                            try
                                                            {
                                                                button48.Text = button48.Text.Remove(button48.Text.IndexOf(del), del.Length);
                                                            }
                                                            catch
                                                            {

                                                            }
            button49.Text = Path.GetFileName(doc12);
                                                                try
                                                                {
                                                                    button49.Text = button49.Text.Remove(button49.Text.IndexOf(del), del.Length);
                                                                }
                                                                catch
                                                                {

                                                                }
            button50.Text = Path.GetFileName(doc15);
                                                                    try
                                                                    {
                                                                        button50.Text = button50.Text.Remove(button50.Text.IndexOf(del), del.Length);
                                                                    }
                                                                    catch
                                                                    {

                                                                    }
                         
            
            if (button36.Text == "")
            {
                button36.Visible = false;
            }
            if (button37.Text == "")
            {
                button37.Visible = false;
            }
            if (button38.Text == "")
            {
                button38.Visible = false;
            }
            if (button39.Text == "")
            {
                button39.Visible = false;
            }
            if (button40.Text == "")
            {
                button40.Visible = false;
            }
            if (button41.Text == "")
            {
                button41.Visible = false;
            }
            if (button42.Text == "")
            {
                button42.Visible = false;
            }
            if (button43.Text == "")
            {
                button43.Visible = false;
            }
            if (button44.Text == "")
            {
                button44.Visible = false;
            }
            if (button45.Text == "")
            {
                button45.Visible = false;
            }
            if (button46.Text == "")
            {
                button46.Visible = false;
            }
            if (button47.Text == "")
            {
                button47.Visible = false;
            }
            if (button48.Text == "")
            {
                button48.Visible = false;
            }
            if (button49.Text == "")
            {
                button49.Visible = false;
            }
            if (button50.Text == "")
            {
                button50.Visible = false;
            }
         
        }

      
        private void button43_Click(object sender, EventArgs e)
        {
           
            fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
        }




        private  void button38_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc1, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l1, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b1, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test1);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {
                            
                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch{}

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc12, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b12, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l12, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc2, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l2, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b2, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test2);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc3, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l3, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            
            else
            if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b3, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test3);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc4, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l4, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
        
            else
                if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b4, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test4);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc5, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l5, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
       
            else
                if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b5, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test5);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc6, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l6, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b6, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test6);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc7, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l7, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b7, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test7);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc8, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l8, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b8, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test8);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc9, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l9, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b9, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test9);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc10, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l10, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b10, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                if (ChosedBut == "Тесты")
            {
                button52.BackColor = Color.Black;
                button53.BackColor = Color.Black;
                button54.BackColor = Color.Black;
                button55.BackColor = Color.Black;
                button56.BackColor = Color.Black;
                button57.BackColor = Color.Black;
                button52.Enabled = true;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                button57.Enabled = true;
                richTextBox3.Text = "";
                try
                {
                    string[] arStr = File.ReadAllLines(test10);
                    richTextBox2.Text = arStr[0];
                    if (arStr[1] == "1")
                    {
                        if (arStr[2] == "6")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button57.Text = arStr[8];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = true;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "5")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button56.Text = arStr[7];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = true;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "4")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button55.Text = arStr[6];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = true;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "3")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button54.Text = arStr[5];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = true;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "2")
                        {

                            button52.Text = arStr[3];
                            button53.Text = arStr[4];
                            button52.Visible = true;
                            button53.Visible = true;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                        if (arStr[2] == "1")
                        {

                            button52.Text = arStr[3];
                            button52.Visible = true;
                            button53.Visible = false;
                            button54.Visible = false;
                            button55.Visible = false;
                            button56.Visible = false;
                            button57.Visible = false;
                            richTextBox3.Visible = true;
                            GoodChoose = arStr[9];
                        }
                    }
                }
                catch { }

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {

                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc11, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;

            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b11, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l11, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc13, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }

            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b13, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l13, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc14, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b1, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l14, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (ChosedBut == "Оглавление")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(doc15, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
                 if (ChosedBut == "Книги")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(b15, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
            else
              if (ChosedBut == "Лабораторные работы")
            {
                richTextBox1.Text = "";
                richTextBox1.LoadFile(l15, RichTextBoxStreamType.RichText);
                richTextBox1.Select(0, richTextBox1.TextLength);
                richTextBox1.SelectionColor = Color.White;
            }
        }

       

        private void button52_Click(object sender, EventArgs e)
        {
            if (button52.Text == GoodChoose)
            {
                button52.BackColor = Color.LightGreen;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
            }
            else
            {
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
                button52.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: "+ GoodChoose;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (button53.Text == GoodChoose)
            {

                button53.BackColor = Color.LightGreen;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
            else
            {
                button53.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: " + GoodChoose;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (button54.Text == GoodChoose)
            {
                button54.BackColor = Color.LightGreen;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
            else
            {
                button54.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: " + GoodChoose;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (button55.Text == GoodChoose)
            {
                button55.BackColor = Color.LightGreen;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
            else
            {
                button55.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: " + GoodChoose;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (button56.Text == GoodChoose)
            {
                button56.BackColor = Color.LightGreen;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
            else
            {
                button56.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: " + GoodChoose;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (button57.Text == GoodChoose)
            {
                button57.BackColor = Color.LightGreen;
                richTextBox3.Text = "Вы правильно ответили на вопрос";
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
            else
            {
                button57.BackColor = Color.PaleVioletRed;
                richTextBox3.Text = "Вы неправильно ответили на вопрос правильный ответ: " + GoodChoose;
                button52.Enabled = false;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                button57.Enabled = false;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "" && ChosedBut != "Глоссарий")
            {
                button36.Visible = true;
                button37.Visible = true;
                button38.Visible = true;
                button39.Visible = true;
                button40.Visible = true;
                button41.Visible = true;
                button42.Visible = true;
                button43.Visible = true;
                button44.Visible = true;
                button45.Visible = true;
                button46.Visible = true;
                button47.Visible = true;
                button48.Visible = true;
                button49.Visible = true;
                button50.Visible = true;
            }
            else {
                if (ChosedBut == "Глоссарий")
                {
                    var b = textBox4.Text;
                    textBox1.Text = "";
                    for (int i = 0; i < GlossValue.Count; i++)
                    {
                        string a0 = "";
                        char[] a = GlossValue[i].ToCharArray();
                        try
                        {
                            a0 = a[0].ToString();
                        }
                        catch
                        {

                        }
                        if (a0 == b)
                        {
                            textBox1.Text = textBox1.Text + GlossValue[i] + "\r\n";
                        }


                    }
                }
                else
                {
                    var b = textBox4.Text;
                    string a0 = "";
                    string a1 = "";
                    string a2 = "";
                    string a3 = "";
                    string a4 = "";
                    string a5 = "";
                    string a6 = "";
                    string a7 = "";
                    string a8 = "";
                    string a9 = "";
                    string a10 = "";
                    string a11 = "";
                    string a12 = "";
                    string a13 = "";
                    string a14 = "";
                    char[] a36 = button36.Text.ToCharArray();
                    char[] a37 = button37.Text.ToCharArray();
                    char[] a38 = button38.Text.ToCharArray();
                    char[] a39 = button39.Text.ToCharArray();
                    char[] a40 = button40.Text.ToCharArray();
                    char[] a41 = button41.Text.ToCharArray();
                    char[] a42 = button42.Text.ToCharArray();
                    char[] a43 = button43.Text.ToCharArray();
                    char[] a44 = button44.Text.ToCharArray();
                    char[] a45 = button45.Text.ToCharArray();
                    char[] a46 = button46.Text.ToCharArray();
                    char[] a47 = button47.Text.ToCharArray();
                    char[] a48 = button48.Text.ToCharArray();
                    char[] a49 = button49.Text.ToCharArray();
                    char[] a50 = button50.Text.ToCharArray();
                    try
                    {
                        a0 = a36[0].ToString();
                        a1 = a37[0].ToString();
                        a2 = a38[0].ToString();
                        a3 = a39[0].ToString();
                        a4 = a40[0].ToString();
                        a5 = a41[0].ToString();
                        a6 = a42[0].ToString();
                        a7 = a43[0].ToString();
                        a8 = a44[0].ToString();
                        a9 = a45[0].ToString();
                        a10 = a46[0].ToString();
                        a11 = a47[0].ToString();
                        a12 = a48[0].ToString();
                        a13 = a49[0].ToString();
                        a14 = a50[0].ToString();
                    }
                    catch
                    {

                    }
                    if (a0 == b) button36.Visible = true;
                    else button36.Visible = false;

                    if (a1 == b) button37.Visible = true;
                    else button37.Visible = false;

                    if (a2 == b) button38.Visible = true;
                    else button38.Visible = false;

                    if (a3 == b) button39.Visible = true;
                    else button39.Visible = false;

                    if (a4 == b) button40.Visible = true;
                    else button40.Visible = false;

                    if (a5 == b) button41.Visible = true;
                    else button41.Visible = false;

                    if (a6 == b) button42.Visible = true;
                    else button42.Visible = false;

                    if (a7 == b) button43.Visible = true;
                    else button43.Visible = false;

                    if (a8 == b) button44.Visible = true;
                    else button44.Visible = false;

                    if (a9 == b) button45.Visible = true;
                    else button45.Visible = false;

                    if (a10 == b) button46.Visible = true;
                    else button46.Visible = false;

                    if (a11 == b) button47.Visible = true;
                    else button47.Visible = false;

                    if (a12 == b) button48.Visible = true;
                    else button48.Visible = false;

                    if (a13 == b) button49.Visible = true;
                    else button49.Visible = false;

                    if (a14 == b) button50.Visible = true;
                    else button50.Visible = false;



                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
            textBox4.Visible = true;
            ChosedBut = "Книги";
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            richTextBox1.Visible = true;
            textBox1.Visible = false;

            button31.Visible = false;
            button36.Visible = true;
            button37.Visible = true;
            button38.Visible = true;
            button39.Visible = true;
            button40.Visible = true;
            button41.Visible = true;
            button42.Visible = true;
            button43.Visible = true;
            button44.Visible = true;
            button45.Visible = true;
            button46.Visible = true;
            button47.Visible = true;
            button48.Visible = true;
            button49.Visible = true;
            button50.Visible = true;

            button52.Visible = false;
            button53.Visible = false;
            button54.Visible = false;
            button55.Visible = false;
            button56.Visible = false;
            button57.Visible = false;
            string del = ".rtf";
            button36.Text = Path.GetFileName(b13);
            try
            {
                button36.Text = button36.Text.Remove(button36.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button37.Text = Path.GetFileName(b14);
            try
            {
                button37.Text = button37.Text.Remove(button37.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button38.Text = Path.GetFileName(b1);
            try
            {
                button38.Text = button38.Text.Remove(button38.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button39.Text = Path.GetFileName(b2);
            try
            {
                button39.Text = button39.Text.Remove(button39.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button40.Text = Path.GetFileName(b3);
            try
            {
                button40.Text = button40.Text.Remove(button40.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button41.Text = Path.GetFileName(b4);
            try
            {
                button41.Text = button41.Text.Remove(button41.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button42.Text = Path.GetFileName(b5);
            try
            {
                button42.Text = button42.Text.Remove(button42.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button43.Text = Path.GetFileName(b6);
            try
            {
                button43.Text = button43.Text.Remove(button43.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button44.Text = Path.GetFileName(b7);
            try
            {
                button44.Text = button44.Text.Remove(button44.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button45.Text = Path.GetFileName(b8);
            try
            {
                button45.Text = button45.Text.Remove(button45.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button46.Text = Path.GetFileName(b9);
            try
            {
                button46.Text = button46.Text.Remove(button46.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button47.Text = Path.GetFileName(b10);
            try
            {
                button47.Text = button47.Text.Remove(button47.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button48.Text = Path.GetFileName(b11);
            try
            {
                button48.Text = button48.Text.Remove(button48.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button49.Text = Path.GetFileName(b12);
            try
            {
                button49.Text = button49.Text.Remove(button49.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }
            button50.Text = Path.GetFileName(b15);
            try
            {
                button50.Text = button50.Text.Remove(button50.Text.IndexOf(del), del.Length);
            }
            catch
            {

            }


            if (button36.Text == "")
            {
                button36.Visible = false;
            }
            if (button37.Text == "")
            {
                button37.Visible = false;
            }
            if (button38.Text == "")
            {
                button38.Visible = false;
            }
            if (button39.Text == "")
            {
                button39.Visible = false;
            }
            if (button40.Text == "")
            {
                button40.Visible = false;
            }
            if (button41.Text == "")
            {
                button41.Visible = false;
            }
            if (button42.Text == "")
            {
                button42.Visible = false;
            }
            if (button43.Text == "")
            {
                button43.Visible = false;
            }
            if (button44.Text == "")
            {
                button44.Visible = false;
            }
            if (button45.Text == "")
            {
                button45.Visible = false;
            }
            if (button46.Text == "")
            {
                button46.Visible = false;
            }
            if (button47.Text == "")
            {
                button47.Visible = false;
            }
            if (button48.Text == "")
            {
                button48.Visible = false;
            }
            if (button49.Text == "")
            {
                button49.Visible = false;
            }
            if (button50.Text == "")
            {
                button50.Visible = false;
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
