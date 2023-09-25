using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingForm
{
    public partial class NextQueue : Form
    {
        private CashierClass cashier;
        private Timer timer;
        public NextQueue()
        {
            InitializeComponent();
            cashier = new CashierClass();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(UpdatedNextQueue);
            timer.Start();
        }

        private void NextQueue_Load(object sender, EventArgs e){}
        private void UpdatedNextQueue(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string nextInQueue = CashierClass.CashierQueue.Peek();
                lblServing.Text = nextInQueue;
            }
        }
    }
}
