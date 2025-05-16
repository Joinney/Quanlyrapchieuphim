using loogin.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loogin.btnDulieu
{
    public partial class ScreenTypeUC : UserControl
    {
        BindingSource screenTypeList = new BindingSource();
        public ScreenTypeUC()
        {

            InitializeComponent();
            LoadScreenType();
        }
        void LoadScreenType()
        {
            dtgvScreenType.DataSource = screenTypeList;
            LoadScreenTypeList();
            AddScreenTypeBinding();
        }
        void LoadScreenTypeList()
        {
            screenTypeList.DataSource = ScreenTypeDAO.GetScreenType();
        }
        void AddScreenTypeBinding()
        {
            txtScreenTypeID.DataBindings.Add("Text", dtgvScreenType.DataSource, "Mã loại màn hình", true, DataSourceUpdateMode.Never);
            txtScreenTypeName.DataBindings.Add("Text", dtgvScreenType.DataSource, "Tên màn hình", true, DataSourceUpdateMode.Never);
        }
       

        void InsertScreenType(string id, string name)
        {
            if (ScreenTypeDAO.InsertScreenType(id, name))
            {
                MessageBox.Show("Thêm loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Thêm loại màn hình thất bại");
            }
        }



        private void ScreenTypeUC_Load(object sender, EventArgs e)
        {

        }

        private void btnShowScreenType_Click(object sender, EventArgs e)
        {
            LoadScreenTypeList();
        }

        private void btnInsertScreenType_Click(object sender, EventArgs e)
        {
            string screenTypeID = txtScreenTypeID.Text;
            string screenTypeName = txtScreenTypeName.Text;
            InsertScreenType(screenTypeID, screenTypeName);
            LoadScreenTypeList();
        }

        void UpdateScreenType(string id, string name)
        {
            if (ScreenTypeDAO.UpdateScreenType(id, name))
            {
                MessageBox.Show("Sửa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại màn hình thất bại");
            }
        }

        private void btnUpdateScreenType_Click(object sender, EventArgs e)
        {
            string screenTypeID = txtScreenTypeID.Text;
            string screenTypeName = txtScreenTypeName.Text;
            UpdateScreenType(screenTypeID, screenTypeName);
            LoadScreenTypeList();
        }
        void DeleteScreenType(string id)
        {
            if (ScreenTypeDAO.DeleteScreenType(id))
            {
                MessageBox.Show("Xóa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại màn hình thất bại");
            }
        }

        private void btnDeleteScreenType_Click(object sender, EventArgs e)
        {
            string screenTypeID = txtScreenTypeID.Text;
            DeleteScreenType(screenTypeID);
            LoadScreenTypeList();
        }

        private void dtgvScreenType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
