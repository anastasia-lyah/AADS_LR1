namespace AADS_LR1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComparisons = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(47, 58);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(399, 29);
            this.txtInput.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.Location = new System.Drawing.Point(466, 58);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(136, 29);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(42, 387);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(190, 27);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Відсортований масив:";
            // 
            // lblComparisons
            // 
            this.lblComparisons.AutoSize = true;
            this.lblComparisons.Location = new System.Drawing.Point(42, 424);
            this.lblComparisons.Name = "lblComparisons";
            this.lblComparisons.Size = new System.Drawing.Size(175, 27);
            this.lblComparisons.TabIndex = 3;
            this.lblComparisons.Text = "Кількість порівнянь:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(47, 109);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(555, 265);
            this.dataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть масив чисел через кому:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblComparisons);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шейкер-сортування";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComparisons;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
    }
}

