using Assets.Composite.Experiment_2.Interfaces;
using UnityEngine;

namespace Assets.Composite.Experiment_2.Concrete
{
	public class Change_Color_LF : Leaf, INeed_Target
	{
		public Material target;
		public Color color;

		public Change_Color_LF(string name, Color color, Material target = null) : base(name)
		{
			this.color = color;
			this.target = target;
		}

		public override void Execute(int depth)
		{
			Debug.Log(new string('-', depth) + name);
			if (target == null) return;
			if(target == null)
			{
				Debug.Log("No material");
			}
			else
			{
				target.color = color;
			}

		}

		public void Set_Target(GameObject target)
		{
			this.target = target.GetComponent<Renderer>().material;
		}
	}
}
