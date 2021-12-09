
namespace duiTask_6
{
    partial class fZad2
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
            this.tbN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labArr = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов";
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(391, 90);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 56);
            this.tbN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(301, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labArr
            // 
            this.labArr.AutoSize = true;
            this.labArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labArr.Location = new System.Drawing.Point(43, 345);
            this.labArr.Name = "labArr";
            this.labArr.Size = new System.Drawing.Size(76, 20);
            this.labArr.TabIndex = 3;
            this.labArr.Text = "Массив:";
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMax.Location = new System.Drawing.Point(43, 454);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(192, 20);
            this.labMax.TabIndex = 4;
            this.labMax.Text = "Максимальное число:";
            // 
            // fZad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 580);
            this.Controls.Add(this.labMax);
            this.Controls.Add(this.labArr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label1);
            this.Name = "fZad2";
            this.Text = "fZad2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labArr;
        private System.Windows.Forms.Label labMax;
    }
}