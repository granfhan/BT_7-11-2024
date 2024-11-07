namespace BT_7_11_2024
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
            this.SimThe = new System.Windows.Forms.DataGridView();
            this.ThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SimThe)).BeginInit();
            this.SuspendLayout();
            // 
            // SimThe
            // 
            this.SimThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimThe.Location = new System.Drawing.Point(12, 13);
            this.SimThe.Name = "SimThe";
            this.SimThe.RowHeadersWidth = 51;
            this.SimThe.RowTemplate.Height = 24;
            this.SimThe.Size = new System.Drawing.Size(776, 209);
            this.SimThe.TabIndex = 0;
            this.SimThe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SimThe_CellContentClick);
            // 
            // ThongKe
            // 
            this.ThongKe.Location = new System.Drawing.Point(313, 250);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(141, 23);
            this.ThongKe.TabIndex = 1;
            this.ThongKe.Text = "Thống Kê";
            this.ThongKe.UseVisualStyleBackColor = true;
            this.ThongKe.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThongKe);
            this.Controls.Add(this.SimThe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SimThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SimThe;
        private System.Windows.Forms.Button ThongKe;
    }
}

