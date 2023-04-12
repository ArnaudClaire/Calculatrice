namespace Calculatrice
{
	partial class Calculatrice
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
			this.btPlus = new System.Windows.Forms.Button();
			this.btMoins = new System.Windows.Forms.Button();
			this.btFois = new System.Windows.Forms.Button();
			this.btDiviser = new System.Windows.Forms.Button();
			this.nmUD1 = new System.Windows.Forms.NumericUpDown();
			this.nmUD2 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbRslt = new System.Windows.Forms.Label();
			this.cbBType = new System.Windows.Forms.ComboBox();
			this.pctB = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nmUD1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmUD2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctB)).BeginInit();
			this.SuspendLayout();
			// 
			// btPlus
			// 
			this.btPlus.Location = new System.Drawing.Point(311, 137);
			this.btPlus.Name = "btPlus";
			this.btPlus.Size = new System.Drawing.Size(75, 23);
			this.btPlus.TabIndex = 0;
			this.btPlus.Text = "+";
			this.btPlus.UseVisualStyleBackColor = true;
			this.btPlus.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btMoins
			// 
			this.btMoins.Location = new System.Drawing.Point(311, 186);
			this.btMoins.Name = "btMoins";
			this.btMoins.Size = new System.Drawing.Size(75, 23);
			this.btMoins.TabIndex = 1;
			this.btMoins.Text = "-";
			this.btMoins.UseVisualStyleBackColor = true;
			this.btMoins.Click += new System.EventHandler(this.BtMoins_Click);
			// 
			// btFois
			// 
			this.btFois.Location = new System.Drawing.Point(311, 242);
			this.btFois.Name = "btFois";
			this.btFois.Size = new System.Drawing.Size(75, 23);
			this.btFois.TabIndex = 2;
			this.btFois.Text = "*";
			this.btFois.UseVisualStyleBackColor = true;
			this.btFois.Click += new System.EventHandler(this.BtFois_Click);
			// 
			// btDiviser
			// 
			this.btDiviser.Location = new System.Drawing.Point(311, 287);
			this.btDiviser.Name = "btDiviser";
			this.btDiviser.Size = new System.Drawing.Size(75, 23);
			this.btDiviser.TabIndex = 3;
			this.btDiviser.Text = "/";
			this.btDiviser.UseVisualStyleBackColor = true;
			this.btDiviser.Click += new System.EventHandler(this.BtDiviser_Click);
			// 
			// nmUD1
			// 
			this.nmUD1.Hexadecimal = true;
			this.nmUD1.Location = new System.Drawing.Point(161, 200);
			this.nmUD1.Name = "nmUD1";
			this.nmUD1.Size = new System.Drawing.Size(120, 22);
			this.nmUD1.TabIndex = 7;
			// 
			// nmUD2
			// 
			this.nmUD2.Hexadecimal = true;
			this.nmUD2.Location = new System.Drawing.Point(430, 200);
			this.nmUD2.Name = "nmUD2";
			this.nmUD2.Size = new System.Drawing.Size(120, 22);
			this.nmUD2.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(441, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Opérande2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Opérande1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "=";
			// 
			// lbRslt
			// 
			this.lbRslt.AutoSize = true;
			this.lbRslt.Location = new System.Drawing.Point(336, 45);
			this.lbRslt.Name = "lbRslt";
			this.lbRslt.Size = new System.Drawing.Size(14, 16);
			this.lbRslt.TabIndex = 12;
			this.lbRslt.Text = "0";
			// 
			// cbBType
			// 
			this.cbBType.FormattingEnabled = true;
			this.cbBType.Items.AddRange(new object[] {
            "Decimal",
            "Hexadecimal"});
			this.cbBType.Location = new System.Drawing.Point(38, 126);
			this.cbBType.Name = "cbBType";
			this.cbBType.Size = new System.Drawing.Size(121, 24);
			this.cbBType.TabIndex = 13;
			this.cbBType.SelectedIndexChanged += new System.EventHandler(this.CbBType_SelectedIndexChanged);
			// 
			// pctB
			// 
			this.pctB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pctB.Image = global::Calculatrice.Properties.Resources.logo_ynov_campus_montpellier;
			this.pctB.Location = new System.Drawing.Point(38, 31);
			this.pctB.Name = "pctB";
			this.pctB.Size = new System.Drawing.Size(160, 79);
			this.pctB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctB.TabIndex = 14;
			this.pctB.TabStop = false;
			// 
			// Calculatrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pctB);
			this.Controls.Add(this.cbBType);
			this.Controls.Add(this.lbRslt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nmUD2);
			this.Controls.Add(this.nmUD1);
			this.Controls.Add(this.btDiviser);
			this.Controls.Add(this.btFois);
			this.Controls.Add(this.btMoins);
			this.Controls.Add(this.btPlus);
			this.Name = "Calculatrice";
			this.Text = "Calculatrice";
			this.Load += new System.EventHandler(this.Calculatrice_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmUD1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmUD2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btPlus;
		private System.Windows.Forms.Button btMoins;
		private System.Windows.Forms.Button btFois;
		private System.Windows.Forms.Button btDiviser;
		private System.Windows.Forms.NumericUpDown nmUD1;
		private System.Windows.Forms.NumericUpDown nmUD2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbRslt;
		private System.Windows.Forms.ComboBox cbBType;
		private System.Windows.Forms.PictureBox pctB;
	}
}

