using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;


namespace TestXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

            DataTable dt = new DataTable("Table");

            /* Region, Salesperson Code, Salesperson, Customer, Eq Cases This Month, 
             * Eq Cases This Month LY, Eq Cases % Achieved, Amount This Month, Amount This Month LY, Amount % Achieved, 
             * GM This Month, GM This Month LY, GM % Achieved */
            dt.Columns.Add("Region", typeof(System.String));
            dt.Columns.Add("Salesperson_Code", typeof(System.String));
            dt.Columns.Add("Salesperson", typeof(System.String));
            dt.Columns.Add("Customer_ID", typeof(System.String));
            dt.Columns.Add("Eq_Cases_This_Month", typeof(System.String));
            dt.Columns.Add("Eq_Cases_This_Month_LY", typeof(System.String));
            dt.Columns.Add("EqCasesperc", typeof(System.String));
            dt.Columns.Add("Amount_This_Month", typeof(System.String));
            dt.Columns.Add("Amount_This_Month_LY", typeof(System.String));
            dt.Columns.Add("Amountperc", typeof(System.String));
            dt.Columns.Add("GM_This_Month", typeof(System.String));
            dt.Columns.Add("GM_This_Month_LY", typeof(System.String));
            dt.Columns.Add("GMperc", typeof(System.String));

            string fileName = @"\\ewcweb\reports\CustomerSalesRep.xml";

            XmlDocument doc = new XmlDocument();

            doc.Load(fileName);

            //XmlNode root = doc.SelectSingleNode("/");
            XmlNode root = doc.FirstChild.NextSibling.FirstChild.FirstChild;

            XmlNodeList nodes = root.ChildNodes;
            
        
                for (int ii = 0; ii < nodes.Count; ii++)
                {
                for (int i=0;i<13;i++)
                {
                dt.Rows.Add();
                    dt.Rows[ii][i]=nodes.Item(ii).ChildNodes.Item(i).InnerText;

                }
                    /*dt.Rows[ii]["Salesperson_Code"] = nodes.Item(ii).ChildNodes.Item(1).InnerText;
                    dt.Rows[ii]["Salesperson"] = nodes.Item(ii).ChildNodes.Item(2).InnerText;
                    dt.Rows[ii]["Customer_ID"] = nodes.Item(ii).ChildNodes.Item(3).InnerText;
                    dt.Rows[ii]["Eq_Cases_This_Month"] = nodes.Item(ii).ChildNodes.Item(4).InnerText;
                    dt.Rows[ii]["Eq_Cases_This_Month_LY"] = nodes.Item(ii).ChildNodes.Item(5).InnerText;
                    dt.Rows[ii]["EqCasesperc"] = nodes.Item(ii).ChildNodes.Item(6).InnerText;
                    dt.Rows[ii]["Amount_This_Month"] = nodes.Item(ii).ChildNodes.Item(7).InnerText;
                    dt.Rows[ii]["Amount_This_Month_LY"] = nodes.Item(ii).ChildNodes.Item(8).InnerText;
                    dt.Rows[ii]["Amountperc"] = nodes.Item(ii).ChildNodes.Item(9).InnerText;
                    dt.Rows[ii]["GM_This_Month"] = nodes.Item(ii).ChildNodes.Item(10).InnerText;
                    dt.Rows[ii]["GM_This_Month_LY"] = nodes.Item(ii).ChildNodes.Item(11).InnerText;
                    dt.Rows[ii]["GMperc"] = nodes.Item(ii).ChildNodes.Item(12).InnerText;*/
                }
         


            gv1.DataSource = dt;
            
            

            

        }
    }
}
