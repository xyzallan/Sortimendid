using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Sortimendid
{
    public enum DirForEnter
    {
        Horisontal = 0,
        Vertical = 1
    }


    public class myDGV : DataGridView
    {
        //private BindingSource _data;
        private DirForEnter suund;

        [Description("Direction for Keys.Enter")]
        [DefaultValue(0)]
        [Category("Behavior")]
        public DirForEnter Direction
        {
            get { return suund; }
            set { suund = value; }
        }

        /*
        public BindingSource BindingData
        {
            get { return _data; }
            set { _data = value; }
        }
        */



        public myDGV()
        {

            this.RowHeadersWidth = 10;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.AutoGenerateColumns = false;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllowUserToResizeColumns = true;
            this.AllowUserToOrderColumns = true;
            this.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(DataGridViewHoris_EditingControlShowing);


        }

        private void DataGridViewHoris_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            TextBox tb = this.EditingControl as TextBox;
            //MessageBox.Show(this.CurrentCell.OwningColumn.ValueType.ToString());
            tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
            string LahtriTyyp = this.CurrentCell.OwningColumn.ValueType.ToString();
            if (LahtriTyyp == "System.Double" || LahtriTyyp == "System.Decimal" || LahtriTyyp == "System.Float")
            {
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            Keys key = (keyData & Keys.KeyCode);
            if (key == Keys.Enter)
            {
                if (this.Direction == DirForEnter.Horisontal)
                {
                    return this.ProcessTabKey(keyData);
                }

            }

            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &
                this.Direction == DirForEnter.Horisontal)
            {
                return this.ProcessTabKey(e.KeyData);
            }

            return base.ProcessDataGridViewKey(e);
        }

        /*
        private void dataGridView1_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            this.Rows[e.RowIndex].ErrorText = "";
            int newInteger;

            // Don't try to validate the 'new row' until finished 
            // editing since there
            // is not any point in validating its initial value.
            if (this.Rows[e.RowIndex].IsNewRow) { return; }
            if (!int.TryParse(e.FormattedValue.ToString(),
                out newInteger) || newInteger < 0)
            {
                e.Cancel = true;
                this.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
            }
        }
        */

    }

    public class DataGridViewDoubleBoxColumn : DataGridViewTextBoxColumn
    {

    }

    public class DataGridViewDoubleBoxCell : DataGridViewTextBoxCell
    {

        public override bool KeyEntersEditMode(KeyEventArgs e)
        {
            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            Keys negativeSignKey = Keys.None;
            string negativeSignStr = numberFormatInfo.NegativeSign;

            if ((char.IsDigit((char)e.KeyCode) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                negativeSignKey == e.KeyCode ||
                Keys.Subtract == e.KeyCode) &&
                !e.Shift && !e.Alt && !e.Control)
            {
                return true;
            }
            return false;
        }

    }
}
