namespace VagnerRealtor
{
    partial class VagnerRealtor
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Condominium", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Townhouse", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Single Family", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Unknown", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VagnerRealtor));
            this.lvwProperty = new System.Windows.Forms.ListView();
            this.colPropertyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYearBuilt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBedrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBathrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSaleStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarketValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuNewProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertBefore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertAfter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReviewProperties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.cmsProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwProperty
            // 
            this.lvwProperty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPropertyNumber,
            this.colCity,
            this.colStories,
            this.colYearBuilt,
            this.colBedrooms,
            this.colBathrooms,
            this.colCondition,
            this.colSaleStatus,
            this.colMarketValue});
            this.lvwProperty.FullRowSelect = true;
            this.lvwProperty.GridLines = true;
            listViewGroup1.Header = "Condominium";
            listViewGroup1.Name = "lvgcondominium";
            listViewGroup2.Header = "Townhouse";
            listViewGroup2.Name = "lvgTownhouse";
            listViewGroup3.Header = "Single Family";
            listViewGroup3.Name = "lvgSingleFamily";
            listViewGroup4.Header = "Unknown";
            listViewGroup4.Name = "lvgUnknown";
            this.lvwProperty.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.lvwProperty.Location = new System.Drawing.Point(13, 13);
            this.lvwProperty.Name = "lvwProperty";
            this.lvwProperty.Size = new System.Drawing.Size(663, 270);
            this.lvwProperty.TabIndex = 0;
            this.lvwProperty.UseCompatibleStateImageBehavior = false;
            this.lvwProperty.View = System.Windows.Forms.View.Details;
            this.lvwProperty.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lvwProperty_ItemMouseHover);
            this.lvwProperty.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwProperty_ItemSelectionChanged);
            this.lvwProperty.DoubleClick += new System.EventHandler(this.lvwProperty_DoubleClick);
            // 
            // colPropertyNumber
            // 
            this.colPropertyNumber.Text = "Property #";
            this.colPropertyNumber.Width = 85;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 100;
            // 
            // colStories
            // 
            this.colStories.Text = "Stories";
            this.colStories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colStories.Width = 45;
            // 
            // colYearBuilt
            // 
            this.colYearBuilt.Text = "Year Built";
            this.colYearBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colBedrooms
            // 
            this.colBedrooms.Text = "Beds";
            this.colBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBedrooms.Width = 38;
            // 
            // colBathrooms
            // 
            this.colBathrooms.Text = "Baths";
            this.colBathrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBathrooms.Width = 40;
            // 
            // colCondition
            // 
            this.colCondition.Text = "Condition";
            this.colCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCondition.Width = 120;
            // 
            // colSaleStatus
            // 
            this.colSaleStatus.Text = "Status";
            this.colSaleStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSaleStatus.Width = 70;
            // 
            // colMarketValue
            // 
            this.colMarketValue.Text = "Value";
            this.colMarketValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMarketValue.Width = 100;
            // 
            // pbxPicture
            // 
            this.pbxPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPicture.Location = new System.Drawing.Point(12, 289);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(664, 253);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicture.TabIndex = 1;
            this.pbxPicture.TabStop = false;
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Location = new System.Drawing.Point(13, 549);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(198, 44);
            this.btnNewProperty.TabIndex = 2;
            this.btnNewProperty.Text = "New Real State Property";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(477, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(198, 44);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsProperties
            // 
            this.cmsProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewProperty,
            this.mnuEditProperty,
            this.mnuInsertBefore,
            this.mnuInsertAfter,
            this.mnuDeleteProperty});
            this.cmsProperties.Name = "cmsProperties";
            this.cmsProperties.Size = new System.Drawing.Size(156, 114);
            // 
            // mnuNewProperty
            // 
            this.mnuNewProperty.Name = "mnuNewProperty";
            this.mnuNewProperty.Size = new System.Drawing.Size(155, 22);
            this.mnuNewProperty.Text = "New Property";
            this.mnuNewProperty.Click += new System.EventHandler(this.mnuNewProperty_Click);
            // 
            // mnuEditProperty
            // 
            this.mnuEditProperty.Enabled = false;
            this.mnuEditProperty.Name = "mnuEditProperty";
            this.mnuEditProperty.Size = new System.Drawing.Size(155, 22);
            this.mnuEditProperty.Text = "Edit Property";
            this.mnuEditProperty.Click += new System.EventHandler(this.mnuEditProperty_Click);
            // 
            // mnuInsertBefore
            // 
            this.mnuInsertBefore.Enabled = false;
            this.mnuInsertBefore.Name = "mnuInsertBefore";
            this.mnuInsertBefore.Size = new System.Drawing.Size(155, 22);
            this.mnuInsertBefore.Text = "Insert Property";
            // 
            // mnuInsertAfter
            // 
            this.mnuInsertAfter.Enabled = false;
            this.mnuInsertAfter.Name = "mnuInsertAfter";
            this.mnuInsertAfter.Size = new System.Drawing.Size(155, 22);
            this.mnuInsertAfter.Text = "Insert After";
            // 
            // mnuDeleteProperty
            // 
            this.mnuDeleteProperty.Enabled = false;
            this.mnuDeleteProperty.Name = "mnuDeleteProperty";
            this.mnuDeleteProperty.Size = new System.Drawing.Size(155, 22);
            this.mnuDeleteProperty.Text = "Delete Property";
            this.mnuDeleteProperty.Click += new System.EventHandler(this.mnuDeleteProperty_Click);
            // 
            // btnReviewProperties
            // 
            this.btnReviewProperties.Location = new System.Drawing.Point(245, 549);
            this.btnReviewProperties.Name = "btnReviewProperties";
            this.btnReviewProperties.Size = new System.Drawing.Size(198, 44);
            this.btnReviewProperties.TabIndex = 4;
            this.btnReviewProperties.Text = "Review Properties";
            this.btnReviewProperties.UseVisualStyleBackColor = true;
            this.btnReviewProperties.Click += new System.EventHandler(this.btnReviewProperties_Click);
            // 
            // VagnerRealtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 605);
            this.ContextMenuStrip = this.cmsProperties;
            this.Controls.Add(this.btnReviewProperties);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewProperty);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.lvwProperty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VagnerRealtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vagner Realtor Services";
            this.Load += new System.EventHandler(this.VagnerRealtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.cmsProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwProperty;
        private System.Windows.Forms.ColumnHeader colPropertyNumber;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colStories;
        private System.Windows.Forms.ColumnHeader colYearBuilt;
        private System.Windows.Forms.ColumnHeader colBedrooms;
        private System.Windows.Forms.ColumnHeader colBathrooms;
        private System.Windows.Forms.ColumnHeader colCondition;
        private System.Windows.Forms.ColumnHeader colSaleStatus;
        private System.Windows.Forms.ColumnHeader colMarketValue;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsProperties;
        private System.Windows.Forms.ToolStripMenuItem mnuNewProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuEditProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertBefore;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertAfter;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteProperty;
        private System.Windows.Forms.Button btnReviewProperties;
    }
}

