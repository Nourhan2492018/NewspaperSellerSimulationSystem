using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewspaperSellerModels
{
    public class DemandDistribution
    {
        public DemandDistribution()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
        }
        public int Demand { get; set; }

        static decimal[] cumm_probability_counter = { 0, 0, 0 };
        static int[] min_range = { 1, 1, 1 };
        static int[] max_range = { 0, 0, 0 };
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }

       

        //calc demand table distribution
        public static void Make_Demand_Distribution_Table(StreamReader file,List<DemandDistribution> demandDistributions)
        {

            //demand    good   fair  poor  good   fair   poor
            //40        0.03   0.1   0.44  1-3    1-10   1-44
           
            String line;
            String[] strlist;
         

            while (true)
            {
                line = file.ReadLine();
                if (line == null || line.Length == 0)
                    break;
               
                strlist = line.Split(',');
                DemandDistribution demandObj = new DemandDistribution();
                demandObj.Demand = Convert.ToInt32(strlist[0]);

                

                for (int i = 0; i < strlist.Length - 1; i++)
                {
                    DayTypeDistribution obj = new DayTypeDistribution();
                   // DemandDistribution obj = new DemandDistribution();

                    int count= DayTypeDistribution.CheckDayType(i, obj);
                    CalcTableCoulmsDataWithDemand(i , obj, strlist, count);
                   demandObj.DayTypeDistributions.Add(obj);

                }

                demandDistributions.Add(demandObj);
              
               
            }
        }

        public static void CalcTableCoulmsDataWithDemand(int i, DayTypeDistribution obj, String[] strlist,int dayTypeCount)
        {
            //intitial comulative probability


            obj.Probability = Decimal.Parse(strlist[i+1]);

            obj.CummProbability = (obj.Probability) + cumm_probability_counter[dayTypeCount];

            obj.MinRange = min_range[dayTypeCount];

            obj.MaxRange = Decimal.ToInt32(obj.CummProbability * 100);
            
            max_range[dayTypeCount] = obj.MaxRange ;

            min_range[dayTypeCount] = max_range[dayTypeCount] + 1;
            //cumm_probability=cumm_probability[i-1]+prob[i]
            cumm_probability_counter[dayTypeCount] = obj.CummProbability;


        }

        public static int CheckDayTypeForDemand(int i, DayTypeDistribution obj)
        {

            int counter = -1;
            //good
            if (i == 0)
            {
                obj.DayType = Enums.DayType.Good;
                counter = 0;
            }
            //fair
            else if (i == 1)
            {
                obj.DayType = Enums.DayType.Fair;
                counter = 1;
            }
            //poor
            else if (i == 2)
            {
                obj.DayType = Enums.DayType.Poor;
                counter = 2;
            }
            else
                Console.WriteLine("not found");
            return counter;
        }
    }
}