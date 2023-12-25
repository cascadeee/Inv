namespace Inv
{
    partial class SubModal
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
            mainPanel = new Panel();
            itemRecipientLabel = new Label();
            itemRecipientTextBox = new TextBox();
            itemWithdrawDataTimePicker = new DateTimePicker();
            itemWithdrawCountNumericUpDown = new NumericUpDown();
            itemWithdrawCountLabel = new Label();
            itemWithdrawDataLabel = new Label();
            itemArrivalDateTextBox = new TextBox();
            itemCountNumericUpDown = new NumericUpDown();
            itemCountLabel = new Label();
            arrivalDateLabel = new Label();
            itemInvLabel = new Label();
            itemInvTextBox = new TextBox();
            itemCodeLabel = new Label();
            itemCodeTextBox = new TextBox();
            itemNameLabel = new Label();
            itemNameTextBox = new TextBox();
            withdrawButton = new Button();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemWithdrawCountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(itemRecipientLabel);
            mainPanel.Controls.Add(itemRecipientTextBox);
            mainPanel.Controls.Add(itemWithdrawDataTimePicker);
            mainPanel.Controls.Add(itemWithdrawCountNumericUpDown);
            mainPanel.Controls.Add(itemWithdrawCountLabel);
            mainPanel.Controls.Add(itemWithdrawDataLabel);
            mainPanel.Controls.Add(itemArrivalDateTextBox);
            mainPanel.Controls.Add(itemCountNumericUpDown);
            mainPanel.Controls.Add(itemCountLabel);
            mainPanel.Controls.Add(arrivalDateLabel);
            mainPanel.Controls.Add(itemInvLabel);
            mainPanel.Controls.Add(itemInvTextBox);
            mainPanel.Controls.Add(itemCodeLabel);
            mainPanel.Controls.Add(itemCodeTextBox);
            mainPanel.Controls.Add(itemNameLabel);
            mainPanel.Controls.Add(itemNameTextBox);
            mainPanel.Controls.Add(withdrawButton);
            mainPanel.Location = new Point(14, 8);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(298, 595);
            mainPanel.TabIndex = 4;
            // 
            // itemRecipientLabel
            // 
            itemRecipientLabel.AutoSize = true;
            itemRecipientLabel.Location = new Point(2, 436);
            itemRecipientLabel.Name = "itemRecipientLabel";
            itemRecipientLabel.Size = new Size(90, 20);
            itemRecipientLabel.TabIndex = 18;
            itemRecipientLabel.Text = "Получатель";
            // 
            // itemRecipientTextBox
            // 
            itemRecipientTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemRecipientTextBox.Location = new Point(2, 460);
            itemRecipientTextBox.Margin = new Padding(3, 4, 3, 4);
            itemRecipientTextBox.Name = "itemRecipientTextBox";
            itemRecipientTextBox.Size = new Size(291, 27);
            itemRecipientTextBox.TabIndex = 1;
            // 
            // itemWithdrawDataTimePicker
            // 
            itemWithdrawDataTimePicker.Location = new Point(3, 343);
            itemWithdrawDataTimePicker.Margin = new Padding(3, 4, 3, 4);
            itemWithdrawDataTimePicker.Name = "itemWithdrawDataTimePicker";
            itemWithdrawDataTimePicker.Size = new Size(291, 27);
            itemWithdrawDataTimePicker.TabIndex = 16;
            itemWithdrawDataTimePicker.TabStop = false;
            // 
            // itemWithdrawCountNumericUpDown
            // 
            itemWithdrawCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemWithdrawCountNumericUpDown.Location = new Point(3, 401);
            itemWithdrawCountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            itemWithdrawCountNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            itemWithdrawCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemWithdrawCountNumericUpDown.Name = "itemWithdrawCountNumericUpDown";
            itemWithdrawCountNumericUpDown.Size = new Size(291, 27);
            itemWithdrawCountNumericUpDown.TabIndex = 15;
            itemWithdrawCountNumericUpDown.TabStop = false;
            itemWithdrawCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemWithdrawCountLabel
            // 
            itemWithdrawCountLabel.AutoSize = true;
            itemWithdrawCountLabel.Location = new Point(3, 377);
            itemWithdrawCountLabel.Name = "itemWithdrawCountLabel";
            itemWithdrawCountLabel.Size = new Size(160, 20);
            itemWithdrawCountLabel.TabIndex = 14;
            itemWithdrawCountLabel.Text = "Количество к расходу";
            // 
            // itemWithdrawDataLabel
            // 
            itemWithdrawDataLabel.AutoSize = true;
            itemWithdrawDataLabel.Location = new Point(3, 319);
            itemWithdrawDataLabel.Name = "itemWithdrawDataLabel";
            itemWithdrawDataLabel.Size = new Size(111, 20);
            itemWithdrawDataLabel.TabIndex = 13;
            itemWithdrawDataLabel.Text = "Дата списания";
            // 
            // itemArrivalDateTextBox
            // 
            itemArrivalDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemArrivalDateTextBox.Enabled = false;
            itemArrivalDateTextBox.Location = new Point(2, 225);
            itemArrivalDateTextBox.Margin = new Padding(3, 4, 3, 4);
            itemArrivalDateTextBox.Name = "itemArrivalDateTextBox";
            itemArrivalDateTextBox.Size = new Size(291, 27);
            itemArrivalDateTextBox.TabIndex = 12;
            itemArrivalDateTextBox.TabStop = false;
            // 
            // itemCountNumericUpDown
            // 
            itemCountNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemCountNumericUpDown.Enabled = false;
            itemCountNumericUpDown.Location = new Point(3, 284);
            itemCountNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            itemCountNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            itemCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemCountNumericUpDown.Name = "itemCountNumericUpDown";
            itemCountNumericUpDown.Size = new Size(291, 27);
            itemCountNumericUpDown.TabIndex = 11;
            itemCountNumericUpDown.TabStop = false;
            itemCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemCountLabel
            // 
            itemCountLabel.AutoSize = true;
            itemCountLabel.Location = new Point(3, 260);
            itemCountLabel.Name = "itemCountLabel";
            itemCountLabel.Size = new Size(150, 20);
            itemCountLabel.TabIndex = 10;
            itemCountLabel.Text = "Текущее количество";
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Location = new Point(3, 201);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new Size(134, 20);
            arrivalDateLabel.TabIndex = 8;
            arrivalDateLabel.Text = "Дата поступления";
            // 
            // itemInvLabel
            // 
            itemInvLabel.AutoSize = true;
            itemInvLabel.Location = new Point(3, 143);
            itemInvLabel.Name = "itemInvLabel";
            itemInvLabel.Size = new Size(61, 20);
            itemInvLabel.TabIndex = 6;
            itemInvLabel.Text = "Инв. №";
            // 
            // itemInvTextBox
            // 
            itemInvTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemInvTextBox.Enabled = false;
            itemInvTextBox.Location = new Point(3, 167);
            itemInvTextBox.Margin = new Padding(3, 4, 3, 4);
            itemInvTextBox.Name = "itemInvTextBox";
            itemInvTextBox.Size = new Size(291, 27);
            itemInvTextBox.TabIndex = 5;
            itemInvTextBox.TabStop = false;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new Point(3, 84);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new Size(65, 20);
            itemCodeLabel.TabIndex = 4;
            itemCodeLabel.Text = "Артикул";
            // 
            // itemCodeTextBox
            // 
            itemCodeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemCodeTextBox.Enabled = false;
            itemCodeTextBox.Location = new Point(3, 108);
            itemCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            itemCodeTextBox.Name = "itemCodeTextBox";
            itemCodeTextBox.Size = new Size(291, 27);
            itemCodeTextBox.TabIndex = 3;
            itemCodeTextBox.TabStop = false;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(3, 25);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(116, 20);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Наименование";
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemNameTextBox.Enabled = false;
            itemNameTextBox.Location = new Point(3, 49);
            itemNameTextBox.Margin = new Padding(3, 4, 3, 4);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(291, 27);
            itemNameTextBox.TabIndex = 1;
            itemNameTextBox.TabStop = false;
            // 
            // withdrawButton
            // 
            withdrawButton.AutoSize = true;
            withdrawButton.DialogResult = DialogResult.Yes;
            withdrawButton.Dock = DockStyle.Bottom;
            withdrawButton.Location = new Point(0, 538);
            withdrawButton.Margin = new Padding(3, 4, 3, 4);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(298, 57);
            withdrawButton.TabIndex = 0;
            withdrawButton.TabStop = false;
            withdrawButton.Text = "Расход";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // SubModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 619);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubModal";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += SubModal_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemWithdrawCountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemCountNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label itemCountLabel;
        private Label arrivalDateLabel;
        private Label itemInvLabel;
        private Label itemCodeLabel;
        private Label itemNameLabel;
        private Button withdrawButton;
        public TextBox itemNameTextBox;
        public NumericUpDown itemCountNumericUpDown;
        public TextBox itemInvTextBox;
        public TextBox itemCodeTextBox;
        public TextBox itemArrivalDateTextBox;
        public NumericUpDown itemWithdrawCountNumericUpDown;
        private Label itemWithdrawCountLabel;
        private Label itemWithdrawDataLabel;
        private DateTimePicker itemWithdrawDataTimePicker;
        private Label itemRecipientLabel;
        public TextBox itemRecipientTextBox;
    }
}