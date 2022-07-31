using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW12.DotNetPayroll.Entities;
using HW12.DotNetPayroll.Interfaces;

namespace HW12.DotNetPayroll.DeveloperTypes
{
    sealed class MiddleDeveloper : Developer, IAbility
    {
        public MiddleDeveloper(string firstName, string lastName, string gitLink, int expirience, string dayOfBirthday) : base(firstName, lastName, gitLink, expirience, dayOfBirthday)
        {
            SetTilt();
            SetResponsibilities();
            SetTechnologies();
        }

        public void SetResponsibilities()
        {
            Responsibilities.AddRange(ResponsibilitiesBase.middleRespnsibilities);
        }

        public void SetTechnologies()
        {
            Technologies.AddRange(TechnologiesBase.middleTechnologies);
        }

        public void SetTilt()
        {
            Title = DevelopTitles.Middle;
        }
    }
}