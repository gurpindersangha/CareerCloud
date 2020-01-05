using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        {
        }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            string[] requiredEndExtention = new string[] { ".ca", ".com", ".biz" };

            foreach (var poco in pocos)
            {
                if (!requiredEndExtention.Any(t => poco.CompanyWebsite.EndsWith(t)))
                {
                    exceptions.Add(new ValidationException(600, "Website must end with .ca, .com or biz"));
                }

                string[] ContactPhone = poco.ContactPhone.Split('-');
                if (ContactPhone.Length != 3)
                {
                    exceptions.Add(new ValidationException(601, "PhoneNumber for Company website is not in the required format."));
                }
                else if (ContactPhone[0].Length != 3)
                {
                    exceptions.Add(new ValidationException(601, "PhoneNumber for Company website is not in the required format."));
                }
                else if (ContactPhone[1].Length != 3)
                {
                    exceptions.Add(new ValidationException(601, "PhoneNumber for Company website is not in the required format."));
                }
                else if (ContactPhone[2].Length != 4)
                {
                    exceptions.Add(new ValidationException(601, "PhoneNumber for Company website is not in the required format."));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }
}
