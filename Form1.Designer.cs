namespace _1._4_ArbolesBinarios
{
    partial class Form1
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
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.btnOrdenarPreOrden = new System.Windows.Forms.Button();
            this.btnOrdenarInOrden = new System.Windows.Forms.Button();
            this.btnOrdenarPosOrden = new System.Windows.Forms.Button();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.txtInfoNodo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.BackColor = System.Drawing.Color.White;
            this.btnAgregarNodo.Location = new System.Drawing.Point(18, 56);
            this.btnAgregarNodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarNodo.TabIndex = 0;
            this.btnAgregarNodo.Text = "Agregar";
            this.btnAgregarNodo.UseVisualStyleBackColor = false;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // btnOrdenarPreOrden
            // 
            this.btnOrdenarPreOrden.BackColor = System.Drawing.Color.White;
            this.btnOrdenarPreOrden.Location = new System.Drawing.Point(13, 173);
            this.btnOrdenarPreOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenarPreOrden.Name = "btnOrdenarPreOrden";
            this.btnOrdenarPreOrden.Size = new System.Drawing.Size(112, 35);
            this.btnOrdenarPreOrden.TabIndex = 1;
            this.btnOrdenarPreOrden.Text = "PreOrden";
            this.btnOrdenarPreOrden.UseVisualStyleBackColor = false;
            this.btnOrdenarPreOrden.Click += new System.EventHandler(this.btnOrdenarPreOrden_Click);
            // 
            // btnOrdenarInOrden
            // 
            this.btnOrdenarInOrden.BackColor = System.Drawing.Color.White;
            this.btnOrdenarInOrden.Location = new System.Drawing.Point(18, 218);
            this.btnOrdenarInOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenarInOrden.Name = "btnOrdenarInOrden";
            this.btnOrdenarInOrden.Size = new System.Drawing.Size(112, 35);
            this.btnOrdenarInOrden.TabIndex = 2;
            this.btnOrdenarInOrden.Text = "InOrden";
            this.btnOrdenarInOrden.UseVisualStyleBackColor = false;
            this.btnOrdenarInOrden.Click += new System.EventHandler(this.btnOrdenarInOrden_Click);
            // 
            // btnOrdenarPosOrden
            // 
            this.btnOrdenarPosOrden.BackColor = System.Drawing.Color.White;
            this.btnOrdenarPosOrden.Location = new System.Drawing.Point(18, 263);
            this.btnOrdenarPosOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenarPosOrden.Name = "btnOrdenarPosOrden";
            this.btnOrdenarPosOrden.Size = new System.Drawing.Size(112, 35);
            this.btnOrdenarPosOrden.TabIndex = 3;
            this.btnOrdenarPosOrden.Text = "PosOrden";
            this.btnOrdenarPosOrden.UseVisualStyleBackColor = false;
            this.btnOrdenarPosOrden.Click += new System.EventHandler(this.btnOrdenarPosOrden_Click);
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.BackColor = System.Drawing.Color.White;
            this.btnBuscarNodo.Location = new System.Drawing.Point(18, 101);
            this.btnBuscarNodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(112, 35);
            this.btnBuscarNodo.TabIndex = 4;
            this.btnBuscarNodo.Text = "Buscar";
            this.btnBuscarNodo.UseVisualStyleBackColor = false;
            this.btnBuscarNodo.Click += new System.EventHandler(this.btnBuscarNodo_Click);
            // 
            // txtInfoNodo
            // 
            this.txtInfoNodo.Location = new System.Drawing.Point(18, 14);
            this.txtInfoNodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfoNodo.Name = "txtInfoNodo";
            this.txtInfoNodo.Size = new System.Drawing.Size(112, 28);
            this.txtInfoNodo.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtResultado.Location = new System.Drawing.Point(138, 14);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(218, 300);
            this.txtResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::_1._4_ArbolesBinarios.Properties.Resources.fondo_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 338);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtInfoNodo);
            this.Controls.Add(this.btnBuscarNodo);
            this.Controls.Add(this.btnOrdenarPosOrden);
            this.Controls.Add(this.btnOrdenarInOrden);
            this.Controls.Add(this.btnOrdenarPreOrden);
            this.Controls.Add(this.btnAgregarNodo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Arboles Binarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.Button btnOrdenarPreOrden;
        private System.Windows.Forms.Button btnOrdenarInOrden;
        private System.Windows.Forms.Button btnOrdenarPosOrden;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.TextBox txtInfoNodo;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

