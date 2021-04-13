using Assets.Decorator.Experiment_3.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Set_Parent_LF : Leaf
	{
		private GameObject child;
		private GameObject parent;
		public Set_Parent_LF(string name, GameObject child, GameObject parent) : base(name)
		{
			this.child = child;
			this.parent = parent;
		}

		public override void Execute()
		{
			base.Execute();
			GameObject_Utilities.Set_Parent(parent, child);
		}
	}
}
