using System.Collections.Generic;

namespace Assets.Composite.Experiment_6
{
	[System.Serializable]
	public abstract class Component
	{
		protected string name;
		public Component(string name)
		{
			this.name = name;
		}
		public abstract void Execute(int depth);
		public abstract List<Component> Get_All_Children();
	}
}
