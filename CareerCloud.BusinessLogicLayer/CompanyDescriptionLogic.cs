﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
    {
        public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {
        }
        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (CompanyDescriptionPoco poco in pocos)
            {
                if (poco.CompanyDescription.Length < 2)
                {
                    exceptions.Add(new ValidationException(107, "Company description  must be greater than 2 char.."));
                }
                if (poco.CompanyName.Length < 2)
                {
                    exceptions.Add(new ValidationException(106, "Company name  must be greater than 2 char.."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }
}