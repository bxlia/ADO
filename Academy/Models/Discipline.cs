using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
	internal class Discipline
	{
		internal int id;
		internal string discipline_name;
		internal string number_of_lessons;
		public Discipline
			(
				int id, string discipline_name, string number_of_lessons
			)
		{
			this.id = id;
			this.discipline_name =	discipline_name;
			this.number_of_lessons = number_of_lessons;
		}
		public Discipline(object[] values)
		{
			this.id = Convert.ToInt32(values[0]);
			this.discipline_name = values[1].ToString();
			this.number_of_lessons = values[2].ToString();
		}
		public Discipline(Discipline other)
		{
			this.id = other.id;
			this.discipline_name = other.discipline_name;
		}
		public virtual string GetNames()
		{
			return "discipline_name,number_of_lessons";
		}
		public virtual string GetValues()
		{
			return $"N'{discipline_name}',N'{number_of_lessons}'";
		}
		public virtual string GetUpdateExpression()
		{
			return 
				$"discipline_name=N'{discipline_name}'" +
				$"number_of_lessons=N'{number_of_lessons}'";
		}
	}
}
