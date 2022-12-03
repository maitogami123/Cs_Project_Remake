using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFuckingProject.GUI
{
    public partial class Account_Form : KryptonForm
    {
        private static bool ascendingOrder = true;
        private static int panelIndex = 100;

        public Account_Form()
        {
            InitializeComponent();
            flowLayoutPanel1.HorizontalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.AutoScroll = true;
            handleRenderItems();

        }

        private void handleRenderItems()
        {
            //
            // Initialize component
            //
            Panel panel9 = new System.Windows.Forms.Panel();
            KryptonButton kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            Label label6 = new System.Windows.Forms.Label();
            Label label7 = new System.Windows.Forms.Label();
            KryptonButton kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            TableLayoutPanel tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            //
            // Add main panel to flowLayoutPanel1 view
            //
            flowLayoutPanel1.Controls.Add(panel9);

            panel9.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            // 
            // panel9
            // 
            panel9.Controls.Add(tableLayoutPanel9);
            panel9.Location = new System.Drawing.Point(0, 0);
            panel9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            panel9.Name = $"panel{panelIndex}";
            panel9.Size = new System.Drawing.Size(1150, 50);
            panel9.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel9.Controls.Add(kryptonButton6, 3, 0);
            tableLayoutPanel9.Controls.Add(label6, 0, 0);
            tableLayoutPanel9.Controls.Add(label7, 1, 0);
            tableLayoutPanel9.Controls.Add(kryptonButton5, 2, 0);
            tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tableLayoutPanel9.Size = new System.Drawing.Size(1150, 50);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // kryptonButton6
            // 
            kryptonButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            kryptonButton6.Location = new System.Drawing.Point(1007, 2);
            kryptonButton6.Margin = new System.Windows.Forms.Padding(0);
            kryptonButton6.Name = $"deleteBtn{panelIndex}";
            kryptonButton6.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton6.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton6.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton6.OverrideDefault.Border.Width = 0;
            kryptonButton6.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton6.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton6.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kryptonButton6.Size = new System.Drawing.Size(107, 46);
            kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton6.StateCommon.Border.Width = 0;
            kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton6.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kryptonButton6.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            kryptonButton6.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            kryptonButton6.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            kryptonButton6.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            kryptonButton6.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton6.StateTracking.Border.Width = 0;
            kryptonButton6.TabIndex = 3;
            kryptonButton6.Values.Text = "✕ Delete";
            kryptonButton6.Click += new System.EventHandler(hanldeDeleteItem);
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label6.Location = new System.Drawing.Point(12, 14);
            label6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 22);
            label6.TabIndex = 0;
            label6.Text = $"UserName{panelIndex}";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label7.Location = new System.Drawing.Point(394, 14);
            label7.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(66, 21);
            label7.TabIndex = 1;
            label7.Text = "Quản lý";
            // 
            // kryptonButton5
            // 
            kryptonButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            kryptonButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonButton5.Location = new System.Drawing.Point(845, 2);
            kryptonButton5.Margin = new System.Windows.Forms.Padding(0);
            kryptonButton5.Name = $"edit{panelIndex}";
            kryptonButton5.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton5.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton5.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton5.OverrideDefault.Border.Width = 0;
            kryptonButton5.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton5.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton5.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kryptonButton5.Size = new System.Drawing.Size(160, 46);
            kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            kryptonButton5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton5.StateCommon.Border.Width = 0;
            kryptonButton5.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton5.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            kryptonButton5.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            kryptonButton5.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            kryptonButton5.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            kryptonButton5.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            kryptonButton5.StateTracking.Border.Width = 0;
            kryptonButton5.TabIndex = 2;
            kryptonButton5.Values.Text = "↺ Edit";
            kryptonButton5.Click += new System.EventHandler(handleEditItem);

            panel9.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panelIndex++;

        }


        private void hanldeDeleteItem(object sender, EventArgs e)
        {
            string btnName = ((KryptonButton)sender).Name;
            string panelName = ($"panel{btnName.Substring(9)}");
            foreach(Panel panel in flowLayoutPanel1.Controls)
            {
                if (panel.Name.Equals(panelName))
                {
                    flowLayoutPanel1.Controls.Remove(panel);
                    break;
                }
            }
        }

        private void handleEditItem(object sender, EventArgs e)
        {
            string btnName = ((KryptonButton)sender).Name;
            string panelName = btnName.Substring(4);
            Edit_Account_Form editForm = new Edit_Account_Form($"UserName{panelName}", $"Password{panelName}", $"Quản lý");
            editForm.Show();
        }

        private void handleAddItem()
        {
            Add_User_Form addUserForm = new Add_User_Form();
            addUserForm.Show();
        }

        private void handleSortOrder()
        {
            if (ascendingOrder)
            {
                kryptonButton2.Text = "Name  ▼";
                ascendingOrder = false;
            } else
            {
                kryptonButton2.Text = "Name  ▲";
                ascendingOrder = true;
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            handleSortOrder();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            handleRenderItems();
        }

    }
}
