using Assets.Composite.Experiment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment_3.Concrete
{
	public class Sneak_Check_CMP : Composite, INeed_Target
	{
		public Test_Program self;

		public Sneak_Check_CMP(string name, Test_Program self, List<Component> children = null) : base(name, children)
		{
			this.self = self;
		}

		public override void Add(Component c)
		{
			base.Add(c);
		}

		public override void Execute(int depth)
		{
			if (!self.Sneak_Attack) return;
			foreach (INeed_Target need_Target in _children)
			{
				need_Target.Set_Target(self.gameObject);
			}
			base.Execute(depth);
		}

		public override void Remove(Component c)
		{
			base.Remove(c);
		}

		public void Set_Target(GameObject target)
		{
			self = target.GetComponent<Test_Program>();
		}
	}
}
