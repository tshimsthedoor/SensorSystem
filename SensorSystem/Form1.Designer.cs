
namespace SensorSystem
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
            this.lblSensorName = new System.Windows.Forms.Label();
            this.lblSensorType = new System.Windows.Forms.Label();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.txtSensorType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Location = new System.Drawing.Point(15, 25);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(98, 17);
            this.lblSensorName.TabIndex = 0;
            this.lblSensorName.Text = "Sensor Name:";
            // 
            // lblSensorType
            // 
            this.lblSensorType.AutoSize = true;
            this.lblSensorType.Location = new System.Drawing.Point(15, 100);
            this.lblSensorType.Name = "lblSensorType";
            this.lblSensorType.Size = new System.Drawing.Size(93, 17);
            this.lblSensorType.TabIndex = 1;
            this.lblSensorType.Text = "Sensor Type:";
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(18, 58);
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(356, 22);
            this.txtSensorName.TabIndex = 2;
            // 
            // txtSensorType
            // 
            this.txtSensorType.Location = new System.Drawing.Point(18, 134);
            this.txtSensorType.Name = "txtSensorType";
            this.txtSensorType.Size = new System.Drawing.Size(356, 22);
            this.txtSensorType.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 243);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSensorType);
            this.Controls.Add(this.txtSensorName);
            this.Controls.Add(this.lblSensorType);
            this.Controls.Add(this.lblSensorName);
            this.Name = "Form1";
            this.Text = "Sensor App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSensorName;
        private System.Windows.Forms.Label lblSensorType;
        private System.Windows.Forms.TextBox txtSensorName;
        private System.Windows.Forms.TextBox txtSensorType;
        private System.Windows.Forms.Button btnSave;
    }
}

