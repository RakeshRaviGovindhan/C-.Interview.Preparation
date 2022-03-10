using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class LinqGroupBy
    {
		public static void Execute()
		{
			//var groups = GetUsers().ToList().GroupBy(X => X.TeamId);
			//foreach (var _group in groups)
			//{
			//	int score = 0;
			//	string teamName = "";
			//	foreach (var user in _group)
			//	{
			//		score += user.Score;
			//		teamName = user.TeamId;
			//	}
			//	Console.WriteLine("Team : {0}, Score : {1}", teamName, score);
			//}
		}

		//public static List<User> GetUsers()
		//{
		//	static List<User> users = new List<User>() 
		//	{
		//		new User()
		//		{
		//			Id = 1,
		//			Name = "User1",
		//			Score = 10,
		//			TeamId = "TeamA"
		//		},
		//		new User()
		//		{
		//			Id = 2,
		//			Name = "User2",
		//			Score = 12,
		//			TeamId = "TeamB"
		//		},
		//		(new User()
		//		{
		//			Id = 3,
		//			Name = "User3",
		//			Score = 12,
		//			TeamId = "TeamA",
		//		},
		//		new User()
		//		{
		//			Id = 4,
		//			Name = "User4",
		//			Score = 2,
		//			TeamId = "TeamB",
		//		}
		//	}
			
		//	return users;
		//}

	}
}


//TODO 1:
// - compile below code
// - run it successfuly 

//TODO 2:
// - add 'display-teams' command
// command should result in listing all teams - order by the sum of the pointes gathered by players inside the given team
//eg:
//TeamA - 40 points
//TeamB -  9 points

/*
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.DependencyInjection;

public class Program
{
	public static void Main()
	{
		var services = new ServiceCollection();
		services.AddSingleton<IUserService, InMemoryUserService>();
		services.AddSingleton<IHandler, UsersHandler>();

		var serviceProvider = services.BuildServiceProvider();

		while (true)
		{
			var command = Console.ReadLine();

			if (command == "exit")
			{
				break;
			}

			var handlers = serviceProvider.GetServices<IHandler>();

			if (handlers.Count() > 0)
			{
				var handler = handlers.FirstOrDefault(it => it.HandlerName == command);


				if (handler != null)
				{
					handler.Execute();
					continue;
				}

				Console.WriteLine("'" + command + "' command was unrecognized.");
			}
		}
	}
}

public interface IHandler
{
	void Execute();

	string HandlerName { get; }
}

public class UsersHandler : IHandler
{
	public string HandlerName
	{
		get { return "display-users"; }
	}

	public IUserService UserService;

	public UsersHandler(IUserService userService)
	{
		UserService = userService;
	}

	public void Execute()
	{
		var groups = UserService.GetUsers().ToList().GroupBy(X => X.TeamId);
		foreach (var _group in groups)
		{
			int score = 0;
			string teamName = "";
			foreach (var user in _group)
			{
				score += user.Score;
				teamName = user.TeamId;
			}
			Console.WriteLine("Team : {0}, Score : {1}", teamName, score);
		}
	}

}

public class User
{
	public string Name { get; set; }

	public int Id;

	public int Score;

	public string TeamId { get; set; }
}

public interface IUserService : IDisposable
{
	IEnumerable<User> GetUsers();
}

public class InMemoryUserService : IUserService
{
	public bool IsDisposed;

	public IEnumerable<User> GetUsers()
	{
		if (IsDisposed)
		{
			throw new ArgumentException("Service was already disposed.");
		}

		List<User> users = new List<User>();

		users.Add(new User()
		{
			Id = 1,
			Name = "User1",
			Score = 10,
			TeamId = "TeamA"
		});

		users.Add(new User()
		{
			Id = 2,
			Name = "User2",
			Score = 12,
			TeamId = "TeamB"
		});

		users.Add(new User()
		{
			Id = 3,
			Name = "User3",
			Score = 12,
			TeamId = "TeamA",
		});

		users.Add(new User()
		{
			Id = 4,
			Name = "User4",
			Score = 2,
			TeamId = "TeamB",
		});

		return users;
	}


	public void Dispose()
	{
		//Some things that need to be disposed.
		IsDisposed = true;
	}
}
*/