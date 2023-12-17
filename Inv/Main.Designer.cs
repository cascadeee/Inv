namespace Inv
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tek = new TabPage();
            dataGridView3 = new DataGridView();
            post = new TabPage();
            panel1 = new Panel();
            dateTimePicker0 = new DateTimePicker();
            numericUpDown0 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxInv0 = new TextBox();
            label2 = new Label();
            textBoxCode0 = new TextBox();
            label1 = new Label();
            textBoxName0 = new TextBox();
            button1 = new Button();
            ras = new TabPage();
            dataGridView2 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            расходToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            label6 = new Label();
            SearchTextBox = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            post.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown0).BeginInit();
            ras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1445, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.BackColor = SystemColors.Control;
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(98, 24);
            файлToolStripMenuItem.Text = "Настройки";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(1099, 751);
            dataGridView1.TabIndex = 1;
            dataGridView1.TabStop = false;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tek);
            tabControl1.Controls.Add(post);
            tabControl1.Controls.Add(ras);
            tabControl1.Location = new Point(14, 89);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1417, 788);
            tabControl1.TabIndex = 2;
            tabControl1.TabStop = false;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tek
            // 
            tek.Controls.Add(dataGridView3);
            tek.Location = new Point(4, 29);
            tek.Margin = new Padding(3, 4, 3, 4);
            tek.Name = "tek";
            tek.Size = new Size(1409, 755);
            tek.TabIndex = 3;
            tek.Text = "Текущее";
            tek.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ShowCellErrors = false;
            dataGridView3.ShowCellToolTips = false;
            dataGridView3.ShowEditingIcon = false;
            dataGridView3.ShowRowErrors = false;
            dataGridView3.Size = new Size(1408, 751);
            dataGridView3.TabIndex = 4;
            dataGridView3.TabStop = false;
            dataGridView3.MouseDown += dataGridView3_MouseDown;
            // 
            // post
            // 
            post.Controls.Add(panel1);
            post.Controls.Add(dataGridView1);
            post.Location = new Point(4, 29);
            post.Margin = new Padding(3, 4, 3, 4);
            post.Name = "post";
            post.Padding = new Padding(3, 4, 3, 4);
            post.Size = new Size(1409, 755);
            post.TabIndex = 0;
            post.Text = "Поступления";
            post.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker0);
            panel1.Controls.Add(numericUpDown0);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxInv0);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxCode0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxName0);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1108, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 747);
            panel1.TabIndex = 3;
            // 
            // dateTimePicker0
            // 
            dateTimePicker0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker0.Location = new Point(3, 232);
            dateTimePicker0.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker0.Name = "dateTimePicker0";
            dateTimePicker0.Size = new Size(291, 27);
            dateTimePicker0.TabIndex = 4;
            // 
            // numericUpDown0
            // 
            numericUpDown0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown0.Location = new Point(3, 291);
            numericUpDown0.Margin = new Padding(3, 4, 3, 4);
            numericUpDown0.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown0.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown0.Name = "numericUpDown0";
            numericUpDown0.Size = new Size(291, 27);
            numericUpDown0.TabIndex = 5;
            numericUpDown0.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 267);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "Количество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 208);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 8;
            label4.Text = "Дата поступления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 149);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Инв. №";
            // 
            // textBoxInv0
            // 
            textBoxInv0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInv0.Location = new Point(3, 173);
            textBoxInv0.Margin = new Padding(3, 4, 3, 4);
            textBoxInv0.Name = "textBoxInv0";
            textBoxInv0.Size = new Size(291, 27);
            textBoxInv0.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 91);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Артикул";
            // 
            // textBoxCode0
            // 
            textBoxCode0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCode0.Location = new Point(3, 115);
            textBoxCode0.Margin = new Padding(3, 4, 3, 4);
            textBoxCode0.Name = "textBoxCode0";
            textBoxCode0.Size = new Size(291, 27);
            textBoxCode0.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Наименование";
            // 
            // textBoxName0
            // 
            textBoxName0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName0.Location = new Point(3, 56);
            textBoxName0.Margin = new Padding(3, 4, 3, 4);
            textBoxName0.Name = "textBoxName0";
            textBoxName0.Size = new Size(291, 27);
            textBoxName0.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Location = new Point(0, 672);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(298, 57);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ras
            // 
            ras.Controls.Add(dataGridView2);
            ras.Location = new Point(4, 29);
            ras.Margin = new Padding(3, 4, 3, 4);
            ras.Name = "ras";
            ras.Padding = new Padding(3, 4, 3, 4);
            ras.Size = new Size(1409, 755);
            ras.TabIndex = 1;
            ras.Text = "Расход";
            ras.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 4);
            dataGridView2.Margin = new Padding(0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.ShowCellErrors = false;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.ShowRowErrors = false;
            dataGridView2.Size = new Size(1403, 747);
            dataGridView2.TabIndex = 2;
            dataGridView2.TabStop = false;
            dataGridView2.MouseDown += dataGridView2_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { расходToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(126, 28);
            contextMenuStrip1.Closed += contextMenuStrip1_Closed;
            contextMenuStrip1.Opened += contextMenuStrip1_Opened;
            // 
            // расходToolStripMenuItem
            // 
            расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            расходToolStripMenuItem.Size = new Size(125, 24);
            расходToolStripMenuItem.Text = "Расход";
            расходToolStripMenuItem.Click += расходToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(1341, 880);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 3;
            button3.TabStop = false;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(1025, 885);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 4;
            label6.Text = "Последнее обновление: ";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.Location = new Point(1120, 51);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Поиск";
            SearchTextBox.Size = new Size(306, 27);
            SearchTextBox.TabIndex = 5;
            SearchTextBox.TabStop = false;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(135, 28);
            contextMenuStrip2.Closed += contextMenuStrip2_Closed;
            contextMenuStrip2.Opened += contextMenuStrip2_Opened;
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(134, 24);
            удалитьToolStripMenuItem1.Text = "Удалить";
            удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(135, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(134, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 917);
            Controls.Add(SearchTextBox);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 651);
            Name = "Main";
            Text = "Inv";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            post.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown0).EndInit();
            ras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage post;
        private TabPage ras;
        private TabPage tek;
        private Panel panel1;
        private Button button1;
        private TextBox textBoxName0;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxInv0;
        private Label label2;
        private TextBox textBoxCode0;
        private NumericUpDown numericUpDown0;
        private DateTimePicker dateTimePicker0;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button3;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem расходToolStripMenuItem;
        private TextBox SearchTextBox;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}