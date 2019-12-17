using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestinv.Classes
{
	class Synchro
    {
        public static ServiceSynchro.Family[] DownloadFamilies()
        {
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.Family[] result = ssc.GetFamilies(true);
            return result;
        }

        private static ServiceSynchro.Article[] DownloadArticlesPerFamily(int FamilyID)
        {
            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.Article[] result = ssc.GetArticles(FamilyID, true);
            return result;
        }

        public static ServiceSynchro.Article[] DownloadArticles()
        {
            ServiceSynchro.Family[] Families = DownloadFamilies();
            ServiceSynchro.Article[] Articles = new ServiceSynchro.Article[] { };
            ServiceSynchro.Article[] temp = new ServiceSynchro.Article[] { };
            foreach (ServiceSynchro.Family family in Families)
            {
                temp = DownloadArticlesPerFamily(family.Id);
                foreach (ServiceSynchro.Article article in temp)
                {
                    int arrayLength = Articles.Length;
                    Array.Resize(ref Articles, arrayLength + 1);
                    Articles[arrayLength] = article;
                }
            }
            return Articles;
        }

        public static void Upload(ServiceSynchro.Article[] Articles_Local, int UserID)
        {

            ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
            ServiceSynchro.Article[] Articles_Remote = DownloadArticles();

            //initie la synchro
            int synchroID = ssc.CreateSynchro(UserID);

            //parcours chaque article en ligne
            foreach (ServiceSynchro.Article articleEnCours_Remote in Articles_Remote)
            {
                //pour chaque article en ligne, parcours les articles locaux pour trouver le correspondant
                foreach(ServiceSynchro.Article articleEnCours_Local in Articles_Local)
                {
                    if(articleEnCours_Local.Id == articleEnCours_Remote.Id)
                    {
                        //vérifie si la quantité à changé
                        if(articleEnCours_Local.Quantity != articleEnCours_Remote.Quantity)
                        {
                            ssc.UpdateStock(articleEnCours_Local.Id, articleEnCours_Local.Quantity, synchroID);
                        }
                    }
                }
            }
        }


    }
}