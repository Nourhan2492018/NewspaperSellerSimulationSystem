using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class PerformanceMeasures
    {
        public void AssigePerformanceMEasuresToZeros()
        {

            TotalCost = 0;
            TotalLostProfit = 0;
            TotalScrapProfit = 0;
            TotalNetProfit = 0;
            DaysWithMoreDemand = 0;
            DaysWithUnsoldPapers = 0;
            TotalSalesProfit = 0;

        }
        public decimal TotalSalesProfit { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLostProfit { get; set; }
        public decimal TotalScrapProfit { get; set; }
        public decimal TotalNetProfit { get; set; }
        public int DaysWithMoreDemand { get; set; }
        public int DaysWithUnsoldPapers { get; set; }

        public void AssigePerformanceMEasuresToValues(int NumOfRecords,
            List<SimulationCase> SimulationTable)
        {
            int j = 0;
            while (j < NumOfRecords)
            {
                SetPerformanceMeasure(SimulationTable[j]);
                j++;
            }
        }
        public void SetPerformanceMeasure(SimulationCase simulationCase)
        {

            TotalScrapProfit += simulationCase.ScrapProfit;
            TotalNetProfit += simulationCase.DailyNetProfit;
            DaysWithMoreDemand += (simulationCase.LostProfit > 0) ? 1 : 0;
            DaysWithUnsoldPapers += (simulationCase.ScrapProfit > 0) ? 1 : 0;
            TotalSalesProfit += simulationCase.SalesProfit;
            TotalCost += simulationCase.DailyCost;
            TotalLostProfit += simulationCase.LostProfit;

        }
    }
}
