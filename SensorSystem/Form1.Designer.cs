
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.lblSensorType.Size = new System.Drawing.Size(89, 17);
            this.lblSensorType.TabIndex = 1;
            this.lblSensorType.Text = "Sensor Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(260, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 38);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 243);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSave;
    }
}

