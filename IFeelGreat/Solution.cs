using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFeelGreat
{
    public class  Solution
    {
        public double maleRatio;
        public double femaleRatio;
        public double maleYes;
        public double maleNo;
        public double femaleYes;
        public double femaleNo;

        public Solution(double _maleRatio,double _maleYes,double _femaleYes)
        {

            maleRatio = _maleRatio;
            maleYes = _maleYes;
            femaleYes = _femaleYes;
           
            femaleRatio = 1- maleRatio;
            maleNo = 1 - maleYes;
            femaleNo = 1 - femaleYes;
            

        }
        public void probabilityNo()
        {   //                           
            double probabilityMaleNo = (maleRatio * maleNo) / ((maleRatio * maleNo) + (femaleRatio * femaleNo));
            double probabilityFemaleNo = (femaleRatio * femaleNo) / ((maleRatio * maleNo) + (femaleRatio * femaleNo));
            
            Console.WriteLine("No/Male Probability: " + String.Format("{0:0.00}",probabilityMaleNo));
            Console.WriteLine("No/Female Probability: " + String.Format("{0:0.00}", probabilityFemaleNo));
        }

        public void probabilityYes()
        {
            double probabilityMaleYes = (maleRatio * maleYes) / ((maleRatio * maleYes) + (femaleRatio * femaleYes));
            double probabilityFemaleYes = (femaleRatio * femaleYes) / ((maleRatio * maleYes) + (femaleRatio * femaleYes));
           
            Console.WriteLine("Yes/Male Probability: " + String.Format("{0:0.00}",probabilityMaleYes));
            Console.WriteLine("Yes/Female Probability: " + String.Format("{0:0.00}",probabilityFemaleYes));
        }


    }
}
