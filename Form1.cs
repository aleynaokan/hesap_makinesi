namespace hesap_makinesi
{
    public partial class Form1 : Form
    {

        bool optDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {

            if (sonuc_text.Text == "0" || optDurum)
                sonuc_text.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            sonuc_text.Text += btn.Text;
        }

        private void OptHesaplama(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbl_sonuc.Text = lbl_sonuc.Text + " " + sonuc_text.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": sonuc_text.Text = (sonuc + Double.Parse(sonuc_text.Text)).ToString(); break;
                case "-": sonuc_text.Text = (sonuc - Double.Parse(sonuc_text.Text)).ToString(); break;
                case "*": sonuc_text.Text = (sonuc * Double.Parse(sonuc_text.Text)).ToString(); break;
                case "/": sonuc_text.Text = (sonuc / Double.Parse(sonuc_text.Text)).ToString(); break;
            }
            sonuc = Double.Parse(sonuc_text.Text);
            lbl_sonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            sonuc_text.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            sonuc_text.Text = "0";
            lbl_sonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false;

        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": sonuc_text.Text = (sonuc + Double.Parse(sonuc_text.Text)).ToString(); break;
                case "-": sonuc_text.Text = (sonuc - Double.Parse(sonuc_text.Text)).ToString(); break;
                case "*": sonuc_text.Text = (sonuc * Double.Parse(sonuc_text.Text)).ToString(); break;
                case "/": sonuc_text.Text = (sonuc / Double.Parse(sonuc_text.Text)).ToString(); break;
            }
            sonuc = Double.Parse(sonuc_text.Text);
            lbl_sonuc.Text = sonuc.ToString();
            opt = "";
            
    ;
        }

        private void btn_nokta_Click(object sender, EventArgs e)
        {
            if (sonuc_text.Text == "0")
            {
                sonuc_text.Text = "0";
            }
            else if (optDurum)
            {
                sonuc_text.Text = "0";
            }

            if (!sonuc_text.Text.Contains(","))
            {
                sonuc_text.Text += ",";
            }
            optDurum = false;
        }
    }
}