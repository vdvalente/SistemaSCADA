namespace SystemSCADA.Vista
{
    partial class SeleccionDeAreaDeTrabajo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionDeAreaDeTrabajo));
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLabComp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalones = new System.Windows.Forms.Label();
            this.btnSalon = new System.Windows.Forms.Button();
            this.btnLabElectronica = new System.Windows.Forms.Button();
            this.btnLabComputacion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Honeydew;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 1385;
            this.lineShape1.Y1 = 117;
            this.lineShape1.Y2 = 117;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1370, 749);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(2, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1279, 23);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Seleccione El Area que desea inspeccionar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabComp
            // 
            this.lblLabComp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabComp.Location = new System.Drawing.Point(23, 318);
            this.lblLabComp.Name = "lblLabComp";
            this.lblLabComp.Size = new System.Drawing.Size(287, 23);
            this.lblLabComp.TabIndex = 8;
            this.lblLabComp.Text = "Laboratorio de Computación";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Laboratorio de Electronica";
            // 
            // lblSalones
            // 
            this.lblSalones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalones.Location = new System.Drawing.Point(950, 307);
            this.lblSalones.Name = "lblSalones";
            this.lblSalones.Size = new System.Drawing.Size(262, 23);
            this.lblSalones.TabIndex = 12;
            this.lblSalones.Text = "Salones de clase";
            // 
            // btnSalon
            // 
            this.btnSalon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalon.Image = global::SystemSCADA.Properties.Resources.salon;
            this.btnSalon.Location = new System.Drawing.Point(954, 155);
            this.btnSalon.Name = "btnSalon";
            this.btnSalon.Size = new System.Drawing.Size(278, 147);
            this.btnSalon.TabIndex = 11;
            this.btnSalon.UseVisualStyleBackColor = true;
            this.btnSalon.Click += new System.EventHandler(this.BtnSalon_Click);
            // 
            // btnLabElectronica
            // 
            this.btnLabElectronica.FlatAppearance.BorderSize = 0;
            this.btnLabElectronica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabElectronica.Image = global::SystemSCADA.Properties.Resources.Electronica;
            this.btnLabElectronica.Location = new System.Drawing.Point(478, 168);
            this.btnLabElectronica.Name = "btnLabElectronica";
            this.btnLabElectronica.Size = new System.Drawing.Size(280, 145);
            this.btnLabElectronica.TabIndex = 9;
            this.btnLabElectronica.UseVisualStyleBackColor = true;
            this.btnLabElectronica.Click += new System.EventHandler(this.BtnLabElectronica_Click);
            // 
            // btnLabComputacion
            // 
            this.btnLabComputacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLabComputacion.FlatAppearance.BorderSize = 0;
            this.btnLabComputacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabComputacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLabComputacion.Image")));
            this.btnLabComputacion.Location = new System.Drawing.Point(38, 170);
            this.btnLabComputacion.Name = "btnLabComputacion";
            this.btnLabComputacion.Size = new System.Drawing.Size(256, 136);
            this.btnLabComputacion.TabIndex = 7;
            this.btnLabComputacion.UseVisualStyleBackColor = true;
            this.btnLabComputacion.Click += new System.EventHandler(this.BtnLabComputacion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SystemSCADA.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1320, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 37);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::SystemSCADA.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1288, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 37);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // SeleccionDeAreaDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblSalones);
            this.Controls.Add(this.btnSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLabElectronica);
            this.Controls.Add(this.lblLabComp);
            this.Controls.Add(this.btnLabComputacion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionDeAreaDeTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionDeAreaDeTrabajo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLabComputacion;
        private System.Windows.Forms.Label lblLabComp;
        private System.Windows.Forms.Button btnLabElectronica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalon;
        private System.Windows.Forms.Label lblSalones;
    }
}