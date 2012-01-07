using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GNN4PortfolioOptimizationClass;

namespace GNN4POConsole
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Po> pos = new List<Po>();

            for (int t = 0; t <= 25; t++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    GNN4PO po1 = new GNN4PO();
                    po1.CalculateA(t);
                    pos.Add(new Po { Column = t + 1, Row = j, Value = po1.a });
                    po1 = null;
                }

                Console.WriteLine(string.Format("i={0}, a1-a5:\r\n{1},{2},{3},{4},{5}", t, pos[5 * t + 0].Value, pos[5 * t + 1].Value, pos[5 * t + 2].Value, pos[5 * t + 3].Value, pos[5 * t + 4].Value));


                //GNN4PO po1 = new GNN4PO();
                //po1.CalculateA(t);
                //GNN4PO po2 = new GNN4PO();
                //po2.CalculateA(t);
                //GNN4PO po3 = new GNN4PO();
                //po3.CalculateA(t);
                //GNN4PO po4 = new GNN4PO();
                //po4.CalculateA(t);
                //GNN4PO po5 = new GNN4PO();
                //po5.CalculateA(t);

                //Console.WriteLine(string.Format("i={0}, a1-a5:\r\n{1},{2},{3},{4},{5}", t, po1.a, po2.a, po3.a, po4.a, po5.a));
                //pos.Add(new Po { Column = t + 1, Row = 1, Value = po1.a });
                //pos.Add(new Po { Column = t + 1, Row = 2, Value = po2.a });
                //pos.Add(new Po { Column = t + 1, Row = 3, Value = po3.a });
                //pos.Add(new Po { Column = t + 1, Row = 4, Value = po4.a });
                //pos.Add(new Po { Column = t + 1, Row = 5, Value = po5.a });
            }
            Console.ReadLine();

            ExcelHelper helper = new ExcelHelper();
            helper.CreateExcel(pos);




        }


    }
}
