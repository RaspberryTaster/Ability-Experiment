using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Library;
using MEC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Timed_Delay_CMP : Composite, INext_Components, IReset
	{
		public float time;
		public Timed_Delay_CMP(string name, float time) : base(name)
		{
			this.time = time;
			Timing.KillCoroutines();
		}

		public Timed_Delay_CMP(string name, List<IComponent> children, float time) : base(name, children)
		{
			this.time = time;
			Timing.KillCoroutines();
		}

		public override void Execute()
		{
			base.Execute();
			Timing.RunCoroutine(Delayed_Execute(time));
		}

		public void Next_Components(IComponent[] components)
		{
			Component_Utilities.Next_Components(components);
		}

		public IEnumerator<float> Delayed_Execute(float time)
		{
			yield return Timing.WaitForSeconds(time);
			Next_Components(Get_My_Children());
		}

		public void Reset()
		{
			Timing.KillCoroutines();
		}

		~Timed_Delay_CMP()
		{
			Timing.KillCoroutines();
		}
	}
}
