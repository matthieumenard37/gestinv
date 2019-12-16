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
		//Méthode users
		public string[] Users()
		{
			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient(); 
			var allUsers = ssc.GetUsers(false);
			string[] users = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
			//string[] users;
			return users;
		}
	}
}