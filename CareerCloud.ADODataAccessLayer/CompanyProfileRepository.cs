using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : IDataRepository<CompanyProfilePoco>
    {
        private readonly string _connStr;
        public CompanyProfileRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
        public void Add(params CompanyProfilePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (CompanyProfilePoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Company_Profiles]
                                   ([Id]
                                   ,[Registration_Date]
                                   ,[Company_Website]
                                   ,[Contact_Phone]
                                   ,[Contact_Name]
                                   ,[Company_Logo]
                             VALUES
                                   (
                                   @Id,
                                   @Registration_Date,
                                   @Company_Website,
                                   @Contact_Phone,
                                   @Contact_Name,
                                   @Company_logo,
                                  )";

                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Registration_Date", poco.RegistrationDate);
                    comm.Parameters.AddWithValue("@Company_Website", poco.CompanyWebsite);
                    comm.Parameters.AddWithValue("@Contact_Phone", poco.ContactPhone);
                    comm.Parameters.AddWithValue("@Contact_Name", poco.ContactName);
                    comm.Parameters.AddWithValue("@Company_Logo", poco.CompanyLogo);

                    connection.Open();
                    int rowEffected = comm.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfilePoco> GetAll(params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfilePoco> GetList(Expression<Func<CompanyProfilePoco, bool>> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyProfilePoco GetSingle(Expression<Func<CompanyProfilePoco, bool>> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
