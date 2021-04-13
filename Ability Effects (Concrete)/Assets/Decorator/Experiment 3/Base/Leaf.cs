using Assets.Decorator.Experiment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component = Assets.Decorator.Experiment_3.Concrete.Base.Component;


namespace Assets.Decorator.Experiment_3.Concrete
{
	public abstract class Leaf : Component, ILeaf
	{
		public Leaf(string name) : base(name)
		{
		}
	}
}
