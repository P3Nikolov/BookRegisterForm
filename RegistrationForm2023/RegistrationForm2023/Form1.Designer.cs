namespace RegistrationForm2023
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.rbPoezia = new System.Windows.Forms.RadioButton();
            this.rbRoman = new System.Windows.Forms.RadioButton();
            this.rbRazkaz = new System.Windows.Forms.RadioButton();
            this.lblJanr = new System.Windows.Forms.Label();
            this.lblIzdatelstvo = new System.Windows.Forms.Label();
            this.cbIzdatelstva = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chcbKorica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTematika = new System.Windows.Forms.Label();
            this.rbHistorical = new System.Windows.Forms.RadioButton();
            this.rbScifi = new System.Windows.Forms.RadioButton();
            this.rbAction = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.Location = new System.Drawing.Point(61, 22);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 22);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Автор :";
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(36, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Заглавие :";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthor.Location = new System.Drawing.Point(140, 19);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(128, 27);
            this.tbAuthor.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTitle.Location = new System.Drawing.Point(140, 58);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(128, 27);
            this.tbTitle.TabIndex = 3;
            // 
            // rbPoezia
            // 
            this.rbPoezia.AutoSize = true;
            this.rbPoezia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPoezia.Location = new System.Drawing.Point(26, 96);
            this.rbPoezia.Name = "rbPoezia";
            this.rbPoezia.Size = new System.Drawing.Size(75, 21);
            this.rbPoezia.TabIndex = 4;
            this.rbPoezia.TabStop = true;
            this.rbPoezia.Text = "Поезия";
            this.rbPoezia.UseVisualStyleBackColor = true;
            this.rbPoezia.CheckedChanged += new System.EventHandler(this.rbPoezia_CheckedChanged);
            // 
            // rbRoman
            // 
            this.rbRoman.AutoSize = true;
            this.rbRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRoman.Location = new System.Drawing.Point(33, 42);
            this.rbRoman.Name = "rbRoman";
            this.rbRoman.Size = new System.Drawing.Size(68, 21);
            this.rbRoman.TabIndex = 5;
            this.rbRoman.TabStop = true;
            this.rbRoman.Text = "Роман";
            this.rbRoman.UseVisualStyleBackColor = true;
            this.rbRoman.CheckedChanged += new System.EventHandler(this.rbRoman_CheckedChanged);
            // 
            // rbRazkaz
            // 
            this.rbRazkaz.AutoSize = true;
            this.rbRazkaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRazkaz.Location = new System.Drawing.Point(29, 69);
            this.rbRazkaz.Name = "rbRazkaz";
            this.rbRazkaz.Size = new System.Drawing.Size(72, 21);
            this.rbRazkaz.TabIndex = 6;
            this.rbRazkaz.TabStop = true;
            this.rbRazkaz.Text = "Разказ";
            this.rbRazkaz.UseVisualStyleBackColor = true;
            this.rbRazkaz.CheckedChanged += new System.EventHandler(this.rbRazkaz_CheckedChanged);
            // 
            // lblJanr
            // 
            this.lblJanr.AutoSize = true;
            this.lblJanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJanr.Location = new System.Drawing.Point(35, 16);
            this.lblJanr.Name = "lblJanr";
            this.lblJanr.Size = new System.Drawing.Size(66, 22);
            this.lblJanr.TabIndex = 7;
            this.lblJanr.Text = "Жанр :";
            // 
            // lblIzdatelstvo
            // 
            this.lblIzdatelstvo.AutoSize = true;
            this.lblIzdatelstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIzdatelstvo.Location = new System.Drawing.Point(6, 101);
            this.lblIzdatelstvo.Name = "lblIzdatelstvo";
            this.lblIzdatelstvo.Size = new System.Drawing.Size(128, 22);
            this.lblIzdatelstvo.TabIndex = 8;
            this.lblIzdatelstvo.Text = "Издателство :";
            this.lblIzdatelstvo.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbIzdatelstva
            // 
            this.cbIzdatelstva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbIzdatelstva.FormattingEnabled = true;
            this.cbIzdatelstva.Items.AddRange(new object[] {
            "БГ УЧЕБНИК",
            "ЕГМОНТ",
            "СИЕЛА",
            "БАРД",
            "БУЛВЕСТ",
            "ПРОСВЕТА"});
            this.cbIzdatelstva.Location = new System.Drawing.Point(140, 102);
            this.cbIzdatelstva.Name = "cbIzdatelstva";
            this.cbIzdatelstva.Size = new System.Drawing.Size(128, 28);
            this.cbIzdatelstva.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJanr);
            this.groupBox1.Controls.Add(this.rbRazkaz);
            this.groupBox1.Controls.Add(this.rbRoman);
            this.groupBox1.Controls.Add(this.rbPoezia);
            this.groupBox1.Location = new System.Drawing.Point(274, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 138);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chcbKorica
            // 
            this.chcbKorica.AutoSize = true;
            this.chcbKorica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chcbKorica.Location = new System.Drawing.Point(428, 60);
            this.chcbKorica.Name = "chcbKorica";
            this.chcbKorica.Size = new System.Drawing.Size(67, 24);
            this.chcbKorica.TabIndex = 11;
            this.chcbKorica.Text = "Мека";
            this.chcbKorica.UseVisualStyleBackColor = true;
            this.chcbKorica.CheckedChanged += new System.EventHandler(this.chcbKorica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Корица :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTematika);
            this.groupBox2.Controls.Add(this.rbHistorical);
            this.groupBox2.Controls.Add(this.rbScifi);
            this.groupBox2.Controls.Add(this.rbAction);
            this.groupBox2.Location = new System.Drawing.Point(353, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 134);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblTematika
            // 
            this.lblTematika.AutoSize = true;
            this.lblTematika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTematika.Location = new System.Drawing.Point(18, 16);
            this.lblTematika.Name = "lblTematika";
            this.lblTematika.Size = new System.Drawing.Size(102, 22);
            this.lblTematika.TabIndex = 7;
            this.lblTematika.Text = "Тематика :";
            // 
            // rbHistorical
            // 
            this.rbHistorical.AutoSize = true;
            this.rbHistorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHistorical.Location = new System.Drawing.Point(14, 69);
            this.rbHistorical.Name = "rbHistorical";
            this.rbHistorical.Size = new System.Drawing.Size(112, 21);
            this.rbHistorical.TabIndex = 6;
            this.rbHistorical.TabStop = true;
            this.rbHistorical.Text = "Историческа";
            this.rbHistorical.UseVisualStyleBackColor = true;
            this.rbHistorical.CheckedChanged += new System.EventHandler(this.rbHistorical_CheckedChanged);
            // 
            // rbScifi
            // 
            this.rbScifi.AutoSize = true;
            this.rbScifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbScifi.Location = new System.Drawing.Point(14, 41);
            this.rbScifi.Name = "rbScifi";
            this.rbScifi.Size = new System.Drawing.Size(107, 21);
            this.rbScifi.TabIndex = 5;
            this.rbScifi.TabStop = true;
            this.rbScifi.Text = "Фантастика";
            this.rbScifi.UseVisualStyleBackColor = true;
            this.rbScifi.CheckedChanged += new System.EventHandler(this.rbScifi_CheckedChanged);
            // 
            // rbAction
            // 
            this.rbAction.AutoSize = true;
            this.rbAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAction.Location = new System.Drawing.Point(32, 96);
            this.rbAction.Name = "rbAction";
            this.rbAction.Size = new System.Drawing.Size(70, 21);
            this.rbAction.TabIndex = 4;
            this.rbAction.TabStop = true;
            this.rbAction.Text = "Екшън";
            this.rbAction.UseVisualStyleBackColor = true;
            this.rbAction.CheckedChanged += new System.EventHandler(this.rbAction_CheckedChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(60, 182);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(208, 42);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Въведи";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(60, 237);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(208, 42);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Изведи";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 317);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chcbKorica);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbIzdatelstva);
            this.Controls.Add(this.lblIzdatelstvo);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Name = "Form1";
            this.Text = "Book Registration Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RadioButton rbPoezia;
        private System.Windows.Forms.RadioButton rbRoman;
        private System.Windows.Forms.RadioButton rbRazkaz;
        private System.Windows.Forms.Label lblJanr;
        private System.Windows.Forms.Label lblIzdatelstvo;
        private System.Windows.Forms.ComboBox cbIzdatelstva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chcbKorica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTematika;
        private System.Windows.Forms.RadioButton rbHistorical;
        private System.Windows.Forms.RadioButton rbScifi;
        private System.Windows.Forms.RadioButton rbAction;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnShow;
    }
}

