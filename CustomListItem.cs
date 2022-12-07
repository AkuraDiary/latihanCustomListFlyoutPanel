using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihanCustomListFlyoutPanel
{
    public partial class CustomListItem : UserControl
    {
        public CustomListItem()
        {
            InitializeComponent();
        }

        #region Properties
        
        private string _title;
        private string _overview;
        private string _url;
       // private double _vote;
        private DateTime _releaseDate;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; this.lblJudulMovie.Text = value; }
        }

        [Category("Custom Props")]
        public string Overview
        {
            get { return _overview; }
            set { _overview = value; this.lblOverview.Text = value; }
        }

        [Category("Custom Props")]
        public string URL
        {
            get { return _url; }
            set { _url = value; this.pic_movie.LoadAsync(value); }
        }

        [Category("Custom Props")]
        public DateTime releaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; lblReleaseDate.Text = value.ToString("dd/MM/yyyy"); }
        }


        /*[Category("Custom Props")]
        public double Vote
        {
            get { return _vote; }
            set { _vote = value; this.lblOverview.Text = value; }
        }*/



        #endregion


        private void lblOverview_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void lblOverview_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void lblOverview_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void CustomListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
