using CoffeeManagement.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.Utilities
{
	public static class JsonHelper
	{
		private static string _saveDir = Path.Combine(Environment.CurrentDirectory, "DataTempt");
		private static string _savePath = Path.Combine(_saveDir, "TemptBills");

		public static void SaveTemptBills(List<Bill> bills)
		{
			var json = JsonConvert.SerializeObject(bills, Formatting.Indented, new JsonSerializerSettings
			{
				 ReferenceLoopHandling = ReferenceLoopHandling.Serialize
			});
			if (!Directory.Exists(_saveDir))
			{
				Directory.CreateDirectory(_saveDir);
			}

			File.WriteAllText(_savePath, json);		
		}

		public static List<Bill> LoadTemptBills()
		{
			if (File.Exists(_savePath))
			{
				return JsonConvert.DeserializeObject<List<Bill>>(File.ReadAllText(_savePath));
			}
			return new List<Bill>();

		}

	}
}
