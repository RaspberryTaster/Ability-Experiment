using Assets.Composite.Experiment_4.Interfaces;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Composite.Experiment_4.Concrete
{
	[Serializable]
	public class Self_Cast_CMP : Composite, INeed_Target
	{
		public GameObject self;

		public Self_Cast_CMP(string name, GameObject self, List<Component> children = null) : base(name, children)
		{
			this.self = self;
		}

		public override void Add(Component c)
		{
			base.Add(c);
		}

		public override void Execute(int depth)
		{
			foreach(INeed_Target need_Target in _children)
			{
				need_Target.Set_Target(self);
			}	
			base.Execute(depth);
		}


		public override void Remove(Component c)
		{
			base.Remove(c);
		}

		public void Set_Target(GameObject target)
		{
			self = target;
		}

	}
}
