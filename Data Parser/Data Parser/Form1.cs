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
using Newtonsoft.Json;

namespace Data_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToJson_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;

                writer.WriteStartObject();
                if (!string.IsNullOrWhiteSpace(this.txtLabel1.Text))
                {
                    writer.WritePropertyName(this.txtLabel1.Text);
                    writer.WriteValue(this.txtValue1.Text);
                }
                if (!string.IsNullOrWhiteSpace(this.txtLabel2.Text))
                {
                    writer.WritePropertyName(this.txtLabel2.Text);
                    writer.WriteValue(this.txtValue2.Text);
                }
                if (!string.IsNullOrWhiteSpace(this.txtLabel3.Text))
                {
                    writer.WritePropertyName(this.txtLabel3.Text);
                    writer.WriteValue(this.txtValue3.Text);
                }
                if (!string.IsNullOrWhiteSpace(this.txtLabel4.Text))
                {
                    writer.WritePropertyName(this.txtLabel4.Text);
                    writer.WriteValue(this.txtValue4.Text);
                }
                writer.WriteEndObject();
            }

            this.txtJsonText.Text = sb.ToString();
        }

        private void btnFromJson_Click(object sender, EventArgs e)
        {
            string json = "";
            if (!string.IsNullOrWhiteSpace(this.txtJsonText.Text))
            {
                json = this.txtJsonText.Text;
            }

            JsonTextReader reader = new JsonTextReader(new StringReader(json));

            int count = 0;
            int count2 = 0;

            while (reader.Read() && count + count2 < 8)
            {
                if (reader.TokenType.Equals(JsonToken.PropertyName))
                {
                    if (count == 0)
                    {
                        this.txtLabel1.Text = reader.Value.ToString();
                    }
                    else if (count == 1)
                    {
                        this.txtLabel2.Text = reader.Value.ToString();
                    }
                    else if (count == 2)
                    {
                        this.txtLabel3.Text = reader.Value.ToString();
                    }
                    else if (count == 3)
                    {
                        this.txtLabel4.Text = reader.Value.ToString();
                    }
                    count++;
                }
                else if (reader.TokenType.Equals(JsonToken.String))
                {
                    if (count2 == 0)
                    {
                        this.txtValue1.Text = reader.Value.ToString();
                    }
                    else if (count2 == 1)
                    {
                        this.txtValue2.Text = reader.Value.ToString();
                    }
                    else if (count2 == 2)
                    {
                        this.txtValue3.Text = reader.Value.ToString();
                    }
                    else if (count2 == 3)
                    {
                        this.txtValue4.Text = reader.Value.ToString();
                    }
                    count2++;
                }
            }

            reader.Close();
        }
    }
}
