using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW12.DotNetPayroll.Entities;
using HW12.DotNetPayroll.Interfaces;

namespace HW12.DotNetPayroll.DeveloperTypes
{
    sealed class SeniorDeveloper : Developer, IAbility
    {
        public SeniorDeveloper(string firstName, string lastName, string gitLink, int expirience, string dayOfBirthday) : base(firstName, lastName, gitLink, expirience, dayOfBirthday)
        {
            SetTilt();
            SetResponsibilities();
            SetTechnologies();
        }

        public void SetResponsibilities()
        {
            Responsibilities.AddRange(ResponsibilitiesBase.seniorRespnsibilities);
        }

        public void SetTechnologies()
        {
            Technologies.AddRange(TechnologiesBase.seniorTechnologies);
        }

        public void SetTilt()
        {
            Title = DevelopTitles.Senior;
        }
    }
}
