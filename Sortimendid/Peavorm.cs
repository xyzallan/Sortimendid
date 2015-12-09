using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Sortimendid
{
    public partial class Peavorm : Form
    {
        public Peavorm()
        {
            InitializeComponent();
        }

        private void btn_tyhi_Click(object sender, EventArgs e)
        {
            andmed.takseer.Rows.Clear();
            andmed.sortimendid.Rows.Clear();
        }

        private void btn_tagavara_Click(object sender, EventArgs e)
        {
            
            foreach (andmed.takseerRow tr in andmed.takseer.Rows)
            {
                tr.puuliik = tr.puuliik.ToUpper();
                tr.tagavara = metsmudelid.Tagavara(tr.puuliik, tr.korgus, tr.rinnaspindala);                
            }
        }

        private void btn_arvuta_Click(object sender, EventArgs e)
        {
            andmed.sortimendid.Rows.Clear();
            andmed.sortimendidRow sortrida;
            Sorts sordid = new Sorts();
            Sorts sordid2 = new Sorts();

            Sdiam diams = new Sdiam();
            diams.Djp = Double.Parse(txtDjp.Text);
            diams.Dpp = Double.Parse(txtDpp.Text);
            diams.Dpa = Double.Parse(txtDpa.Text);
            diams.Dky = Double.Parse(txtDky.Text);

            foreach (andmed.takseerRow tr in andmed.takseer.Rows)
            {
                tr.puuliik = tr.puuliik.ToUpper();
                sordid = metsmudelid.SortJaot(tr.puuliik, tr.diameeter, tr.korgus, 0, 0, 0, diams);

                sordid2.vjp = Math.Round(sordid.vjp / sordid.vko * tr.tagavara, 2);
                sordid2.vpp = Math.Round(sordid.vpp / sordid.vko * tr.tagavara, 2);
                sordid2.vpa = Math.Round(sordid.vpa / sordid.vko * tr.tagavara, 2);
                sordid2.vky = Math.Round(sordid.vky / sordid.vko * tr.tagavara, 2);
                sordid2.vjt = Math.Round(sordid.vjt / sordid.vko * tr.tagavara, 2);
                sordid2.vko = Math.Round(tr.tagavara, 2);
                
                sortrida = andmed.sortimendid.AddsortimendidRow(
                        tr.rinne, tr.puuliik, sordid2.vjp, sordid2.vpp, sordid2.vpa, sordid2.vky, sordid2.vjt, sordid2.vko
                    );

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
