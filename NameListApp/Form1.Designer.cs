namespace NameListApp
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(256, 24);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Firstname";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.ItemHeight = 16;
            this.lbxNames.Location = new System.Drawing.Point(200, 82);
            this.lbxNames.Margin = new System.Windows.Forms.Padding(4);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(255, 404);
            this.lbxNames.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(586, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 404);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(646, 24);
            this.btnLoad2.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(138, 28);
            this.btnLoad2.TabIndex = 2;
            this.btnLoad2.Text = "Load Surname";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLoad2;
    }
}

