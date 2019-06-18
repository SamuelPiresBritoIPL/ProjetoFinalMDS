﻿namespace ProjetoFinal
{
    partial class VendasCarrosGestao
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
            this.groupBoxInformacaoCarro = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxExtras = new System.Windows.Forms.TextBox();
            this.textBoxCombustivel = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelExtras = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelNumeroChassis = new System.Windows.Forms.Label();
            this.textBoxNumeroChassis = new System.Windows.Forms.TextBox();
            this.groupBoxInformacaoCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacaoCarro
            // 
            this.groupBoxInformacaoCarro.Controls.Add(this.buttonEliminar);
            this.groupBoxInformacaoCarro.Controls.Add(this.buttonEditar);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxExtras);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxCombustivel);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxModelo);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxMarca);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelExtras);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelCombustivel);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelModelo);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelMarca);
            this.groupBoxInformacaoCarro.Controls.Add(this.labelNumeroChassis);
            this.groupBoxInformacaoCarro.Controls.Add(this.textBoxNumeroChassis);
            this.groupBoxInformacaoCarro.Location = new System.Drawing.Point(7, 10);
            this.groupBoxInformacaoCarro.Name = "groupBoxInformacaoCarro";
            this.groupBoxInformacaoCarro.Size = new System.Drawing.Size(371, 227);
            this.groupBoxInformacaoCarro.TabIndex = 2;
            this.groupBoxInformacaoCarro.TabStop = false;
            this.groupBoxInformacaoCarro.Text = "Informação do Carro de Venda";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(268, 184);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(3, 184);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 40);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxExtras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxExtras.Location = new System.Drawing.Point(113, 147);
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.Size = new System.Drawing.Size(235, 20);
            this.textBoxExtras.TabIndex = 4;
            // 
            // textBoxCombustivel
            // 
            this.textBoxCombustivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCombustivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCombustivel.Location = new System.Drawing.Point(113, 119);
            this.textBoxCombustivel.Name = "textBoxCombustivel";
            this.textBoxCombustivel.Size = new System.Drawing.Size(235, 20);
            this.textBoxCombustivel.TabIndex = 3;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxModelo.Location = new System.Drawing.Point(113, 90);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(235, 20);
            this.textBoxModelo.TabIndex = 2;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMarca.Location = new System.Drawing.Point(113, 62);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(235, 20);
            this.textBoxMarca.TabIndex = 1;
            // 
            // labelExtras
            // 
            this.labelExtras.Location = new System.Drawing.Point(6, 146);
            this.labelExtras.Name = "labelExtras";
            this.labelExtras.Size = new System.Drawing.Size(101, 20);
            this.labelExtras.TabIndex = 11;
            this.labelExtras.Text = "Extras:";
            this.labelExtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.Location = new System.Drawing.Point(6, 118);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(101, 20);
            this.labelCombustivel.TabIndex = 10;
            this.labelCombustivel.Text = "Combustivel:";
            this.labelCombustivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModelo
            // 
            this.labelModelo.Location = new System.Drawing.Point(6, 90);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(101, 20);
            this.labelModelo.TabIndex = 9;
            this.labelModelo.Text = "Modelo:";
            this.labelModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMarca
            // 
            this.labelMarca.Location = new System.Drawing.Point(6, 62);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(101, 20);
            this.labelMarca.TabIndex = 8;
            this.labelMarca.Text = "Marca:";
            this.labelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumeroChassis
            // 
            this.labelNumeroChassis.Location = new System.Drawing.Point(6, 34);
            this.labelNumeroChassis.Name = "labelNumeroChassis";
            this.labelNumeroChassis.Size = new System.Drawing.Size(101, 20);
            this.labelNumeroChassis.TabIndex = 7;
            this.labelNumeroChassis.Text = "Número de Chassis:";
            this.labelNumeroChassis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNumeroChassis
            // 
            this.textBoxNumeroChassis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNumeroChassis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNumeroChassis.Location = new System.Drawing.Point(113, 35);
            this.textBoxNumeroChassis.Name = "textBoxNumeroChassis";
            this.textBoxNumeroChassis.Size = new System.Drawing.Size(235, 20);
            this.textBoxNumeroChassis.TabIndex = 0;
            // 
            // VendasCarrosGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 246);
            this.Controls.Add(this.groupBoxInformacaoCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VendasCarrosGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Carros de Venda";
            this.Load += new System.EventHandler(this.VendasCarrosGestao_Load);
            this.groupBoxInformacaoCarro.ResumeLayout(false);
            this.groupBoxInformacaoCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformacaoCarro;
        private System.Windows.Forms.TextBox textBoxExtras;
        private System.Windows.Forms.TextBox textBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelExtras;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelNumeroChassis;
        private System.Windows.Forms.TextBox textBoxNumeroChassis;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
    }
}