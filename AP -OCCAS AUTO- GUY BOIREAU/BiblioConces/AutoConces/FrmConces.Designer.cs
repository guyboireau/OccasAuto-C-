
namespace AutoConces
{
    partial class FrmConces
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConces));
            this.listView1 = new System.Windows.Forms.ListView();
            this.idConces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblcri = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtaff = new System.Windows.Forms.TextBox();
            this.btnenvoyer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtville = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtpren = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblpren = new System.Windows.Forms.Label();
            this.lbladresse = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.lblville = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btsuppr = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblnouvcons = new System.Windows.Forms.Label();
            this.lblsuppr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnafct = new System.Windows.Forms.Button();
            this.pnlInsert = new System.Windows.Forms.Panel();
            this.pnlSuppr = new System.Windows.Forms.Panel();
            this.pnlAff = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInsert.SuspendLayout();
            this.pnlSuppr.SuspendLayout();
            this.pnlAff.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idConces,
            this.nom,
            this.prenom,
            this.Adresse,
            this.CodePostal,
            this.Ville});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idConces
            // 
            this.idConces.Tag = "";
            this.idConces.Text = "Id";
            this.idConces.Width = 77;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 85;
            // 
            // prenom
            // 
            this.prenom.Text = "Prenom";
            this.prenom.Width = 95;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 106;
            // 
            // CodePostal
            // 
            this.CodePostal.Text = "Code Postal";
            this.CodePostal.Width = 93;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 315;
            // 
            // lblcri
            // 
            this.lblcri.AutoSize = true;
            this.lblcri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcri.Location = new System.Drawing.Point(9, 19);
            this.lblcri.Name = "lblcri";
            this.lblcri.Size = new System.Drawing.Size(135, 13);
            this.lblcri.TabIndex = 1;
            this.lblcri.Text = "Critères de sélection : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ville",
            "Nom",
            "Code Postal"});
            this.comboBox1.Location = new System.Drawing.Point(150, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.UseWaitCursor = true;
            // 
            // txtaff
            // 
            this.txtaff.Location = new System.Drawing.Point(310, 16);
            this.txtaff.Name = "txtaff";
            this.txtaff.Size = new System.Drawing.Size(187, 20);
            this.txtaff.TabIndex = 3;
            // 
            // btnenvoyer
            // 
            this.btnenvoyer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnenvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenvoyer.Location = new System.Drawing.Point(527, 14);
            this.btnenvoyer.Name = "btnenvoyer";
            this.btnenvoyer.Size = new System.Drawing.Size(117, 39);
            this.btnenvoyer.TabIndex = 4;
            this.btnenvoyer.Text = "Envoyer";
            this.btnenvoyer.UseVisualStyleBackColor = false;
            this.btnenvoyer.Click += new System.EventHandler(this.btnenvoyer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1340, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            this.affichageToolStripMenuItem.Click += new System.EventHandler(this.affichageToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.insertToolStripMenuItem.Text = "Insertion";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(149, 145);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(187, 20);
            this.txtville.TabIndex = 5;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(149, 119);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(187, 20);
            this.txtcp.TabIndex = 4;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(149, 93);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(187, 20);
            this.txtadresse.TabIndex = 3;
            // 
            // txtpren
            // 
            this.txtpren.Location = new System.Drawing.Point(149, 67);
            this.txtpren.Name = "txtpren";
            this.txtpren.Size = new System.Drawing.Size(187, 20);
            this.txtpren.TabIndex = 2;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(149, 41);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(187, 20);
            this.txtnom.TabIndex = 1;
            // 
            // lblpren
            // 
            this.lblpren.AutoSize = true;
            this.lblpren.Location = new System.Drawing.Point(31, 70);
            this.lblpren.Name = "lblpren";
            this.lblpren.Size = new System.Drawing.Size(52, 13);
            this.lblpren.TabIndex = 11;
            this.lblpren.Text = "Prénom : ";
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Location = new System.Drawing.Point(31, 96);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(51, 13);
            this.lbladresse.TabIndex = 12;
            this.lbladresse.Text = "Adresse :";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(31, 119);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(73, 13);
            this.lblcp.TabIndex = 13;
            this.lblcp.Text = "Code Postal : ";
            // 
            // lblville
            // 
            this.lblville.AutoSize = true;
            this.lblville.Location = new System.Drawing.Point(31, 148);
            this.lblville.Name = "lblville";
            this.lblville.Size = new System.Drawing.Size(35, 13);
            this.lblville.TabIndex = 14;
            this.lblville.Text = "Ville : ";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(32, 44);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(38, 13);
            this.lblnom.TabIndex = 15;
            this.lblnom.Text = "Nom : ";
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Blue;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(179, 199);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(117, 37);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Envoyer";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btsuppr
            // 
            this.btsuppr.BackColor = System.Drawing.Color.Red;
            this.btsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsuppr.Location = new System.Drawing.Point(113, 146);
            this.btsuppr.Name = "btsuppr";
            this.btsuppr.Size = new System.Drawing.Size(117, 37);
            this.btsuppr.TabIndex = 19;
            this.btsuppr.Text = "Supprimer";
            this.btsuppr.UseVisualStyleBackColor = false;
            this.btsuppr.Click += new System.EventHandler(this.btsuppr_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(84, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 91);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id : ";
            // 
            // lblnouvcons
            // 
            this.lblnouvcons.AutoSize = true;
            this.lblnouvcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnouvcons.Location = new System.Drawing.Point(78, 11);
            this.lblnouvcons.Name = "lblnouvcons";
            this.lblnouvcons.Size = new System.Drawing.Size(218, 18);
            this.lblnouvcons.TabIndex = 20;
            this.lblnouvcons.Text = "Nouveau concessionnaire : ";
            // 
            // lblsuppr
            // 
            this.lblsuppr.AutoSize = true;
            this.lblsuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuppr.Location = new System.Drawing.Point(11, 14);
            this.lblsuppr.Name = "lblsuppr";
            this.lblsuppr.Size = new System.Drawing.Size(282, 18);
            this.lblsuppr.TabIndex = 21;
            this.lblsuppr.Text = "Suppression d\'un concessionnaire : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoConces.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(685, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnafct
            // 
            this.btnafct.BackColor = System.Drawing.Color.White;
            this.btnafct.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafct.Location = new System.Drawing.Point(189, 514);
            this.btnafct.Name = "btnafct";
            this.btnafct.Size = new System.Drawing.Size(268, 43);
            this.btnafct.TabIndex = 23;
            this.btnafct.Text = "Afficher tout";
            this.btnafct.UseVisualStyleBackColor = false;
            this.btnafct.Click += new System.EventHandler(this.btnafct_Click);
            // 
            // pnlInsert
            // 
            this.pnlInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlInsert.Controls.Add(this.txtcp);
            this.pnlInsert.Controls.Add(this.txtville);
            this.pnlInsert.Controls.Add(this.txtadresse);
            this.pnlInsert.Controls.Add(this.txtpren);
            this.pnlInsert.Controls.Add(this.lblnouvcons);
            this.pnlInsert.Controls.Add(this.txtnom);
            this.pnlInsert.Controls.Add(this.lblpren);
            this.pnlInsert.Controls.Add(this.lbladresse);
            this.pnlInsert.Controls.Add(this.lblcp);
            this.pnlInsert.Controls.Add(this.btninsert);
            this.pnlInsert.Controls.Add(this.lblville);
            this.pnlInsert.Controls.Add(this.lblnom);
            this.pnlInsert.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnlInsert.Location = new System.Drawing.Point(669, 254);
            this.pnlInsert.Name = "pnlInsert";
            this.pnlInsert.Size = new System.Drawing.Size(364, 293);
            this.pnlInsert.TabIndex = 24;
            // 
            // pnlSuppr
            // 
            this.pnlSuppr.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSuppr.Controls.Add(this.btsuppr);
            this.pnlSuppr.Controls.Add(this.txtId);
            this.pnlSuppr.Controls.Add(this.lblId);
            this.pnlSuppr.Controls.Add(this.lblsuppr);
            this.pnlSuppr.Location = new System.Drawing.Point(1026, 36);
            this.pnlSuppr.Name = "pnlSuppr";
            this.pnlSuppr.Size = new System.Drawing.Size(314, 212);
            this.pnlSuppr.TabIndex = 25;
            // 
            // pnlAff
            // 
            this.pnlAff.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlAff.Controls.Add(this.btnenvoyer);
            this.pnlAff.Controls.Add(this.lblcri);
            this.pnlAff.Controls.Add(this.comboBox1);
            this.pnlAff.Controls.Add(this.txtaff);
            this.pnlAff.Location = new System.Drawing.Point(12, 27);
            this.pnlAff.Name = "pnlAff";
            this.pnlAff.Size = new System.Drawing.Size(667, 84);
            this.pnlAff.TabIndex = 26;
            // 
            // FrmConces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1340, 569);
            this.Controls.Add(this.pnlAff);
            this.Controls.Add(this.pnlSuppr);
            this.Controls.Add(this.pnlInsert);
            this.Controls.Add(this.btnafct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmConces";
            this.Text = "ConcessAuto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInsert.ResumeLayout(false);
            this.pnlInsert.PerformLayout();
            this.pnlSuppr.ResumeLayout(false);
            this.pnlSuppr.PerformLayout();
            this.pnlAff.ResumeLayout(false);
            this.pnlAff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idConces;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader CodePostal;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.Label lblcri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtaff;
        private System.Windows.Forms.Button btnenvoyer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtpren;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lblpren;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.Label lblville;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btsuppr;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblnouvcons;
        private System.Windows.Forms.Label lblsuppr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnafct;
        private System.Windows.Forms.Panel pnlInsert;
        private System.Windows.Forms.Panel pnlSuppr;
        private System.Windows.Forms.Panel pnlAff;
    }
}

