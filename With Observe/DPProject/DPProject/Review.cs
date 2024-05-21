using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProject.Composite;
using DPProject.State;

namespace DPProject
{
    internal class Review
    {
        List<FactorsConfirms> factorsConfirms = new List<FactorsConfirms>();
        public void ThisReview()
        {
            for (int i = 0; i < factorsConfirms.Count; i++)
            {
                factorsConfirms[i].TheFileIsUnderReview();
            }
            ;

        }
    }
}
