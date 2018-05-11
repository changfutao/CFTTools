using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFTTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 生成SQL格式字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateSQLType_Click(object sender, EventArgs e)
        {

            //生成前字符串
            string listFrom = txtFrom.Text;
            if (!string.IsNullOrEmpty(listFrom))
            {
                var strList = listFrom.Split(new char[] { '\r', '\n', ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                StringBuilder sbJoin = new StringBuilder();
                strList.ForEach(item =>
                {
                    sbJoin.Append("'" + item + "',");
                });
                txtTo.Text = sbJoin.ToString().Substring(0, sbJoin.ToString().Length - 1);
            }
            else
            {
                MessageBox.Show("请输入要生成的内容!");
            }

        }
        /// <summary>
        /// 生成DBLink格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDbLink_Click(object sender, EventArgs e)
        {
            //生成前字符串
            string listFrom = txtFrom.Text;
            if (!string.IsNullOrEmpty(listFrom))
            {
                var strList = listFrom.Split(new char[] { '\r', '\n', ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                StringBuilder sbJoin = new StringBuilder();
                strList.ForEach(item =>
                {
                    sbJoin.Append("''" + item + "'',");
                });
                txtTo.Text = sbJoin.ToString().Substring(0, sbJoin.ToString().Length - 1);
            }
            else
            {
                MessageBox.Show("请输入要生成的内容!");
            }
        }
        /// <summary>
        /// 生成大写格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateToUpper_Click(object sender, EventArgs e)
        {
            //生成前字符串
            string listFrom = txtFrom.Text;
            if (!string.IsNullOrEmpty(listFrom))
            {
                txtTo.Text = listFrom.ToUpper();
            }
            else
            {
                MessageBox.Show("请输入要生成的内容!");
            }
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            string listFrom = txtFrom.Text;
            List<string> listFroms=listFrom.Split(new char[] { ',', ' ', '\t', '\r', '\n' },StringSplitOptions.RemoveEmptyEntries).ToList();
            StringBuilder sbTos = new StringBuilder();
            foreach (var lf in listFroms)
            {
                sbTos.Append(lf+"\r\n");
            }
            txtTo.Text = sbTos.ToString();
        }
    }
}
