namespace Уч_пр_1_2_
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
            this.ColumnSizeTextBox = new System.Windows.Forms.TextBox();
            this.RowSizeTextBox = new System.Windows.Forms.TextBox();
            this.EnterSizeButton = new System.Windows.Forms.Button();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.MaxRowElementButton = new System.Windows.Forms.Button();
            this.SelectedRowTextBox = new System.Windows.Forms.TextBox();
            this.MinColumnElementButton = new System.Windows.Forms.Button();
            this.SelectedColumnTextBox = new System.Windows.Forms.TextBox();
            this.AddColumn = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxRowElement = new System.Windows.Forms.Label();
            this.MinColumnElement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnSizeTextBox
            // 
            this.ColumnSizeTextBox.Location = new System.Drawing.Point(31, 36);
            this.ColumnSizeTextBox.Name = "ColumnSizeTextBox";
            this.ColumnSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColumnSizeTextBox.TabIndex = 0;
            // 
            // RowSizeTextBox
            // 
            this.RowSizeTextBox.Location = new System.Drawing.Point(161, 36);
            this.RowSizeTextBox.Name = "RowSizeTextBox";
            this.RowSizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RowSizeTextBox.TabIndex = 1;
            // 
            // EnterSizeButton
            // 
            this.EnterSizeButton.Location = new System.Drawing.Point(31, 62);
            this.EnterSizeButton.Name = "EnterSizeButton";
            this.EnterSizeButton.Size = new System.Drawing.Size(75, 23);
            this.EnterSizeButton.TabIndex = 2;
            this.EnterSizeButton.Text = "Ввод";
            this.EnterSizeButton.UseVisualStyleBackColor = true;
            this.EnterSizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.ColumnHeadersVisible = false;
            this.matrix.Location = new System.Drawing.Point(405, 24);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersVisible = false;
            this.matrix.Size = new System.Drawing.Size(853, 529);
            this.matrix.TabIndex = 4;
            // 
            // MaxRowElementButton
            // 
            this.MaxRowElementButton.Location = new System.Drawing.Point(31, 127);
            this.MaxRowElementButton.Name = "MaxRowElementButton";
            this.MaxRowElementButton.Size = new System.Drawing.Size(75, 23);
            this.MaxRowElementButton.TabIndex = 5;
            this.MaxRowElementButton.Text = "Ввод";
            this.MaxRowElementButton.UseVisualStyleBackColor = true;
            this.MaxRowElementButton.Click += new System.EventHandler(this.MaxRowElementButton_Click);
            // 
            // SelectedRowTextBox
            // 
            this.SelectedRowTextBox.Location = new System.Drawing.Point(216, 105);
            this.SelectedRowTextBox.Name = "SelectedRowTextBox";
            this.SelectedRowTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRowTextBox.TabIndex = 6;
            // 
            // MinColumnElementButton
            // 
            this.MinColumnElementButton.Location = new System.Drawing.Point(31, 200);
            this.MinColumnElementButton.Name = "MinColumnElementButton";
            this.MinColumnElementButton.Size = new System.Drawing.Size(75, 23);
            this.MinColumnElementButton.TabIndex = 7;
            this.MinColumnElementButton.Text = "Ввод";
            this.MinColumnElementButton.UseVisualStyleBackColor = true;
            this.MinColumnElementButton.Click += new System.EventHandler(this.MinColumnElementButton_Click);
            // 
            // SelectedColumnTextBox
            // 
            this.SelectedColumnTextBox.Location = new System.Drawing.Point(213, 171);
            this.SelectedColumnTextBox.Name = "SelectedColumnTextBox";
            this.SelectedColumnTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedColumnTextBox.TabIndex = 8;
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(31, 255);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(124, 23);
            this.AddColumn.TabIndex = 9;
            this.AddColumn.Text = "Добавить столбец";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(161, 255);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(113, 23);
            this.AddRow.TabIndex = 10;
            this.AddRow.Text = "Добавить строку";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Количество столбцов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Максимальный элемент в строке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Минимальный элемнт в столбце";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Результат";
            // 
            // MaxRowElement
            // 
            this.MaxRowElement.AutoSize = true;
            this.MaxRowElement.Location = new System.Drawing.Point(217, 132);
            this.MaxRowElement.Name = "MaxRowElement";
            this.MaxRowElement.Size = new System.Drawing.Size(10, 13);
            this.MaxRowElement.TabIndex = 19;
            this.MaxRowElement.Text = " ";
            // 
            // MinColumnElement
            // 
            this.MinColumnElement.AutoSize = true;
            this.MinColumnElement.Location = new System.Drawing.Point(217, 201);
            this.MinColumnElement.Name = "MinColumnElement";
            this.MinColumnElement.Size = new System.Drawing.Size(10, 13);
            this.MinColumnElement.TabIndex = 20;
            this.MinColumnElement.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 622);
            this.Controls.Add(this.MinColumnElement);
            this.Controls.Add(this.MaxRowElement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.SelectedColumnTextBox);
            this.Controls.Add(this.MinColumnElementButton);
            this.Controls.Add(this.SelectedRowTextBox);
            this.Controls.Add(this.MaxRowElementButton);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.EnterSizeButton);
            this.Controls.Add(this.RowSizeTextBox);
            this.Controls.Add(this.ColumnSizeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColumnSizeTextBox;
        private System.Windows.Forms.TextBox RowSizeTextBox;
        private System.Windows.Forms.Button EnterSizeButton;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button MaxRowElementButton;
        private System.Windows.Forms.TextBox SelectedRowTextBox;
        private System.Windows.Forms.Button MinColumnElementButton;
        private System.Windows.Forms.TextBox SelectedColumnTextBox;
        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MaxRowElement;
        private System.Windows.Forms.Label MinColumnElement;
    }
}

