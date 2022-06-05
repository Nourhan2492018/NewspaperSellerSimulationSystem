using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace NewspaperSellerModels
{
    public class SystemReadFile
    {
        static StreamReader file;
        private static void ReadPurchasePrice(string line , SimulationSystem simulationSystem)
        {
            simulationSystem.PurchasePrice = Decimal.Parse(line);
        }
        private static void ReadNumOfRecords(string line, SimulationSystem simulationSystem)
        {
            simulationSystem.NumOfRecords = Int32.Parse(line);
        }
        private static void ReadNumOfNewspapers(string line, SimulationSystem simulationSystem)
        {
            simulationSystem.NumOfNewspapers = Int32.Parse(line);
        }
        private static string line = " ";
        public static void ReadFileTestCaseInputs(SimulationSystem simulationSystem, String path)
        {
            
            file = new StreamReader(path);
            
            while ((line = file.ReadLine()) != null)
            {

                //get NumOfNewspapers
                if (line.Equals("NumOfNewspapers"))
                {
                    ReadNumOfNewspapers(file.ReadLine(), simulationSystem);
                }
                //get NumOfRecords
                else if (line.Equals("NumOfRecords"))
                { 
                    ReadNumOfRecords(file.ReadLine(), simulationSystem);


                }
                //get PurchasePrice
                else if (line.Equals("PurchasePrice"))
                {
                    ReadPurchasePrice(file.ReadLine(), simulationSystem);
                }
                //get ScrapPrice
                else if (line.Equals("ScrapPrice"))
                {
                    
                    ReadScrapPrice(file.ReadLine(), simulationSystem);


                }
                //get SellingPrice
                else if (line.Equals("SellingPrice"))
                {
                   
                    ReadSellingPrice(file.ReadLine(), simulationSystem);


                }
                //get DayTypeDistributions
                else if (line.Equals("DayTypeDistributions"))
                {
                    ReadDayTypeDistributions(file.ReadLine(), simulationSystem);
                }
                //get DemandDistributions
                else if (line.Equals("DemandDistributions"))
                {
                    ReadDemandDistributions(simulationSystem);
                }

              /*  Console.WriteLine(simulationSystem.NumOfNewspapers);
                Console.WriteLine(simulationSystem.NumOfRecords);
                Console.WriteLine(simulationSystem.PurchasePrice);
                Console.WriteLine(simulationSystem.ScrapPrice);
                Console.WriteLine(simulationSystem.SellingPrice);
                Console.WriteLine(line2);*/
            }

            file.Close();
        }
        private static void ReadScrapPrice(string line, SimulationSystem simulationSystem)
        {
            simulationSystem.ScrapPrice = Decimal.Parse(line);
        }
        private static void ReadSellingPrice(string line, SimulationSystem simulationSystem)
        {
            simulationSystem.SellingPrice = Decimal.Parse(line);
        }
        private static void ReadDayTypeDistributions(string line,SimulationSystem simulationSystem)
        {
            DayTypeDistribution.RandomDigitAssignmentDayType(line, simulationSystem.DayTypeDistributions);


        }
        private static void ReadDemandDistributions(SimulationSystem simulationSystem)
        {
            DemandDistribution.Make_Demand_Distribution_Table(file, simulationSystem.DemandDistributions);

        }


    }
}

   
