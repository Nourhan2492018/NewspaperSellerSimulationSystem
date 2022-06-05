using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        string pathTestCaseFile = "";
        SimulationSystem simulationSystem;
        public Form1()
        {
            InitializeComponent();
            comboBoxTestCase.Items.Add("Test Case One");
            comboBoxTestCase.Items.Add("Test Case Two");
            comboBoxTestCase.Items.Add("Test Case Three");
            simulationSystem = new SimulationSystem();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ResultTestCaseOne()
        {
            SystemReadFile.ReadFileTestCaseInputs(this.simulationSystem, pathTestCaseFile);
            this.simulationSystem.bulidTableOfSimulation();
            this.simulationSystem.buildTableOfPerformanceMEasures();
            string result = TestingManager.Test(this.simulationSystem,
            Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            InitialGridView();
            FillTale();
        }
        private void ResultTestCaseTwo()
        {
            this.simulationSystem = new SimulationSystem();
            SystemReadFile.ReadFileTestCaseInputs(this.simulationSystem,
                this.pathTestCaseFile);
            this.simulationSystem.bulidTableOfSimulation();
            this.simulationSystem.buildTableOfPerformanceMEasures();
            string result = TestingManager.Test(this.simulationSystem,
          Constants.FileNames.TestCase2);
            MessageBox.Show(result);
            InitialGridView();
            FillTale();
        }
        private void ResultTestCaseThree()
        {
            SystemReadFile.ReadFileTestCaseInputs(this.simulationSystem,
                     this.pathTestCaseFile);
            this.simulationSystem.bulidTableOfSimulation();
            this.simulationSystem.buildTableOfPerformanceMEasures();
            string result = TestingManager.Test(this.simulationSystem,
          Constants.FileNames.TestCase3);
            MessageBox.Show(result);
            InitialGridView();
            FillTale();
        }
        private void buttonSimulationClick(object sender, EventArgs e)
        {

            if (pathTestCaseFile.Equals(""))
            {
                MessageBox.Show("Please Enter Choose Test Case.........");
                //this.simulationSystem = new SimulationSystem();
            }
            else
            {

                if (comboBoxTestCase.SelectedItem.ToString() == "Test Case One")
                {

                    //this.simulationSystem = new SimulationSystem();
                    ResultTestCaseOne();
                    //this.pathTestCaseFile = "";
                    //this.simulationSystem = new SimulationSystem();

                }
                else if (comboBoxTestCase.SelectedItem.ToString() == "Test Case Two")
                {
                    ResultTestCaseTwo();
                    //this.pathTestCaseFile = "";
                    //  this.simulationSystem = new SimulationSystem();

                }
                else if (comboBoxTestCase.SelectedItem.ToString() == "Test Case Three")
                {
                    //this.simulationSystem = new SimulationSystem();
                    ResultTestCaseThree();
                    //this.pathTestCaseFile = "";
                    //this.simulationSystem = new SimulationSystem();

                }
               
                //this.simulationSystem = new SimulationSystem();
                //this.pathTestCaseFile ="";
            }    
        }
        private void InitialGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(this.simulationSystem.NumOfRecords);
        }
        private void FillTale()
        {

            int i = 0;
            while (i < this.simulationSystem.NumOfRecords)
            {
                FillRow(i);
                i++;
            }
            

        }
        private void FillRow(int index)
        {

            dataGridView1.Rows[index].Cells["Day"].Value = this.simulationSystem.SimulationTable[index].DayNo;
            dataGridView1.Rows[index].Cells["RandomNewsDayType"].Value = this.simulationSystem.SimulationTable[index].RandomNewsDayType;
            dataGridView1.Rows[index].Cells["NewsDayType"].Value = this.simulationSystem.SimulationTable[index].NewsDayType;
            dataGridView1.Rows[index].Cells["RandomDemand"].Value = this.simulationSystem.SimulationTable[index].RandomDemand;
            dataGridView1.Rows[index].Cells["Demand"].Value = this.simulationSystem.SimulationTable[index].Demand;
            dataGridView1.Rows[index].Cells["DailyCost"].Value = this.simulationSystem.SimulationTable[index].DailyCost;
            dataGridView1.Rows[index].Cells["SalesProfit"].Value = this.simulationSystem.SimulationTable[index].SalesProfit;
            dataGridView1.Rows[index].Cells["LostProfit"].Value = this.simulationSystem.SimulationTable[index].LostProfit;
            dataGridView1.Rows[index].Cells["ScrapProfit"].Value = this.simulationSystem.SimulationTable[index].ScrapProfit;
            dataGridView1.Rows[index].Cells["DailyNetProfit"].Value = this.simulationSystem.SimulationTable[index].DailyNetProfit;

        }


        private void buttonMeauresClick(object sender, EventArgs e)
        {

            if (pathTestCaseFile.Equals(""))
            {
                MessageBox.Show("Please Select test Case Wont Run Now.........");

            }
            else
            {

                
                Form2 form2 = new Form2(simulationSystem);
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
           
        }

        private void ComboBoxTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.simulationSystem = new SimulationSystem();
            this.pathTestCaseFile = "";
            if (comboBoxTestCase.SelectedItem.ToString() == "Choose Test Case")
            {
                 MessageBox.Show("Please Select test Case Wont Run Now.........");

            }
            else
            {
                if (comboBoxTestCase.SelectedItem.ToString() == "Test Case One")
                {

                    pathTestCaseFile = "C:\\Users\\Norhan\\Desktop\\Modeling Tasks\\TaskTwo\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase1.txt";
                    MessageBox.Show("Now You Run Test Case One .........");

                    /*ReadFileController.ReadFileTestCaseInputs(this.simulationSystem, pathTestCaseFile);
                    this.simulationSystem.bulidTableOfSimulation();
                    this.simulationSystem.buildTableOfPerformanceMEasures();
                    string result = TestingManager.Test(this.simulationSystem,
                        Constants.FileNames.TestCase1);
                    MessageBox.Show(result);*/
                }
                else if (comboBoxTestCase.SelectedItem.ToString() == "Test Case Two")
                {

                    pathTestCaseFile = "C:\\Users\\Norhan\\Desktop\\Modeling Tasks\\TaskTwo\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase2.txt";
                    MessageBox.Show("Now You Run Test Case Two .........");

                }
                else if (comboBoxTestCase.SelectedItem.ToString() == "Test Case Three")
                {

                    pathTestCaseFile = "C:\\Users\\Norhan\\Desktop\\Modeling Tasks\\TaskTwo\\NewspaperSellerSimulation_Students\\NewspaperSellerSimulation\\TestCases\\TestCase3.txt";
                    MessageBox.Show("Now You Run Test Case Three .........");

                    /*ReadFileController.ReadFileTestCaseInputs(this.simulationSystem, pathTestCaseFile);
                    this.simulationSystem.bulidTableOfSimulation();
                    this.simulationSystem.buildTableOfPerformanceMEasures();
                    string result = TestingManager.Test(this.simulationSystem,
                        Constants.FileNames.TestCase3);
                    MessageBox.Show(result);*/
                }
            }

        }
    }
}
