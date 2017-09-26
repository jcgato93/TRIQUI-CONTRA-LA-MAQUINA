namespace TRIQUI_CONTRA_LA_MAQUINA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.maquina = new System.Windows.Forms.RadioButton();
            this.amigo = new System.Windows.Forms.RadioButton();
            this.ingresar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maquina
            // 
            this.maquina.AutoSize = true;
            this.maquina.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.maquina.Location = new System.Drawing.Point(104, 97);
            this.maquina.Name = "maquina";
            this.maquina.Size = new System.Drawing.Size(106, 23);
            this.maquina.TabIndex = 1;
            this.maquina.TabStop = true;
            this.maquina.Text = "MAQUINA";
            this.maquina.UseVisualStyleBackColor = true;
            // 
            // amigo
            // 
            this.amigo.AutoSize = true;
            this.amigo.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.amigo.Location = new System.Drawing.Point(104, 149);
            this.amigo.Name = "amigo";
            this.amigo.Size = new System.Drawing.Size(112, 23);
            this.amigo.TabIndex = 2;
            this.amigo.TabStop = true;
            this.amigo.Text = "UN AMIGO";
            this.amigo.UseVisualStyleBackColor = true;
            // 
            // ingresar2
            // 
            this.ingresar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold);
            this.ingresar2.Location = new System.Drawing.Point(104, 210);
            this.ingresar2.Name = "ingresar2";
            this.ingresar2.Size = new System.Drawing.Size(112, 35);
            this.ingresar2.TabIndex = 3;
            this.ingresar2.Text = "INGRESAR";
            this.ingresar2.UseVisualStyleBackColor = true;
            this.ingresar2.Click += new System.EventHandler(this.ingresar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ELIJA UN OPONENTE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingresar2);
            this.Controls.Add(this.amigo);
            this.Controls.Add(this.maquina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 327);
            this.MinimumSize = new System.Drawing.Size(361, 327);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TRIQUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton maquina;
        private System.Windows.Forms.RadioButton amigo;
        private System.Windows.Forms.Button ingresar2;
        private System.Windows.Forms.Label label1;
    }
}