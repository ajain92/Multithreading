namespace multithreadingGUI
{
    partial class Form1
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
            this.thread1checkbox = new System.Windows.Forms.CheckBox();
            this.thread2checkbox = new System.Windows.Forms.CheckBox();
            this.thread3checkbox = new System.Windows.Forms.CheckBox();
            this.thread1label = new System.Windows.Forms.Label();
            this.thread2label = new System.Windows.Forms.Label();
            this.thread3label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thread1checkbox
            // 
            this.thread1checkbox.AutoSize = true;
            this.thread1checkbox.Location = new System.Drawing.Point(141, 48);
            this.thread1checkbox.Name = "thread1checkbox";
            this.thread1checkbox.Size = new System.Drawing.Size(80, 17);
            this.thread1checkbox.TabIndex = 0;
            this.thread1checkbox.Text = "checkBox1";
            this.thread1checkbox.UseVisualStyleBackColor = true;
            this.thread1checkbox.CheckedChanged += new System.EventHandler(this.thread1checkbox_CheckedChanged);
            // 
            // thread2checkbox
            // 
            this.thread2checkbox.AutoSize = true;
            this.thread2checkbox.Location = new System.Drawing.Point(141, 109);
            this.thread2checkbox.Name = "thread2checkbox";
            this.thread2checkbox.Size = new System.Drawing.Size(80, 17);
            this.thread2checkbox.TabIndex = 1;
            this.thread2checkbox.Text = "checkBox2";
            this.thread2checkbox.UseVisualStyleBackColor = true;
            this.thread2checkbox.CheckedChanged += new System.EventHandler(this.thread2checkbox_CheckedChanged);
            // 
            // thread3checkbox
            // 
            this.thread3checkbox.AutoSize = true;
            this.thread3checkbox.Location = new System.Drawing.Point(141, 169);
            this.thread3checkbox.Name = "thread3checkbox";
            this.thread3checkbox.Size = new System.Drawing.Size(80, 17);
            this.thread3checkbox.TabIndex = 2;
            this.thread3checkbox.Text = "checkBox3";
            this.thread3checkbox.UseVisualStyleBackColor = true;
            this.thread3checkbox.CheckedChanged += new System.EventHandler(this.thread3checkbox_CheckedChanged);
            // 
            // thread1label
            // 
            this.thread1label.AutoSize = true;
            this.thread1label.Location = new System.Drawing.Point(32, 48);
            this.thread1label.Name = "thread1label";
            this.thread1label.Size = new System.Drawing.Size(35, 13);
            this.thread1label.TabIndex = 3;
            this.thread1label.Text = "label1";
            // 
            // thread2label
            // 
            this.thread2label.AutoSize = true;
            this.thread2label.Location = new System.Drawing.Point(32, 109);
            this.thread2label.Name = "thread2label";
            this.thread2label.Size = new System.Drawing.Size(35, 13);
            this.thread2label.TabIndex = 4;
            this.thread2label.Text = "label2";
            // 
            // thread3label
            // 
            this.thread3label.AutoSize = true;
            this.thread3label.Location = new System.Drawing.Point(32, 173);
            this.thread3label.Name = "thread3label";
            this.thread3label.Size = new System.Drawing.Size(35, 13);
            this.thread3label.TabIndex = 5;
            this.thread3label.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.thread3label);
            this.Controls.Add(this.thread2label);
            this.Controls.Add(this.thread1label);
            this.Controls.Add(this.thread3checkbox);
            this.Controls.Add(this.thread2checkbox);
            this.Controls.Add(this.thread1checkbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox thread1checkbox;
        private System.Windows.Forms.CheckBox thread2checkbox;
        private System.Windows.Forms.CheckBox thread3checkbox;
        private System.Windows.Forms.Label thread1label;
        private System.Windows.Forms.Label thread2label;
        private System.Windows.Forms.Label thread3label;
    }
}

