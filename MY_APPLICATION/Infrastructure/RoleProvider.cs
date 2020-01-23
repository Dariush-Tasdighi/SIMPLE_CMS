using System.Linq;
//using System.Data.Entity;

namespace Infrastructure
{
	public class RoleProvider : System.Web.Security.RoleProvider
	{
		public RoleProvider()
		{
			//ApplicationName = "Dtx Application";
		}

		public override string Name
		{
			get
			{
				return "DtxRoleProvider";
			}
		}

		public override string Description
		{
			get
			{
				return "Dtx Role Provider";
			}
		}

		private string applicationName;

		public override string ApplicationName
		{
			get
			{
				return applicationName;
			}
			set
			{
				applicationName = value;
			}
		}

		public override string[] GetAllRoles()
		{
			return null;
		}

		public override bool RoleExists(string roleName)
		{
			return false;
		}

		public override void CreateRole(string rolename)
		{
		}

		public override string[] GetUsersInRole(string roleName)
		{
			return null;
		}

		public override string[] GetRolesForUser(string username)
		{
			if (username == null)
			{
				return null;
			}

			username =
				username.Replace(" ", string.Empty);

			if (username == string.Empty)
			{
				return null;
			}

			// **************************************************
			// TODO
			// در نسخه‌های بعدی باید حذف شود

			if (username.ToLower() == "Dariush".ToLower())
			{
				string[] roles = new string[1];

				roles[0] = "Administrator";

				return roles;
			}

			return null;
			// **************************************************

			//Models.DatabaseContext databaseContext = null;

			//try
			//{
			//	databaseContext =
			//		new Models.DatabaseContext();

			//	Models.User user =
			//		databaseContext.Users
			//		.Where(current => string.Compare(current.Username, username, true) == 0)
			//		.FirstOrDefault();

			//	if (user == null)
			//	{
			//		return null;
			//	}

			//	if (user.IsActive == false)
			//	{
			//		return null;
			//	}

			//	if (user.IsAdministrator == false)
			//	{
			//		roles[0] = Roles.USER;
			//	}
			//	else
			//	{
			//		roles[0] = Roles.ADMINISTRATOR;
			//	}

			//	return roles;
			//}
			//catch (System.Exception ex)
			//{
			//	Dtx.Logger.LogError
			//		(type: GetType(), exception: ex);
			//}
			//finally
			//{
			//	if (databaseContext != null)
			//	{
			//		databaseContext.Dispose();
			//		databaseContext = null;
			//	}
			//}

			return null;
		}

		public override bool IsUserInRole(string userName, string roleName)
		{
			return false;
		}

		public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
		{
			return false;
		}

		public override void AddUsersToRoles(string[] usernames, string[] rolenames)
		{
		}

		public override void RemoveUsersFromRoles(string[] userNames, string[] roleNames)
		{
		}

		public override string[] FindUsersInRole(string rolename, string userNameToMatch)
		{
			return null;
		}

		public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config)
		{
			try
			{
				if (config == null)
				{
					throw new System.ArgumentNullException(Name + " config is null!");
				}

				if (string.IsNullOrEmpty(name))
				{
					name = Name;
				}

				base.Initialize(name, config);
			}
			catch
			{
			}
			finally
			{
			}
		}
	}
}
