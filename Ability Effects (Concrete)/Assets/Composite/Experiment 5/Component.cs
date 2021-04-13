using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Composite.Experiment_5
{
	[System.Serializable]
	public abstract class Component
	{
		protected string name;
		public Component(string name)
		{
			this.name = name;
		}
		public abstract void Execute(int depth);
	}
}
