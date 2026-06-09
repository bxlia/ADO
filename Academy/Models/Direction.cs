using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Drawing;

namespace Academy.Models
{
	internal class Direction
	{
		internal int id;
		internal string direction_name;
		public Direction
			(
				int id, string direction_name
			)
		{
			this.id = id;
			this.direction_name = direction_name;
		}
		public Direction(object[] values)
		{
			this.id = Convert.ToInt32(values[0]);
			this.direction_name = values[1].ToString();
		}
		public Direction(Direction other)
		{
			this.id = other.id;
			this.direction_name = other.direction_name;
		}
		public virtual string GetNames()
		{
			return "direction_name";
		}
		public virtual string GetValues()
		{
			return $"N'{direction_name}'";
		}
		public virtual string GetUpdateExpression()
		{
			return $"direction_name=N'{direction_name}'";
		}
	}
}
