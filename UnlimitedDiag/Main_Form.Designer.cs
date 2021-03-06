﻿namespace UnlimitedDiag
{
    partial class Main_Form
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
            this.cmdDetectVehicle = new System.Windows.Forms.Button();
            this.cmdReadVoltage = new System.Windows.Forms.Button();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.cmdReadVin = new System.Windows.Forms.Button();
            this.txtReadVin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdDetectVehicle
            // 
            this.cmdDetectVehicle.Location = new System.Drawing.Point(13, 13);
            this.cmdDetectVehicle.Name = "cmdDetectVehicle";
            this.cmdDetectVehicle.Size = new System.Drawing.Size(154, 23);
            this.cmdDetectVehicle.TabIndex = 0;
            this.cmdDetectVehicle.Text = "Detect Vehicle";
            this.cmdDetectVehicle.UseVisualStyleBackColor = true;
            this.cmdDetectVehicle.Click += new System.EventHandler(this.CmdDetectVehicleClick);
            // 
            // cmdReadVoltage
            // 
            this.cmdReadVoltage.Location = new System.Drawing.Point(12, 246);
            this.cmdReadVoltage.Name = "cmdReadVoltage";
            this.cmdReadVoltage.Size = new System.Drawing.Size(155, 23);
            this.cmdReadVoltage.TabIndex = 2;
            this.cmdReadVoltage.Text = "Read Voltage";
            this.cmdReadVoltage.UseVisualStyleBackColor = true;
            this.cmdReadVoltage.Click += new System.EventHandler(this.CmdReadVoltageClick);
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(172, 248);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(429, 20);
            this.txtVoltage.TabIndex = 3;
            // 
            // cmdReadVin
            // 
            this.cmdReadVin.Location = new System.Drawing.Point(12, 275);
            this.cmdReadVin.Name = "cmdReadVin";
            this.cmdReadVin.Size = new System.Drawing.Size(155, 23);
            this.cmdReadVin.TabIndex = 4;
            this.cmdReadVin.Text = "Read VIN";
            this.cmdReadVin.UseVisualStyleBackColor = true;
            this.cmdReadVin.Click += new System.EventHandler(this.CmdReadVinClick);
            // 
            // txtReadVin
            // 
            this.txtReadVin.Location = new System.Drawing.Point(173, 277);
            this.txtReadVin.Name = "txtReadVin";
            this.txtReadVin.Size = new System.Drawing.Size(428, 20);
            this.txtReadVin.TabIndex = 5;
            // 
            // Root_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 422);
            this.Controls.Add(this.txtReadVin);
            this.Controls.Add(this.cmdReadVin);
            this.Controls.Add(this.txtVoltage);
            this.Controls.Add(this.cmdReadVoltage);
            this.Controls.Add(this.cmdDetectVehicle);
            this.Name = "Root_Form";
            this.Text = "J2534DotNet Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDetectVehicle;
        private System.Windows.Forms.Button cmdReadVoltage;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.Button cmdReadVin;
        private System.Windows.Forms.TextBox txtReadVin;
    }
}

