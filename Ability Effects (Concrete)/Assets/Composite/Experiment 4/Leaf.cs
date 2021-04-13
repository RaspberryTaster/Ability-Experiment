using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment_4
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
	}
}
