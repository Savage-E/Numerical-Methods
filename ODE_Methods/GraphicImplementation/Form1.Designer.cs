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
            this.Euler_w_Right = new System.Windows.Forms.RadioButton();
            this.Euler_central = new System.Windows.Forms.RadioButton();
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
            this.dv.Location = new System.Drawing.Point(1061, 14);
            this.dv.Margin = new System.Windows.Forms.Padding(4);
            this.dv.Name = "dv";
            this.dv.RowHeadersVisible = false;
            this.dv.RowHeadersWidth = 62;
            this.dv.Size = new System.Drawing.Size(304, 676);
            this.dv.TabIndex = 0;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "Xi";
            this.Xi.MinimumWidth = 8;
            this.Xi.Name = "Xi";
            this.Xi.ReadOnly = true;
            this.Xi.Width = 150;
            // 
            // Yi
            // 
            this.Yi.HeaderText = "Yi";
            this.Yi.MinimumWidth = 8;
            this.Yi.Name = "Yi";
            this.Yi.ReadOnly = true;
            this.Yi.Width = 150;
            // 
            // Modified_Euler
            // 
            this.Modified_Euler.AutoSize = true;
            this.Modified_Euler.Location = new System.Drawing.Point(1192, 464);
            this.Modified_Euler.Margin = new System.Windows.Forms.Padding(4);
            this.Modified_Euler.Name = "Modified_Euler";
            this.Modified_Euler.Size = new System.Drawing.Size(119, 21);
            this.Modified_Euler.TabIndex = 1;
            this.Modified_Euler.TabStop = true;
            this.Modified_Euler.Text = "Modified Euler";
            this.Modified_Euler.UseVisualStyleBackColor = true;
            this.Modified_Euler.CheckedChanged += new System.EventHandler(this.Modified_Euler_CheckedChanged);
            // 
            // Euler
            // 
            this.Euler.AutoSize = true;
            this.Euler.Location = new System.Drawing.Point(1192, 492);
            this.Euler.Margin = new System.Windows.Forms.Padding(4);
            this.Euler.Name = "Euler";
            this.Euler.Size = new System.Drawing.Size(62, 21);
            this.Euler.TabIndex = 2;
            this.Euler.TabStop = true;
            this.Euler.Text = "Euler";
            this.Euler.UseVisualStyleBackColor = true;
            this.Euler.CheckedChanged += new System.EventHandler(this.Euler_CheckedChanged);
            // 
            // Rugle_Kutte
            // 
            this.Rugle_Kutte.AutoSize = true;
            this.Rugle_Kutte.Location = new System.Drawing.Point(1192, 573);
            this.Rugle_Kutte.Margin = new System.Windows.Forms.Padding(4);
            this.Rugle_Kutte.Name = "Rugle_Kutte";
            this.Rugle_Kutte.Size = new System.Drawing.Size(104, 21);
            this.Rugle_Kutte.TabIndex = 3;
            this.Rugle_Kutte.TabStop = true;
            this.Rugle_Kutte.Text = "Rugle-Kutte";
            this.Rugle_Kutte.UseVisualStyleBackColor = true;
            this.Rugle_Kutte.CheckedChanged += new System.EventHandler(this.Rugle_Kutte_CheckedChanged);
            // 
            // Adams
            // 
            this.Adams.AutoSize = true;
            this.Adams.Location = new System.Drawing.Point(1192, 602);
            this.Adams.Margin = new System.Windows.Forms.Padding(4);
            this.Adams.Name = "Adams";
            this.Adams.Size = new System.Drawing.Size(72, 21);
            this.Adams.TabIndex = 4;
            this.Adams.TabStop = true;
            this.Adams.Text = "Adams";
            this.Adams.UseVisualStyleBackColor = true;
            this.Adams.CheckedChanged += new System.EventHandler(this.Adams_CheckedChanged);
            // 
            // Euler_w_Right
            // 
            this.Euler_w_Right.AutoSize = true;
            this.Euler_w_Right.Location = new System.Drawing.Point(1192, 518);
            this.Euler_w_Right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Euler_w_Right.Name = "Euler_w_Right";
            this.Euler_w_Right.Size = new System.Drawing.Size(145, 21);
            this.Euler_w_Right.TabIndex = 5;
            this.Euler_w_Right.TabStop = true;
            this.Euler_w_Right.Text = "Euler with right diff";
            this.Euler_w_Right.UseVisualStyleBackColor = true;
            this.Euler_w_Right.CheckedChanged += new System.EventHandler(this.Euler_w_Right_CheckedChanged);
            // 
            // Euler_central
            // 
            this.Euler_central.AutoSize = true;
            this.Euler_central.Location = new System.Drawing.Point(1192, 545);
            this.Euler_central.Name = "Euler_central";
            this.Euler_central.Size = new System.Drawing.Size(173, 21);
            this.Euler_central.TabIndex = 6;
            this.Euler_central.TabStop = true;
            this.Euler_central.Text = "Euler center difference";
            this.Euler_central.UseVisualStyleBackColor = true;
            this.Euler_central.CheckedChanged += new System.EventHandler(this.Euler_central_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 718);
            this.Controls.Add(this.Euler_central);
            this.Controls.Add(this.Euler_w_Right);
            this.Controls.Add(this.Adams);
            this.Controls.Add(this.Rugle_Kutte);
            this.Controls.Add(this.Euler);
            this.Controls.Add(this.Modified_Euler);
            this.Controls.Add(this.dv);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.RadioButton Euler_w_Right;
        private System.Windows.Forms.RadioButton Euler_central;
    }
}

