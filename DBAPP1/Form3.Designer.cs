﻿namespace DBAPP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label cITYLabel;
            System.Windows.Forms.Label tELLabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label dATEJOINEDLabel;
            System.Windows.Forms.Label aGELabel;
            this.employeeDataSet = new DBAPP1.EmployeeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new DBAPP1.EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new DBAPP1.EmployeeDataSetTableAdapters.TableAdapterManager();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            this.tELTextBox = new System.Windows.Forms.TextBox();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.dATEJOINEDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            tELLabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            dATEJOINEDLabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DBAPP1.EmployeeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeBindingNavigator.BindingSource = this.employeeBindingSource;
            this.employeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(358, 25);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeBindingNavigatorSaveItem.Image")));
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employeeBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(32, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(116, 57);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(32, 86);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(47, 13);
            fNAMELabel.TabIndex = 3;
            fNAMELabel.Text = "FNAME:";
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(116, 83);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.fNAMETextBox.TabIndex = 4;
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(32, 112);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(47, 13);
            lNAMELabel.TabIndex = 5;
            lNAMELabel.Text = "LNAME:";
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(116, 109);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.lNAMETextBox.TabIndex = 6;
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(32, 138);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(62, 13);
            aDDRESSLabel.TabIndex = 7;
            aDDRESSLabel.Text = "ADDRESS:";
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(116, 135);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(200, 20);
            this.aDDRESSTextBox.TabIndex = 8;
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Location = new System.Drawing.Point(32, 164);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(34, 13);
            cITYLabel.TabIndex = 9;
            cITYLabel.Text = "CITY:";
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CITY", true));
            this.cITYTextBox.Location = new System.Drawing.Point(116, 161);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(200, 20);
            this.cITYTextBox.TabIndex = 10;
            // 
            // tELLabel
            // 
            tELLabel.AutoSize = true;
            tELLabel.Location = new System.Drawing.Point(32, 190);
            tELLabel.Name = "tELLabel";
            tELLabel.Size = new System.Drawing.Size(30, 13);
            tELLabel.TabIndex = 11;
            tELLabel.Text = "TEL:";
            // 
            // tELTextBox
            // 
            this.tELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "TEL", true));
            this.tELTextBox.Location = new System.Drawing.Point(116, 187);
            this.tELTextBox.Name = "tELTextBox";
            this.tELTextBox.Size = new System.Drawing.Size(200, 20);
            this.tELTextBox.TabIndex = 12;
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(32, 216);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(56, 13);
            gENDERLabel.TabIndex = 13;
            gENDERLabel.Text = "GENDER:";
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "GENDER", true));
            this.gENDERTextBox.Location = new System.Drawing.Point(116, 213);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(200, 20);
            this.gENDERTextBox.TabIndex = 14;
            // 
            // dATEJOINEDLabel
            // 
            dATEJOINEDLabel.AutoSize = true;
            dATEJOINEDLabel.Location = new System.Drawing.Point(32, 243);
            dATEJOINEDLabel.Name = "dATEJOINEDLabel";
            dATEJOINEDLabel.Size = new System.Drawing.Size(78, 13);
            dATEJOINEDLabel.TabIndex = 15;
            dATEJOINEDLabel.Text = "DATEJOINED:";
            // 
            // dATEJOINEDDateTimePicker
            // 
            this.dATEJOINEDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "DATEJOINED", true));
            this.dATEJOINEDDateTimePicker.Location = new System.Drawing.Point(116, 239);
            this.dATEJOINEDDateTimePicker.Name = "dATEJOINEDDateTimePicker";
            this.dATEJOINEDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATEJOINEDDateTimePicker.TabIndex = 16;
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(32, 268);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(32, 13);
            aGELabel.TabIndex = 17;
            aGELabel.Text = "AGE:";
            // 
            // aGETextBox
            // 
            this.aGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "AGE", true));
            this.aGETextBox.Location = new System.Drawing.Point(116, 265);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(200, 20);
            this.aGETextBox.TabIndex = 18;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 328);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(fNAMELabel);
            this.Controls.Add(this.fNAMETextBox);
            this.Controls.Add(lNAMELabel);
            this.Controls.Add(this.lNAMETextBox);
            this.Controls.Add(aDDRESSLabel);
            this.Controls.Add(this.aDDRESSTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(tELLabel);
            this.Controls.Add(this.tELTextBox);
            this.Controls.Add(gENDERLabel);
            this.Controls.Add(this.gENDERTextBox);
            this.Controls.Add(dATEJOINEDLabel);
            this.Controls.Add(this.dATEJOINEDDateTimePicker);
            this.Controls.Add(aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private EmployeeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
        private System.Windows.Forms.TextBox tELTextBox;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.DateTimePicker dATEJOINEDDateTimePicker;
        private System.Windows.Forms.TextBox aGETextBox;
    }
}