using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK09_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rad_btn = sender as RadioButton;
            if (rad_btn == rb_LargeIcon) listView1.View = View.LargeIcon;
            if (rad_btn == rb_SmallIcon) listView1.View = View.SmallIcon;
            if (rad_btn == rb_List) listView1.View = View.List;
            if (rad_btn == rb_Details) listView1.View = View.Details;
            if (rad_btn == rb_Tile) listView1.View = View.Tile;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                var sub_item = item.SubItems;

                label1.Text = $"{sub_item[0].Text}의 국가번호는 {sub_item[1].Text}입니다.";
            }
        }
    }
}
