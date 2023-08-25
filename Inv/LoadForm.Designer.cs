namespace Inv
{
    partial class LoadForm
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
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 36);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(440, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // LoadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 69);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Поиск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}