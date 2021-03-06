﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POS.BusinessLayer;
using POS.BusinessLayer.Wrapper;

namespace POS.UserInterfaceLayer.Administration
{
    public partial class frmUserGroupSearch : POS.UserInterfaceLayer.Portal.frmBaseSearchForm
    {
        private ADGroupWrapper _aDGroupWrapper;

        public frmUserGroupSearch()
        {
            InitializeComponent();
            _aDGroupWrapper = new ADGroupWrapper();
            base.lbl_FormHeader.Text = "مجموعات المستخدمين";
            InitiateGrid();
        }

        /// <summary>
        /// Events Override
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Add_Click(object sender, EventArgs e)
        {
            frmUserGroupAddEdit frm = new frmUserGroupAddEdit();
            frm.FormClosed += frmUserGroupAddEditClosed;
            frm.ShowDialog();
        }
        public override void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                frmUserGroupAddEdit frm = new frmUserGroupAddEdit(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["GroupID"].Value.ToString()));
                frm.FormClosed += frmUserGroupAddEditClosed;
                frm.ShowDialog();
            }
            else { MessageBox.Show("اختر عنصر اولا"); }
        }
        public override void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                ADGroupPrimaryKey pk = new ADGroupPrimaryKey();
                pk.GroupID = Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["GroupID"].Value);
                if (_aDGroupWrapper.Delete(pk))
                {
                    MessageBox.Show("تم الحذف");
                    BindGrid();
                }
            }
            else { MessageBox.Show("اختر عنصر اولا"); }

        }
        public override void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Priviligies_Click(object sender, EventArgs e)
        {
            if (dgrid_Result.SelectedRows.Count != 0)
            {
                frmGroupPriviliges frm = new frmGroupPriviliges(Convert.ToInt32(dgrid_Result.SelectedRows[0].Cells["GroupID"].Value));
                frm.ShowDialog();
            }
            else { MessageBox.Show("اختر عنصر اولا"); }

        }
        private void frmUserGroupAddEditClosed(object sender, FormClosedEventArgs e)
        {
            BindGrid();
        }
        ///<summary>
        ///private methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitiateGrid()
        {
            dgrid_Result.Size = new Size(10, 250);
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = _aDGroupWrapper.SelectAll();
            addColumnToGrid("رقم المجموعه", "GroupID", 20, false);
            addColumnToGrid("أسم المجموعة", "GroupName", 200, true);
        }
        private void BindGrid()
        {
            dgrid_Result.DataSource = null;
            dgrid_Result.DataSource = _aDGroupWrapper.SelectAll();
        }





    }
}
