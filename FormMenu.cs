using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using S7.Net;
using SymbolFactoryDotNet;
using test.MainForms;
using test.Database;

namespace test
{
    public partial class FormMenu : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }

        public static bool s_isAdmin = false;
        public static bool s_powerState = false, s_autmanState = false;
        public static ValveSwitch s_switchCount = new ValveSwitch();

        private Plc _myPlc;
        private readonly string _ip = "169.254.116.178";
        public Plc MyPlc { get => _myPlc; private set => _myPlc = value; }
        public PLCComm MyComm { get; set; }

        private readonly string _powerAddressDB = "DB2.DBX0.0";
        private readonly string _autmanAddressDB = "DB2.DBX0.1";

        public FormMenu()
        {
            InitializeComponent();
            s_switchCount.PropertyChanged += S_switchCount_PropertyChanged;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MyPlc = new Plc(CpuType.S71200, _ip, 0, 0);
            MyComm = new PLCComm();
            MyComm.SwitchCountUp += MyComm_SwitchCountUp;
            MyPlc.Open();

            // Get AUTMAN and POWER current state
            Power_Light.DiscreteValue1 = (bool)MyPlc.Read(_powerAddressDB);
            s_powerState = Power_Light.DiscreteValue1;
            AutMan_Light.DiscreteValue1 = (bool)MyPlc.Read(_autmanAddressDB);
            s_autmanState = AutMan_Light.DiscreteValue1;

            if (MyPlc.IsConnected)
            {
                timerComm.Start();
                timerComm.Tick += new System.EventHandler(this.timerComm_Tick);
            }

            GetSwitchCount();
        }

        private void MyComm_SwitchCountUp(object sender, EventArgs e)
        {
            PropertyInfo prop = s_switchCount.GetType().GetProperty(sender.ToString());
            if (prop != null)
            {
                UInt16 currentCount = (UInt16)prop.GetValue(s_switchCount);
                prop.SetValue(s_switchCount, (UInt16)(currentCount + 1));
            }
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
            gao.ShowDialog();
        }

        private void GetSwitchCount()
        {
            MyPlc.ReadClass(s_switchCount, 3);
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
            s_powerState = Power_Light.DiscreteValue1;
            MyPlc.Write(_powerAddressDB, Power_Light.DiscreteValue1);
        }

        private void AutMan_Light_Click(object sender, EventArgs e)
        {
            AutMan_Light.DiscreteValue1 = !(AutMan_Light.DiscreteValue1);
            s_autmanState = AutMan_Light.DiscreteValue1;
            MyPlc.Write(_autmanAddressDB, AutMan_Light.DiscreteValue1);
        }

        private void S_switchCount_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            timerComm.Stop();
            MyPlc.WriteClass(s_switchCount, 3);
            timerComm.Start();
        }

    }
}

