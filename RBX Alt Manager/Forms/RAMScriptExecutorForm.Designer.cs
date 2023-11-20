namespace RBX_Alt_Manager.Forms
{
    partial class RAMScriptExecutorForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExecuteScriptButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ScriptsListView = new BrightIdeasSoftware.ObjectListView();
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DescriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TagColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ScriptExecuteDelayCheckbox = new System.Windows.Forms.CheckBox();
            this.DelayExecuteNumeric = new System.Windows.Forms.NumericUpDown();
            this.SetPythonDLLButton = new System.Windows.Forms.Button();
            this.PythonDLLOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RefreshScriptsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayExecuteNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(204, 24);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "RAM Script Executor";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // ExecuteScriptButton
            // 
            this.ExecuteScriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteScriptButton.Location = new System.Drawing.Point(456, 359);
            this.ExecuteScriptButton.Name = "ExecuteScriptButton";
            this.ExecuteScriptButton.Size = new System.Drawing.Size(88, 27);
            this.ExecuteScriptButton.TabIndex = 1;
            this.ExecuteScriptButton.Text = "Execute";
            this.ExecuteScriptButton.UseVisualStyleBackColor = true;
            this.ExecuteScriptButton.Click += new System.EventHandler(this.ExecuteScriptButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 44);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(252, 15);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Controlling your Roblox accounts with scripts!";
            // 
            // ScriptsListView
            // 
            this.ScriptsListView.AllColumns.Add(this.NameColumn);
            this.ScriptsListView.AllColumns.Add(this.DescriptionColumn);
            this.ScriptsListView.AllColumns.Add(this.TagColumn);
            this.ScriptsListView.CellEditUseWholeCell = false;
            this.ScriptsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.DescriptionColumn,
            this.TagColumn});
            this.ScriptsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScriptsListView.HideSelection = false;
            this.ScriptsListView.Location = new System.Drawing.Point(16, 72);
            this.ScriptsListView.Name = "ScriptsListView";
            this.ScriptsListView.Size = new System.Drawing.Size(318, 314);
            this.ScriptsListView.TabIndex = 3;
            this.ScriptsListView.UseCompatibleStateImageBehavior = false;
            this.ScriptsListView.View = System.Windows.Forms.View.Details;
            this.ScriptsListView.SelectedIndexChanged += new System.EventHandler(this.ScriptsListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.AspectName = "NAME";
            this.NameColumn.Groupable = false;
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 79;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AspectName = "DESCRIPTION";
            this.DescriptionColumn.Groupable = false;
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 171;
            // 
            // TagColumn
            // 
            this.TagColumn.AspectName = "TAG";
            this.TagColumn.Text = "Tag";
            // 
            // ScriptExecuteDelayCheckbox
            // 
            this.ScriptExecuteDelayCheckbox.AutoSize = true;
            this.ScriptExecuteDelayCheckbox.Location = new System.Drawing.Point(356, 72);
            this.ScriptExecuteDelayCheckbox.Name = "ScriptExecuteDelayCheckbox";
            this.ScriptExecuteDelayCheckbox.Size = new System.Drawing.Size(95, 17);
            this.ScriptExecuteDelayCheckbox.TabIndex = 5;
            this.ScriptExecuteDelayCheckbox.Text = "Delay Execute";
            this.ScriptExecuteDelayCheckbox.UseVisualStyleBackColor = true;
            // 
            // DelayExecuteNumeric
            // 
            this.DelayExecuteNumeric.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.DelayExecuteNumeric.Location = new System.Drawing.Point(457, 72);
            this.DelayExecuteNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DelayExecuteNumeric.Name = "DelayExecuteNumeric";
            this.DelayExecuteNumeric.Size = new System.Drawing.Size(58, 20);
            this.DelayExecuteNumeric.TabIndex = 6;
            this.DelayExecuteNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DelayExecuteNumeric.ValueChanged += new System.EventHandler(this.DelayExecuteNumeric_ValueChanged);
            // 
            // SetPythonDLLButton
            // 
            this.SetPythonDLLButton.Location = new System.Drawing.Point(457, 319);
            this.SetPythonDLLButton.Name = "SetPythonDLLButton";
            this.SetPythonDLLButton.Size = new System.Drawing.Size(87, 34);
            this.SetPythonDLLButton.TabIndex = 8;
            this.SetPythonDLLButton.Text = "Set Python DLL Location";
            this.SetPythonDLLButton.UseVisualStyleBackColor = true;
            this.SetPythonDLLButton.Click += new System.EventHandler(this.SetPythonDLLButton_Click);
            // 
            // PythonDLLOpenFileDialog
            // 
            this.PythonDLLOpenFileDialog.DefaultExt = "dll";
            this.PythonDLLOpenFileDialog.FileName = "Python DLL";
            this.PythonDLLOpenFileDialog.Filter = "Python DLL (*.dll) |*.dll|All files (*)|*";
            this.PythonDLLOpenFileDialog.InitialDirectory = "C:\\";
            this.PythonDLLOpenFileDialog.Tag = "dll";
            this.PythonDLLOpenFileDialog.Title = "Set Python DLL location";
            // 
            // RefreshScriptsButton
            // 
            this.RefreshScriptsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshScriptsButton.Location = new System.Drawing.Point(356, 359);
            this.RefreshScriptsButton.Name = "RefreshScriptsButton";
            this.RefreshScriptsButton.Size = new System.Drawing.Size(88, 27);
            this.RefreshScriptsButton.TabIndex = 9;
            this.RefreshScriptsButton.Text = "Refresh";
            this.RefreshScriptsButton.UseVisualStyleBackColor = true;
            this.RefreshScriptsButton.Click += new System.EventHandler(this.RefreshScriptsButton_Click);
            // 
            // RAMScriptExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 400);
            this.Controls.Add(this.RefreshScriptsButton);
            this.Controls.Add(this.SetPythonDLLButton);
            this.Controls.Add(this.DelayExecuteNumeric);
            this.Controls.Add(this.ScriptExecuteDelayCheckbox);
            this.Controls.Add(this.ScriptsListView);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ExecuteScriptButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "RAMScriptExecutorForm";
            this.Text = "RAM Script Executor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RAMScriptExecutorForm_FormClosing);
            this.Load += new System.EventHandler(this.RAMScriptExecutorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayExecuteNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ExecuteScriptButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private BrightIdeasSoftware.ObjectListView ScriptsListView;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn DescriptionColumn;
        private System.Windows.Forms.CheckBox ScriptExecuteDelayCheckbox;
        private System.Windows.Forms.NumericUpDown DelayExecuteNumeric;
        private System.Windows.Forms.Button SetPythonDLLButton;
        private System.Windows.Forms.OpenFileDialog PythonDLLOpenFileDialog;
        private BrightIdeasSoftware.OLVColumn TagColumn;
        private System.Windows.Forms.Button RefreshScriptsButton;
    }
}