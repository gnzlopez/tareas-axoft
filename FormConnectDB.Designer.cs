namespace axoftTareas
{
    partial class FormConnectDB
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
            this.lblConnString = new System.Windows.Forms.Label();
            this.txtBoxConnString = new System.Windows.Forms.TextBox();
            this.btnAcceptConnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnString
            // 
            this.lblConnString.AutoSize = true;
            this.lblConnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnString.Location = new System.Drawing.Point(27, 9);
            this.lblConnString.Name = "lblConnString";
            this.lblConnString.Size = new System.Drawing.Size(204, 20);
            this.lblConnString.TabIndex = 7;
            this.lblConnString.Text = "Ingrese la connection string";
            // 
            // txtBoxConnString
            // 
            this.txtBoxConnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConnString.Location = new System.Drawing.Point(31, 46);
            this.txtBoxConnString.Name = "txtBoxConnString";
            this.txtBoxConnString.Size = new System.Drawing.Size(407, 26);
            this.txtBoxConnString.TabIndex = 6;
            // 
            // btnAcceptConnString
            // 
            this.btnAcceptConnString.Location = new System.Drawing.Point(327, 81);
            this.btnAcceptConnString.Name = "btnAcceptConnString";
            this.btnAcceptConnString.Size = new System.Drawing.Size(111, 39);
            this.btnAcceptConnString.TabIndex = 8;
            this.btnAcceptConnString.Text = "Aceptar";
            this.btnAcceptConnString.UseVisualStyleBackColor = true;
            this.btnAcceptConnString.Click += new System.EventHandler(this.btnAcceptConnString_Click);
            // 
            // FormConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 132);
            this.Controls.Add(this.btnAcceptConnString);
            this.Controls.Add(this.lblConnString);
            this.Controls.Add(this.txtBoxConnString);
            this.Name = "FormConnectDB";
            this.Text = "Conectar a la base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnString;
        private System.Windows.Forms.TextBox txtBoxConnString;
        private System.Windows.Forms.Button btnAcceptConnString;
    }
}