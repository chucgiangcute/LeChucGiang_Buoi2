namespace LeChucGiang_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            
            //list.Add(int.Parse(txtn.Text));
            list.Add(Convert.ToInt32(txtn.Text));
            string kq = " ";
            txtn.Text = " ";
            foreach (int i in list)
            {
                kq += (i + " ").ToString();
                txtmang.Text = kq;
            }

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            foreach (int i in list)
            {
                if (i % 2 != 0)
                {
                    txtle.Text += (i+ " ").ToString() ;
                }
            }



        }

        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;

                    }
                }
            }
            return true;

        }
        private void btntim1_Click(object sender, EventArgs e)
        {
            foreach (int i in list)
            {
                if(SNT(i))
                {
                    txtnt.Text += ( i + " ").ToString();
                }    
            }    
        }
    }
}
