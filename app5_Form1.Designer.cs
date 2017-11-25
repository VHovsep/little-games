namespace WindowsFormsApplication7
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonShow1 = new System.Windows.Forms.Button();
            this.buttonShow2 = new System.Windows.Forms.Button();
            this.buttonShow3 = new System.Windows.Forms.Button();
            this.buttonShow4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShow1
            // 
            this.buttonShow1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonShow1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow1.Location = new System.Drawing.Point(25, 23);
            this.buttonShow1.Name = "buttonShow1";
            this.buttonShow1.Size = new System.Drawing.Size(71, 33);
            this.buttonShow1.TabIndex = 0;
            this.buttonShow1.Text = "Озеро";
            this.buttonShow1.UseVisualStyleBackColor = true;
            this.buttonShow1.Click += new System.EventHandler(this.buttonShow1_Click);
            // 
            // buttonShow2
            // 
            this.buttonShow2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShow2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonShow2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow2.Location = new System.Drawing.Point(263, 23);
            this.buttonShow2.Name = "buttonShow2";
            this.buttonShow2.Size = new System.Drawing.Size(93, 33);
            this.buttonShow2.TabIndex = 1;
            this.buttonShow2.Text = "Ню-Йорк";
            this.buttonShow2.UseVisualStyleBackColor = true;
            this.buttonShow2.Click += new System.EventHandler(this.buttonShow2_Click);
            // 
            // buttonShow3
            // 
            this.buttonShow3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShow3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonShow3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow3.Location = new System.Drawing.Point(263, 206);
            this.buttonShow3.Name = "buttonShow3";
            this.buttonShow3.Size = new System.Drawing.Size(93, 33);
            this.buttonShow3.TabIndex = 1;
            this.buttonShow3.Text = "Океан";
            this.buttonShow3.UseVisualStyleBackColor = true;
            this.buttonShow3.Click += new System.EventHandler(this.buttonShow3_Click);
            // 
            // buttonShow4
            // 
            this.buttonShow4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShow4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonShow4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow4.Location = new System.Drawing.Point(25, 206);
            this.buttonShow4.Name = "buttonShow4";
            this.buttonShow4.Size = new System.Drawing.Size(71, 33);
            this.buttonShow4.TabIndex = 1;
            this.buttonShow4.Text = "Город";
            this.buttonShow4.UseVisualStyleBackColor = true;
            this.buttonShow4.Click += new System.EventHandler(this.buttonShow4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonShow4);
            this.Controls.Add(this.buttonShow3);
            this.Controls.Add(this.buttonShow2);
            this.Controls.Add(this.buttonShow1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretPicture";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonShow1;
        private System.Windows.Forms.Button buttonShow2;
        private System.Windows.Forms.Button buttonShow3;
        private System.Windows.Forms.Button buttonShow4;
    }
}
