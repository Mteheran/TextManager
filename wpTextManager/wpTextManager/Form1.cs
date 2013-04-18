using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using TextManager.Entities;

namespace wpTextManager
{
    public partial class Form1 : Form
    {
        public TextManager.TextManager objTextManager { get; set; }
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objTextManager = new TextManager.TextManager(txtText.Text);

            txtCountWords.Text = objTextManager.CountWords().ToString();
            txtCountLetter.Text = objTextManager.CountLetters().ToString();            
            txtcoundFindWordRegx.Text = objTextManager.FindWordRepetContinue(txtWordFindReg.Text, true).Count.ToString();
            txtcountWordExact.Text = objTextManager.FindExactWord(txtFindExactWord.Text, true).Count.ToString();          
            txtcountWordFind.Text = objTextManager.FindWord(txtWordFind.Text, true).Count.ToString();
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            lblVersion.Text = "Versión - " + version;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Language lang = Language.None;
            foreach (Language val in Enum.GetValues(typeof(Language)))
            {
                if (val.ToString() == cmbLenguaje.SelectedItem.ToString())
                {
                    lang = val;
                    break;
                }
            }

            txtNumberConverter.Text = TextManager.ConverterManager.StringToInteger(lang ,txtTextToNumberConverter.Text).ToString();
        }

    }
}
