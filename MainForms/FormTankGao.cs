﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.MainForms;
using test.Database;
using SymbolFactoryDotNet;
using test.SubForms;

namespace test
{
    public partial class Noi_gao : ScadaUI
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }

        static public UInt16 s_maxSwitchCount;
        static public int s_switchCountLimit;
        public PLCComm CurrentComm { get; set; }

        public event EventHandler gioiHan_ThayDoi;
        private void AdminCfg_WarningReset(object sender, EventArgs e)
        {
            bool isSafe = (FormMenu.s_switchCount.V13D < s_switchCountLimit)
                       && (FormMenu.s_switchCount.V14D < s_switchCountLimit)
                       && (FormMenu.s_switchCount.V17D < s_switchCountLimit);
            WarningSym.Visible = !isSafe;
        }

        private void S_switchCount_SwitchCountWarning(object sender, EventArgs e)
        {
            WarningSym.Visible = true;
        }

        private void GioiHan_ThayDoi(object sender, EventArgs e)
        {
            gioiHan_ThayDoi.Invoke(null, EventArgs.Empty);
        }

        public Noi_gao(PLCComm currentComm)
        {
            InitializeComponent();
            CurrentComm = currentComm;
            FormMenu.s_switchCount.SwitchCountWarning += S_switchCount_SwitchCountWarning;
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            AdminConfigGao adminCfg = new AdminConfigGao();
            adminCfg.WarningReset += AdminCfg_WarningReset;
            adminCfg.DatGioiHan += GioiHan_ThayDoi;
            adminCfg.ShowDialog();
        }

        private void Noi_gao_Load(object sender, EventArgs e)
        {
            Power_Light.DiscreteValue1 = FormMenu.s_powerState;
            AutMan_Light.DiscreteValue1 = FormMenu.s_autmanState;
            configButton.Visible = FormMenu.s_isAdmin;

            returnButton.Click += base.returnButton_Click;
            V13.Click += valve_Click;
            V14.Click += valve_Click;
            V17.Click += valve_Click;
            Bom_cap_CIP.Click += pump_Click;
            Bom_sang_Malt.Click += pump_Click;
            Bom_nuoc_hoi.Click += pump_Click;

            Binding bind_V13_State = new Binding("DiscreteValue1", this.CurrentComm, "V13D", false, DataSourceUpdateMode.OnPropertyChanged);
            V13.DataBindings.Add(bind_V13_State);
            Binding bind_V14_State = new Binding("DiscreteValue1", this.CurrentComm, "V14D", false, DataSourceUpdateMode.OnPropertyChanged);
            V14.DataBindings.Add(bind_V14_State);
            Binding bind_V17_State = new Binding("DiscreteValue1", this.CurrentComm, "V17D", false, DataSourceUpdateMode.OnPropertyChanged);
            V17.DataBindings.Add(bind_V17_State);
            Binding bind_BomCapCIP_State = new Binding("DiscreteValue1", this.CurrentComm, "BomCapCIP", false, DataSourceUpdateMode.OnPropertyChanged);
            Bom_cap_CIP.DataBindings.Add(bind_BomCapCIP_State);
            Binding bind_BomSangMalt_State = new Binding("DiscreteValue1", this.CurrentComm, "BomSangMalt", false, DataSourceUpdateMode.OnPropertyChanged);
            Bom_sang_Malt.DataBindings.Add(bind_BomSangMalt_State);
            Binding bind_BomNuocHoi_State = new Binding("DiscreteValue1", this.CurrentComm, "BomNuocHoi", false, DataSourceUpdateMode.OnPropertyChanged);
            Bom_nuoc_hoi.DataBindings.Add(bind_BomNuocHoi_State);

            WarningSym.DiscreteValue1 = true;
            WarningSym.Visible = (FormMenu.s_switchCount.V13D >= s_switchCountLimit)
                       || (FormMenu.s_switchCount.V14D >= s_switchCountLimit)
                       || (FormMenu.s_switchCount.V17D >= s_switchCountLimit);
        }

    }
}
