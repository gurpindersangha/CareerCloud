﻿using CareerCloud.DataAccessLayer;
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
    public class ApplicantProfileRepository : IDataRepository<ApplicantProfilePoco>
    {
        private readonly string _connStr;
        public ApplicantProfileRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
        public void Add(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (ApplicantProfilePoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Applicant_Profiles]
                                   ([Id]
                                   ,[Login]
                                   ,[Current_Salary]
                                   ,[Current_Rate]
                                   ,[Currency]
                                   ,[Country_Code]
                                   ,[State_Province_Code]
                                   ,[Street_Address]
                                   ,[City_Town]
                                   ,[Zip_Postal_Code])
                             VALUES
                                   (
                                   @Id,
                                   @Login,
                                   @Current_Salary,
                                   @Current_Rate,
                                   @Currency,
                                   @Country_Code,
                                   @State_Province_Code,
                                   @Street_Address,
                                   @City_Town,
                                   @Zip_Postal_Code
                                  )";

                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Login", poco.Login);
                    comm.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                    comm.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                    comm.Parameters.AddWithValue("@Currency", poco.Currency);
                    comm.Parameters.AddWithValue("@Country_Code", poco.Country);
                    comm.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    comm.Parameters.AddWithValue("@Street_Address", poco.Street);
                    comm.Parameters.AddWithValue("@City_Town", poco.City);
                    comm.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

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

        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
