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
    public class ApplicantJobApplicationRepository : IDataRepository<ApplicantJobApplicationPoco>
    {
        private readonly string _connStr;
        public ApplicantJobApplicationRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
        public void Add(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (ApplicantJobApplicationPoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Applicant_Job_Applications]
                                   ([Id]
                                   ,[Applicant]
                                   ,[Job]                                
                                   ,[Application_Date]
                                   )
                             VALUES
                                   (
                                   @Id,
                                   @Applicant,
                                   @Job,
                                   @Start_Date,
                                   @Appliaction_Date                               
                                  )";

                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    comm.Parameters.AddWithValue("@Job", poco.Job);
                    comm.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
            
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

        public IList<ApplicantJobApplicationPoco> GetAll(params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationPoco> GetList(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"DELETE Applicant_Job_Applications
                                     WHERE [Id]=@Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var poco in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Applicant_Job_Applications]
                                       SET [Id] = @Id
                                          ,[Applicant] = @Applicant
                                          ,[Job] = @Job
                                          ,[Application_Date] = @Application_Date
                                     WHERE [Id]=@Id";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
