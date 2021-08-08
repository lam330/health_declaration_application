using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Windows.Forms.DataVisualization;



namespace First_GUI 
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        public void ClearCheckBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (player.status == "Stop" || player.status == "Pause")
            {
                player.controls.play();
            }

            //data from input textbox
            string name = tb_name.Text;
            int age = int.Parse(tb_age.Text);
            string address = tb_address.Text;

            //show thanks
            //MessageBox.Show("Thank you (^-^)", "", MessageBoxButtons.OK);
            //checkbox process
            string signsResult = " ";
            
            int count = 0;
            if(ckb_temp.Checked || ckb_cough.Checked ||ckb_headache.Checked)
            {
                //+ chuoi
                //test func
                if(ckb_temp.Checked)
                {
                    if(count == 0)
                    {
                        signsResult += "high temperature";
                        count++;
                    }
                    else
                    {
                        signsResult += ",high temperature";
                    }
                    
                }
                if(ckb_cough.Checked)
                {
                    
                    if (count == 0)
                    {
                        signsResult += "cough";
                        count++;
                    }
                    else
                    {
                        signsResult += ",cough";
                    }
                }
                if(ckb_headache.Checked)
                {
                    if (count == 0)
                    {
                        signsResult += "headache";
                        count++;
                    }
                    else
                    {
                        signsResult += ",headache";
                    }
                }
   
            }
            else
            {
                signsResult = "normal";
            }

            string title = "Thanks for information";
            string message = "Name: {0} \n Age: {1} \n Address: {2} \n Illness's signs: {3} ";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;

            //show result
            DialogResult result = MessageBox.Show(string.Format(message, name, age, address, signsResult), title, buttons,
                MessageBoxIcon.Information);
            //handle user choose
            if (result == DialogResult.OK)
            {
                //Create QR Code
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                string finalString = "Name: " + name + '\n' +
                                     "Age: " + tb_age.Text + '\n' +
                                     "Signs of illness: " + signsResult;

                var myData = QG.CreateQrCode(finalString, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(myData);
                pb_QR.Image = code.GetGraphic(50);

                //save File
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pb_QR.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                }

               

                try
                {
                    //store to sqlite

                    Database file;
                    file.CreateTable();
                    Person person = new Person(name, age, address, signsResult);
                    file.InsertData(person.Insert());
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
                //clear contents 
                ClearTextBoxes(this.Controls);
                ClearCheckBoxes(this.Controls);
            }
            else
            {
                //clear contents 
                ClearTextBoxes(this.Controls);
                ClearCheckBoxes(this.Controls);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void tb_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var html = GetData("https://www.howkteam.vn/");
            //    TestData(html);
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //}

            //play music
            
           



        }

        void TestData(string html)
        {
            File.WriteAllText("res.html", html);

            Process.Start("res.html");
        }

        string GetData(string url)
        {
            HttpRequest http = new HttpRequest();
            string html = http.Get(url).ToString();

            MessageBox.Show(html);

            TestData(html);

            return html;
        }

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer
        {
            URL = "E:/temp_new/C++/FPT_CoCa_Project/Health_Declaration_App/First_GUI/First_GUI/bin/Debug/Covid.mp3.mp3"
        };
        public void PlayMusic( )
        {
            
            player.controls.play();

            //Contineu
            if (player.status == "Stop" || player.status == "Pause")
            {
                player.controls.play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
