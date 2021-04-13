using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Composite.Experiment
{
	[System.Serializable]
	public class Composite : Component
	{
		[SerializeField] private List<Component> _children = new List<Component>();
		public Composite(string name, List<Component> children) : base(name)
		{
			_children = children;
		}

		public Composite(string name) : base(name)
		{

		}

		public override void Add(Component c)
		{
			_children.Add(c);
		}

		public override void Display(int depth)
		{
			Debug.Log(new string('-', depth) + name);
			
			foreach (Component component in _children)
			{
				component.Display(depth + 2);
			}
		}

		public override void Remove(Component c)
		{
			if(_children.Contains(c))
			{
				_children.Remove(c);
			}
		}
	}
}
