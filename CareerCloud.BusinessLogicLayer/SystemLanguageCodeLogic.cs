using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic : SystemLanguageCodePoco
    {
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository)
        {
        }
        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (SystemLanguageCodePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, "Longuge id cannot be empty"));
                }
                if (String.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001, "Name cannot be empty"));
                }
                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, "Native name cannot be empty"));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        public void Get(SystemLanguageCodePoco[] pocos)
        {
        }
        public void GetAll(SystemLanguageCodePoco[] pocos)
        {
        }
        public void Delete(SystemLanguageCodePoco[] pocos)
        {  
        }

        public void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Add(pocos);
        }
        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Update(pocos);
        }
    }
}