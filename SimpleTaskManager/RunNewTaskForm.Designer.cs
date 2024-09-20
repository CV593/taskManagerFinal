namespace SimpleTaskManager
{
    partial class RunNewTaskForm
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
            this.openLabel = new System.Windows.Forms.Label();
            this.openInput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.openLabel.Location = new System.Drawing.Point(16, 44);
            this.openLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(125, 29);
            this.openLabel.TabIndex = 0;
            this.openLabel.Text = "Programa:";
            this.openLabel.Click += new System.EventHandler(this.openLabel_Click);
            // 
            // openInput
            // 
            this.openInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.openInput.Location = new System.Drawing.Point(224, 44);
            this.openInput.Margin = new System.Windows.Forms.Padding(4);
            this.openInput.Name = "openInput";
            this.openInput.Size = new System.Drawing.Size(484, 32);
            this.openInput.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Snow;
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnRun.Location = new System.Drawing.Point(567, 115);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(141, 41);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "&Correr";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // RunNewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(765, 251);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.openInput);
            this.Controls.Add(this.openLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RunNewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CORRER NUEVO PROCESO";
            this.Load += new System.EventHandler(this.RunNewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.TextBox openInput;
        private System.Windows.Forms.Button btnRun;
    }
}