using FISCA;
using FISCA.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineNamed
{
    public class Program
    {
        [MainMethod()]
        static public void Main()
        {
            tool._A.Select<AbsenceUDT>();
            tool._A.Select<RollCallLog>();

            ServerModule.AutoManaged("http://module.ischool.com.tw/module/138/OnlineNamed/udm.xml");

            RibbonBarItem Print = FISCA.Presentation.MotherForm.RibbonBarItems["學務作業", "APP線上點名"];
            Print["點名節次缺曠別設定"].Click += delegate
            {
                ConfigFrom cf = new ConfigFrom();
                cf.ShowDialog();

            };




        }
    }
}
