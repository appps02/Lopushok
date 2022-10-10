using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lopushok
{
    public class Product
    {
        public string Title;
        public string type;
        public int article;
        public string image;
        public decimal cost;
        public string Materials;

        public Product(string title, string type, int article, string image, decimal cost)
        {
            this.Title = title;
            this.type = type;
            this.article = article;
            this.image = image;
            this.cost = cost;
        }

        public static List<Product> table_class(DataTable table)
        {
            List<Product> list = new List<Product>();
            foreach (DataRow dr in table.Rows)
            {
                int count = 0;
                object[] row = dr.ItemArray;
                Product product = new Product(row[1].ToString(), row[2].ToString(), Convert.ToInt32(row[3]), row[4].ToString(), Convert.ToDecimal(row[5]));
                DataTable dataTable = DB.ListofProductMaterial((int)row[0]);
                foreach (DataRow i in dataTable.Rows)
                {
                    count++;
                    if (count == dataTable.Rows.Count)
                        product.Materials += $"{i.ItemArray[4]}";
                    else
                        product.Materials += $"{i.ItemArray[4]}, ";
                }
                list.Add(product);
            }
            return list;
        }
    }
}
