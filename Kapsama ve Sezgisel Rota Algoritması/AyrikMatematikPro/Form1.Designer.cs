namespace AyrikMatematikPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gonder = new DevExpress.XtraEditors.SimpleButton();
            this.mValue = new DevExpress.XtraEditors.TextEdit();
            this.nValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.kapsamalar = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.random = new DevExpress.XtraEditors.SimpleButton();
            this.restart = new DevExpress.XtraEditors.SimpleButton();
            this.contiune = new DevExpress.XtraEditors.SimpleButton();
            this.track = new DevExpress.XtraEditors.SimpleButton();
            this.direct = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.history = new DevExpress.XtraEditors.ListBoxControl();
            this.matris2 = new System.Windows.Forms.DataGridView();
            this.matris3 = new System.Windows.Forms.DataGridView();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matris2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matris3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.gonder);
            this.groupControl1.Controls.Add(this.mValue);
            this.groupControl1.Controls.Add(this.nValue);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(14, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 156);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Matris Bilgileri Alanı";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(276, 58);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(101, 88);
            this.gonder.TabIndex = 4;
            this.gonder.Text = "OLUŞTUR";
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // mValue
            // 
            this.mValue.Location = new System.Drawing.Point(149, 103);
            this.mValue.Name = "mValue";
            this.mValue.Size = new System.Drawing.Size(37, 22);
            this.mValue.TabIndex = 3;
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(152, 73);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(35, 22);
            this.nValue.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 15);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "M Değeri:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 15);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "N Değeri :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.matrix);
            this.groupControl2.Location = new System.Drawing.Point(14, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(577, 369);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Matris";
            // 
            // matrix
            // 
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(6, 30);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(560, 333);
            this.matrix.TabIndex = 0;
            this.matrix.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrix_CellDoubleClick);
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.kapsamalar);
            this.groupControl3.Location = new System.Drawing.Point(706, 553);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(967, 369);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "I";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kapsama : ";
            // 
            // kapsamalar
            // 
            this.kapsamalar.AutoSize = true;
            this.kapsamalar.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapsamalar.Location = new System.Drawing.Point(259, 155);
            this.kapsamalar.Name = "kapsamalar";
            this.kapsamalar.Size = new System.Drawing.Size(0, 45);
            this.kapsamalar.TabIndex = 9;
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl4.CaptionImageOptions.SvgImage")));
            this.groupControl4.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl4.Controls.Add(this.random);
            this.groupControl4.Controls.Add(this.restart);
            this.groupControl4.Controls.Add(this.contiune);
            this.groupControl4.Controls.Add(this.track);
            this.groupControl4.Controls.Add(this.direct);
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl4.Location = new System.Drawing.Point(405, 14);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1272, 156);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "İşlem Yapma Menüsü";
            this.groupControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl4_Paint);
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(86, 53);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(215, 95);
            this.random.TabIndex = 8;
            this.random.Text = "Matrisi Rastgele Doldurma";
            this.random.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(972, 53);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(215, 96);
            this.restart.TabIndex = 7;
            this.restart.Text = "Programı Sıfırla";
            this.restart.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // contiune
            // 
            this.contiune.Location = new System.Drawing.Point(750, 53);
            this.contiune.Name = "contiune";
            this.contiune.Size = new System.Drawing.Size(215, 95);
            this.contiune.TabIndex = 6;
            this.contiune.Text = "İşleme Devam Et";
            this.contiune.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(528, 53);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(215, 95);
            this.track.TabIndex = 5;
            this.track.Text = "Adımlarla İşlem";
            this.track.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // direct
            // 
            this.direct.Location = new System.Drawing.Point(308, 53);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(213, 95);
            this.direct.TabIndex = 4;
            this.direct.Text = "Adımsız İşlem";
            this.direct.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.history);
            this.groupControl5.Location = new System.Drawing.Point(14, 553);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(685, 369);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "İşlem Geçmişi";
            this.groupControl5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl5_Paint);
            // 
            // history
            // 
            this.history.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.history.Appearance.Options.UseFont = true;
            this.history.HorizontalScrollbar = true;
            this.history.ItemAutoHeight = true;
            this.history.Location = new System.Drawing.Point(6, 30);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(673, 333);
            this.history.TabIndex = 0;
            // 
            // matris2
            // 
            this.matris2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matris2.Location = new System.Drawing.Point(8, 30);
            this.matris2.Name = "matris2";
            this.matris2.Size = new System.Drawing.Size(525, 333);
            this.matris2.TabIndex = 7;
            // 
            // matris3
            // 
            this.matris3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matris3.Location = new System.Drawing.Point(8, 28);
            this.matris3.Name = "matris3";
            this.matris3.Size = new System.Drawing.Size(516, 336);
            this.matris3.TabIndex = 8;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.matris2);
            this.groupControl6.Location = new System.Drawing.Point(598, 177);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(541, 369);
            this.groupControl6.TabIndex = 9;
            this.groupControl6.Text = "Matris 2";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.matris3);
            this.groupControl7.Location = new System.Drawing.Point(1147, 177);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(530, 369);
            this.groupControl7.TabIndex = 10;
            this.groupControl7.Text = "Matris 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 934);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "İSMAİL BULUT - 377158";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1695, 958);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.Name = "Form1";
            this.Text = "İSMAİL BULUT - 377158";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matris2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matris3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit nValue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit mValue;
        private DevExpress.XtraEditors.SimpleButton gonder;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton track;
        private DevExpress.XtraEditors.SimpleButton direct;
        private DevExpress.XtraEditors.SimpleButton restart;
        private DevExpress.XtraEditors.SimpleButton contiune;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.ListBoxControl history;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.DataGridView matris2;
        private System.Windows.Forms.DataGridView matris3;
        private System.Windows.Forms.Label kapsamalar;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton random;
        private System.Windows.Forms.Label label2;
    }
}

