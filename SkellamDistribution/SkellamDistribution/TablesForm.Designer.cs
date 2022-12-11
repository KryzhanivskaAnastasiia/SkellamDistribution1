
namespace SkellamDistribution
{
    partial class TablesForm
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
            this.dataGridViewReverse = new System.Windows.Forms.DataGridView();
            this.dataGridViewNeumann = new System.Windows.Forms.DataGridView();
            this.dataGridViewMetropolis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeumann)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetropolis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReverse
            // 
            this.dataGridViewReverse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReverse.Location = new System.Drawing.Point(20, 40);
            this.dataGridViewReverse.Name = "dataGridViewReverse";
            this.dataGridViewReverse.Size = new System.Drawing.Size(240, 410);
            this.dataGridViewReverse.TabIndex = 0;
            // 
            // dataGridViewNeumann
            // 
            this.dataGridViewNeumann.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNeumann.Location = new System.Drawing.Point(280, 40);
            this.dataGridViewNeumann.Name = "dataGridViewNeumann";
            this.dataGridViewNeumann.Size = new System.Drawing.Size(240, 410);
            this.dataGridViewNeumann.TabIndex = 1;
            // 
            // dataGridViewMetropolis
            // 
            this.dataGridViewMetropolis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetropolis.Location = new System.Drawing.Point(540, 40);
            this.dataGridViewMetropolis.Name = "dataGridViewMetropolis";
            this.dataGridViewMetropolis.Size = new System.Drawing.Size(240, 410);
            this.dataGridViewMetropolis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 9);
            this.label1.TabIndex = 3;
            this.label1.Text = "Метод обратной функции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 9);
            this.label2.TabIndex = 4;
            this.label2.Text = "Метод Неймана";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 9);
            this.label3.TabIndex = 5;
            this.label3.Text = "Метод Метрополиса";
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMetropolis);
            this.Controls.Add(this.dataGridViewNeumann);
            this.Controls.Add(this.dataGridViewReverse);
            this.Name = "TablesForm";
            this.Text = "Таблицы";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNeumann)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetropolis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReverse;
        private System.Windows.Forms.DataGridView dataGridViewNeumann;
        private System.Windows.Forms.DataGridView dataGridViewMetropolis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}