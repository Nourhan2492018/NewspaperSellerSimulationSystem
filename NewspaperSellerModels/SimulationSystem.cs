using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        Random rnd ;
    
        SimulationCase simulationCase;
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
            rnd = new Random();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        ///////////// FUNCTIONS /////////////

        public static bool checkDemand(int Demand, int NumNewspapers)
        {
            if (Demand > NumNewspapers)
            {
                return true;
            }
            return false;
        }
        public int getDayNumber(int index)
        {

            return index + 1;
        }
        public decimal getDailyCost( int NumOfNewspapers, decimal PurchasePrice)
        {
            return NumOfNewspapers * PurchasePrice;
        }
        public SimulationCase getRecord( int i)
        {
            int min = 0;
            int max = 100;

            Random rnd = new Random();
            SimulationCase simulationCase = new SimulationCase();
            simulationCase.DayNo = getDayNumber(i);

            simulationCase.RandomNewsDayType = rnd.Next(0, 100);
            int dayType = Check_Range(DayTypeDistributions, simulationCase.RandomNewsDayType);
            simulationCase.NewsDayType = DayTypeDistributions[dayType].DayType;

            simulationCase.RandomDemand = rnd.Next(0, 100);
            simulationCase.Demand = getDemandAfterCheckRang(DemandDistributions, simulationCase.RandomDemand, simulationCase.NewsDayType);

            simulationCase.DailyCost = NumOfNewspapers * PurchasePrice;

            simulationCase.SalesProfit = Math.Min(simulationCase.Demand, NumOfNewspapers) * SellingPrice;

            if (checkDemand(simulationCase.Demand, NumOfNewspapers)==true)
            {
                simulationCase.LostProfit = ((simulationCase.Demand * SellingPrice) -
                (simulationCase.Demand * PurchasePrice)) - ((NumOfNewspapers * SellingPrice) - (NumOfNewspapers * PurchasePrice));
                
            }
            else
            {
                simulationCase.LostProfit = 0;

            }


            // ((Demand * SellingPrice) - (Demand * PurchasePrice)) - ((N * SellingPrice) - (N * PurchasePrice))
            // Math.Max(simulationCase.Demand - NumOfNewspapers, 0) *( SellingPrice -
            // Math.Max(simulationCase.Demand - NumOfNewspapers, 0)) *PurchasePrice;

            simulationCase.ScrapProfit = Math.Max(NumOfNewspapers - simulationCase.Demand, 0) * ScrapPrice;

            simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost
                - simulationCase.LostProfit + simulationCase.ScrapProfit;
            return simulationCase;
        }
       public void bulidTableOfSimulation()
        {
            int min = 0;
            int max = 100;
            int i = 0;
            while ( i < NumOfRecords)
            {
                simulationCase = getRecord(i);
                SimulationTable.Add(simulationCase);
                i++;
            }
        }

        // return index of day
        public static int Check_Range(List<DayTypeDistribution> table,
            int random_Rang)
        {
            int i = 0;
            int size_table = table.Count();
            while ( i < size_table)
            {
                if (random_Rang <= table[i].MaxRange && random_Rang >= table[i].MinRange)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        //checkDayType
        public static int checkDayType(Enums.DayType type)
        {
            int index=-1;
            if (type == Enums.DayType.Good)
                index = 0;
            else if (type == Enums.DayType.Fair)
                index = 1;
            else if (type == Enums.DayType.Poor)
                index = 2;
            
            return index;
        }
        // check rang
        public static bool checkRang(List<DemandDistribution> table,
            int randomRang, int i,int index)
        {
            if (randomRang >= table[i].DayTypeDistributions[index].MinRange)
                if(randomRang <= table[i].DayTypeDistributions[index].MaxRange)
                    return true;

            return false;

        }
        // return demand
        public static int getDemand(List<DemandDistribution> table,
            int randomRang,int index)
        {
            int i = 0;
            int sizeTable = table.Count();
            while (i < sizeTable)
            {
                if (checkRang(table, randomRang,  i,  index)== true)
                {
                    return table[i].Demand;
                }
                i++;
            }
            return -1;
        }
        public static int getDemandAfterCheckRang(List<DemandDistribution> table, 
            int randomRang, Enums.DayType dayType)
        {
            int index,demand;
            if(checkDayType(dayType)!=-1)
            {
                index = checkDayType(dayType);
                demand = getDemand(table, randomRang, index);
                if(demand!=-1)
                {
                    return demand;
                }

            }
            return -1;
        }
        public void buildTableOfPerformanceMEasures()
        {
           PerformanceMeasures.AssigePerformanceMEasuresToZeros();
           PerformanceMeasures.AssigePerformanceMEasuresToValues(NumOfRecords,SimulationTable);
        }
    }
}