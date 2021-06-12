
namespace LeagueManagerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewGracz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewPrzeciwnik = new System.Windows.Forms.DataGridView();
            this.dataGridViewDruzyny = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZarzadzanie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Rywalizuj = new System.Windows.Forms.Button();
            this.dataGridViewDruzyna1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzeciwnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruzyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruzyna1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGracz
            // 
            this.dataGridViewGracz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGracz.Location = new System.Drawing.Point(205, 75);
            this.dataGridViewGracz.Name = "dataGridViewGracz";
            this.dataGridViewGracz.RowHeadersWidth = 30;
            this.dataGridViewGracz.RowTemplate.Height = 25;
            this.dataGridViewGracz.Size = new System.Drawing.Size(319, 306);
            this.dataGridViewGracz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zawodnicy pierwszej drużyny";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewPrzeciwnik
            // 
            this.dataGridViewPrzeciwnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrzeciwnik.Location = new System.Drawing.Point(789, 75);
            this.dataGridViewPrzeciwnik.Name = "dataGridViewPrzeciwnik";
            this.dataGridViewPrzeciwnik.RowHeadersWidth = 30;
            this.dataGridViewPrzeciwnik.RowTemplate.Height = 25;
            this.dataGridViewPrzeciwnik.Size = new System.Drawing.Size(319, 306);
            this.dataGridViewPrzeciwnik.TabIndex = 3;
            // 
            // dataGridViewDruzyny
            // 
            this.dataGridViewDruzyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDruzyny.Location = new System.Drawing.Point(1109, 75);
            this.dataGridViewDruzyny.Name = "dataGridViewDruzyny";
            this.dataGridViewDruzyny.RowTemplate.Height = 25;
            this.dataGridViewDruzyny.Size = new System.Drawing.Size(187, 306);
            this.dataGridViewDruzyny.TabIndex = 4;
            this.dataGridViewDruzyny.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDruzyny_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1109, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wybierz drugą drużynę";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zawodnicy drugiej drużyny";
            // 
            // buttonZarzadzanie
            // 
            this.buttonZarzadzanie.Location = new System.Drawing.Point(205, 387);
            this.buttonZarzadzanie.Name = "buttonZarzadzanie";
            this.buttonZarzadzanie.Size = new System.Drawing.Size(319, 23);
            this.buttonZarzadzanie.TabIndex = 7;
            this.buttonZarzadzanie.Text = "Zarządzanie drużynami";
            this.buttonZarzadzanie.UseVisualStyleBackColor = true;
            this.buttonZarzadzanie.Click += new System.EventHandler(this.buttonZarzadzanie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(593, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wynik starcia";
            // 
            // Rywalizuj
            // 
            this.Rywalizuj.Location = new System.Drawing.Point(789, 387);
            this.Rywalizuj.Name = "Rywalizuj";
            this.Rywalizuj.Size = new System.Drawing.Size(319, 23);
            this.Rywalizuj.TabIndex = 10;
            this.Rywalizuj.Text = "Rywalizuj";
            this.Rywalizuj.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDruzyna1
            // 
            this.dataGridViewDruzyna1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDruzyna1.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewDruzyna1.Name = "dataGridViewDruzyna1";
            this.dataGridViewDruzyna1.RowTemplate.Height = 25;
            this.dataGridViewDruzyna1.Size = new System.Drawing.Size(187, 306);
            this.dataGridViewDruzyna1.TabIndex = 11;
            this.dataGridViewDruzyna1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDruzyna1_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wybierz pierwszą drużyne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 531);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewDruzyna1);
            this.Controls.Add(this.Rywalizuj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonZarzadzanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDruzyny);
            this.Controls.Add(this.dataGridViewPrzeciwnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGracz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrzeciwnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruzyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDruzyna1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGracz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewPrzeciwnik;
        private System.Windows.Forms.DataGridView dataGridViewDruzyny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZarzadzanie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Rywalizuj;
        private System.Windows.Forms.DataGridView dataGridViewDruzyna1;
        private System.Windows.Forms.Label label10;
    }
}

