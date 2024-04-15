namespace AC3
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
            lblYear = new Label();
            lblRegion = new Label();
            lblPoblation = new Label();
            lblDomXarx = new Label();
            lblActEco = new Label();
            lblCons = new Label();
            lblTotal = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblPobGreater = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(20, 58);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(33, 17);
            lblYear.TabIndex = 1;
            lblYear.Text = "Any";
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegion.Location = new Point(160, 58);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(63, 17);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Comarca";
            // 
            // lblPoblation
            // 
            lblPoblation.AutoSize = true;
            lblPoblation.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoblation.Location = new Point(352, 58);
            lblPoblation.Name = "lblPoblation";
            lblPoblation.Size = new Size(63, 17);
            lblPoblation.TabIndex = 3;
            lblPoblation.Text = "Població";
            // 
            // lblDomXarx
            // 
            lblDomXarx.AutoSize = true;
            lblDomXarx.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomXarx.Location = new Point(20, 176);
            lblDomXarx.Name = "lblDomXarx";
            lblDomXarx.Size = new Size(107, 17);
            lblDomXarx.TabIndex = 4;
            lblDomXarx.Text = "Domèstic xarxa";
            // 
            // lblActEco
            // 
            lblActEco.AutoSize = true;
            lblActEco.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActEco.Location = new Point(160, 176);
            lblActEco.MaximumSize = new Size(160, 0);
            lblActEco.Name = "lblActEco";
            lblActEco.Size = new Size(159, 34);
            lblActEco.TabIndex = 5;
            lblActEco.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // lblCons
            // 
            lblCons.AutoSize = true;
            lblCons.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCons.Location = new Point(352, 176);
            lblCons.MaximumSize = new Size(130, 0);
            lblCons.Name = "lblCons";
            lblCons.Size = new Size(124, 34);
            lblCons.TabIndex = 6;
            lblCons.Text = "Consum domèstic per càpita";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(512, 176);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 17);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 91);
            comboBox1.MaximumSize = new Size(80, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 33);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(160, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 33);
            comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(352, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 32);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(352, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 32);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(512, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 32);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 32);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(160, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 32);
            textBox5.TabIndex = 14;
            // 
            // lblPobGreater
            // 
            lblPobGreater.AutoSize = true;
            lblPobGreater.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPobGreater.Location = new Point(16, 49);
            lblPobGreater.Name = "lblPobGreater";
            lblPobGreater.Size = new Size(148, 17);
            lblPobGreater.TabIndex = 16;
            lblPobGreater.Text = "Població > 20000 hab.:";
            lblPobGreater.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 97);
            label2.Name = "label2";
            label2.Size = new Size(159, 17);
            label2.TabIndex = 17;
            label2.Text = "Consum domèstic mitjà:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 142);
            label3.Name = "label3";
            label3.Size = new Size(238, 17);
            label3.TabIndex = 18;
            label3.Text = "Consum domèstic per càpita més alt:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bell MT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 186);
            label4.Name = "label4";
            label4.Size = new Size(253, 17);
            label4.TabIndex = 19;
            label4.Text = "Consum doméstic per càpita més baix: ";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblRegion);
            groupBox1.Controls.Add(lblPoblation);
            groupBox1.Controls.Add(lblDomXarx);
            groupBox1.Controls.Add(lblActEco);
            groupBox1.Controls.Add(lblCons);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 299);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPobGreater);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(681, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 234);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(681, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(164, 59);
            btnClear.TabIndex = 22;
            btnClear.Text = "Netejar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(851, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 59);
            btnSave.TabIndex = 23;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.Size = new Size(1004, 127);
            dataGridView1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 476);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblYear;
        private Label lblRegion;
        private Label lblPoblation;
        private Label lblDomXarx;
        private Label lblActEco;
        private Label lblCons;
        private Label lblTotal;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblPobGreater;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dataGridView1;
    }
}
