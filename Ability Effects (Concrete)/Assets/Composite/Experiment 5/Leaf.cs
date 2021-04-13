using UnityEngine;

namespace Assets.Composite.Experiment_5
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
