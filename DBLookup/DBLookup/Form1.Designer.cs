﻿using System;
using System.Windows.Forms;
using System.Configuration;

namespace DBLookup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnApplyChangesToDB = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeDBtables = new System.Windows.Forms.TreeView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.Tlp_OpenConnection = new System.Windows.Forms.TableLayoutPanel();
            this.cmbConnectString = new System.Windows.Forms.ComboBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCollapseTree = new System.Windows.Forms.Button();
            this.btnClearDataTableFilter = new System.Windows.Forms.Button();
            this.btnDeleteRecordsFromTableGrid = new System.Windows.Forms.Button();
            this.btnScriptTableData = new System.Windows.Forms.Button();
            this.chkTruncateFirst = new System.Windows.Forms.CheckBox();
            this.btnSaveChangesToProjectAndDB = new System.Windows.Forms.Button();
            this.Tlp_Datagrids = new System.Windows.Forms.TableLayoutPanel();
            this.dgrid_TableData = new System.Windows.Forms.DataGridView();
            this.dgrid_Search = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwConnectToDB = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tmrTableData = new System.Windows.Forms.Timer(this.components);
            this.cMenu_DBTree_TableScriptActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenu_DBTree_TableScript_Top500 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_DBTree_TableScript_DDL = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_DBTree_TableScript_Select = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_DBTree_TableScript_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_DBTree_TableScript_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_DBTree_TableScript_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTimeOut_TableData = new System.Windows.Forms.Timer(this.components);
            this.cmenuDgrid_TableData_Actions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenuItemDeleteHighlightedRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuItem_DeleteSelectedRecordOnly = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Tlp_OpenConnection.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Tlp_Datagrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TableData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Search)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.cMenu_DBTree_TableScriptActions.SuspendLayout();
            this.cmenuDgrid_TableData_Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplyChangesToDB
            // 
            this.btnApplyChangesToDB.Location = new System.Drawing.Point(277, 3);
            this.btnApplyChangesToDB.Name = "btnApplyChangesToDB";
            this.btnApplyChangesToDB.Size = new System.Drawing.Size(134, 23);
            this.btnApplyChangesToDB.TabIndex = 2;
            this.btnApplyChangesToDB.Text = "Apply Changes To DB";
            this.btnApplyChangesToDB.UseVisualStyleBackColor = true;
            this.btnApplyChangesToDB.Click += new System.EventHandler(this.BtnApplyChangesToDB_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tlp_Datagrids);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(724, 534);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Tlp_OpenConnection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 207);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 79);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeDBtables);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtSQL);
            this.splitContainer2.Size = new System.Drawing.Size(718, 145);
            this.splitContainer2.SplitterDistance = 116;
            this.splitContainer2.TabIndex = 3;
            // 
            // treeDBtables
            // 
            this.treeDBtables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDBtables.Location = new System.Drawing.Point(0, 0);
            this.treeDBtables.Name = "treeDBtables";
            this.treeDBtables.Size = new System.Drawing.Size(116, 145);
            this.treeDBtables.TabIndex = 0;
            this.treeDBtables.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseDoubleClick);
            this.treeDBtables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView1_MouseDown);
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(0, 0);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Size = new System.Drawing.Size(598, 145);
            this.txtSQL.TabIndex = 4;
            // 
            // Tlp_OpenConnection
            // 
            this.Tlp_OpenConnection.ColumnCount = 2;
            this.Tlp_OpenConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70282F));
            this.Tlp_OpenConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.29719F));
            this.Tlp_OpenConnection.Controls.Add(this.cmbConnectString, 1, 0);
            this.Tlp_OpenConnection.Controls.Add(this.lblConnection, 0, 0);
            this.Tlp_OpenConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_OpenConnection.Location = new System.Drawing.Point(4, 4);
            this.Tlp_OpenConnection.Margin = new System.Windows.Forms.Padding(4);
            this.Tlp_OpenConnection.Name = "Tlp_OpenConnection";
            this.Tlp_OpenConnection.RowCount = 1;
            this.Tlp_OpenConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tlp_OpenConnection.Size = new System.Drawing.Size(716, 26);
            this.Tlp_OpenConnection.TabIndex = 4;
            // 
            // cmbConnectString
            // 
            this.cmbConnectString.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbConnectString.FormattingEnabled = true;
            this.cmbConnectString.Location = new System.Drawing.Point(108, 3);
            this.cmbConnectString.MaxDropDownItems = 50;
            this.cmbConnectString.Name = "cmbConnectString";
            this.cmbConnectString.Size = new System.Drawing.Size(605, 21);
            this.cmbConnectString.TabIndex = 1;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConnection.AutoSize = true;
            this.lblConnection.CausesValidation = false;
            this.lblConnection.Location = new System.Drawing.Point(16, 0);
            this.lblConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(72, 26);
            this.lblConnection.TabIndex = 0;
            this.lblConnection.Text = "Select Connection:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCollapseTree);
            this.flowLayoutPanel1.Controls.Add(this.btnClearDataTableFilter);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteRecordsFromTableGrid);
            this.flowLayoutPanel1.Controls.Add(this.btnApplyChangesToDB);
            this.flowLayoutPanel1.Controls.Add(this.btnScriptTableData);
            this.flowLayoutPanel1.Controls.Add(this.chkTruncateFirst);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveChangesToProjectAndDB);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(718, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCollapseTree
            // 
            this.btnCollapseTree.Location = new System.Drawing.Point(2, 2);
            this.btnCollapseTree.Margin = new System.Windows.Forms.Padding(2);
            this.btnCollapseTree.Name = "btnCollapseTree";
            this.btnCollapseTree.Size = new System.Drawing.Size(87, 23);
            this.btnCollapseTree.TabIndex = 0;
            this.btnCollapseTree.Text = "Collapse Tree";
            this.btnCollapseTree.UseVisualStyleBackColor = true;
            this.btnCollapseTree.Click += new System.EventHandler(this.BtnCollapseTree_Click);
            // 
            // btnClearDataTableFilter
            // 
            this.btnClearDataTableFilter.Enabled = false;
            this.btnClearDataTableFilter.Location = new System.Drawing.Point(93, 2);
            this.btnClearDataTableFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDataTableFilter.Name = "btnClearDataTableFilter";
            this.btnClearDataTableFilter.Size = new System.Drawing.Size(81, 24);
            this.btnClearDataTableFilter.TabIndex = 6;
            this.btnClearDataTableFilter.Text = "Clear Filter";
            this.btnClearDataTableFilter.UseVisualStyleBackColor = true;
            this.btnClearDataTableFilter.Click += new System.EventHandler(this.BtnClearTableDataFilter_Click);
            // 
            // btnDeleteRecordsFromTableGrid
            // 
            this.btnDeleteRecordsFromTableGrid.Location = new System.Drawing.Point(178, 2);
            this.btnDeleteRecordsFromTableGrid.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteRecordsFromTableGrid.Name = "btnDeleteRecordsFromTableGrid";
            this.btnDeleteRecordsFromTableGrid.Size = new System.Drawing.Size(94, 24);
            this.btnDeleteRecordsFromTableGrid.TabIndex = 7;
            this.btnDeleteRecordsFromTableGrid.Text = "Delete Records";
            this.btnDeleteRecordsFromTableGrid.UseVisualStyleBackColor = true;
            this.btnDeleteRecordsFromTableGrid.Click += new System.EventHandler(this.BtnDeleteRecordsFromTableGrild_Click);
            // 
            // btnScriptTableData
            // 
            this.btnScriptTableData.Enabled = false;
            this.btnScriptTableData.Location = new System.Drawing.Point(417, 3);
            this.btnScriptTableData.Name = "btnScriptTableData";
            this.btnScriptTableData.Size = new System.Drawing.Size(100, 23);
            this.btnScriptTableData.TabIndex = 3;
            this.btnScriptTableData.Text = "Script Table Data";
            this.btnScriptTableData.UseVisualStyleBackColor = true;
            this.btnScriptTableData.Click += new System.EventHandler(this.BtnScriptTableData);
            // 
            // chkTruncateFirst
            // 
            this.chkTruncateFirst.AutoSize = true;
            this.chkTruncateFirst.Checked = true;
            this.chkTruncateFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTruncateFirst.Enabled = false;
            this.chkTruncateFirst.Location = new System.Drawing.Point(522, 2);
            this.chkTruncateFirst.Margin = new System.Windows.Forms.Padding(2);
            this.chkTruncateFirst.Name = "chkTruncateFirst";
            this.chkTruncateFirst.Size = new System.Drawing.Size(100, 19);
            this.chkTruncateFirst.TabIndex = 5;
            this.chkTruncateFirst.Text = "Truncate First";
            this.chkTruncateFirst.UseVisualStyleBackColor = true;
            // 
            // btnSaveChangesToProjectAndDB
            // 
            this.btnSaveChangesToProjectAndDB.Enabled = false;
            this.btnSaveChangesToProjectAndDB.Location = new System.Drawing.Point(3, 32);
            this.btnSaveChangesToProjectAndDB.Name = "btnSaveChangesToProjectAndDB";
            this.btnSaveChangesToProjectAndDB.Size = new System.Drawing.Size(184, 23);
            this.btnSaveChangesToProjectAndDB.TabIndex = 4;
            this.btnSaveChangesToProjectAndDB.Text = "Save Changes to Project and DB";
            this.btnSaveChangesToProjectAndDB.UseVisualStyleBackColor = true;
            this.btnSaveChangesToProjectAndDB.Click += new System.EventHandler(this.BtnSaveChangesToProjectAndDB_Click);
            // 
            // Tlp_Datagrids
            // 
            this.Tlp_Datagrids.ColumnCount = 1;
            this.Tlp_Datagrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Datagrids.Controls.Add(this.dgrid_TableData, 0, 1);
            this.Tlp_Datagrids.Controls.Add(this.dgrid_Search, 0, 0);
            this.Tlp_Datagrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Datagrids.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Tlp_Datagrids.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Datagrids.Margin = new System.Windows.Forms.Padding(2);
            this.Tlp_Datagrids.Name = "Tlp_Datagrids";
            this.Tlp_Datagrids.RowCount = 2;
            this.Tlp_Datagrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Tlp_Datagrids.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Tlp_Datagrids.Size = new System.Drawing.Size(724, 288);
            this.Tlp_Datagrids.TabIndex = 5;
            // 
            // dgrid_TableData
            // 
            this.dgrid_TableData.AllowDrop = true;
            this.dgrid_TableData.AllowUserToOrderColumns = true;
            this.dgrid_TableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrid_TableData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_TableData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_TableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_TableData.Location = new System.Drawing.Point(3, 73);
            this.dgrid_TableData.Name = "dgrid_TableData";
            this.dgrid_TableData.RowHeadersWidth = 51;
            this.dgrid_TableData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_TableData.Size = new System.Drawing.Size(718, 216);
            this.dgrid_TableData.TabIndex = 4;
            // 
            // dgrid_Search
            // 
            this.dgrid_Search.AllowDrop = true;
            this.dgrid_Search.AllowUserToAddRows = false;
            this.dgrid_Search.AllowUserToDeleteRows = false;
            this.dgrid_Search.AllowUserToResizeRows = false;
            this.dgrid_Search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Search.ColumnHeadersHeight = 29;
            this.dgrid_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgrid_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Search.Location = new System.Drawing.Point(3, 3);
            this.dgrid_Search.MultiSelect = false;
            this.dgrid_Search.Name = "dgrid_Search";
            this.dgrid_Search.RowHeadersWidth = 51;
            this.dgrid_Search.Size = new System.Drawing.Size(718, 64);
            this.dgrid_Search.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 35);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(2, 5, 5, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 28);
            this.toolStripStatusLabel2.Text = "View History";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.ToolStripStatusLabel2Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 29);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 29);
            // 
            // bgwConnectToDB
            // 
            this.bgwConnectToDB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwConnectToDB);
            this.bgwConnectToDB.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwConnectToDB_ProgressChanged);
            this.bgwConnectToDB.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwConnectToDB_Completed);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // tmrTableData
            // 
            this.tmrTableData.Interval = 1000;
            this.tmrTableData.Tick += new System.EventHandler(this.tmrTableData_Tick);
            // 
            // cMenu_DBTree_TableScriptActions
            // 
            this.cMenu_DBTree_TableScriptActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenu_DBTree_TableScriptActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_DBTree_TableScript_Top500,
            this.cMenu_DBTree_TableScript_DDL});
            this.cMenu_DBTree_TableScriptActions.Name = "contextMenuStripTable";
            this.cMenu_DBTree_TableScriptActions.Size = new System.Drawing.Size(215, 52);
            // 
            // cMenu_DBTree_TableScript_Top500
            // 
            this.cMenu_DBTree_TableScript_Top500.Name = "cMenu_DBTree_TableScript_Top500";
            this.cMenu_DBTree_TableScript_Top500.Size = new System.Drawing.Size(214, 24);
            this.cMenu_DBTree_TableScript_Top500.Text = "Select Top 500 Rows";
            this.cMenu_DBTree_TableScript_Top500.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
            // 
            // cMenu_DBTree_TableScript_DDL
            // 
            this.cMenu_DBTree_TableScript_DDL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_DBTree_TableScript_Select,
            this.cMenu_DBTree_TableScript_Insert,
            this.cMenu_DBTree_TableScript_Update,
            this.cMenu_DBTree_TableScript_Delete});
            this.cMenu_DBTree_TableScript_DDL.Name = "cMenu_DBTree_TableScript_DDL";
            this.cMenu_DBTree_TableScript_DDL.Size = new System.Drawing.Size(214, 24);
            this.cMenu_DBTree_TableScript_DDL.Text = "Script Table as";
            // 
            // cMenu_DBTree_TableScript_Select
            // 
            this.cMenu_DBTree_TableScript_Select.Name = "cMenu_DBTree_TableScript_Select";
            this.cMenu_DBTree_TableScript_Select.Size = new System.Drawing.Size(146, 26);
            this.cMenu_DBTree_TableScript_Select.Text = "SELECT";
            this.cMenu_DBTree_TableScript_Select.Click += new System.EventHandler(this.tsmiSelectClick);
            // 
            // cMenu_DBTree_TableScript_Insert
            // 
            this.cMenu_DBTree_TableScript_Insert.Name = "cMenu_DBTree_TableScript_Insert";
            this.cMenu_DBTree_TableScript_Insert.Size = new System.Drawing.Size(146, 26);
            this.cMenu_DBTree_TableScript_Insert.Text = "INSERT";
            this.cMenu_DBTree_TableScript_Insert.Click += new System.EventHandler(this.tsmiInsertClick);
            // 
            // cMenu_DBTree_TableScript_Update
            // 
            this.cMenu_DBTree_TableScript_Update.Name = "cMenu_DBTree_TableScript_Update";
            this.cMenu_DBTree_TableScript_Update.Size = new System.Drawing.Size(146, 26);
            this.cMenu_DBTree_TableScript_Update.Text = "UPDATE";
            this.cMenu_DBTree_TableScript_Update.Click += new System.EventHandler(this.tsmiUpdateClick);
            // 
            // cMenu_DBTree_TableScript_Delete
            // 
            this.cMenu_DBTree_TableScript_Delete.Name = "cMenu_DBTree_TableScript_Delete";
            this.cMenu_DBTree_TableScript_Delete.Size = new System.Drawing.Size(146, 26);
            this.cMenu_DBTree_TableScript_Delete.Text = "DELETE";
            this.cMenu_DBTree_TableScript_Delete.Click += new System.EventHandler(this.tsmiDeleteClick);
            // 
            // tmrTimeOut_TableData
            // 
            this.tmrTimeOut_TableData.Interval = 60000;
            this.tmrTimeOut_TableData.Tick += new System.EventHandler(this.tmrTimeOut_TableData_Tick);
            // 
            // cmenuDgrid_TableData_Actions
            // 
            this.cmenuDgrid_TableData_Actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmenuDgrid_TableData_Actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenuItemDeleteHighlightedRecords,
            this.cMenuItem_DeleteSelectedRecordOnly});
            this.cmenuDgrid_TableData_Actions.Name = "cmenuDgrid_TableData_Actions";
            this.cmenuDgrid_TableData_Actions.Size = new System.Drawing.Size(269, 52);
            // 
            // cMenuItemDeleteHighlightedRecords
            // 
            this.cMenuItemDeleteHighlightedRecords.Name = "cMenuItemDeleteHighlightedRecords";
            this.cMenuItemDeleteHighlightedRecords.Size = new System.Drawing.Size(268, 24);
            this.cMenuItemDeleteHighlightedRecords.Text = "Delete Highlighted Records";
            // 
            // cMenuItem_DeleteSelectedRecordOnly
            // 
            this.cMenuItem_DeleteSelectedRecordOnly.Name = "cMenuItem_DeleteSelectedRecordOnly";
            this.cMenuItem_DeleteSelectedRecordOnly.Size = new System.Drawing.Size(268, 24);
            this.cMenuItem_DeleteSelectedRecordOnly.Text = "Delete Selected Record Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 534);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DB Lookup";
            this.Load += new System.EventHandler(this.Form1Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Tlp_OpenConnection.ResumeLayout(false);
            this.Tlp_OpenConnection.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Tlp_Datagrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TableData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Search)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cMenu_DBTree_TableScriptActions.ResumeLayout(false);
            this.cmenuDgrid_TableData_Actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplyChangesToDB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker bgwConnectToDB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer tmrTableData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeDBtables;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.ContextMenuStrip cMenu_DBTree_TableScriptActions;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_Top500;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_DDL;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_Select;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_Insert;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_Update;
        private System.Windows.Forms.ToolStripMenuItem cMenu_DBTree_TableScript_Delete;
        private System.Windows.Forms.DataGridView dgrid_Search;
        private System.Windows.Forms.TableLayoutPanel Tlp_Datagrids;
        private System.Windows.Forms.DataGridView dgrid_TableData;
        private System.Windows.Forms.TableLayoutPanel Tlp_OpenConnection;
        private System.Windows.Forms.ComboBox cmbConnectString;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCollapseTree;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btnScriptTableData;
        private System.Windows.Forms.Button btnSaveChangesToProjectAndDB;
        private CheckBox chkTruncateFirst;
        private Button btnClearDataTableFilter;
        private Timer tmrTimeOut_TableData;
        private Button btnDeleteRecordsFromTableGrid;
        private ContextMenuStrip cmenuDgrid_TableData_Actions;
        private ToolStripMenuItem cMenuItemDeleteHighlightedRecords;
        private ToolStripMenuItem cMenuItem_DeleteSelectedRecordOnly;
    }
}

