
namespace DataAccessLayer
{
    using DataAccessLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UtilityLogger;

    public class ManagementDataAccess
    {
        //ConnectionString that references the Web.config
        private string connectionString = ConfigurationManager.ConnectionStrings["SS"].ConnectionString;

        //Reading all the users in the database table "Users" into a List.
        public List<PayrollDO> PayrollList()
        {
            List<PayrollDO> payList = new List<PayrollDO>();

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("VIEW_PAYROLL", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {

                        //Reading the data in each column by column name
                        while (dataReader.Read())
                        {
                            //Creates a New List to store the Users in.
                            PayrollDO listPay = new PayrollDO();
                            listPay.PayrollID = (int)dataReader["PayrollID"];
                            listPay.JobTitle = (string)dataReader["JobTitle"];
                            listPay.JobDescription = (string)dataReader["JobDescription"];
                            listPay.HourlyRate = (decimal)dataReader["HourlyRate"];
                            listPay.Salary = (decimal)dataReader["Salary"];

                            payList.Add(listPay);
                        }
                    }
                }

            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

            return payList;
        }

        //Deletes a Single Entity
        public void DeletePayrollItem(int payToDelete)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("DELETE_PAYROLL_ITEM", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@PayrollID", payToDelete);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }

        //Call to Create a Payroll Item in the database
        public void CreatePayrollItem(PayrollDO payCreate)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("CREATE_PAYROLL_ITEM", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@JobTitle", payCreate.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@JobDescription", payCreate.JobDescription);
                    sqlCommand.Parameters.AddWithValue("@HourlyRate", payCreate.HourlyRate);
                    sqlCommand.Parameters.AddWithValue("@Salary", payCreate.Salary);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }

        //Call to Update Payroll data in the server database
        public void UpdatePayroll(PayrollDO update)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE_PAYROLL_ITEM", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@PayrollID", update.PayrollID);
                    sqlCommand.Parameters.AddWithValue("@JobTitle", update.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@JobDescription", update.JobDescription);
                    sqlCommand.Parameters.AddWithValue("@HourlyRate", update.HourlyRate);
                    sqlCommand.Parameters.AddWithValue("@Salary", update.Salary);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------//

        public List<RoleDO> RoleList()
        {
            List<RoleDO> roleList = new List<RoleDO>();

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("VIEW_ROLES", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {

                        //Reading the data in each column by column name
                        while (dataReader.Read())
                        {
                            //Creates a New List to store the Users in.
                            RoleDO listRole = new RoleDO();
                            listRole.RoleID = (int)dataReader["RoleID"];
                            listRole.RoleName = (string)dataReader["RoleName"];
                            listRole.RoleDescription = (string)dataReader["RoleDescription"];
                           
                            roleList.Add(listRole);
                        }
                    }
                }

            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

            return roleList;
        }

        //Deletes a Single Entity
        public void DeleteRole(int roleToDelete)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("DELETE_ROLE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@RoleID", roleToDelete);
                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }

        //Call to Create a Payroll Item in the database
        public void CreateRole(RoleDO roleCreate)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("CREATE_ROLE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@RoleName", roleCreate.RoleName);
                    sqlCommand.Parameters.AddWithValue("@RoleDescription", roleCreate.RoleDescription);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }

        //Call to Update Payroll data in the server database
        public void UpdateRoles(RoleDO update)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE_ROLE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@RoleID", update.RoleID);
                    sqlCommand.Parameters.AddWithValue("@RoleName", update.RoleName);
                    sqlCommand.Parameters.AddWithValue("@RoleDescription", update.RoleDescription);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

        }


    }
}
