using System.Collections.Generic;
using UnityEngine;

namespace Assets.Composite.Experiment_6
{
	public abstract class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Execute(int depth)
		{
			Debug.Log(new string('-', depth) + name);
		}

		public override List<Component> Get_All_Children()
		{
			List<Component> temp = new List<Component>
			{
				this
			};
			return temp;
		}
	}
}
