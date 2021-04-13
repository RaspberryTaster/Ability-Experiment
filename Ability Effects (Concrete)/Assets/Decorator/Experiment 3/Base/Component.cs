using Assets.Decorator.Experiment_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete.Base
{
	public abstract class Component : IComponent
	{
		public string name;
		public IComponent root;
		public int Depth { get; set; }

		protected Component(string name)
		{
			this.name = name;
			Depth = 1;
		}

		public virtual IComponent Clone()
		{
			return this;
		}

		public virtual void Execute()
		{
			Debug.Log(new string('-', Depth) + name);
		}

		public void Set_Root(IComponent component)
		{
			root = component;
			Depth = component.Depth + 1;
		}
		
	}
}

