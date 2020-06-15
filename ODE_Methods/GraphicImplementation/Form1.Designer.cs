namespace GraphicImplementation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dv = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modified_Euler = new System.Windows.Forms.RadioButton();
            this.Euler = new System.Windows.Forms.RadioButton();
            this.Rugle_Kutte = new System.Windows.Forms.RadioButton();
            this.Adams = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // dv
            // 
            this.dv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi,
            this.Yi});
            this.dv.GridColor = System.Drawing.Color.White;
            this.dv.Location = new System.Drawing.Point(796, 12);
            this.dv.Name = "dv";
            this.dv.RowHeadersVisible = false;
            this.dv.Size = new System.Drawing.Size(207, 549);
            this.dv.TabIndex = 0;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "Yi";
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            // 
            // Modified_Euler
            // 
            this.Modified_Euler.AutoSize = true;
            this.Modified_Euler.Location = new System.Drawing.Point(894, 377);
            this.Modified_Euler.Name = "Modified_Euler";
            this.Modified_Euler.Size = new System.Drawing.Size(92, 17);
            this.Modified_Euler.TabIndex = 1;
            this.Modified_Euler.TabStop = true;
            this.Modified_Euler.Text = "Modified Euler";
            this.Modified_Euler.UseVisualStyleBackColor = true;
            this.Modified_Euler.CheckedChanged += new System.EventHandler(this.Modified_Euler_CheckedChanged);
            // 
            // Euler
            // 
            this.Euler.AutoSize = true;
            this.Euler.Location = new System.Drawing.Point(894, 400);
            this.Euler.Name = "Euler";
            this.Euler.Size = new System.Drawing.Size(49, 17);
            this.Euler.TabIndex = 2;
            this.Euler.TabStop = true;
            this.Euler.Text = "Euler";
            this.Euler.UseVisualStyleBackColor = true;
            this.Euler.CheckedChanged += new System.EventHandler(this.Euler_CheckedChanged);
            // 
            // Rugle_Kutte
            // 
            this.Rugle_Kutte.AutoSize = true;
            this.Rugle_Kutte.Location = new System.Drawing.Point(894, 423);
            this.Rugle_Kutte.Name = "Rugle_Kutte";
            this.Rugle_Kutte.Size = new System.Drawing.Size(81, 17);
            this.Rugle_Kutte.TabIndex = 3;
            this.Rugle_Kutte.TabStop = true;
            this.Rugle_Kutte.Text = "Rugle-Kutte";
            this.Rugle_Kutte.UseVisualStyleBackColor = true;
            this.Rugle_Kutte.CheckedChanged += new System.EventHandler(this.Rugle_Kutte_CheckedChanged);
            // 
            // Adams
            // 
            this.Adams.AutoSize = true;
            this.Adams.Location = new System.Drawing.Point(894, 446);
            this.Adams.Name = "Adams";
            this.Adams.Size = new System.Drawing.Size(57, 17);
            this.Adams.TabIndex = 4;
            this.Adams.TabStop = true;
            this.Adams.Text = "Adams";
            this.Adams.UseVisualStyleBackColor = true;
            this.Adams.CheckedChanged += new System.EventHandler(this.Adams_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 584);
            this.Controls.Add(this.Adams);
            this.Controls.Add(this.Rugle_Kutte);
            this.Controls.Add(this.Euler);
            this.Controls.Add(this.Modified_Euler);
            this.Controls.Add(this.dv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GraphicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.RadioButton Modified_Euler;
        private System.Windows.Forms.RadioButton Euler;
        private System.Windows.Forms.RadioButton Rugle_Kutte;
        private System.Windows.Forms.RadioButton Adams;
    }
}

