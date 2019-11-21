namespace AppEjerciciosBucles
{
    partial class frmBuclesFor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstNumeros = new System.Windows.Forms.ListBox();
            this.btnLlenarList = new System.Windows.Forms.Button();
            this.btnOrdenarList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // LstNumeros
            // 
            this.LstNumeros.FormattingEnabled = true;
            this.LstNumeros.Location = new System.Drawing.Point(64, 80);
            this.LstNumeros.Name = "LstNumeros";
            this.LstNumeros.Size = new System.Drawing.Size(319, 121);
            this.LstNumeros.TabIndex = 4;
            // 
            // btnLlenarList
            // 
            this.btnLlenarList.Location = new System.Drawing.Point(64, 36);
            this.btnLlenarList.Name = "btnLlenarList";
            this.btnLlenarList.Size = new System.Drawing.Size(131, 22);
            this.btnLlenarList.TabIndex = 5;
            this.btnLlenarList.Text = "LLenar lista de números";
            this.btnLlenarList.UseVisualStyleBackColor = true;
            this.btnLlenarList.Click += new System.EventHandler(this.btnLlenarList_Click);
            // 
            // btnOrdenarList
            // 
            this.btnOrdenarList.Location = new System.Drawing.Point(238, 36);
            this.btnOrdenarList.Name = "btnOrdenarList";
            this.btnOrdenarList.Size = new System.Drawing.Size(145, 22);
            this.btnOrdenarList.TabIndex = 6;
            this.btnOrdenarList.Text = "Ordenar lista";
            this.btnOrdenarList.UseVisualStyleBackColor = true;
            this.btnOrdenarList.Click += new System.EventHandler(this.btnOrdenarList_Click);
            // 
            // frmBuclesFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenarList);
            this.Controls.Add(this.btnLlenarList);
            this.Controls.Add(this.LstNumeros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBuclesFor";
            this.Text = "frmBuclesFor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstNumeros;
        private System.Windows.Forms.Button btnLlenarList;
        private System.Windows.Forms.Button btnOrdenarList;
    }
}