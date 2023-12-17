namespace Inv
{
    partial class Settings
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(30, 100);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1170, 733);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(104, 4);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1062, 725);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "База данных";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 583);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 3;
            label3.Text = "Размер базы данных:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Отключить", "10 сек", "30 сек", "1 мин", "5 мин", "20 мин" });
            comboBox1.Location = new Point(285, 580);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 2;
            comboBox1.TabStop = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 583);
            label2.Name = "label2";
            label2.Size = new Size(264, 20);
            label2.TabIndex = 1;
            label2.Text = "Автообновление записей с сервера:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(7, 632);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(785, 20);
            label1.TabIndex = 2;
            label1.Text = "Для удалении всех записей из базы данных введите в поле ниже: «Я хочу удалить все записи из базы данных»";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 47);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Я хочу удалить все записи из базы данных";
            textBox1.Size = new Size(822, 27);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(833, 47);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(194, 31);
            button1.TabIndex = 0;
            button1.Text = "Очистить базу данных";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 733);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Настройки";
            TopMost = true;
            Load += Settings_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
    }
}