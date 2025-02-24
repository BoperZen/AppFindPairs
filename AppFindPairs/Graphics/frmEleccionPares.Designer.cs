namespace AppFindPairs.Graphics
{
    partial class frmEleccionPares
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
            panConfig = new Panel();
            cmbCantidad = new ComboBox();
            label1 = new Label();
            btnIniciar = new Button();
            panConfig.SuspendLayout();
            SuspendLayout();
            // 
            // panConfig
            // 
            panConfig.BackColor = SystemColors.ActiveBorder;
            panConfig.Controls.Add(cmbCantidad);
            panConfig.Controls.Add(label1);
            panConfig.Controls.Add(btnIniciar);
            panConfig.Location = new Point(12, 12);
            panConfig.Name = "panConfig";
            panConfig.Size = new Size(267, 349);
            panConfig.TabIndex = 0;
            // 
            // cmbCantidad
            // 
            cmbCantidad.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCantidad.ForeColor = Color.WhiteSmoke;
            cmbCantidad.FormattingEnabled = true;
            cmbCantidad.Location = new Point(40, 69);
            cmbCantidad.Name = "cmbCantidad";
            cmbCantidad.Size = new Size(189, 24);
            cmbCantidad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(226, 18);
            label1.TabIndex = 1;
            label1.Text = "Elija la cantidad de pares";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.AppWorkspace;
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.WhiteSmoke;
            btnIniciar.Location = new Point(101, 246);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 43);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // frmEleccionPares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 373);
            Controls.Add(panConfig);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmEleccionPares";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEleccionPares";
            FormClosed += frmEleccionPares_FormClosed;
            Load += frmEleccionPares_Load;
            panConfig.ResumeLayout(false);
            panConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panConfig;
        private Label label1;
        private Button btnIniciar;
        private ComboBox cmbCantidad;
    }
}