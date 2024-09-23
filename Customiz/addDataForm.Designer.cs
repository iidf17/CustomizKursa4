namespace Customiz
{
    partial class addDataForm
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
            this.workTypeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.timePlanLabel = new System.Windows.Forms.Label();
            this.timePlanTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datesLabel = new System.Windows.Forms.Label();
            this.statusesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workTypeTextBox
            // 
            this.workTypeTextBox.Location = new System.Drawing.Point(30, 49);
            this.workTypeTextBox.Name = "workTypeTextBox";
            this.workTypeTextBox.Size = new System.Drawing.Size(130, 22);
            this.workTypeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип работы";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(166, 27);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 16);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Описание";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(166, 49);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(130, 22);
            this.DescTextBox.TabIndex = 2;
            // 
            // timePlanLabel
            // 
            this.timePlanLabel.AutoSize = true;
            this.timePlanLabel.Location = new System.Drawing.Point(302, 27);
            this.timePlanLabel.Name = "timePlanLabel";
            this.timePlanLabel.Size = new System.Drawing.Size(63, 16);
            this.timePlanLabel.TabIndex = 5;
            this.timePlanLabel.Text = "План (ч.)";
            // 
            // timePlanTextBox
            // 
            this.timePlanTextBox.Location = new System.Drawing.Point(302, 49);
            this.timePlanTextBox.MaxLength = 7;
            this.timePlanTextBox.Name = "timePlanTextBox";
            this.timePlanTextBox.Size = new System.Drawing.Size(130, 22);
            this.timePlanTextBox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // datesLabel
            // 
            this.datesLabel.AutoSize = true;
            this.datesLabel.Location = new System.Drawing.Point(435, 27);
            this.datesLabel.Name = "datesLabel";
            this.datesLabel.Size = new System.Drawing.Size(39, 16);
            this.datesLabel.TabIndex = 7;
            this.datesLabel.Text = "Срок";
            // 
            // statusesComboBox
            // 
            this.statusesComboBox.FormattingEnabled = true;
            this.statusesComboBox.Items.AddRange(new object[] {
            "Назначено",
            "В работе",
            "Выполнено",
            "Утверждено"});
            this.statusesComboBox.Location = new System.Drawing.Point(584, 47);
            this.statusesComboBox.Name = "statusesComboBox";
            this.statusesComboBox.Size = new System.Drawing.Size(135, 24);
            this.statusesComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Статус";
            // 
            // saveButt
            // 
            this.saveButt.Location = new System.Drawing.Point(584, 77);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(135, 32);
            this.saveButt.TabIndex = 10;
            this.saveButt.Text = "Сохранить";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // addDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 122);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusesComboBox);
            this.Controls.Add(this.datesLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timePlanLabel);
            this.Controls.Add(this.timePlanTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workTypeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(400, 200);
            this.Name = "addDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TimePlanTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //throw new System.NotImplementedException();
        }

        private void TimePlanTextBox_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox workTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.Label timePlanLabel;
        private System.Windows.Forms.TextBox timePlanTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datesLabel;
        private System.Windows.Forms.ComboBox statusesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButt;
    }
}