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
			var tailleSsc = ssc.GetUsers(false);
			string[] users;
			foreach (var item in tailleSsc)
			{
				//nourir le tableau
			}
			return users;
		}
	}
}
