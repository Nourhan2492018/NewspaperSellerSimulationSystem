using NewspaperSellerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SimulationSystem simulationSystem = new SimulationSystem();
        public Form2(SimulationSystem simulationSystem)
        {
            InitializeComponent();
            this.simulationSystem = simulationSystem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMeaseres()
        {
            TotalCost.Text = simulationSystem.PerformanceMeasures.TotalCost.ToString();
            TotalLostProfit.Text = simulationSystem.PerformanceMeasures.TotalLostProfit.ToString();
            TotalNetProfit.Text = simulationSystem.PerformanceMeasures.TotalNetProfit.ToString();
            TotalSalesProfit.Text = simulationSystem.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalScrapProfit.Text = simulationSystem.PerformanceMeasures.TotalScrapProfit.ToString();
            DaysWithMoreDemand.Text = simulationSystem.PerformanceMeasures.DaysWithMoreDemand.ToString();
            DaysWithUnsoldPapers.Text = simulationSystem.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMesures_Click(object sender, EventArgs e)
        {
            DisplayMeaseres();
        }
    }
}
