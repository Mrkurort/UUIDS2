namespace UUIDS
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label код_Студ_id_Label;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label группаLabel;
            System.Windows.Forms.Label кураторLabel;
            System.Windows.Forms.Label телLabel;
            System.Windows.Forms.Label код_СпециальностиLabel;
            System.Windows.Forms.Label направление_специальностиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new UUIDS.DataSet1();
            this.studBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studTableAdapter = new UUIDS.DataSet1TableAdapters.StudTableAdapter();
            this.tableAdapterManager = new UUIDS.DataSet1TableAdapters.TableAdapterManager();
            this.код_Студ_id_TextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.группаTextBox = new System.Windows.Forms.TextBox();
            this.кураторTextBox = new System.Windows.Forms.TextBox();
            this.телTextBox = new System.Windows.Forms.TextBox();
            this.код_СпециальностиTextBox = new System.Windows.Forms.TextBox();
            this.направление_специальностиTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            код_Студ_id_Label = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            группаLabel = new System.Windows.Forms.Label();
            кураторLabel = new System.Windows.Forms.Label();
            телLabel = new System.Windows.Forms.Label();
            код_СпециальностиLabel = new System.Windows.Forms.Label();
            направление_специальностиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingNavigator)).BeginInit();
            this.studBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_Студ_id_Label
            // 
            код_Студ_id_Label.AutoSize = true;
            код_Студ_id_Label.Location = new System.Drawing.Point(569, 282);
            код_Студ_id_Label.Name = "код_Студ_id_Label";
            код_Студ_id_Label.Size = new System.Drawing.Size(69, 13);
            код_Студ_id_Label.TabIndex = 2;
            код_Студ_id_Label.Text = "Код Студ(id):";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(569, 308);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 4;
            фИОLabel.Text = "ФИО:";
            // 
            // группаLabel
            // 
            группаLabel.AutoSize = true;
            группаLabel.Location = new System.Drawing.Point(569, 334);
            группаLabel.Name = "группаLabel";
            группаLabel.Size = new System.Drawing.Size(45, 13);
            группаLabel.TabIndex = 6;
            группаLabel.Text = "Группа:";
            // 
            // кураторLabel
            // 
            кураторLabel.AutoSize = true;
            кураторLabel.Location = new System.Drawing.Point(569, 360);
            кураторLabel.Name = "кураторLabel";
            кураторLabel.Size = new System.Drawing.Size(51, 13);
            кураторLabel.TabIndex = 8;
            кураторLabel.Text = "Куратор:";
            // 
            // телLabel
            // 
            телLabel.AutoSize = true;
            телLabel.Location = new System.Drawing.Point(569, 386);
            телLabel.Name = "телLabel";
            телLabel.Size = new System.Drawing.Size(29, 13);
            телLabel.TabIndex = 10;
            телLabel.Text = "Тел:";
            // 
            // код_СпециальностиLabel
            // 
            код_СпециальностиLabel.AutoSize = true;
            код_СпециальностиLabel.Location = new System.Drawing.Point(569, 412);
            код_СпециальностиLabel.Name = "код_СпециальностиLabel";
            код_СпециальностиLabel.Size = new System.Drawing.Size(110, 13);
            код_СпециальностиLabel.TabIndex = 12;
            код_СпециальностиLabel.Text = "Код Специальности:";
            // 
            // направление_специальностиLabel
            // 
            направление_специальностиLabel.AutoSize = true;
            направление_специальностиLabel.Location = new System.Drawing.Point(569, 438);
            направление_специальностиLabel.Name = "направление_специальностиLabel";
            направление_специальностиLabel.Size = new System.Drawing.Size(158, 13);
            направление_специальностиLabel.TabIndex = 14;
            направление_специальностиLabel.Text = "Направление специальности:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studBindingSource
            // 
            this.studBindingSource.DataMember = "Stud";
            this.studBindingSource.DataSource = this.dataSet1;
            // 
            // studTableAdapter
            // 
            this.studTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudTableAdapter = this.studTableAdapter;
            this.tableAdapterManager.UpdateOrder = UUIDS.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_РаботыTableAdapter = null;
            this.tableAdapterManager.ГруппаПTableAdapter = null;
            this.tableAdapterManager.ПредметыПTableAdapter = null;
            this.tableAdapterManager.Работы_студентовTableAdapter = null;
            this.tableAdapterManager.РуководителиПTableAdapter = null;
            this.tableAdapterManager.СпециальностиПTableAdapter = null;
            // 
            // код_Студ_id_TextBox
            // 
            this.код_Студ_id_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Код Студ(id)", true));
            this.код_Студ_id_TextBox.Location = new System.Drawing.Point(733, 279);
            this.код_Студ_id_TextBox.Name = "код_Студ_id_TextBox";
            this.код_Студ_id_TextBox.Size = new System.Drawing.Size(100, 20);
            this.код_Студ_id_TextBox.TabIndex = 3;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(733, 305);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 5;
            // 
            // группаTextBox
            // 
            this.группаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Группа", true));
            this.группаTextBox.Location = new System.Drawing.Point(733, 331);
            this.группаTextBox.Name = "группаTextBox";
            this.группаTextBox.Size = new System.Drawing.Size(100, 20);
            this.группаTextBox.TabIndex = 7;
            // 
            // кураторTextBox
            // 
            this.кураторTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Куратор", true));
            this.кураторTextBox.Location = new System.Drawing.Point(733, 357);
            this.кураторTextBox.Name = "кураторTextBox";
            this.кураторTextBox.Size = new System.Drawing.Size(100, 20);
            this.кураторTextBox.TabIndex = 9;
            // 
            // телTextBox
            // 
            this.телTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Тел", true));
            this.телTextBox.Location = new System.Drawing.Point(733, 383);
            this.телTextBox.Name = "телTextBox";
            this.телTextBox.Size = new System.Drawing.Size(100, 20);
            this.телTextBox.TabIndex = 11;
            // 
            // код_СпециальностиTextBox
            // 
            this.код_СпециальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Код Специальности", true));
            this.код_СпециальностиTextBox.Location = new System.Drawing.Point(733, 409);
            this.код_СпециальностиTextBox.Name = "код_СпециальностиTextBox";
            this.код_СпециальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_СпециальностиTextBox.TabIndex = 13;
            // 
            // направление_специальностиTextBox
            // 
            this.направление_специальностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studBindingSource, "Направление специальности", true));
            this.направление_специальностиTextBox.Location = new System.Drawing.Point(733, 435);
            this.направление_специальностиTextBox.Name = "направление_специальностиTextBox";
            this.направление_специальностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.направление_специальностиTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Направление специальности";
            this.dataGridViewTextBoxColumn7.HeaderText = "Направление специальности";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код Специальности";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код Специальности";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Тел";
            this.dataGridViewTextBoxColumn5.HeaderText = "Тел";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Куратор";
            this.dataGridViewTextBoxColumn4.HeaderText = "Куратор";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn3.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код Студ(id)";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код Студ(id)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // studDataGridView
            // 
            this.studDataGridView.AutoGenerateColumns = false;
            this.studDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.studDataGridView.DataSource = this.studBindingSource;
            this.studDataGridView.Location = new System.Drawing.Point(12, 28);
            this.studDataGridView.Name = "studDataGridView";
            this.studDataGridView.Size = new System.Drawing.Size(821, 220);
            this.studDataGridView.TabIndex = 1;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // studBindingNavigatorSaveItem
            // 
            this.studBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studBindingNavigatorSaveItem.Image")));
            this.studBindingNavigatorSaveItem.Name = "studBindingNavigatorSaveItem";
            this.studBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.studBindingNavigatorSaveItem.Click += new System.EventHandler(this.studBindingNavigatorSaveItem_Click);
            // 
            // studBindingNavigator
            // 
            this.studBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studBindingNavigator.BindingSource = this.studBindingSource;
            this.studBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studBindingNavigatorSaveItem});
            this.studBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studBindingNavigator.Name = "studBindingNavigator";
            this.studBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.studBindingNavigator.TabIndex = 0;
            this.studBindingNavigator.Text = "bindingNavigator1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(279, 406);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Назад";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 552);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(код_Студ_id_Label);
            this.Controls.Add(this.код_Студ_id_TextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(группаLabel);
            this.Controls.Add(this.группаTextBox);
            this.Controls.Add(кураторLabel);
            this.Controls.Add(this.кураторTextBox);
            this.Controls.Add(телLabel);
            this.Controls.Add(this.телTextBox);
            this.Controls.Add(код_СпециальностиLabel);
            this.Controls.Add(this.код_СпециальностиTextBox);
            this.Controls.Add(направление_специальностиLabel);
            this.Controls.Add(this.направление_специальностиTextBox);
            this.Controls.Add(this.studDataGridView);
            this.Controls.Add(this.studBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studBindingNavigator)).EndInit();
            this.studBindingNavigator.ResumeLayout(false);
            this.studBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studBindingSource;
        private DataSet1TableAdapters.StudTableAdapter studTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_Студ_id_TextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox группаTextBox;
        private System.Windows.Forms.TextBox кураторTextBox;
        private System.Windows.Forms.TextBox телTextBox;
        private System.Windows.Forms.TextBox код_СпециальностиTextBox;
        private System.Windows.Forms.TextBox направление_специальностиTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView studDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton studBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator studBindingNavigator;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}