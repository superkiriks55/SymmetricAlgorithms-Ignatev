namespace SymmetricAlgorithms_Ignatev
{
    partial class SymmetricForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymmetricForm));
            this.label1 = new System.Windows.Forms.Label();
            this.testingGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.fileChoiseBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryDataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.testingGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Файл данных для тестирования:";
            // 
            // testingGroupBox
            // 
            this.testingGroupBox.Controls.Add(this.errorLabel);
            this.testingGroupBox.Controls.Add(this.passwordTextBox);
            this.testingGroupBox.Controls.Add(this.label2);
            this.testingGroupBox.Controls.Add(this.startBtn);
            this.testingGroupBox.Controls.Add(this.fileChoiseBtn);
            this.testingGroupBox.Controls.Add(this.filePathTextBox);
            this.testingGroupBox.Controls.Add(this.label3);
            this.testingGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.testingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.testingGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.testingGroupBox.Name = "testingGroupBox";
            this.testingGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.testingGroupBox.Size = new System.Drawing.Size(800, 148);
            this.testingGroupBox.TabIndex = 4;
            this.testingGroupBox.TabStop = false;
            this.testingGroupBox.Text = "Тестирование";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(11, 118);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(188, 60);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(423, 20);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль для шифрования:";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(11, 87);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(780, 25);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // fileChoiseBtn
            // 
            this.fileChoiseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileChoiseBtn.Location = new System.Drawing.Point(632, 33);
            this.fileChoiseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fileChoiseBtn.Name = "fileChoiseBtn";
            this.fileChoiseBtn.Size = new System.Drawing.Size(69, 25);
            this.fileChoiseBtn.TabIndex = 4;
            this.fileChoiseBtn.Text = "Выбор";
            this.fileChoiseBtn.UseVisualStyleBackColor = true;
            this.fileChoiseBtn.Click += new System.EventHandler(this.fileChoiseBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(188, 37);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(423, 20);
            this.filePathTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Файл данных для тестирования:";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryGroupBox.Controls.Add(this.summaryDataGridView);
            this.summaryGroupBox.Location = new System.Drawing.Point(0, 152);
            this.summaryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.summaryGroupBox.Size = new System.Drawing.Size(789, 287);
            this.summaryGroupBox.TabIndex = 5;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Результаты";
            // 
            // summaryDataGridView
            // 
            this.summaryDataGridView.AllowUserToAddRows = false;
            this.summaryDataGridView.AllowUserToDeleteRows = false;
            this.summaryDataGridView.AllowUserToOrderColumns = true;
            this.summaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.summaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.summaryDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.summaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryDataGridView.Location = new System.Drawing.Point(2, 15);
            this.summaryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.summaryDataGridView.Name = "summaryDataGridView";
            this.summaryDataGridView.ReadOnly = true;
            this.summaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.summaryDataGridView.RowHeadersWidth = 10;
            this.summaryDataGridView.RowTemplate.Height = 24;
            this.summaryDataGridView.Size = new System.Drawing.Size(785, 270);
            this.summaryDataGridView.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.Title = "Выбор файла";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SymmetricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.testingGroupBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SymmetricForm";
            this.Text = "Лабораторная работа 2 : Сравнение симметричных алгоритмов шифрования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.testingGroupBox.ResumeLayout(false);
            this.testingGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.summaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox testingGroupBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button fileChoiseBtn;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.DataGridView summaryDataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

