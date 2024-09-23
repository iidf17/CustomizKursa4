using System;
using System.Windows.Forms;

namespace Customiz
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
            this.components = new System.ComponentModel.Container();
            this.TabContorl = new System.Windows.Forms.TabControl();
            this.mainn = new System.Windows.Forms.TabPage();
            this.warningLabel = new System.Windows.Forms.Label();
            this.tempTruncate = new System.Windows.Forms.Button();
            this.mainRefreshButt = new System.Windows.Forms.Button();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.worktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studying_planssDataSet = new Customiz.Studying_planssDataSet();
            this.umrTabPage = new System.Windows.Forms.TabPage();
            this.umrButt = new System.Windows.Forms.Button();
            this.umrGridView = new System.Windows.Forms.DataGridView();
            this.worktypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.omrTabPage = new System.Windows.Forms.TabPage();
            this.omrButt = new System.Windows.Forms.Button();
            this.omrGridView = new System.Windows.Forms.DataGridView();
            this.worktypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplanDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oMRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nirTabPage = new System.Windows.Forms.TabPage();
            this.nirButt = new System.Windows.Forms.Button();
            this.nirGridView = new System.Windows.Forms.DataGridView();
            this.worktypeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeplanDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umrTableAdapter1 = new Customiz.Studying_plansDataSetTableAdapters.UMRTableAdapter();
            this.mainTableAdapter = new Customiz.Studying_planssDataSetTableAdapters.MainTableAdapter();
            this.uMRTableAdapter = new Customiz.Studying_planssDataSetTableAdapters.UMRTableAdapter();
            this.oMRTableAdapter = new Customiz.Studying_planssDataSetTableAdapters.OMRTableAdapter();
            this.nIRTableAdapter = new Customiz.Studying_planssDataSetTableAdapters.NIRTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.TabContorl.SuspendLayout();
            this.mainn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studying_planssDataSet)).BeginInit();
            this.umrTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umrGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMRBindingSource)).BeginInit();
            this.omrTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.omrGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oMRBindingSource)).BeginInit();
            this.nirTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nirGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabContorl
            // 
            this.TabContorl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContorl.Controls.Add(this.mainn);
            this.TabContorl.Controls.Add(this.umrTabPage);
            this.TabContorl.Controls.Add(this.omrTabPage);
            this.TabContorl.Controls.Add(this.nirTabPage);
            this.TabContorl.Location = new System.Drawing.Point(12, 36);
            this.TabContorl.Name = "TabContorl";
            this.TabContorl.SelectedIndex = 0;
            this.TabContorl.Size = new System.Drawing.Size(1128, 455);
            this.TabContorl.TabIndex = 0;
            // 
            // mainn
            // 
            this.mainn.Controls.Add(this.warningLabel);
            this.mainn.Controls.Add(this.tempTruncate);
            this.mainn.Controls.Add(this.mainRefreshButt);
            this.mainn.Controls.Add(this.mainGridView);
            this.mainn.Location = new System.Drawing.Point(4, 25);
            this.mainn.Name = "mainn";
            this.mainn.Padding = new System.Windows.Forms.Padding(3);
            this.mainn.Size = new System.Drawing.Size(1120, 426);
            this.mainn.TabIndex = 0;
            this.mainn.Text = "Главная";
            this.mainn.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warningLabel.Location = new System.Drawing.Point(6, 3);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(552, 48);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Внимание!\r\nСрок следующих дисциплин истекает в течение 30-ти дней!";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempTruncate
            // 
            this.tempTruncate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tempTruncate.Location = new System.Drawing.Point(846, 383);
            this.tempTruncate.Name = "tempTruncate";
            this.tempTruncate.Size = new System.Drawing.Size(131, 30);
            this.tempTruncate.TabIndex = 2;
            this.tempTruncate.Text = "Очистить";
            this.tempTruncate.UseVisualStyleBackColor = true;
            this.tempTruncate.Click += new System.EventHandler(this.tempTruncate_Click);
            // 
            // mainRefreshButt
            // 
            this.mainRefreshButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mainRefreshButt.Location = new System.Drawing.Point(983, 383);
            this.mainRefreshButt.Name = "mainRefreshButt";
            this.mainRefreshButt.Size = new System.Drawing.Size(131, 30);
            this.mainRefreshButt.TabIndex = 1;
            this.mainRefreshButt.Text = "Обновить";
            this.mainRefreshButt.UseVisualStyleBackColor = true;
            this.mainRefreshButt.Click += new System.EventHandler(this.mainRefreshButt_Click);
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGridView.AutoGenerateColumns = false;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worktypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.timeplanDataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.mainGridView.DataSource = this.mainBindingSource;
            this.mainGridView.Location = new System.Drawing.Point(6, 54);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.RowHeadersVisible = false;
            this.mainGridView.RowHeadersWidth = 51;
            this.mainGridView.RowTemplate.Height = 24;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(1108, 323);
            this.mainGridView.TabIndex = 0;
            // 
            // worktypeDataGridViewTextBoxColumn
            // 
            this.worktypeDataGridViewTextBoxColumn.DataPropertyName = "work_type";
            this.worktypeDataGridViewTextBoxColumn.HeaderText = "Вид работы";
            this.worktypeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.worktypeDataGridViewTextBoxColumn.Name = "worktypeDataGridViewTextBoxColumn";
            this.worktypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeplanDataGridViewTextBoxColumn
            // 
            this.timeplanDataGridViewTextBoxColumn.DataPropertyName = "time_plan";
            this.timeplanDataGridViewTextBoxColumn.HeaderText = "План (ч.)";
            this.timeplanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeplanDataGridViewTextBoxColumn.Name = "timeplanDataGridViewTextBoxColumn";
            this.timeplanDataGridViewTextBoxColumn.Width = 150;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Срок";
            this.datesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "Main";
            this.mainBindingSource.DataSource = this.studying_planssDataSet;
            // 
            // studying_planssDataSet
            // 
            this.studying_planssDataSet.DataSetName = "Studying_planssDataSet";
            this.studying_planssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // umrTabPage
            // 
            this.umrTabPage.Controls.Add(this.umrButt);
            this.umrTabPage.Controls.Add(this.umrGridView);
            this.umrTabPage.Location = new System.Drawing.Point(4, 25);
            this.umrTabPage.Name = "umrTabPage";
            this.umrTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.umrTabPage.Size = new System.Drawing.Size(1120, 426);
            this.umrTabPage.TabIndex = 1;
            this.umrTabPage.Text = "УМР";
            this.umrTabPage.UseVisualStyleBackColor = true;
            // 
            // umrButt
            // 
            this.umrButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.umrButt.Location = new System.Drawing.Point(983, 383);
            this.umrButt.Name = "umrButt";
            this.umrButt.Size = new System.Drawing.Size(131, 31);
            this.umrButt.TabIndex = 2;
            this.umrButt.Text = "Добавить";
            this.umrButt.UseVisualStyleBackColor = true;
            this.umrButt.Click += new System.EventHandler(this.umrButt_Click);
            // 
            // umrGridView
            // 
            this.umrGridView.AllowUserToAddRows = false;
            this.umrGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.umrGridView.AutoGenerateColumns = false;
            this.umrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.umrGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worktypeDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.timeplanDataGridViewTextBoxColumn1,
            this.datesDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.umrGridView.DataSource = this.uMRBindingSource;
            this.umrGridView.Location = new System.Drawing.Point(6, 6);
            this.umrGridView.Name = "umrGridView";
            this.umrGridView.RowHeadersVisible = false;
            this.umrGridView.RowHeadersWidth = 51;
            this.umrGridView.RowTemplate.Height = 24;
            this.umrGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.umrGridView.Size = new System.Drawing.Size(1108, 371);
            this.umrGridView.TabIndex = 0;
            // 
            // worktypeDataGridViewTextBoxColumn1
            // 
            this.worktypeDataGridViewTextBoxColumn1.DataPropertyName = "work_type";
            this.worktypeDataGridViewTextBoxColumn1.HeaderText = "Вид работы";
            this.worktypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.worktypeDataGridViewTextBoxColumn1.Name = "worktypeDataGridViewTextBoxColumn1";
            this.worktypeDataGridViewTextBoxColumn1.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // timeplanDataGridViewTextBoxColumn1
            // 
            this.timeplanDataGridViewTextBoxColumn1.DataPropertyName = "time_plan";
            this.timeplanDataGridViewTextBoxColumn1.HeaderText = "План (ч.)";
            this.timeplanDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.timeplanDataGridViewTextBoxColumn1.Name = "timeplanDataGridViewTextBoxColumn1";
            this.timeplanDataGridViewTextBoxColumn1.Width = 150;
            // 
            // datesDataGridViewTextBoxColumn1
            // 
            this.datesDataGridViewTextBoxColumn1.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn1.HeaderText = "Срок";
            this.datesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn1.Name = "datesDataGridViewTextBoxColumn1";
            this.datesDataGridViewTextBoxColumn1.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Width = 150;
            // 
            // uMRBindingSource
            // 
            this.uMRBindingSource.DataMember = "UMR";
            this.uMRBindingSource.DataSource = this.studying_planssDataSet;
            // 
            // omrTabPage
            // 
            this.omrTabPage.Controls.Add(this.omrButt);
            this.omrTabPage.Controls.Add(this.omrGridView);
            this.omrTabPage.Location = new System.Drawing.Point(4, 25);
            this.omrTabPage.Name = "omrTabPage";
            this.omrTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.omrTabPage.Size = new System.Drawing.Size(1120, 426);
            this.omrTabPage.TabIndex = 2;
            this.omrTabPage.Text = "ОМР";
            this.omrTabPage.UseVisualStyleBackColor = true;
            // 
            // omrButt
            // 
            this.omrButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.omrButt.Location = new System.Drawing.Point(983, 383);
            this.omrButt.Name = "omrButt";
            this.omrButt.Size = new System.Drawing.Size(131, 31);
            this.omrButt.TabIndex = 3;
            this.omrButt.Text = "Добавить";
            this.omrButt.UseVisualStyleBackColor = true;
            this.omrButt.Click += new System.EventHandler(this.omrButt_Click);
            // 
            // omrGridView
            // 
            this.omrGridView.AllowUserToAddRows = false;
            this.omrGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.omrGridView.AutoGenerateColumns = false;
            this.omrGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.omrGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worktypeDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2,
            this.timeplanDataGridViewTextBoxColumn2,
            this.datesDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn2});
            this.omrGridView.DataSource = this.oMRBindingSource;
            this.omrGridView.Location = new System.Drawing.Point(6, 6);
            this.omrGridView.Name = "omrGridView";
            this.omrGridView.RowHeadersVisible = false;
            this.omrGridView.RowHeadersWidth = 51;
            this.omrGridView.RowTemplate.Height = 24;
            this.omrGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.omrGridView.Size = new System.Drawing.Size(1108, 371);
            this.omrGridView.TabIndex = 0;
            // 
            // worktypeDataGridViewTextBoxColumn2
            // 
            this.worktypeDataGridViewTextBoxColumn2.DataPropertyName = "work_type";
            this.worktypeDataGridViewTextBoxColumn2.HeaderText = "Вид работы";
            this.worktypeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.worktypeDataGridViewTextBoxColumn2.Name = "worktypeDataGridViewTextBoxColumn2";
            this.worktypeDataGridViewTextBoxColumn2.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.Width = 200;
            // 
            // timeplanDataGridViewTextBoxColumn2
            // 
            this.timeplanDataGridViewTextBoxColumn2.DataPropertyName = "time_plan";
            this.timeplanDataGridViewTextBoxColumn2.HeaderText = "План (ч.)";
            this.timeplanDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.timeplanDataGridViewTextBoxColumn2.Name = "timeplanDataGridViewTextBoxColumn2";
            this.timeplanDataGridViewTextBoxColumn2.Width = 150;
            // 
            // datesDataGridViewTextBoxColumn2
            // 
            this.datesDataGridViewTextBoxColumn2.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn2.HeaderText = "Срок";
            this.datesDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn2.Name = "datesDataGridViewTextBoxColumn2";
            this.datesDataGridViewTextBoxColumn2.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.Width = 150;
            // 
            // oMRBindingSource
            // 
            this.oMRBindingSource.DataMember = "OMR";
            this.oMRBindingSource.DataSource = this.studying_planssDataSet;
            // 
            // nirTabPage
            // 
            this.nirTabPage.Controls.Add(this.nirButt);
            this.nirTabPage.Controls.Add(this.nirGridView);
            this.nirTabPage.Location = new System.Drawing.Point(4, 25);
            this.nirTabPage.Name = "nirTabPage";
            this.nirTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nirTabPage.Size = new System.Drawing.Size(1120, 426);
            this.nirTabPage.TabIndex = 3;
            this.nirTabPage.Text = "НИР";
            this.nirTabPage.UseVisualStyleBackColor = true;
            // 
            // nirButt
            // 
            this.nirButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nirButt.Location = new System.Drawing.Point(983, 383);
            this.nirButt.Name = "nirButt";
            this.nirButt.Size = new System.Drawing.Size(131, 31);
            this.nirButt.TabIndex = 4;
            this.nirButt.Text = "Добавить";
            this.nirButt.UseVisualStyleBackColor = true;
            this.nirButt.Click += new System.EventHandler(this.nirButt_Click);
            // 
            // nirGridView
            // 
            this.nirGridView.AllowUserToAddRows = false;
            this.nirGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nirGridView.AutoGenerateColumns = false;
            this.nirGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nirGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.worktypeDataGridViewTextBoxColumn3,
            this.descriptionDataGridViewTextBoxColumn3,
            this.timeplanDataGridViewTextBoxColumn3,
            this.datesDataGridViewTextBoxColumn3,
            this.statusDataGridViewTextBoxColumn3});
            this.nirGridView.DataSource = this.nIRBindingSource;
            this.nirGridView.Location = new System.Drawing.Point(6, 6);
            this.nirGridView.Name = "nirGridView";
            this.nirGridView.RowHeadersVisible = false;
            this.nirGridView.RowHeadersWidth = 51;
            this.nirGridView.RowTemplate.Height = 24;
            this.nirGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nirGridView.Size = new System.Drawing.Size(1108, 371);
            this.nirGridView.TabIndex = 0;
            // 
            // worktypeDataGridViewTextBoxColumn3
            // 
            this.worktypeDataGridViewTextBoxColumn3.DataPropertyName = "work_type";
            this.worktypeDataGridViewTextBoxColumn3.HeaderText = "Вид работы";
            this.worktypeDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.worktypeDataGridViewTextBoxColumn3.Name = "worktypeDataGridViewTextBoxColumn3";
            this.worktypeDataGridViewTextBoxColumn3.Width = 175;
            // 
            // descriptionDataGridViewTextBoxColumn3
            // 
            this.descriptionDataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn3.Name = "descriptionDataGridViewTextBoxColumn3";
            this.descriptionDataGridViewTextBoxColumn3.Width = 200;
            // 
            // timeplanDataGridViewTextBoxColumn3
            // 
            this.timeplanDataGridViewTextBoxColumn3.DataPropertyName = "time_plan";
            this.timeplanDataGridViewTextBoxColumn3.HeaderText = "План (ч.)";
            this.timeplanDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.timeplanDataGridViewTextBoxColumn3.Name = "timeplanDataGridViewTextBoxColumn3";
            this.timeplanDataGridViewTextBoxColumn3.Width = 150;
            // 
            // datesDataGridViewTextBoxColumn3
            // 
            this.datesDataGridViewTextBoxColumn3.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn3.HeaderText = "Срок";
            this.datesDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.datesDataGridViewTextBoxColumn3.Name = "datesDataGridViewTextBoxColumn3";
            this.datesDataGridViewTextBoxColumn3.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn3
            // 
            this.statusDataGridViewTextBoxColumn3.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn3.Name = "statusDataGridViewTextBoxColumn3";
            this.statusDataGridViewTextBoxColumn3.Width = 150;
            // 
            // nIRBindingSource
            // 
            this.nIRBindingSource.DataMember = "NIR";
            this.nIRBindingSource.DataSource = this.studying_planssDataSet;
            // 
            // umrTableAdapter1
            // 
            this.umrTableAdapter1.ClearBeforeFill = true;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // uMRTableAdapter
            // 
            this.uMRTableAdapter.ClearBeforeFill = true;
            // 
            // oMRTableAdapter
            // 
            this.oMRTableAdapter.ClearBeforeFill = true;
            // 
            // nIRTableAdapter
            // 
            this.nIRTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "2023/24 учебный год";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabContorl);
            this.MaximumSize = new System.Drawing.Size(1170, 850);
            this.MinimumSize = new System.Drawing.Size(1170, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Индивидуальный план работы преподавателя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabContorl.ResumeLayout(false);
            this.mainn.ResumeLayout(false);
            this.mainn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studying_planssDataSet)).EndInit();
            this.umrTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.umrGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMRBindingSource)).EndInit();
            this.omrTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.omrGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oMRBindingSource)).EndInit();
            this.nirTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nirGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIRBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabContorl;
        private System.Windows.Forms.TabPage mainn;
        private System.Windows.Forms.TabPage umrTabPage;
        private System.Windows.Forms.TabPage omrTabPage;
        private System.Windows.Forms.TabPage nirTabPage;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.DataGridView umrGridView;
        private System.Windows.Forms.DataGridView omrGridView;
        private System.Windows.Forms.DataGridView nirGridView;
        private System.Windows.Forms.Button mainRefreshButt;
        private System.Windows.Forms.Button umrButt;
        private System.Windows.Forms.Button omrButt;
        private Studying_plansDataSetTableAdapters.UMRTableAdapter umrTableAdapter1;
        private Studying_planssDataSet studying_planssDataSet;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private Studying_planssDataSetTableAdapters.MainTableAdapter mainTableAdapter;
        private System.Windows.Forms.BindingSource uMRBindingSource;
        private Studying_planssDataSetTableAdapters.UMRTableAdapter uMRTableAdapter;
        private System.Windows.Forms.BindingSource oMRBindingSource;
        private Studying_planssDataSetTableAdapters.OMRTableAdapter oMRTableAdapter;
        private System.Windows.Forms.BindingSource nIRBindingSource;
        private Studying_planssDataSetTableAdapters.NIRTableAdapter nIRTableAdapter;
        private System.Windows.Forms.Button tempTruncate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nirButt;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktypeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplanDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeplanDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label warningLabel;
    }
}

