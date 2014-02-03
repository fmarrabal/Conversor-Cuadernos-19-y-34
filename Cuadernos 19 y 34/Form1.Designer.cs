namespace Cuadernos_Alvores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ofd19 = new System.Windows.Forms.OpenFileDialog();
            this.ofd34 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRef19 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirCuaderno19A1914ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertirCuaderno34A3414ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRef34 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd19
            // 
            this.ofd19.FileName = "openFileDialog1";
            // 
            // ofd34
            // 
            this.ofd34.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Referencia cuaderno 19:";
            // 
            // txtRef19
            // 
            this.txtRef19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef19.Location = new System.Drawing.Point(163, 27);
            this.txtRef19.Name = "txtRef19";
            this.txtRef19.Size = new System.Drawing.Size(89, 13);
            this.txtRef19.TabIndex = 3;
            this.txtRef19.TextChanged += new System.EventHandler(this.txtRef19_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máximo 13 caracteres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de caracteres = 0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 225);
            this.panel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Desarrrollado por Francisco Manuel Arrabal Campos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "0.- En el caso de usar el cuaderno 19 añadir referencia con un máximo de 13 carac" +
    "teres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "3.- Guarde con el nombre deseado el archivo ya convertido.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "2.- Seleccione el archivo en el formato antiguo.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "1.- Presione el cuaderno a convertir: 19 a 19.14 o 34 a 34.14.";
           
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.convertirCuaderno19A1914ToolStripMenuItem,
            this.convertirCuaderno34A3414ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // convertirCuaderno19A1914ToolStripMenuItem
            // 
            this.convertirCuaderno19A1914ToolStripMenuItem.Name = "convertirCuaderno19A1914ToolStripMenuItem";
            this.convertirCuaderno19A1914ToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.convertirCuaderno19A1914ToolStripMenuItem.Text = "Convertir cuaderno 19 a 19.14";
            this.convertirCuaderno19A1914ToolStripMenuItem.Click += new System.EventHandler(this.convertirCuaderno19A1914ToolStripMenuItem_Click);
            // 
            // convertirCuaderno34A3414ToolStripMenuItem
            // 
            this.convertirCuaderno34A3414ToolStripMenuItem.Name = "convertirCuaderno34A3414ToolStripMenuItem";
            this.convertirCuaderno34A3414ToolStripMenuItem.Size = new System.Drawing.Size(175, 20);
            this.convertirCuaderno34A3414ToolStripMenuItem.Text = "Convertir cuaderno 34 a 34.14";
            this.convertirCuaderno34A3414ToolStripMenuItem.Click += new System.EventHandler(this.convertirCuaderno34A3414ToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Número de caracteres = 0";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Máximo 13 caracteres";
            this.label10.Visible = false;
            // 
            // txtRef34
            // 
            this.txtRef34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef34.Location = new System.Drawing.Point(163, 46);
            this.txtRef34.Name = "txtRef34";
            this.txtRef34.Size = new System.Drawing.Size(89, 13);
            this.txtRef34.TabIndex = 10;
            this.txtRef34.Visible = false;
            this.txtRef34.TextChanged += new System.EventHandler(this.txtRef34_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Detalle cargo cuaderno 34:";
            this.label11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 292);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRef34);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRef19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cuadernos Norma 19 y 34";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd19;
        private System.Windows.Forms.OpenFileDialog ofd34;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRef19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirCuaderno19A1914ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertirCuaderno34A3414ToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRef34;
        private System.Windows.Forms.Label label11;
    }
}

