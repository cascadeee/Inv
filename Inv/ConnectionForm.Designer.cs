namespace Inv
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            timer1 = new System.Windows.Forms.Timer(components);
            databaseTextBox = new TextBox();
            databaseLabel = new Label();
            catalogLabel = new Label();
            connectionFormPicture = new PictureBox();
            confirmButton = new Button();
            catalogComboBox = new ComboBox();
            tryToConnectButton = new Button();
            ((System.ComponentModel.ISupportInitialize)connectionFormPicture).BeginInit();
            SuspendLayout();
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(154, 170);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(242, 27);
            databaseTextBox.TabIndex = 3;
            databaseTextBox.TextChanged += databaseTextBox_TextChanged;
            // 
            // databaseLabel
            // 
            databaseLabel.AutoSize = true;
            databaseLabel.Location = new Point(72, 173);
            databaseLabel.Name = "databaseLabel";
            databaseLabel.Size = new Size(60, 20);
            databaseLabel.TabIndex = 2;
            databaseLabel.Text = "Сервер";
            // 
            // catalogLabel
            // 
            catalogLabel.AutoSize = true;
            catalogLabel.Location = new Point(72, 213);
            catalogLabel.Name = "catalogLabel";
            catalogLabel.Size = new Size(63, 20);
            catalogLabel.TabIndex = 4;
            catalogLabel.Text = "Каталог";
            // 
            // connectionFormPicture
            // 
            connectionFormPicture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            connectionFormPicture.Image = (Image)resources.GetObject("connectionFormPicture.Image");
            connectionFormPicture.InitialImage = null;
            connectionFormPicture.Location = new Point(175, 12);
            connectionFormPicture.Name = "connectionFormPicture";
            connectionFormPicture.Size = new Size(136, 127);
            connectionFormPicture.TabIndex = 10;
            connectionFormPicture.TabStop = false;
            // 
            // confirmButton
            // 
            confirmButton.Enabled = false;
            confirmButton.Location = new Point(175, 254);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(136, 41);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "Подтвердить";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // catalogComboBox
            // 
            catalogComboBox.Enabled = false;
            catalogComboBox.FormattingEnabled = true;
            catalogComboBox.Location = new Point(154, 210);
            catalogComboBox.Name = "catalogComboBox";
            catalogComboBox.Size = new Size(242, 28);
            catalogComboBox.TabIndex = 12;
            catalogComboBox.SelectedIndexChanged += Validator;
            // 
            // tryToConnectButton
            // 
            tryToConnectButton.BackgroundImage = (Image)resources.GetObject("tryToConnectButton.BackgroundImage");
            tryToConnectButton.BackgroundImageLayout = ImageLayout.Stretch;
            tryToConnectButton.Enabled = false;
            tryToConnectButton.Location = new Point(402, 169);
            tryToConnectButton.Name = "tryToConnectButton";
            tryToConnectButton.Size = new Size(29, 29);
            tryToConnectButton.TabIndex = 13;
            tryToConnectButton.UseVisualStyleBackColor = true;
            tryToConnectButton.Click += tryToConnectButton_Click;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 322);
            Controls.Add(tryToConnectButton);
            Controls.Add(catalogComboBox);
            Controls.Add(confirmButton);
            Controls.Add(connectionFormPicture);
            Controls.Add(catalogLabel);
            Controls.Add(databaseTextBox);
            Controls.Add(databaseLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConnectionForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Подключение";
            FormClosed += ConnectionForm_FormClosed;
            Load += ConnectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)connectionFormPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TextBox databaseTextBox;
        private Label databaseLabel;
        private Label catalogLabel;
        private PictureBox connectionFormPicture;
        private Button confirmButton;
        private ComboBox catalogComboBox;
        private Button tryToConnectButton;
    }
}