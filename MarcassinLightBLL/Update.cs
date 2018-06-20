﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightDAL;
using MarcassinLightBO;

namespace MarcassinLightBLL
{
    public class Update
    {
        public static void UpdateCompetence(Competence_BO compBO)
        {
            Competence_DAL.UpdCompetence(compBO);
        }
        public static void UpdateLangueCategorie(LangueCategorie_BO lanCat)
        {
            LangueCategorie_DAL.UpdLangueCategorie(lanCat);
        }
        public static void UpdateTrad(string[] trad)
        {
            Competence_DAL.UpdTrad(trad);
        }
    }
}
