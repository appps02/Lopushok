using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lopushok
{
    public class DB
    {
        public static SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Lopushok"].ConnectionString);

        public SqlCommand cmd;

        public DB()
        {
            Connection.Open();
            cmd = new SqlCommand("", Connection);
        }
        public DataTable Products()
        {
            return Data_Table(@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID] ORDER BY [Product].[ID] ASC");
        }
        public DataTable Products_Order(string column, string order)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID] ORDER BY {column} {order}");
        }

        public DataTable Products_Search(string state)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [Product].[Title] LIKE '%{state}%'
                                ORDER BY [Product].[ID] ASC");
        }

        public DataTable Products_Type(string type)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [ProductType].[Title] = '{type}'
                                ORDER BY [Product].[ID] ASC");
        }

        public DataTable Products_Order_Search(string column, string order, string state)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [Product].[Title] LIKE '%{state}%'
                                ORDER BY {column} {order}");
        }

        public DataTable Products_Order_Type(string column, string order, string type)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [ProductType].[Title] = '{type}'
                                ORDER BY {column} {order}");
        }

        public DataTable Products_Search_Type(string state, string type)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [Product].[Title] LIKE '%{state}%' AND [ProductType].[Title] = '{type}'
                                ORDER BY [Product].[ID] ASC");
        }

        public DataTable Products_Search_Type_Order(string state, string type, string column, string order)
        {
            return Data_Table($@"SELECT [Product].[ID], [Product].[Title] as [Title], [ProductType].[Title] as [ProductType], [Product].[ArticleNumber], [Product].[Image], [Product].[MinCostForAgent]
                                FROM [Product]
                                INNER JOIN [ProductType] ON [ProductType].[ID] = [Product].[ProductTypeID]
                                WHERE [Product].[Title] LIKE '%{state}%' AND [ProductType].[Title] = '{type}'
                                ORDER BY {column} {order}");
        }

        public static DataTable ListofProductMaterial(int productID)
        {
            return Data_Table($@"SELECT * FROM [ProductMaterial]
                                INNER JOIN [Material] on [Material].[ID] = [ProductMaterial].[MaterialID]
                                WHERE ProductID = {productID}");
        }
        public static DataTable Data_Table(string cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, Connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}
