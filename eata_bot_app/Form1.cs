using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
namespace eata_bot_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string token=textBox3.Text;
            string id=textBox2.Text;
            string ispin;
            using (HttpClient api = new HttpClient())
            {
                HttpResponseMessage message =await api.GetAsync($"https://eitaayar.ir/api/{token}/sendMessage?chat_id={id}&text={textBox1.Text}&pin=on&viewCountForDelete=");
                if (message.IsSuccessStatusCode)
                {
                    textBox4.Text = await message.Content.ReadAsStringAsync();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
