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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            mainMenuStrip = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            addDataGridView = new DataGridView();
            MainTabControl = new TabControl();
            tek = new TabPage();
            currentDataGridView = new DataGridView();
            post = new TabPage();
            panel1 = new Panel();
            itemArrivalDateTimePicker = new DateTimePicker();
            itemCountNumericUpDown = new NumericUpDown();
            itemCountLabel = new Label();
            itemArrivalDateLabel = new Label();
            itemInvLabel = new Label();
            itemInvTextBox = new TextBox();
            itemCodeLabel = new Label();
            itemCodeTextBox = new TextBox();
            itemNameLabel = new Label();
            itemNameTextBox = new TextBox();
            addItemButton = new Button();
            ras = new TabPage();
            subDataGridView = new DataGridView();
            subItemContextMenuStrip = new ContextMenuStrip(components);
            расходToolStripMenuItem = new ToolStripMenuItem();
            UpdateButton = new Button();
            lastUpdateTimeLabel = new Label();
            searchTextBox = new TextBox();
            removeAddRecordContextMenuStrip = new ContextMenuStrip(components);
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            removeSubRecordContextMenuStrip = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addDataGridView).BeginInit();
            MainTabControl.SuspendLayout();
            tek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentDataGridView).BeginInit();
            post.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemCountNumericUpDown).BeginInit();
            ras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subDataGridView).BeginInit();
            subItemContextMenuStrip.SuspendLayout();
            removeAddRecordContextMenuStrip.SuspendLayout();
            removeSubRecordContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(7, 3, 0, 3);
            mainMenuStrip.Size = new Size(1445, 30);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.BackColor = SystemColors.Control;
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(98, 24);
            settingToolStripMenuItem.Text = "Настройки";
            settingToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // addDataGridView
            // 
            addDataGridView.AllowUserToAddRows = false;
            addDataGridView.AllowUserToDeleteRows = false;
            addDataGridView.AllowUserToResizeRows = false;
            addDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            addDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            addDataGridView.Location = new Point(0, 0);
            addDataGridView.Margin = new Padding(3, 4, 3, 4);
            addDataGridView.MultiSelect = false;
            addDataGridView.Name = "addDataGridView";
            addDataGridView.ReadOnly = true;
            addDataGridView.RowHeadersVisible = false;
            addDataGridView.RowHeadersWidth = 51;
            addDataGridView.RowTemplate.Height = 25;
            addDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addDataGridView.ShowCellErrors = false;
            addDataGridView.ShowCellToolTips = false;
            addDataGridView.ShowEditingIcon = false;
            addDataGridView.ShowRowErrors = false;
            addDataGridView.Size = new Size(1099, 751);
            addDataGridView.TabIndex = 1;
            addDataGridView.TabStop = false;
            addDataGridView.MouseDown += dataGridView1_MouseDown;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(tek);
            MainTabControl.Controls.Add(post);
            MainTabControl.Controls.Add(ras);
            MainTabControl.Location = new Point(14, 89);
            MainTabControl.Margin = new Padding(3, 4, 3, 4);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1417, 788);
            MainTabControl.TabIndex = 2;
            MainTabControl.TabStop = false;
            MainTabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tek
            // 
            tek.Controls.Add(currentDataGridView);
            tek.Location = new Point(4, 29);
            tek.Margin = new Padding(3, 4, 3, 4);
            tek.Name = "tek";
            tek.Size = new Size(1409, 755);
            tek.TabIndex = 3;
            tek.Text = "Текущее";
            tek.UseVisualStyleBackColor = true;
            // 
            // currentDataGridView
            // 
            currentDataGridView.AllowUserToAddRows = false;
            currentDataGridView.AllowUserToDeleteRows = false;
            currentDataGridView.AllowUserToResizeRows = false;
            currentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            currentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            currentDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            currentDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            currentDataGridView.Location = new Point(0, 0);
            currentDataGridView.Margin = new Padding(3, 4, 3, 4);
            currentDataGridView.Name = "currentDataGridView";
            currentDataGridView.ReadOnly = true;
            currentDataGridView.RowHeadersVisible = false;
            currentDataGridView.RowHeadersWidth = 51;
            currentDataGridView.RowTemplate.Height = 25;
            currentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            currentDataGridView.ShowCellErrors = false;
            currentDataGridView.ShowCellToolTips = false;
            currentDataGridView.ShowEditingIcon = false;
            currentDataGridView.ShowRowErrors = false;
            currentDataGridView.Size = new Size(1408, 751);
            currentDataGridView.TabIndex = 4;
            currentDataGridView.TabStop = false;
            currentDataGridView.MouseDown += dataGridView3_MouseDown;
            // 
            // post
            // 
            post.Controls.Add(panel1);
            post.Controls.Add(addDataGridView);
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
            panel1.Controls.Add(itemArrivalDateTimePicker);
            panel1.Controls.Add(itemCountNumericUpDown);
            panel1.Controls.Add(itemCountLabel);
            panel1.Controls.Add(itemArrivalDateLabel);
            panel1.Controls.Add(itemInvLabel);
            panel1.Controls.Add(itemInvTextBox);
            panel1.Controls.Add(itemCodeLabel);
            panel1.Controls.Add(itemCodeTextBox);
            panel1.Controls.Add(itemNameLabel);
            panel1.Controls.Add(itemNameTextBox);
            panel1.Controls.Add(addItemButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1108, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 747);
            panel1.TabIndex = 3;
            // 
            // itemArrivalDateTimePicker
            // 
            itemArrivalDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemArrivalDateTimePicker.Location = new Point(3, 232);
            itemArrivalDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            itemArrivalDateTimePicker.Name = "itemArrivalDateTimePicker";
            itemArrivalDateTimePicker.Size = new Size(291, 27);
            itemArrivalDateTimePicker.TabIndex = 4;
            // 
            // itemCountNumericUpDown
            // 
            itemCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemCountNumericUpDown.Location = new Point(3, 291);
            itemCountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            itemCountNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            itemCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemCountNumericUpDown.Name = "itemCountNumericUpDown";
            itemCountNumericUpDown.Size = new Size(291, 27);
            itemCountNumericUpDown.TabIndex = 5;
            itemCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemCountLabel
            // 
            itemCountLabel.AutoSize = true;
            itemCountLabel.Location = new Point(3, 267);
            itemCountLabel.Name = "itemCountLabel";
            itemCountLabel.Size = new Size(90, 20);
            itemCountLabel.TabIndex = 10;
            itemCountLabel.Text = "Количество";
            // 
            // itemArrivalDateLabel
            // 
            itemArrivalDateLabel.AutoSize = true;
            itemArrivalDateLabel.Location = new Point(3, 208);
            itemArrivalDateLabel.Name = "itemArrivalDateLabel";
            itemArrivalDateLabel.Size = new Size(134, 20);
            itemArrivalDateLabel.TabIndex = 8;
            itemArrivalDateLabel.Text = "Дата поступления";
            // 
            // itemInvLabel
            // 
            itemInvLabel.AutoSize = true;
            itemInvLabel.Location = new Point(3, 149);
            itemInvLabel.Name = "itemInvLabel";
            itemInvLabel.Size = new Size(61, 20);
            itemInvLabel.TabIndex = 6;
            itemInvLabel.Text = "Инв. №";
            // 
            // itemInvTextBox
            // 
            itemInvTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemInvTextBox.Location = new Point(3, 173);
            itemInvTextBox.Margin = new Padding(3, 4, 3, 4);
            itemInvTextBox.Name = "itemInvTextBox";
            itemInvTextBox.Size = new Size(291, 27);
            itemInvTextBox.TabIndex = 3;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new Point(3, 91);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new Size(65, 20);
            itemCodeLabel.TabIndex = 4;
            itemCodeLabel.Text = "Артикул";
            // 
            // itemCodeTextBox
            // 
            itemCodeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemCodeTextBox.Location = new Point(3, 115);
            itemCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            itemCodeTextBox.Name = "itemCodeTextBox";
            itemCodeTextBox.Size = new Size(291, 27);
            itemCodeTextBox.TabIndex = 2;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(3, 32);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(116, 20);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Наименование";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemNameTextBox.Location = new Point(3, 56);
            itemNameTextBox.Margin = new Padding(3, 4, 3, 4);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(291, 27);
            itemNameTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addItemButton.AutoSize = true;
            addItemButton.Location = new Point(0, 672);
            addItemButton.Margin = new Padding(3, 4, 3, 4);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(298, 57);
            addItemButton.TabIndex = 0;
            addItemButton.TabStop = false;
            addItemButton.Text = "Добавить";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += button1_Click;
            // 
            // ras
            // 
            ras.Controls.Add(subDataGridView);
            ras.Location = new Point(4, 29);
            ras.Margin = new Padding(3, 4, 3, 4);
            ras.Name = "ras";
            ras.Padding = new Padding(3, 4, 3, 4);
            ras.Size = new Size(1409, 755);
            ras.TabIndex = 1;
            ras.Text = "Расход";
            ras.UseVisualStyleBackColor = true;
            // 
            // subDataGridView
            // 
            subDataGridView.AllowUserToAddRows = false;
            subDataGridView.AllowUserToDeleteRows = false;
            subDataGridView.AllowUserToResizeRows = false;
            subDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subDataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            subDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            subDataGridView.Dock = DockStyle.Fill;
            subDataGridView.Location = new Point(3, 4);
            subDataGridView.Margin = new Padding(0);
            subDataGridView.Name = "subDataGridView";
            subDataGridView.ReadOnly = true;
            subDataGridView.RowHeadersVisible = false;
            subDataGridView.RowHeadersWidth = 51;
            subDataGridView.RowTemplate.Height = 25;
            subDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subDataGridView.ShowCellErrors = false;
            subDataGridView.ShowCellToolTips = false;
            subDataGridView.ShowEditingIcon = false;
            subDataGridView.ShowRowErrors = false;
            subDataGridView.Size = new Size(1403, 747);
            subDataGridView.TabIndex = 2;
            subDataGridView.TabStop = false;
            subDataGridView.MouseDown += dataGridView2_MouseDown;
            // 
            // subItemContextMenuStrip
            // 
            subItemContextMenuStrip.ImageScalingSize = new Size(20, 20);
            subItemContextMenuStrip.Items.AddRange(new ToolStripItem[] { расходToolStripMenuItem });
            subItemContextMenuStrip.Name = "contextMenuStrip1";
            subItemContextMenuStrip.ShowImageMargin = false;
            subItemContextMenuStrip.Size = new Size(101, 28);
            subItemContextMenuStrip.Closed += contextMenuStrip1_Closed;
            subItemContextMenuStrip.Opened += contextMenuStrip1_Opened;
            // 
            // расходToolStripMenuItem
            // 
            расходToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            расходToolStripMenuItem.Size = new Size(100, 24);
            расходToolStripMenuItem.Text = "Расход";
            расходToolStripMenuItem.Click += расходToolStripMenuItem_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateButton.Location = new Point(1341, 880);
            UpdateButton.Margin = new Padding(3, 4, 3, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(86, 31);
            UpdateButton.TabIndex = 3;
            UpdateButton.TabStop = false;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += button3_Click;
            // 
            // lastUpdateTimeLabel
            // 
            lastUpdateTimeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lastUpdateTimeLabel.AutoSize = true;
            lastUpdateTimeLabel.Enabled = false;
            lastUpdateTimeLabel.Location = new Point(1025, 885);
            lastUpdateTimeLabel.Name = "lastUpdateTimeLabel";
            lastUpdateTimeLabel.Size = new Size(182, 20);
            lastUpdateTimeLabel.TabIndex = 4;
            lastUpdateTimeLabel.Text = "Последнее обновление: ";
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.Location = new Point(1120, 51);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Поиск";
            searchTextBox.Size = new Size(306, 27);
            searchTextBox.TabIndex = 5;
            searchTextBox.TabStop = false;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // removeAddRecordContextMenuStrip
            // 
            removeAddRecordContextMenuStrip.ImageScalingSize = new Size(20, 20);
            removeAddRecordContextMenuStrip.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem1 });
            removeAddRecordContextMenuStrip.Name = "contextMenuStrip2";
            removeAddRecordContextMenuStrip.ShowImageMargin = false;
            removeAddRecordContextMenuStrip.Size = new Size(110, 28);
            removeAddRecordContextMenuStrip.Closed += contextMenuStrip2_Closed;
            removeAddRecordContextMenuStrip.Opened += contextMenuStrip2_Opened;
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(109, 24);
            удалитьToolStripMenuItem1.Text = "Удалить";
            удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click;
            // 
            // removeSubRecordContextMenuStrip
            // 
            removeSubRecordContextMenuStrip.ImageScalingSize = new Size(20, 20);
            removeSubRecordContextMenuStrip.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            removeSubRecordContextMenuStrip.Name = "contextMenuStrip3";
            removeSubRecordContextMenuStrip.ShowImageMargin = false;
            removeSubRecordContextMenuStrip.Size = new Size(110, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(109, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 917);
            Controls.Add(searchTextBox);
            Controls.Add(lastUpdateTimeLabel);
            Controls.Add(UpdateButton);
            Controls.Add(MainTabControl);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 651);
            Name = "Main";
            Text = "Inv";
            Load += Main_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addDataGridView).EndInit();
            MainTabControl.ResumeLayout(false);
            tek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)currentDataGridView).EndInit();
            post.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemCountNumericUpDown).EndInit();
            ras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)subDataGridView).EndInit();
            subItemContextMenuStrip.ResumeLayout(false);
            removeAddRecordContextMenuStrip.ResumeLayout(false);
            removeSubRecordContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem settingToolStripMenuItem;
        private DataGridView addDataGridView;
        private TabControl MainTabControl;
        private TabPage post;
        private TabPage ras;
        private TabPage tek;
        private Panel panel1;
        private Button addItemButton;
        private TextBox itemNameTextBox;
        private Label itemNameLabel;
        private Label itemCountLabel;
        private Label itemArrivalDateLabel;
        private Label itemInvLabel;
        private TextBox itemInvTextBox;
        private Label itemCodeLabel;
        private TextBox itemCodeTextBox;
        private NumericUpDown itemCountNumericUpDown;
        private DateTimePicker itemArrivalDateTimePicker;
        private DataGridView subDataGridView;
        private DataGridView currentDataGridView;
        private Button UpdateButton;
        private Label lastUpdateTimeLabel;
        private ContextMenuStrip subItemContextMenuStrip;
        private ToolStripMenuItem расходToolStripMenuItem;
        private TextBox searchTextBox;
        private ContextMenuStrip removeAddRecordContextMenuStrip;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private ContextMenuStrip removeSubRecordContextMenuStrip;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}