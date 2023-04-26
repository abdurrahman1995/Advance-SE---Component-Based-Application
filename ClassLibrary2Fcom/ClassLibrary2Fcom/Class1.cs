using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2Fcom
{
    public class Class2
    {
        //1500 for meterial, 15000 for labar cost
        public double calcustomPChairOAK(double wid, double hei) => (((wid * hei) * 1500) +15000);
        //1500 for meterial, 20000 for labar cost
        public double calcustomPTableOAK(double wid, double hei) => (((wid * hei) * 1500)+ 20000);
        //1500 for meterial, 30000 for labar cost
        public double calcustomPBedOAK(double wid, double hei) => (((wid * hei) * 1500) + 30000);
        //1500 for meterial, 45000 for labar cost
        public double calcustomPCubOAK(double wid, double hei) => (((wid * hei) * 1500) + 45000);
        //////////
        ///
        public double calcustomPChairTEAK(double wid, double hei) => (((wid * hei) * 2000) + 25000);
        //1500 for meterial, 20000 for labar cost
        public double calcustomPTableTEAK(double wid, double hei) => (((wid * hei) * 2000) + 35000);
        //1500 for meterial, 30000 for labar cost
        public double calcustomPBedTEAK(double wid, double hei) => (((wid * hei) * 2000) + 40000);

        //1500 for meterial, 45000 for labar cost
        public double calcustomPCubTEAK(double wid, double hei) => (((wid * hei) * 1500) + 50000);
        ////////
        ///
        public double calcustomPChairMAP(double wid, double hei) => (((wid * hei) * 1800) + 20000);
        //1500 for meterial, 20000 for labar cost
        public double calcustomPTableMAP(double wid, double hei) => (((wid * hei) * 1800) + 35000);
        //1500 for meterial, 30000 for labar cost
        public double calcustomPBedMAP(double wid, double hei) => (((wid * hei) * 1800) + 45000);
        //1500 for meterial, 45000 for labar cost
        public double calcustomPCubMAP(double wid, double hei) => (((wid * hei) * 1800) + 55000);
    }
}
