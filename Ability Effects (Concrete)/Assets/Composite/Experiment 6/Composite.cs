using System.Collections.Generic;
using UnityEngine;

namespace Assets.Composite.Experiment_6
{
	[System.Serializable]
	public abstract class Composite : Component
	{
		public List<Component> _children = new List<Component>();

		protected Composite(string name, List<Component> children = null) : base(name)
		{
			if(children == null)
			{
				if(_children.Count == 0)
				{
					_children = new List<Component>();
				}

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
		}

		public virtual void Execute_Children(int depth)
		{
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

		public override List<Component> Get_All_Children()
		{
			List<Component> temp = _children;
			int count = _children.Count;
			for (int i = 0; i < count; i++)
			{
				foreach(Component component in _children[i].Get_All_Children())
				{
					temp.Add(component);
				}
			}
			return temp;
		}
	}
}
