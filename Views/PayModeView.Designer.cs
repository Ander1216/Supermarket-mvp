namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayModeList = new System.Windows.Forms.TabPage();
            this.tabPagePayModeDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPayModeId = new System.Windows.Forms.TextBox();
            this.TxtPayModeName = new System.Windows.Forms.TextBox();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePayModeList.SuspendLayout();
            this.tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePayModeList);
            this.tabControl1.Controls.Add(this.tabPagePayModeDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 364);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            this.tabPagePayModeList.Controls.Add(this.BtnClose);
            this.tabPagePayModeList.Controls.Add(this.BtnDelete);
            this.tabPagePayModeList.Controls.Add(this.BtnEdit);
            this.tabPagePayModeList.Controls.Add(this.BtnNew);
            this.tabPagePayModeList.Controls.Add(this.DgPayMode);
            this.tabPagePayModeList.Controls.Add(this.BtnSearch);
            this.tabPagePayModeList.Controls.Add(this.label2);
            this.tabPagePayModeList.Controls.Add(this.TxtSearch);
            this.tabPagePayModeList.Location = new System.Drawing.Point(4, 25);
            this.tabPagePayModeList.Name = "tabPagePayModeList";
            this.tabPagePayModeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayModeList.Size = new System.Drawing.Size(890, 335);
            this.tabPagePayModeList.TabIndex = 0;
            this.tabPagePayModeList.Text = "Pay Mode List";
            this.tabPagePayModeList.UseVisualStyleBackColor = true;
            this.tabPagePayModeList.Click += new System.EventHandler(this.tabPagePayModeList_Click);
            // 
            // tabPagePayModeDetail
            // 
            this.tabPagePayModeDetail.Controls.Add(this.BtnCancel);
            this.tabPagePayModeDetail.Controls.Add(this.BtnSave);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeObservation);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeName);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeId);
            this.tabPagePayModeDetail.Controls.Add(this.label5);
            this.tabPagePayModeDetail.Controls.Add(this.label4);
            this.tabPagePayModeDetail.Controls.Add(this.label3);
            this.tabPagePayModeDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            this.tabPagePayModeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayModeDetail.Size = new System.Drawing.Size(890, 335);
            this.tabPagePayModeDetail.TabIndex = 1;
            this.tabPagePayModeDetail.Text = "Pay Mode Detail";
            this.tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(22, 46);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(580, 21);
            this.TxtSearch.TabIndex = 1;
            // 
            // DgPayMode
            // 
            this.DgPayMode.AllowUserToAddRows = false;
            this.DgPayMode.AllowUserToDeleteRows = false;
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Location = new System.Drawing.Point(22, 82);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.ReadOnly = true;
            this.DgPayMode.Size = new System.Drawing.Size(653, 248);
            this.DgPayMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay Mode Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pay Mode Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pay Mode Observation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.Location = new System.Drawing.Point(36, 46);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.Size = new System.Drawing.Size(119, 21);
            this.TxtPayModeId.TabIndex = 3;
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.Location = new System.Drawing.Point(36, 97);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.Size = new System.Drawing.Size(345, 21);
            this.TxtPayModeName.TabIndex = 4;
            this.TxtPayModeName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.Location = new System.Drawing.Point(36, 150);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(346, 95);
            this.TxtPayModeObservation.TabIndex = 5;
            this.TxtPayModeObservation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(169, 260);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 54);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(696, 264);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(169, 54);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(696, 204);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(169, 54);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(696, 144);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(169, 54);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(696, 82);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(169, 54);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::Supermarket_mvp.Properties.Resources.buscar;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.Location = new System.Drawing.Point(608, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(67, 70);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(36, 260);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 54);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_mvp.Properties.Resources.buy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PayModeView
            // 
            this.ClientSize = new System.Drawing.Size(898, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PayModeView";
            this.Text = "Pay Mode Management";
            this.Load += new System.EventHandler(this.PayModeView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayModeList.ResumeLayout(false);
            this.tabPagePayModeList.PerformLayout();
            this.tabPagePayModeDetail.ResumeLayout(false);
            this.tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePayModeList;
        private System.Windows.Forms.TabPage tabPagePayModeDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgPayMode;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.TextBox TxtPayModeObservation;
        private System.Windows.Forms.TextBox TxtPayModeName;
        private System.Windows.Forms.TextBox TxtPayModeId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
    }
}