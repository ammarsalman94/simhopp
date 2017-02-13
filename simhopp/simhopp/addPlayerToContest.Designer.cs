using System.Windows.Forms;

namespace simhopp
{
    partial class addPlayerToContest
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboJumpComboKey = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.jumpTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jumpTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jumpTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jumpTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboJumpComboValue = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboJumpComboKey
            // 
            this.comboJumpComboKey.FormattingEnabled = true;
            this.comboJumpComboKey.Location = new System.Drawing.Point(31, 240);
            this.comboJumpComboKey.Name = "comboJumpComboKey";
            this.comboJumpComboKey.Size = new System.Drawing.Size(121, 28);
            this.comboJumpComboKey.TabIndex = 5;
            this.comboJumpComboKey.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "7.5m",
            "10m",
            "12m"});
            this.comboBox2.Location = new System.Drawing.Point(185, 240);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Standing",
            "Handstand",
            "Trampoline"});
            this.comboBox3.Location = new System.Drawing.Point(482, 240);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Standing",
            "Handstand",
            "Trampoline"});
            this.comboBox4.Location = new System.Drawing.Point(335, 240);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 8;
            // 
            // jumpTypeBindingSource2
            // 
            this.jumpTypeBindingSource2.DataSource = typeof(simhopp.JumpType);
            // 
            // jumpTypeBindingSource1
            // 
            this.jumpTypeBindingSource1.DataSource = typeof(simhopp.JumpType);
            // 
            // jumpTypeBindingSource
            // 
            this.jumpTypeBindingSource.DataSource = typeof(simhopp.JumpType);
            // 
            // jumpTypeBindingSource3
            // 
            this.jumpTypeBindingSource3.DataSource = typeof(simhopp.JumpType);
            // 
            // comboJumpComboValue
            // 
            this.comboJumpComboValue.FormattingEnabled = true;
            this.comboJumpComboValue.Location = new System.Drawing.Point(31, 285);
            this.comboJumpComboValue.Name = "comboJumpComboValue";
            this.comboJumpComboValue.Size = new System.Drawing.Size(121, 28);
            this.comboJumpComboValue.TabIndex = 9;
            this.comboJumpComboValue.SelectedIndexChanged += new System.EventHandler(this.comboJumpComboValue_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "7.5m",
            "10m",
            "12m"});
            this.comboBox6.Location = new System.Drawing.Point(185, 285);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 28);
            this.comboBox6.TabIndex = 10;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Standing",
            "Handstand",
            "Trampoline"});
            this.comboBox7.Location = new System.Drawing.Point(335, 285);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 28);
            this.comboBox7.TabIndex = 11;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Standing",
            "Handstand",
            "Trampoline"});
            this.comboBox8.Location = new System.Drawing.Point(482, 285);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 28);
            this.comboBox8.TabIndex = 12;
            // 
            // addPlayerToContest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 464);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboJumpComboValue);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboJumpComboKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "addPlayerToContest";
            this.Text = "addPlayerToContest";
            this.Load += new System.EventHandler(this.addPlayerToContest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTypeBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private BindingSource jumpTypeBindingSource;
        private BindingSource jumpTypeBindingSource1;
        public ComboBox comboJumpComboKey;
        private BindingSource jumpTypeBindingSource2;
        private BindingSource jumpTypeBindingSource3;
        public ComboBox comboJumpComboValue;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
    }
}