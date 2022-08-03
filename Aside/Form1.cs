using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aside
{
    public partial class Form1 : Form
    {
        private Boolean btnPanelDashboardState = false;
        private Boolean btnPanelMarketState = false;
        private Boolean btnPanelRealTimeState = false;
        private Boolean btnPanelRateState = false;
        private Boolean btnPanelEconomicState = false;

        public Form1()
        {
            InitializeComponent();

            this.runAsidePanels();
        }

        private void runAsidePanels()
        {
            if (this.btnPanelDashboardState)
            {
                this.btnPanelDashboard.Height = 99;
            }
            else
            {
                this.btnPanelDashboard.Height = 0;
            }

            if (this.btnPanelMarketState)
            {
                this.btnPanelMarket.Height = 99;
            }
            else
            {
                this.btnPanelMarket.Height = 0;
            }

            if (this.btnPanelRealTimeState)
            {
                this.btnPanelRealTime.Height = 66;
            }
            else
            {
                this.btnPanelRealTime.Height = 0;
            }

            if (this.btnPanelRateState)
            {
                this.btnPanelRate.Height = 66;
            }
            else
            {
                this.btnPanelRate.Height = 0;
            }

            if (this.btnPanelEconomicState)
            {
                this.btnPanelEconomic.Height = 66;
            }
            else
            {
                this.btnPanelEconomic.Height = 0;
            }
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            this.btnPanelMarketState = !this.btnPanelMarketState;
            if (this.btnPanelMarketState)
            {
                btnPanelDashboardState = false;
                btnPanelRealTimeState = false;
                btnPanelRateState = false;
                btnPanelEconomicState = false;
            }
            this.runAsidePanels();
        }

        private void btnRealTime_Click(object sender, EventArgs e)
        {
            this.btnPanelRealTimeState = !this.btnPanelRealTimeState;
            if (this.btnPanelRealTimeState)
            {
                btnPanelDashboardState = false;
                btnPanelMarketState = false;
                btnPanelRateState = false;
                btnPanelEconomicState = false;
            }
            this.runAsidePanels();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            this.btnPanelRateState = !this.btnPanelRateState;
            if (this.btnPanelRateState)
            {
                btnPanelDashboardState = false;
                btnPanelMarketState = false;
                btnPanelRealTimeState = false;
                btnPanelEconomicState = false;
            }
            this.runAsidePanels();
        }

        private void btnEconomic_Click(object sender, EventArgs e)
        {
            this.btnPanelEconomicState = !this.btnPanelEconomicState;
            if (this.btnPanelEconomicState)
            {
                btnPanelDashboardState = false;
                btnPanelMarketState = false;
                btnPanelRealTimeState = false;
                btnPanelRateState = false;
            }
            this.runAsidePanels();
        }
    }
}
