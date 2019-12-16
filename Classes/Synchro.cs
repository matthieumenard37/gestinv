using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestinv.Classes
{
	class Synchro
	{
		//Dans notre classe synchro, la propriété users contient un tableau de tous les users venant de l'api
		//Méthode Users = renvoie soit tous les user ou juste les actifs
		public static ServiceSynchro.User[] Users(bool all)
		{
			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient(); 
			var allUsers = ssc.GetUsers(false);
			var actUsers = ssc.GetUsers(true);
			if (all)
			{
				return allUsers;
			}
			else
				return actUsers;
		}
	}
}