namespace AppFindPairs.Graphics
{
    partial class frmInicio
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
            panArriba = new Panel();
            panCielo = new Panel();
            label1 = new Label();
            btnJugar = new Button();
            btnIntruc = new Button();
            btnSalir = new Button();
            panAbajo = new Panel();
            panArriba.SuspendLayout();
            SuspendLayout();
            // 
            // panArriba
            // 
            panArriba.BackColor = SystemColors.ControlDarkDark;
            panArriba.Controls.Add(panCielo);
            panArriba.Controls.Add(label1);
            panArriba.Location = new Point(-4, 0);
            panArriba.Name = "panArriba";
            panArriba.Size = new Size(481, 86);
            panArriba.TabIndex = 0;
            // 
            // panCielo
            // 
            panCielo.BackColor = SystemColors.ButtonShadow;
            panCielo.Location = new Point(0, 0);
            panCielo.Name = "panCielo";
            panCielo.Size = new Size(481, 18);
            panCielo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(200, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // btnJugar
            // 
            btnJugar.FlatStyle = FlatStyle.Popup;
            btnJugar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.ForeColor = Color.WhiteSmoke;
            btnJugar.Location = new Point(157, 142);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(158, 56);
            btnJugar.TabIndex = 1;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnIntruc
            // 
            btnIntruc.FlatStyle = FlatStyle.Popup;
            btnIntruc.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntruc.ForeColor = Color.WhiteSmoke;
            btnIntruc.Location = new Point(157, 242);
            btnIntruc.Name = "btnIntruc";
            btnIntruc.Size = new Size(158, 56);
            btnIntruc.TabIndex = 2;
            btnIntruc.Text = "Instrucciones";
            btnIntruc.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.Location = new Point(157, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(158, 56);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panAbajo
            // 
            panAbajo.BackColor = SystemColors.ControlDarkDark;
            panAbajo.Location = new Point(-4, 442);
            panAbajo.Name = "panAbajo";
            panAbajo.Size = new Size(481, 46);
            panAbajo.TabIndex = 4;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(473, 482);
            Controls.Add(panAbajo);
            Controls.Add(btnSalir);
            Controls.Add(btnIntruc);
            Controls.Add(btnJugar);
            Controls.Add(panArriba);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmInicio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmInicio_Load;
            panArriba.ResumeLayout(false);
            panArriba.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panArriba;
        private Label label1;
        private Button btnJugar;
        private Button btnIntruc;
        private Button btnSalir;
        private Panel panAbajo;
        private Panel panCielo;
    }
}