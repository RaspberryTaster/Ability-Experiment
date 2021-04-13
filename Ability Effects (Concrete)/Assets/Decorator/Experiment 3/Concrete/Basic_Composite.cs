using Assets.Decorator.Experiment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Basic_Composite : Composite
	{
		public Basic_Composite(string name) : base(name)
		{
		}

		public Basic_Composite(string name, List<IComponent> children) : base(name, children)
		{
		}
	}
}
