using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment_4
{
	[System.Serializable]
	public abstract class Composite : Component
	{
		public List<Component> _children = new List<Component>();

		protected Composite(string name, List<Component> children = null) : base(name)
		{
			if(children == null)
			{
				_children = new List<Component>();
			}
			else
			{
				_children = children;
			}

		}

		public virtual void Add(Component c)
		{
			if(_children == null)
			{
				Debug.Log("No children");
			}
			else
			{
				_children.Add(c);
			}

		}

		public override void Execute(int depth)
		{
			Debug.Log(new string('-', depth) + name);

			foreach (Component component in _children)
			{
				component.Execute(depth + 2);
			}
		}

		public virtual void Remove(Component c)
		{
			if (_children.Contains(c))
			{
				_children.Remove(c);
			}
		}
	}
}
