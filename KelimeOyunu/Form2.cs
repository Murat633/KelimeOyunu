using Newtonsoft.Json;
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

namespace KelimeOyunu
{
    public partial class Form2 : Form
    {
        private List<string> CurrentWords = new List<string>();


        public Form2()
        {
            InitializeComponent();
            CurrentWords.Add("araba");
        }

        // JSON verisini karşılamak için bir sınıf oluşturun
        public class WordsModel
        {
            public string[] kelimeler { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // JSON dosyasının yolunu belirtin
            string jsonFilePath = "C:\\Users\\MHD\\source\\repos\\KelimeOyunu\\KelimeOyunu\\kelimeler.json";

            // JSON dosyasındaki veriyi okuyun
            string jsonContent = File.ReadAllText(jsonFilePath);

            // JSON verisini C# nesnesine çözümleyin
            var wordModel = JsonConvert.DeserializeObject<WordsModel>(jsonContent);

            // Kelimeler dizisine erişin
            string[] words = wordModel.kelimeler;

            ErrorTextLbl.Text = "";
            ErrorTextLbl.ForeColor = Color.Yellow;



            if (!CurrentWords.Contains(wordTxb.Text) && words.Contains(wordTxb.Text))
            {
                if (wordTxb.Text[0].ToString().ToLower() == CurrentLetterLbl.Text.ToLower())
                {
                    CurrentWords.Add(wordTxb.Text);
                    ErrorTextLbl.Text = "Kelime Eklendi";
                    ErrorTextLbl.ForeColor = Color.Green;
                }
                else
                {
                    ErrorTextLbl.Text = $"Lütfen {CurrentLetterLbl.Text} Harfi ile başlayan bir kelime yazın.";
                    ErrorTextLbl.ForeColor = Color.Red;
                }
            }
            else if (!words.Contains(wordTxb.Text))
            {
                ErrorTextLbl.Text = "Böyle bir kelime yok!";
                ErrorTextLbl.ForeColor = Color.Red;
            }
            else
            {
                ErrorTextLbl.Text = "Bu kelime zaten yazıldı";
                ErrorTextLbl.ForeColor = Color.Red;
            }


            if (CurrentWords[CurrentWords.Count - 1] != null)
            {
                LastWordLbl.Text = CurrentWords[CurrentWords.Count - 1];
                CurrentLetterLbl.Text = CurrentWords[CurrentWords.Count - 1][CurrentWords[CurrentWords.Count - 1].Length - 1].ToString();
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
