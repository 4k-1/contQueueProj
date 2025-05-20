namespace queueProject
{
    public partial class QueueMonitorForm : Form

    {
        private LinkedList depositQueue;
        private LinkedList loanQeue;
        private LinkedList accountQueue;
        private LinkedList customerQueue;

        public QueueMonitorForm()
        {

            InitializeComponent();

            depositQueue = new LinkedList(1000);
            loanQueue = new LinkedList(2000);
            accountQueue = new LinkedList(3000);
            customerQueue = new LinkedList(4000);



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deposit/Withdrawal
            depositQueue.Enqueue();
            int number = depositQueue.PeekLast();
            heresNumlbl.Text = number.ToString();


        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Account
            accountQueue.Enqueue();
            int number = accountQueue.PeekLast();
            heresNumlbl.Text = number.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //customer
            customerQueue.Enqueue();
            int number = customerQueue.PeekLast();
            heresNumlbl.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loan 
            loanQueue.Enqueue();
            int number = loanQueue.PeekLast();
            heresNumlbl.Text = number.ToString();
        }


        private void c2NSLabel_Click(object sender, EventArgs e)
        {

        }

        private void c1NSLabel_Click(object sender, EventArgs e)
        {

        }

        private void c3NSLabel_Click(object sender, EventArgs e)
        {

        }

        private void c4NSLabel_Click(object sender, EventArgs e)
        {

        }

        private void c1CallBtn_Click(object sender, EventArgs e)
        {


        }

        int? currentServingNumber = null;

        private void c1NextBtn\_Click(object sender, EventArgs e)
        {
            if (depositQueue.Count > 0)
            {
                int? nextNumber = depositQueue.Dequeue();
                currentServingNumber = nextNumber;


                c1NSLabel.Text = nextNumber.ToString(); // this will display on the counter
            }
            else
            {
                c1NSLabel.Text = "";
            }


        }

        int? currentServingNumberC2 = null;

        private void c2NextBtn\_Click(object sender, EventArgs e)
        {
            if (loanQueue.Count > 0)
            {
                int? nextNumber = loanQueue.Dequeue();
                currentServingNumberC2 = nextNumber;


                c2NSLabel.Text = nextNumber.ToString();
            }
            else
            {
                c2NSLabel.Text = "";
            }

        }

        int? currentServingNumberC3 = null;

        private void c3NextBtn\_Click(object sender, EventArgs e)
        {
            if (accountQueue.Count > 0)
            {
                int? nextNumber = accountQueue.Dequeue();
                currentServingNumberC3 = nextNumber;


                c3NSLabel.Text = nextNumber.ToString();
            }
            else
            {
                c3NSLabel.Text = "";
            }


        }

        int? currentServingNumberC4 = null;

        private void c4NextBtn\_Click(object sender, EventArgs e)
        {
            if (customerQueue.Count > 0)
            {
                int? nextNumber = customerQueue.Dequeue();
                currentServingNumberC4 = nextNumber;


                 c4NSLabel.Text = nextNumber.ToString();
            }
            else
            {
                c4NSLabel.Text = "";
            }


         }
       
    }
