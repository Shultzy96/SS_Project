

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

    public class UsersDataAccess
    {
        //ConnectionString that references the Web.config
        private string connectionString = ConfigurationManager.ConnectionStrings["SS"].ConnectionString;

        //Reading all the users in the database table "Users" into a List.
        public List<UserDO> UsersList()
        {
            List<UserDO> userList = new List<UserDO>();

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("VIEW_USERS", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {

                        //Reading the data in each column by column name
                        while (dataReader.Read())
                        {
                            //Creates a New List to store the Users in.
                            UserDO listUsers = new UserDO();
                            listUsers.UserID = (int) dataReader["UserID"];
                            listUsers.ProfileID = (int) dataReader["ProfileID"];
                            listUsers.UserFirstName = (string) dataReader["UserFirstName"];
                            listUsers.UserLastName = (string) dataReader["UserLastName"];
                            listUsers.Email = (string) dataReader["Email"];
                            listUsers.UserName = (string) dataReader["UserName"];
                            listUsers.RoleName = (string) dataReader["RoleName"];
                            listUsers.JobTitle = (string) dataReader["JobTitle"];
                            listUsers.Salary = (decimal) dataReader["Salary"];

                            userList.Add(listUsers);
                        }
                    }
                }

            }
            catch(Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

            return userList;
        }

        //Deletes a Single Entity
        public void DeleteUser(int userToDelete)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("DELETE_USER", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@UserID", userToDelete);
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

        //Call to Register the user into the database
        public void RegisterUser(UserDO register)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using(SqlCommand sqlCommand = new SqlCommand("USER_REGISTER", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@UserFirstName", register.UserFirstName);
                    sqlCommand.Parameters.AddWithValue("@UserLastName", register.UserLastName);
                    sqlCommand.Parameters.AddWithValue("@Email", register.Email);
                    sqlCommand.Parameters.AddWithValue("@UserName", register.UserName);
                    sqlCommand.Parameters.AddWithValue("@Password", register.Password);

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

        //Call to check the credentials of a user in the database for Login
        public LoginDO UserLogin(LoginDO userLogin)
        {

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("USER_LOGIN", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@UserName", userLogin.UserName);
                    sqlCommand.Parameters.AddWithValue("@Password", userLogin.Password);

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            userLogin.UserID = (int) dataReader["UserID"];
                            userLogin.ProfileID = (int) dataReader["ProfileID"];
                            userLogin.UserName = (string) dataReader["UserName"];
                            userLogin.JobTitle = (string)dataReader["JobTitle"];
                            userLogin.RoleName = (string) dataReader["RoleName"];

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

            return userLogin;
        }

        //Call to Update a Users data in the server database
        public void UpdateUser(UserDO update)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE_USER", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@UserID", update.UserID);
                    sqlCommand.Parameters.AddWithValue("@UserFirstName", update.UserFirstName);
                    sqlCommand.Parameters.AddWithValue("@UserLastName", update.UserLastName);
                    sqlCommand.Parameters.AddWithValue("@Email", update.Email);
                    sqlCommand.Parameters.AddWithValue("@UserName", update.UserName);
                    sqlCommand.Parameters.AddWithValue("@RoleName", update.RoleName);
                    sqlCommand.Parameters.AddWithValue("@JobTitle", update.JobTitle);

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

        // User Profiles Database Procdures ------------------------------------------------------------------------------------------------------------------------

        //Reading all the Profile Information in the database table "UserProfiles" into a List.
        public ViewProfileDO ViewProfiles(int profileID)
        {
            ViewProfileDO userProfile = new ViewProfileDO();

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("VIEW_PROFILE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@ProfileID", profileID);

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {

                        //Reads all the data in the UserProfile table by ProfileID.
                        while (dataReader.Read())
                        {
                            userProfile.ProfileID = (int)dataReader["ProfileID"];
                            userProfile.UserFirstName = (string)dataReader["UserFirstName"];
                            userProfile.UserLastName = (string)dataReader["UserLastName"];
                            userProfile.Email = (string)dataReader["Email"];
                            userProfile.UserName = (string)dataReader["UserName"];
                            userProfile.Bio = (string)dataReader["Bio"];
                            userProfile.JobTitle = (string)dataReader["JobTitle"];
                            userProfile.Achievements = (string)dataReader["Achievements"];
                            userProfile.Posts = (string)dataReader["Posts"];
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

            return userProfile;
        }

        //Deletes a User Profile
        public void DeleteProfile(int ProfileID)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("DELETE_PROFILE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@ProfileID", ProfileID);
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

        //Update User Profile
        public void UpdateProfile(ViewProfileDO update, int profileID)
        {

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE_PROFILE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@ProfileID", profileID);
                    sqlCommand.Parameters.AddWithValue("@Bio", update.Bio);
                    sqlCommand.Parameters.AddWithValue("@JobTitle", update.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@Achievements", update.Achievements);
                    sqlCommand.Parameters.AddWithValue("@Posts", update.Posts);

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

        //Create User Profile and Scope ProfileID
        public int CreateProfile(ViewProfileDO create)
        {
            int profileID = 0;

            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("CREATE_PROFILE", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@Bio", create.Bio);
                    sqlCommand.Parameters.AddWithValue("@JobTitle", create.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@Achievements", create.Achievements);
                    sqlCommand.Parameters.AddWithValue("@Posts", create.Posts);
                    profileID = (int)sqlCommand.ExecuteScalar();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                Logger Error = new Logger();
                Error.logErrors(error);
            }
            finally { }

            return profileID;
        }

        //Update User Info with ProfileID Scoped from Profile Insert
        public void UpdateProfileID(string update, int profileID)
        {
            //Try(catch) to open a connection and access the server database
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE_PROFILEID", sqlConnect))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnect.Open();

                    sqlCommand.Parameters.AddWithValue("@UserName", update);
                    sqlCommand.Parameters.AddWithValue("@ProfileID", profileID);

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
