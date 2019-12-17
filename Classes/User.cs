using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestinv.ServiceSynchro;

namespace Gestinv.Classes
{
	public class User
	{
		private string _nom;
		public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		private bool _admin;

		public bool Admin
		{
			get { return _admin; }
			set { _admin = value; }
		}

		private bool _state;

		public bool State
		{
			get { return _state; }
			set { _state = value; }
		}

		private User _get;

		public User Get
		{
			get { return _get; }
			set { _get = value; }
		}

		public User(string nom, string password, bool admin, bool state)
		{
			_nom = nom;
			_password = password;
			_admin = admin;
			_state = state;
		}
		public static bool AddUser(ServiceSynchro.User u)
		{
			bool success = false;

			ServiceSynchro.ServiceSynchroClient ssc = new ServiceSynchro.ServiceSynchroClient();
			//A changer quand la connexion indiquera quel user est actuellement connecté
			int SynchroID = ssc.CreateSynchro(7);
			if (ssc.SetUser(-1, u, SynchroID) == 1)
			{
				success = true;
				return success;
			}
			return success;
		}
	}
}
