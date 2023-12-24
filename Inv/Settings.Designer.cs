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
            settingsTabControl = new TabControl();
            tabPage1 = new TabPage();
            infoLabel2 = new Label();
            updateCooldownComboBox = new ComboBox();
            infoLabel1 = new Label();
            panel1 = new Panel();
            infoLabel3 = new Label();
            confirmClearDBTextBox = new TextBox();
            ClearDBButton = new Button();
            settingsTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // settingsTabControl
            // 
            settingsTabControl.Alignment = TabAlignment.Left;
            settingsTabControl.Controls.Add(tabPage1);
            settingsTabControl.Dock = DockStyle.Fill;
            settingsTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            settingsTabControl.ItemSize = new Size(30, 100);
            settingsTabControl.Location = new Point(0, 0);
            settingsTabControl.Margin = new Padding(3, 4, 3, 4);
            settingsTabControl.Multiline = true;
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(1170, 733);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;
            settingsTabControl.TabIndex = 0;
            settingsTabControl.DrawItem += tabControl1_DrawItem;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(infoLabel2);
            tabPage1.Controls.Add(updateCooldownComboBox);
            tabPage1.Controls.Add(infoLabel1);
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
            // infoLabel2
            // 
            infoLabel2.AutoSize = true;
            infoLabel2.Location = new Point(470, 583);
            infoLabel2.Name = "infoLabel2";
            infoLabel2.Size = new Size(158, 20);
            infoLabel2.TabIndex = 3;
            infoLabel2.Text = "Размер базы данных:";
            // 
            // updateCooldownComboBox
            // 
            updateCooldownComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            updateCooldownComboBox.Items.AddRange(new object[] { "Отключить", "10 сек", "30 сек", "1 мин", "5 мин", "20 мин" });
            updateCooldownComboBox.Location = new Point(285, 580);
            updateCooldownComboBox.Margin = new Padding(3, 4, 3, 4);
            updateCooldownComboBox.Name = "updateCooldownComboBox";
            updateCooldownComboBox.Size = new Size(157, 28);
            updateCooldownComboBox.TabIndex = 2;
            updateCooldownComboBox.TabStop = false;
            updateCooldownComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // infoLabel1
            // 
            infoLabel1.AutoSize = true;
            infoLabel1.Location = new Point(15, 583);
            infoLabel1.Name = "infoLabel1";
            infoLabel1.Size = new Size(264, 20);
            infoLabel1.TabIndex = 1;
            infoLabel1.Text = "Автообновление записей с сервера:";
            // 
            // panel1
            // 
            panel1.Controls.Add(infoLabel3);
            panel1.Controls.Add(confirmClearDBTextBox);
            panel1.Controls.Add(ClearDBButton);
            panel1.Location = new Point(7, 632);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 81);
            panel1.TabIndex = 0;
            // 
            // infoLabel3
            // 
            infoLabel3.AutoSize = true;
            infoLabel3.Location = new Point(7, 12);
            infoLabel3.Name = "infoLabel3";
            infoLabel3.Size = new Size(785, 20);
            infoLabel3.TabIndex = 2;
            infoLabel3.Text = "Для удалении всех записей из базы данных введите в поле ниже: «Я хочу удалить все записи из базы данных»";
            // 
            // confirmClearDBTextBox
            // 
            confirmClearDBTextBox.Location = new Point(3, 47);
            confirmClearDBTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmClearDBTextBox.Name = "confirmClearDBTextBox";
            confirmClearDBTextBox.PlaceholderText = "Я хочу удалить все записи из базы данных";
            confirmClearDBTextBox.Size = new Size(822, 27);
            confirmClearDBTextBox.TabIndex = 1;
            confirmClearDBTextBox.TabStop = false;
            confirmClearDBTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ClearDBButton
            // 
            ClearDBButton.Enabled = false;
            ClearDBButton.Location = new Point(833, 47);
            ClearDBButton.Margin = new Padding(3, 4, 3, 4);
            ClearDBButton.Name = "ClearDBButton";
            ClearDBButton.Size = new Size(194, 31);
            ClearDBButton.TabIndex = 0;
            ClearDBButton.Text = "Очистить базу данных";
            ClearDBButton.UseVisualStyleBackColor = true;
            ClearDBButton.Click += button1_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 733);
            Controls.Add(settingsTabControl);
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
            settingsTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl settingsTabControl;
        private TabPage tabPage1;
        private TextBox confirmClearDBTextBox;
        private Panel panel1;
        private Button ClearDBButton;
        private Label infoLabel3;
        private ComboBox updateCooldownComboBox;
        private Label infoLabel1;
        private Label infoLabel2;
    }
}