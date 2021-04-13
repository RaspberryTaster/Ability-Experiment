using Assets.Composite.Experiment_6.Interfaces;
using System.Collections.Generic;

namespace Assets.Composite.Experiment_6.Concrete
{
	public class Children_Execute_Once_CMP : Composite, IReset
	{
		public int times_Executed = 0;
		public Children_Execute_Once_CMP(string name, List<Component> children = null) : base(name, children)
		{
			Reset();
		}

		public override void Execute(int depth)
		{
			base.Execute(depth);
			if (times_Executed < 1)
			{
				Execute_Children(depth);
			}
			times_Executed++;


		}

		public void Reset()
		{
			times_Executed = 0;
		}
	}
}
