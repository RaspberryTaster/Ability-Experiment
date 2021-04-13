using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment
{
	[System.Serializable]
	public class Leaf : Component
	{
		public Leaf(string name) : base(name)
		{
		}

		public override void Add(Component c)
		{
			//can't add to a leaf
		}

		public override void Display(int depth)
		{
			//
			Debug.Log(new string('-', depth) + name);
		}

		public override void Remove(Component c)
		{
			//can't remove form a leaf
		}
	}
}
