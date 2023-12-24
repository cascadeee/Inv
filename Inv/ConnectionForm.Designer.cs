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
            catalogTextBox = new TextBox();
            catalogLabel = new Label();
            connectionFormPicture = new PictureBox();
            confirmButton = new Button();
            ((System.ComponentModel.ISupportInitialize)connectionFormPicture).BeginInit();
            SuspendLayout();
            // 
            // databaseTextBox
            // 
            databaseTextBox.Location = new Point(187, 173);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(242, 27);
            databaseTextBox.TabIndex = 3;
            // 
            // databaseLabel
            // 
            databaseLabel.AutoSize = true;
            databaseLabel.Location = new Point(66, 173);
            databaseLabel.Name = "databaseLabel";
            databaseLabel.Size = new Size(99, 20);
            databaseLabel.TabIndex = 2;
            databaseLabel.Text = "База Данных";
            // 
            // catalogTextBox
            // 
            catalogTextBox.Location = new Point(187, 213);
            catalogTextBox.Name = "catalogTextBox";
            catalogTextBox.Size = new Size(242, 27);
            catalogTextBox.TabIndex = 5;
            // 
            // catalogLabel
            // 
            catalogLabel.AutoSize = true;
            catalogLabel.Location = new Point(66, 213);
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
            confirmButton.Location = new Point(175, 261);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(136, 41);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "Подтвердить";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // LoadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 322);
            Controls.Add(confirmButton);
            Controls.Add(connectionFormPicture);
            Controls.Add(catalogTextBox);
            Controls.Add(catalogLabel);
            Controls.Add(databaseTextBox);
            Controls.Add(databaseLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Подключение";
            FormClosing += ConnectionForm_FormClosing;
            Load += ConnectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)connectionFormPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TextBox databaseTextBox;
        private Label databaseLabel;
        private TextBox catalogTextBox;
        private Label catalogLabel;
        private PictureBox connectionFormPicture;
        private Button confirmButton;
    }
}