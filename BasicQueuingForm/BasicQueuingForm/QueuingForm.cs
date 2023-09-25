namespace BasicQueuingForm
{
    public partial class QueuingForm : Form

    {
        private NextQueue nextQueue;
        private CashierClass cashier = new CashierClass();

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm obj = new CashierWindowQueueForm();
            obj.Show();
            nextQueue = new NextQueue();
            nextQueue.Show();   
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
        }
    }
}