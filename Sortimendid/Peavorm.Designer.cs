namespace Sortimendid
{
    partial class Peavorm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peavorm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_tyhi = new System.Windows.Forms.Button();
            this.btn_arvuta = new System.Windows.Forms.Button();
            this.btn_tagavara = new System.Windows.Forms.Button();
            this.txtDjp = new System.Windows.Forms.TextBox();
            this.txtDpp = new System.Windows.Forms.TextBox();
            this.txtDpa = new System.Windows.Forms.TextBox();
            this.txtDky = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myDGV2 = new Sortimendid.myDGV();
            this.rinneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puuliikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vanusDataGridViewTextBoxColumn = new DataGridViewDoubleBoxColumn();
            this.diameeterDataGridViewTextBoxColumn = new DataGridViewDoubleBoxColumn();
            this.korgusDataGridViewTextBoxColumn = new DataGridViewDoubleBoxColumn();
            this.rinnaspindalaDataGridViewTextBoxColumn = new DataGridViewDoubleBoxColumn();
            this.tagavaraDataGridViewTextBoxColumn = new DataGridViewDoubleBoxColumn();
            this.takseerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.andmed = new Sortimendid.andmed();
            this.myDGV1 = new Sortimendid.myDGV();
            this.rinneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puuliikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamepalkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peenpalkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paberipuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kyttepuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jaatmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kokkuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortimendidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takseerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortimendidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tyhi
            // 
            this.btn_tyhi.Location = new System.Drawing.Point(604, 49);
            this.btn_tyhi.Name = "btn_tyhi";
            this.btn_tyhi.Size = new System.Drawing.Size(115, 42);
            this.btn_tyhi.TabIndex = 3;
            this.btn_tyhi.Text = "Tühjenda";
            this.btn_tyhi.UseVisualStyleBackColor = true;
            this.btn_tyhi.Click += new System.EventHandler(this.btn_tyhi_Click);
            // 
            // btn_arvuta
            // 
            this.btn_arvuta.Location = new System.Drawing.Point(604, 302);
            this.btn_arvuta.Name = "btn_arvuta";
            this.btn_arvuta.Size = new System.Drawing.Size(115, 48);
            this.btn_arvuta.TabIndex = 4;
            this.btn_arvuta.Text = "Arvuta sortimendid";
            this.btn_arvuta.UseVisualStyleBackColor = true;
            this.btn_arvuta.Click += new System.EventHandler(this.btn_arvuta_Click);
            // 
            // btn_tagavara
            // 
            this.btn_tagavara.Location = new System.Drawing.Point(604, 147);
            this.btn_tagavara.Name = "btn_tagavara";
            this.btn_tagavara.Size = new System.Drawing.Size(115, 45);
            this.btn_tagavara.TabIndex = 5;
            this.btn_tagavara.Text = "Arvuta tagavara";
            this.btn_tagavara.UseVisualStyleBackColor = true;
            this.btn_tagavara.Click += new System.EventHandler(this.btn_tagavara_Click);
            // 
            // txtDjp
            // 
            this.txtDjp.Location = new System.Drawing.Point(12, 276);
            this.txtDjp.Name = "txtDjp";
            this.txtDjp.Size = new System.Drawing.Size(44, 20);
            this.txtDjp.TabIndex = 6;
            this.txtDjp.Text = "18";
            this.txtDjp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDpp
            // 
            this.txtDpp.Location = new System.Drawing.Point(62, 276);
            this.txtDpp.Name = "txtDpp";
            this.txtDpp.Size = new System.Drawing.Size(46, 20);
            this.txtDpp.TabIndex = 7;
            this.txtDpp.Text = "12";
            this.txtDpp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDpa
            // 
            this.txtDpa.Location = new System.Drawing.Point(114, 276);
            this.txtDpa.Name = "txtDpa";
            this.txtDpa.Size = new System.Drawing.Size(44, 20);
            this.txtDpa.TabIndex = 8;
            this.txtDpa.Text = "7";
            this.txtDpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDky
            // 
            this.txtDky.Location = new System.Drawing.Point(164, 276);
            this.txtDky.Name = "txtDky";
            this.txtDky.Size = new System.Drawing.Size(49, 20);
            this.txtDky.TabIndex = 9;
            this.txtDky.Text = "5";
            this.txtDky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sortimentide miinimum diameetrid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // myDGV2
            // 
            this.myDGV2.AllowUserToOrderColumns = true;
            this.myDGV2.AutoGenerateColumns = false;
            this.myDGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rinneDataGridViewTextBoxColumn1,
            this.puuliikDataGridViewTextBoxColumn1,
            this.vanusDataGridViewTextBoxColumn,
            this.diameeterDataGridViewTextBoxColumn,
            this.korgusDataGridViewTextBoxColumn,
            this.rinnaspindalaDataGridViewTextBoxColumn,
            this.tagavaraDataGridViewTextBoxColumn});
            this.myDGV2.DataSource = this.takseerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDGV2.DefaultCellStyle = dataGridViewCellStyle1;
            this.myDGV2.Direction = Sortimendid.DirForEnter.Horisontal;
            this.myDGV2.Location = new System.Drawing.Point(15, 76);
            this.myDGV2.Name = "myDGV2";
            this.myDGV2.RowHeadersWidth = 10;
            this.myDGV2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.myDGV2.Size = new System.Drawing.Size(583, 158);
            this.myDGV2.TabIndex = 13;
            // 
            // rinneDataGridViewTextBoxColumn1
            // 
            this.rinneDataGridViewTextBoxColumn1.DataPropertyName = "rinne";
            this.rinneDataGridViewTextBoxColumn1.HeaderText = "rinne";
            this.rinneDataGridViewTextBoxColumn1.Name = "rinneDataGridViewTextBoxColumn1";
            // 
            // puuliikDataGridViewTextBoxColumn1
            // 
            this.puuliikDataGridViewTextBoxColumn1.DataPropertyName = "puuliik";
            this.puuliikDataGridViewTextBoxColumn1.HeaderText = "puuliik";
            this.puuliikDataGridViewTextBoxColumn1.Name = "puuliikDataGridViewTextBoxColumn1";
            // 
            // vanusDataGridViewTextBoxColumn
            // 
            this.vanusDataGridViewTextBoxColumn.DataPropertyName = "vanus";
            this.vanusDataGridViewTextBoxColumn.HeaderText = "vanus";
            this.vanusDataGridViewTextBoxColumn.Name = "vanusDataGridViewTextBoxColumn";
            // 
            // diameeterDataGridViewTextBoxColumn
            // 
            this.diameeterDataGridViewTextBoxColumn.DataPropertyName = "diameeter";
            this.diameeterDataGridViewTextBoxColumn.HeaderText = "diameeter";
            this.diameeterDataGridViewTextBoxColumn.Name = "diameeterDataGridViewTextBoxColumn";
            // 
            // korgusDataGridViewTextBoxColumn
            // 
            this.korgusDataGridViewTextBoxColumn.DataPropertyName = "korgus";
            this.korgusDataGridViewTextBoxColumn.HeaderText = "korgus";
            this.korgusDataGridViewTextBoxColumn.Name = "korgusDataGridViewTextBoxColumn";
            // 
            // rinnaspindalaDataGridViewTextBoxColumn
            // 
            this.rinnaspindalaDataGridViewTextBoxColumn.DataPropertyName = "rinnaspindala";
            this.rinnaspindalaDataGridViewTextBoxColumn.HeaderText = "rinnaspindala";
            this.rinnaspindalaDataGridViewTextBoxColumn.Name = "rinnaspindalaDataGridViewTextBoxColumn";
            // 
            // tagavaraDataGridViewTextBoxColumn
            // 
            this.tagavaraDataGridViewTextBoxColumn.DataPropertyName = "tagavara";
            this.tagavaraDataGridViewTextBoxColumn.HeaderText = "tagavara";
            this.tagavaraDataGridViewTextBoxColumn.Name = "tagavaraDataGridViewTextBoxColumn";
            // 
            // takseerBindingSource
            // 
            this.takseerBindingSource.DataMember = "takseer";
            this.takseerBindingSource.DataSource = this.andmed;
            // 
            // andmed
            // 
            this.andmed.DataSetName = "andmed";
            this.andmed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDGV1
            // 
            this.myDGV1.AllowUserToOrderColumns = true;
            this.myDGV1.AutoGenerateColumns = false;
            this.myDGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rinneDataGridViewTextBoxColumn,
            this.puuliikDataGridViewTextBoxColumn,
            this.jamepalkDataGridViewTextBoxColumn,
            this.peenpalkDataGridViewTextBoxColumn,
            this.paberipuitDataGridViewTextBoxColumn,
            this.kyttepuitDataGridViewTextBoxColumn,
            this.jaatmedDataGridViewTextBoxColumn,
            this.kokkuDataGridViewTextBoxColumn});
            this.myDGV1.DataSource = this.sortimendidBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.myDGV1.Direction = Sortimendid.DirForEnter.Horisontal;
            this.myDGV1.Location = new System.Drawing.Point(12, 302);
            this.myDGV1.Name = "myDGV1";
            this.myDGV1.RowHeadersWidth = 10;
            this.myDGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.myDGV1.Size = new System.Drawing.Size(586, 197);
            this.myDGV1.TabIndex = 12;
            // 
            // rinneDataGridViewTextBoxColumn
            // 
            this.rinneDataGridViewTextBoxColumn.DataPropertyName = "rinne";
            this.rinneDataGridViewTextBoxColumn.HeaderText = "rinne";
            this.rinneDataGridViewTextBoxColumn.Name = "rinneDataGridViewTextBoxColumn";
            // 
            // puuliikDataGridViewTextBoxColumn
            // 
            this.puuliikDataGridViewTextBoxColumn.DataPropertyName = "puuliik";
            this.puuliikDataGridViewTextBoxColumn.HeaderText = "puuliik";
            this.puuliikDataGridViewTextBoxColumn.Name = "puuliikDataGridViewTextBoxColumn";
            // 
            // jamepalkDataGridViewTextBoxColumn
            // 
            this.jamepalkDataGridViewTextBoxColumn.DataPropertyName = "jamepalk";
            this.jamepalkDataGridViewTextBoxColumn.HeaderText = "jamepalk";
            this.jamepalkDataGridViewTextBoxColumn.Name = "jamepalkDataGridViewTextBoxColumn";
            // 
            // peenpalkDataGridViewTextBoxColumn
            // 
            this.peenpalkDataGridViewTextBoxColumn.DataPropertyName = "peenpalk";
            this.peenpalkDataGridViewTextBoxColumn.HeaderText = "peenpalk";
            this.peenpalkDataGridViewTextBoxColumn.Name = "peenpalkDataGridViewTextBoxColumn";
            // 
            // paberipuitDataGridViewTextBoxColumn
            // 
            this.paberipuitDataGridViewTextBoxColumn.DataPropertyName = "paberipuit";
            this.paberipuitDataGridViewTextBoxColumn.HeaderText = "paberipuit";
            this.paberipuitDataGridViewTextBoxColumn.Name = "paberipuitDataGridViewTextBoxColumn";
            // 
            // kyttepuitDataGridViewTextBoxColumn
            // 
            this.kyttepuitDataGridViewTextBoxColumn.DataPropertyName = "kyttepuit";
            this.kyttepuitDataGridViewTextBoxColumn.HeaderText = "kyttepuit";
            this.kyttepuitDataGridViewTextBoxColumn.Name = "kyttepuitDataGridViewTextBoxColumn";
            // 
            // jaatmedDataGridViewTextBoxColumn
            // 
            this.jaatmedDataGridViewTextBoxColumn.DataPropertyName = "jaatmed";
            this.jaatmedDataGridViewTextBoxColumn.HeaderText = "jaatmed";
            this.jaatmedDataGridViewTextBoxColumn.Name = "jaatmedDataGridViewTextBoxColumn";
            // 
            // kokkuDataGridViewTextBoxColumn
            // 
            this.kokkuDataGridViewTextBoxColumn.DataPropertyName = "kokku";
            this.kokkuDataGridViewTextBoxColumn.HeaderText = "kokku";
            this.kokkuDataGridViewTextBoxColumn.Name = "kokkuDataGridViewTextBoxColumn";
            // 
            // sortimendidBindingSource
            // 
            this.sortimendidBindingSource.DataMember = "sortimendid";
            this.sortimendidBindingSource.DataSource = this.andmed;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 511);
            this.Controls.Add(this.myDGV2);
            this.Controls.Add(this.myDGV1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDky);
            this.Controls.Add(this.txtDpa);
            this.Controls.Add(this.txtDpp);
            this.Controls.Add(this.txtDjp);
            this.Controls.Add(this.btn_tagavara);
            this.Controls.Add(this.btn_arvuta);
            this.Controls.Add(this.btn_tyhi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takseerkirjeldusest sortimendid - Õppeprogramm - (C) Allan Sims, 2012";
            ((System.ComponentModel.ISupportInitialize)(this.myDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takseerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.andmed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortimendidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private andmed andmed;
        private System.Windows.Forms.BindingSource takseerBindingSource;
        private System.Windows.Forms.BindingSource sortimendidBindingSource;
        private System.Windows.Forms.Button btn_tyhi;
        private System.Windows.Forms.Button btn_arvuta;
        private System.Windows.Forms.Button btn_tagavara;
        private System.Windows.Forms.TextBox txtDjp;
        private System.Windows.Forms.TextBox txtDpp;
        private System.Windows.Forms.TextBox txtDpa;
        private System.Windows.Forms.TextBox txtDky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private myDGV myDGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rinneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puuliikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamepalkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peenpalkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paberipuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kyttepuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jaatmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kokkuDataGridViewTextBoxColumn;
        private myDGV myDGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rinneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn puuliikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vanusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korgusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rinnaspindalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagavaraDataGridViewTextBoxColumn;
    }
}

