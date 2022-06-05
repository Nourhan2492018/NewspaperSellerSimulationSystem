using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }

        public static decimal cumm_probability = 0;

        public static int CheckDayType(int i, DayTypeDistribution obj)
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
            else if (i == 2) { obj.DayType = Enums.DayType.Poor;
                counter = 2;
            }
            else
                Console.WriteLine("not found");
            return counter;
        }
        
        public static void CalcTableCoulmsData(int i,int j, DayTypeDistribution obj, String[] strlist)
        {
            //intitial comulative probability
           

            int min_range = 1;
            obj.Probability = Decimal.Parse(strlist[j]);

            obj.CummProbability = (obj.Probability) + cumm_probability;

            obj.MinRange = min_range;

            obj.MaxRange = Decimal.ToInt32(obj.CummProbability * 100);

            min_range = obj.MaxRange + 1;
            //cumm_probability=cumm_probability[i-1]+prob[i]
            cumm_probability = obj.CummProbability;


        }

        //generate table distribution for day type
        public static void RandomDigitAssignmentDayType(string fileline, List<DayTypeDistribution> listOfDayTypeDistribution)
        {
            // typeNewsDay   prob    comulative_prob  random_digit
            // good           0.35       0.35           1-35


            //get distribution prob
            String[] strlist = fileline.Split(',');
            Console.WriteLine(" ///  "+strlist);


            int i = 0;
            while ( i < strlist.Length)
            {
                DayTypeDistribution obj = new DayTypeDistribution();
                CheckDayType(i, obj);

                CalcTableCoulmsData(i, i, obj, strlist);


                listOfDayTypeDistribution.Add(obj);
                i++;
            }
            Console.WriteLine(listOfDayTypeDistribution.Count);
         

        }
    }
}