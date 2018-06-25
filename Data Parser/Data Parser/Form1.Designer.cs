namespace Data_Parser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtLabel1 = new System.Windows.Forms.TextBox();
            this.txtLabel2 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtLabel3 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.txtLabel4 = new System.Windows.Forms.TextBox();
            this.txtValue4 = new System.Windows.Forms.TextBox();
            this.txtJsonText = new System.Windows.Forms.TextBox();
            this.btnFromJson = new System.Windows.Forms.Button();
            this.btnToJson = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToJson);
            this.panel1.Controls.Add(this.txtLabel4);
            this.panel1.Controls.Add(this.txtValue4);
            this.panel1.Controls.Add(this.txtLabel3);
            this.panel1.Controls.Add(this.txtValue3);
            this.panel1.Controls.Add(this.txtLabel2);
            this.panel1.Controls.Add(this.txtValue2);
            this.panel1.Controls.Add(this.txtLabel1);
            this.panel1.Controls.Add(this.txtValue1);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 310);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFromJson);
            this.panel2.Controls.Add(this.txtJsonText);
            this.panel2.Location = new System.Drawing.Point(392, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 309);
            this.panel2.TabIndex = 1;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(191, 18);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(161, 20);
            this.txtValue1.TabIndex = 0;
            // 
            // txtLabel1
            // 
            this.txtLabel1.Location = new System.Drawing.Point(12, 18);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.Size = new System.Drawing.Size(161, 20);
            this.txtLabel1.TabIndex = 1;
            // 
            // txtLabel2
            // 
            this.txtLabel2.Location = new System.Drawing.Point(12, 63);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(161, 20);
            this.txtLabel2.TabIndex = 3;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(191, 63);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(161, 20);
            this.txtValue2.TabIndex = 2;
            // 
            // txtLabel3
            // 
            this.txtLabel3.Location = new System.Drawing.Point(12, 108);
            this.txtLabel3.Name = "txtLabel3";
            this.txtLabel3.Size = new System.Drawing.Size(161, 20);
            this.txtLabel3.TabIndex = 5;
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(191, 108);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(161, 20);
            this.txtValue3.TabIndex = 4;
            // 
            // txtLabel4
            // 
            this.txtLabel4.Location = new System.Drawing.Point(12, 153);
            this.txtLabel4.Name = "txtLabel4";
            this.txtLabel4.Size = new System.Drawing.Size(161, 20);
            this.txtLabel4.TabIndex = 7;
            // 
            // txtValue4
            // 
            this.txtValue4.Location = new System.Drawing.Point(191, 153);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(161, 20);
            this.txtValue4.TabIndex = 6;
            // 
            // txtJsonText
            // 
            this.txtJsonText.Location = new System.Drawing.Point(13, 18);
            this.txtJsonText.Multiline = true;
            this.txtJsonText.Name = "txtJsonText";
            this.txtJsonText.Size = new System.Drawing.Size(383, 155);
            this.txtJsonText.TabIndex = 0;
            // 
            // btnFromJson
            // 
            this.btnFromJson.Location = new System.Drawing.Point(13, 213);
            this.btnFromJson.Name = "btnFromJson";
            this.btnFromJson.Size = new System.Drawing.Size(75, 23);
            this.btnFromJson.TabIndex = 1;
            this.btnFromJson.Text = "<--";
            this.btnFromJson.UseVisualStyleBackColor = true;
            this.btnFromJson.Click += new System.EventHandler(this.btnFromJson_Click);
            // 
            // btnToJson
            // 
            this.btnToJson.Location = new System.Drawing.Point(277, 213);
            this.btnToJson.Name = "btnToJson";
            this.btnToJson.Size = new System.Drawing.Size(75, 23);
            this.btnToJson.TabIndex = 8;
            this.btnToJson.Text = "-->";
            this.btnToJson.UseVisualStyleBackColor = true;
            this.btnToJson.Click += new System.EventHandler(this.btnToJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 340);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "JSON Parsing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLabel4;
        private System.Windows.Forms.TextBox txtValue4;
        private System.Windows.Forms.TextBox txtLabel3;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.TextBox txtLabel2;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtLabel1;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtJsonText;
        private System.Windows.Forms.Button btnToJson;
        private System.Windows.Forms.Button btnFromJson;
    }
}

