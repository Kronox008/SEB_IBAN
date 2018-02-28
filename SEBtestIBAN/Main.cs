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

namespace SEBtestIBAN
{
    public partial class Test : Form
    {
        

        public Test()
        {
            InitializeComponent();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Check.ManualString = BoxManual.Text;
            Check.ManualCheck();

            if (BoxManual.Text == "")
            {
                labelValid.Text = "Įveskite IBAN";
                labelValid.ForeColor = Color.Yellow;
            }else if (!Check.ValidManualLength)
            {
                labelValid.Text = "IBAN neteisingas (ilgis)";
                labelValid.ForeColor = Color.Red;
            }else if (Check.ValidManual97)
            {
                labelValid.Text = "IBAN teisingas";
                labelValid.ForeColor = Color.Green;
            }
            else
            {
                labelValid.Text = "IBAN neteisingas";
                labelValid.ForeColor = Color.Red;
            }






            //if (!Check.ValidManualLength)
            //{
            //    if (BoxManual.Text == "")
            //    {
            //        labelValid.Text = "Įveskite IBAN";
            //        labelValid.ForeColor = Color.Yellow;
            //    }
            //    else
            //    {
            //        labelValid.Text = "IBAN neteisingas";
            //        labelValid.ForeColor = Color.Red;
            //    }
            //}
            //if (Check.ValidManual97)
            //{
            //    labelValid.Text = "IBAN teisingas";
            //    labelValid.ForeColor = Color.Green;
            //}
            //else
            //{
            //    labelValid.Text = "IBAN neteisingas";
            //    labelValid.ForeColor = Color.Red;
            //}












        }

        private async void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                string[] IBANlines = File.ReadAllLines(@"C:\Users\Public\TestFolder\IBAN_list.txt");
                foreach (string line in IBANlines) //all lines taken from file
                {
                    Check.FormatString(line, 1);  //sending to check % if it is valid
                    string SavetoFile = string.Format("{0};{1}", line, Check.IsValid); // formating string which will be saved to out file
                    
                    using (StreamWriter sw = File.AppendText(@"C:\Users\Public\TestFolder\IBAN_list.out")) 
                    {
                        sw.WriteLine(SavetoFile);
                    }


                }
            }
            catch (Exception)
            {
                LabelResult.Text = "Nepavyko atidaryti failo";
                LabelResult.ForeColor = Color.Red;
            }

            LabelResult.Text = "Failas patikrintas, rezultatai išsaugoti:" + Environment.NewLine + "C:>Users>Public>TestFolder>IBAN_list.out";
            LabelResult.ForeColor = Color.Green;
        }
    }
}
