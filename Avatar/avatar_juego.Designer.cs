namespace Avatar
{
    partial class avatar_juego
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblNameAvatar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.LightSalmon;
            this.pbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(100, 133);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // lblNameAvatar
            // 
            this.lblNameAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameAvatar.BackColor = System.Drawing.Color.MistyRose;
            this.lblNameAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAvatar.Location = new System.Drawing.Point(-1, 107);
            this.lblNameAvatar.Name = "lblNameAvatar";
            this.lblNameAvatar.Size = new System.Drawing.Size(102, 20);
            this.lblNameAvatar.TabIndex = 1;
            this.lblNameAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar_juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNameAvatar);
            this.Controls.Add(this.pbAvatar);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(100, 131);
            this.Name = "avatar_juego";
            this.Size = new System.Drawing.Size(100, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblNameAvatar;
    }
}
