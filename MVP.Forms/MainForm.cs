using MVP.Presenters;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Forms
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;
        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
        }

        public string EnteredName
        {
            get
            {
                return txtCreateBook.Text;
            }

            set
            {
                value = txtCreateBook.Text;
            }
        }

        public void ShowResult(bool result)
        {
            if(result == false)
            {
                MessageBox.Show("Error!");
                return;
            }
            MessageBox.Show("Book has been created!");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _presenter.CreateBook();
        }
    }
}
