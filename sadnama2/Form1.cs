using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sadnama2
{
    public partial class Form1 : Form
    {
      string clickedNode;
    MenuItem myMenuItem = new MenuItem("Show Me");
    ContextMenu mnu = new ContextMenu();
    public Form1()
    {
        InitializeComponent();
        mnu.MenuItems.Add(myMenuItem);
        myMenuItem.Click += new EventHandler(myMenuItem_Click);
    }

    void myMenuItem_Click(object sender, EventArgs e)
    {
        Form frm = new Form();
        frm.Text = clickedNode;
        frm.ShowDialog(this);
        clickedNode = "";
    }

    private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            clickedNode = e.Node.Name;
            mnu.Show(treeView2,e.Location);
        }
    }
    
        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Display context menu for eg:
                TreeNode destinationNode = ((TreeView)sender).GetNodeAt(new Point(e.X, e.Y));
                treeView2.SelectedNode = destinationNode;
                contextMenuStrip1.Show(treeView2, e.Location);
            }
        }

        private void stripMenuItemAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("اضافه شد");
        }

        //stripMenuItemAdd_Click


        private void stripMenuItemRename_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تغیر نام پیدا کرد");
        }

        //stripMenuItemRename_Click

        private void stripMenuItemRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حذف شد");
        }

        private void tabMain_Click(object sender, EventArgs e)
        {

        }
        //stripMenuItemRemove_Click
    }









}
