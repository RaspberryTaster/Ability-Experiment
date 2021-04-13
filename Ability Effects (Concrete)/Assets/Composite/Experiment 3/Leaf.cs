using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Composite.Experiment_3
{
	public abstract class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Add(Component c)
		{
			//can't add to a leaf
		}

		public override void Remove(Component c)
		{
			//can't remove form a leaf
		}
	}
}
