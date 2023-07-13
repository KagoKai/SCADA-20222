using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using SymbolFactoryDotNet;
using test.MainForms;
using test.Database;

namespace test
{
    public partial class FormMenu : Form
    {
        private Plc _myPlc;
        private readonly string _ip = "169.254.116.178";
        public Plc MyPlc { get => _myPlc; private set => _myPlc = value; }
        public PLCComm MyComm { get; set; }

        private readonly string _powerAddressDB = "DB2.DBX0.0";
        private readonly string _autmanAddressDB = "DB2.DBX0.1";
            
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }

        public FormMenu()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCIP_Click(object sender, EventArgs e)
        {
            FormCIP cip = new FormCIP();
            cip.ShowDialog();
        }

        private void buttonGao_Click(object sender, EventArgs e)
        {
            Noi_gao gao = new Noi_gao(MyComm);
            gao.ThayDoi += HMI_ThayDoi;
            gao._powerState = Power_Light.DiscreteValue1;
            gao._autmanState = AutMan_Light.DiscreteValue1;
            gao.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MyPlc = new Plc(CpuType.S71200, _ip, 0, 0);
            MyComm = new PLCComm();
            MyPlc.Open();

            // Get AUTMAN and POWER current state
            Power_Light.DiscreteValue1 = (bool)MyPlc.Read(_powerAddressDB);
            AutMan_Light.DiscreteValue1 = (bool)MyPlc.Read(_autmanAddressDB);

            if (MyPlc.IsConnected)
            {
                timerComm.Start();
                timerComm.Tick += new System.EventHandler(this.timerComm_Tick);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void timerComm_Tick(object sender, EventArgs e)
        {
            MyPlc.ReadClass(MyComm, 1);
        }

        public void HMI_ThayDoi(object sender, EventArgs e)
        {
            timerComm.Stop();
            MyPlc.WriteClass(MyComm, 1);
            timerComm.Start();
        }

        private void Power_Light_Click(object sender, EventArgs e)
        {
            Power_Light.DiscreteValue1 = !(Power_Light.DiscreteValue1);
            MyPlc.Write(_powerAddressDB, Power_Light.DiscreteValue1);
        }

        private void AutMan_Light_Click(object sender, EventArgs e)
        {
            AutMan_Light.DiscreteValue1 = !(AutMan_Light.DiscreteValue1);
            MyPlc.Write(_autmanAddressDB, AutMan_Light.DiscreteValue1);
        }

    }
}

