//using ProjectAriel.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace ProjectAriel.Repositories
//{
//	public class PlayerRepository //: Repository<T> where T : class
//	{
//		public void AddPlayer(string name)
//		{
//			Database.Players().Add(new Player { Name = name });
//			Database.SaveChanges();
//		}

//		public List<Player> GetPlayers()
//		{
//			return Database.Players().Where(p => p.IsActive).ToList();
//		}

//		public Player GetPlayerByID(int ID)
//		{
//			return Database.Players().Where(p => p.ID == ID && p.IsActive).SingleOrDefault();
//		}

//		public void EditPlayer(int ID, string name)
//		{
//			var player = Database.Players().Where(p => p.ID == ID && p.IsActive).SingleOrDefault();
//			if (player != null)
//			{
//				player.Name = name;
//				Database.SaveChanges();
//			}

//		}

//		public void DeletePlayer(int ID)
//		{
//			var player = Database.Players().Where(p => p.ID == ID && p.IsActive).SingleOrDefault();
//			if (player != null)
//			{
//				player.IsActive = false;
//				Database.SaveChanges();
//			}
//		}
//	}
//}