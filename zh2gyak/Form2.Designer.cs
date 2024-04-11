namespace zh2gyak
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox1.Location = new Point(32, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Population";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox2.Location = new Point(32, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 23);
            textBox2.TabIndex = 1;
            textBox2.Tag = "";
            textBox2.Text = "Country";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(32, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Area";
            // 
            // button1
            // 
            button1.Location = new Point(32, 315);
            button1.Name = "button1";
            button1.Size = new Size(270, 107);
            button1.TabIndex = 3;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 482);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private BindingSource bindingSource1;
    }
}