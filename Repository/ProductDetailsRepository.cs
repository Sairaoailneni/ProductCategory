using ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductCategory.Repository
{
    public class ProductDetailsRepository
    {
        string Configuration = ConfigurationManager.ConnectionStrings["ProductConnection"].ConnectionString;


        //This Method is used to Get The All Product data as Grid View
        public DataTable GetData()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Configuration);
                SqlDataAdapter sql = new SqlDataAdapter("select * from Product", sqlConnection);
                DataSet data = new DataSet();
                sql.Fill(data);
                DataTable table = new DataTable();
                table = data.Tables[0];
                return table;
            }
            catch (Exception Ex)
            {
                return new DataTable();
            }
        }

        //This Method is used to Add The New Product data
        public string AddData(ProductDetail productDetail)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Configuration);
                SqlCommand command = new SqlCommand
                ("insert into Product(Product,Category,Mrp,Tax,TaxType,IsActive) values(@Product,@Category,@Mrp,@Tax,@TaxType,@IsActive)", sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("Product", productDetail.Product);
                command.Parameters.AddWithValue("Category", productDetail.Category);
                command.Parameters.AddWithValue("Mrp", productDetail.Mrp);
                command.Parameters.AddWithValue("Tax", productDetail.Tax);
                command.Parameters.AddWithValue("TaxType", productDetail.TaxType);
                command.Parameters.AddWithValue("IsActive", productDetail.IsActive);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                return "Data Saved Successfully";

            }   
            catch (Exception ex)
            {

                return "Data Not Saved Successfully";
            }

        }


        //This Method is used to Update The Existing Product data
        public string UpdateData(ProductDetail productDetail)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Configuration);
                SqlCommand command = new SqlCommand
                    ("update  Product set(Id=@Id,Product=@Product,Category=@Category,Mrp=@Mrp,Tax=@Tax,TaxType=@TaxType,IsActive=@IsActive) where Id=@Id)", sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("Id", productDetail.Id);
                command.Parameters.AddWithValue("Product", productDetail.Product);
                command.Parameters.AddWithValue("Category", productDetail.Category);
                command.Parameters.AddWithValue("Mrp", productDetail.Mrp);
                command.Parameters.AddWithValue("Tax", productDetail.Tax);
                command.Parameters.AddWithValue("TaxType", productDetail.TaxType);
                command.Parameters.AddWithValue("IsActive", productDetail.IsActive);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                return "Data Updated Successfully";

            }
            catch (Exception ex)
            {

                return "Data Not Updated Successfully";
            }

        }



        //This Method is used to Delete The Existing Product data
        public string DeleteData(int Id)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Configuration);
                SqlCommand command = new SqlCommand
                    ("delete from  Product where Id=@Id)", sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("Id",Id);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                return "Data Deleted Successfully";

            }
            catch (Exception ex)
            {

                return "Data Not Deleted Successfully";
            }

        }



        //This Method is used to Delete The Existing Product data
        public ProductDetail GetById(int Id)
        {
            try
            {
                ProductDetail product = new ProductDetail();
                SqlConnection sqlConnection = new SqlConnection(Configuration);
                SqlCommand command = new SqlCommand
                    ("select * from  Product where Id=@Id)", sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("Id", Id);
                SqlDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    product.Id = Convert.ToInt32(dataReader["Id"]);
                    product.Product = Convert.ToString(dataReader["Product"]);
                    product.Category = Convert.ToString(dataReader["Category"]);
                    product.Mrp = Convert.ToInt32(dataReader["Mrp"]);
                    product.Tax = Convert.ToInt32(dataReader["Tax"]);
                    product.TaxType = Convert.ToString(dataReader["TaxType"]);
                    product.IsActive = Convert.ToBoolean(dataReader["IsActive"]);
                }
                dataReader.Close();
                sqlConnection.Close();
                return product;

            }
            catch (Exception ex)
            {

                return null;
            }

        }

    }
}