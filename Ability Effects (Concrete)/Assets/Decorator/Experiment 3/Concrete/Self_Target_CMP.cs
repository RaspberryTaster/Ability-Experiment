using Assets.Decorator.Experiment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Self_Target_CMP : Composite, INeed_Self, INext_Components
	{
		public GameObject self;
		public Self_Target_CMP(string name) : base(name)
		{
		}

		public Self_Target_CMP(string name, List<IComponent> children) : base(name, children)
		{

		}

		public override void Execute()
		{
			base.Execute();
		}

		public void Next_Components(IComponent[] components)
		{
			throw new NotImplementedException();
		}

		public void Set_Self(GameObject self)
		{
			this.self = self;
		}
	}
}
