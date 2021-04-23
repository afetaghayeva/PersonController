
namespace WindowsForm.Forms
{
    partial class PersonsInfo
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
            this.gbxSidebar = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateSurname = new System.Windows.Forms.TextBox();
            this.lblUpdateSurname = new System.Windows.Forms.Label();
            this.tbxUpdateAge = new System.Windows.Forms.TextBox();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.gbxSave = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSaveSurname = new System.Windows.Forms.TextBox();
            this.lblSaveSurname = new System.Windows.Forms.Label();
            this.tbxSaveAge = new System.Windows.Forms.TextBox();
            this.lblSaveAge = new System.Windows.Forms.Label();
            this.tbxSaveName = new System.Windows.Forms.TextBox();
            this.lblSaveName = new System.Windows.Forms.Label();
            this.gbxNavbar = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.dgwPersons = new System.Windows.Forms.DataGridView();
            this.gbxSidebar.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxSave.SuspendLayout();
            this.gbxNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSidebar
            // 
            this.gbxSidebar.Controls.Add(this.gbxUpdate);
            this.gbxSidebar.Controls.Add(this.gbxSave);
            this.gbxSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxSidebar.Location = new System.Drawing.Point(0, 0);
            this.gbxSidebar.Name = "gbxSidebar";
            this.gbxSidebar.Size = new System.Drawing.Size(222, 533);
            this.gbxSidebar.TabIndex = 0;
            this.gbxSidebar.TabStop = false;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateSurname);
            this.gbxUpdate.Controls.Add(this.lblUpdateSurname);
            this.gbxUpdate.Controls.Add(this.tbxUpdateAge);
            this.gbxUpdate.Controls.Add(this.lblUpdateAge);
            this.gbxUpdate.Controls.Add(this.tbxUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateName);
            this.gbxUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxUpdate.Location = new System.Drawing.Point(3, 272);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(216, 258);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateSurname
            // 
            this.tbxUpdateSurname.Location = new System.Drawing.Point(104, 88);
            this.tbxUpdateSurname.Name = "tbxUpdateSurname";
            this.tbxUpdateSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateSurname.TabIndex = 16;
            // 
            // lblUpdateSurname
            // 
            this.lblUpdateSurname.AutoSize = true;
            this.lblUpdateSurname.Location = new System.Drawing.Point(13, 91);
            this.lblUpdateSurname.Name = "lblUpdateSurname";
            this.lblUpdateSurname.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateSurname.TabIndex = 15;
            this.lblUpdateSurname.Text = "Surname";
            // 
            // tbxUpdateAge
            // 
            this.tbxUpdateAge.Location = new System.Drawing.Point(104, 129);
            this.tbxUpdateAge.Name = "tbxUpdateAge";
            this.tbxUpdateAge.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateAge.TabIndex = 14;
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(13, 132);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(26, 13);
            this.lblUpdateAge.TabIndex = 13;
            this.lblUpdateAge.Text = "Age";
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(104, 47);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateName.TabIndex = 12;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(13, 50);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 11;
            this.lblUpdateName.Text = "Name";
            // 
            // gbxSave
            // 
            this.gbxSave.Controls.Add(this.btnSave);
            this.gbxSave.Controls.Add(this.tbxSaveSurname);
            this.gbxSave.Controls.Add(this.lblSaveSurname);
            this.gbxSave.Controls.Add(this.tbxSaveAge);
            this.gbxSave.Controls.Add(this.lblSaveAge);
            this.gbxSave.Controls.Add(this.tbxSaveName);
            this.gbxSave.Controls.Add(this.lblSaveName);
            this.gbxSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxSave.Location = new System.Drawing.Point(3, 16);
            this.gbxSave.Name = "gbxSave";
            this.gbxSave.Size = new System.Drawing.Size(216, 250);
            this.gbxSave.TabIndex = 0;
            this.gbxSave.TabStop = false;
            this.gbxSave.Text = "Save";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxSaveSurname
            // 
            this.tbxSaveSurname.Location = new System.Drawing.Point(100, 78);
            this.tbxSaveSurname.Name = "tbxSaveSurname";
            this.tbxSaveSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSaveSurname.TabIndex = 9;
            // 
            // lblSaveSurname
            // 
            this.lblSaveSurname.AutoSize = true;
            this.lblSaveSurname.Location = new System.Drawing.Point(9, 81);
            this.lblSaveSurname.Name = "lblSaveSurname";
            this.lblSaveSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSaveSurname.TabIndex = 8;
            this.lblSaveSurname.Text = "Surname";
            // 
            // tbxSaveAge
            // 
            this.tbxSaveAge.Location = new System.Drawing.Point(100, 119);
            this.tbxSaveAge.Name = "tbxSaveAge";
            this.tbxSaveAge.Size = new System.Drawing.Size(100, 20);
            this.tbxSaveAge.TabIndex = 7;
            // 
            // lblSaveAge
            // 
            this.lblSaveAge.AutoSize = true;
            this.lblSaveAge.Location = new System.Drawing.Point(9, 122);
            this.lblSaveAge.Name = "lblSaveAge";
            this.lblSaveAge.Size = new System.Drawing.Size(26, 13);
            this.lblSaveAge.TabIndex = 6;
            this.lblSaveAge.Text = "Age";
            // 
            // tbxSaveName
            // 
            this.tbxSaveName.Location = new System.Drawing.Point(100, 37);
            this.tbxSaveName.Name = "tbxSaveName";
            this.tbxSaveName.Size = new System.Drawing.Size(100, 20);
            this.tbxSaveName.TabIndex = 5;
            // 
            // lblSaveName
            // 
            this.lblSaveName.AutoSize = true;
            this.lblSaveName.Location = new System.Drawing.Point(9, 40);
            this.lblSaveName.Name = "lblSaveName";
            this.lblSaveName.Size = new System.Drawing.Size(35, 13);
            this.lblSaveName.TabIndex = 4;
            this.lblSaveName.Text = "Name";
            // 
            // gbxNavbar
            // 
            this.gbxNavbar.Controls.Add(this.btnDelete);
            this.gbxNavbar.Controls.Add(this.btnSearch);
            this.gbxNavbar.Controls.Add(this.tbxSearchByName);
            this.gbxNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxNavbar.Location = new System.Drawing.Point(222, 0);
            this.gbxNavbar.Name = "gbxNavbar";
            this.gbxNavbar.Size = new System.Drawing.Size(1001, 72);
            this.gbxNavbar.TabIndex = 2;
            this.gbxNavbar.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(902, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(786, 29);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(100, 20);
            this.tbxSearchByName.TabIndex = 0;
            // 
            // dgwPersons
            // 
            this.dgwPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwPersons.Location = new System.Drawing.Point(222, 72);
            this.dgwPersons.Name = "dgwPersons";
            this.dgwPersons.Size = new System.Drawing.Size(1001, 461);
            this.dgwPersons.TabIndex = 3;
            this.dgwPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersons_CellClick);
            // 
            // PersonsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 533);
            this.Controls.Add(this.dgwPersons);
            this.Controls.Add(this.gbxNavbar);
            this.Controls.Add(this.gbxSidebar);
            this.Name = "PersonsInfo";
            this.Text = "PersonsInfo";
            this.Load += new System.EventHandler(this.PersonsInfo_Load);
            this.gbxSidebar.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxSave.ResumeLayout(false);
            this.gbxSave.PerformLayout();
            this.gbxNavbar.ResumeLayout(false);
            this.gbxNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSidebar;
        private System.Windows.Forms.GroupBox gbxNavbar;
        private System.Windows.Forms.DataGridView dgwPersons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxSave;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateSurname;
        private System.Windows.Forms.Label lblUpdateSurname;
        private System.Windows.Forms.TextBox tbxUpdateAge;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSaveSurname;
        private System.Windows.Forms.Label lblSaveSurname;
        private System.Windows.Forms.TextBox tbxSaveAge;
        private System.Windows.Forms.Label lblSaveAge;
        private System.Windows.Forms.TextBox tbxSaveName;
        private System.Windows.Forms.Label lblSaveName;
    }
}