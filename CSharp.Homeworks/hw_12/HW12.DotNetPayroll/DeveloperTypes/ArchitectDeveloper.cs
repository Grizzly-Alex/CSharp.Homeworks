using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW12.DotNetPayroll.Entities;
using HW12.DotNetPayroll.Interfaces;

namespace HW12.DotNetPayroll.DeveloperTypes
{
    sealed class ArchitectDeveloper : Developer, IAbility
    {
        public ArchitectDeveloper(string firstName, string lastName, string gitLink, int expirience, string dayOfBirthday) : base(firstName, lastName, gitLink, expirience, dayOfBirthday)
        {
            SetTilt();
            SetResponsibilities();
            SetTechnologies();
        }

        public void SetResponsibilities()
        {
            Responsibilities.AddRange(ResponsibilitiesBase.architectRespnsibilities);
        }

        public void SetTechnologies()
        {
            Technologies.AddRange(TechnologiesBase.architectTechnologies);
        }

        public void SetTilt()
        {
            Title = DevelopTitles.Architect;
        }
    }
}
