using Assets.Decorator.Experiment_3.Interfaces;
using Assets.Decorator.Experiment_3.Library;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Echo_CMP : Composite, INext_Components
	{
		int echo_Amount;
		float echo_Delay;
		public Echo_CMP(string name, int echo_Amount, float echo_Delay) : base(name)
		{
			this.echo_Amount = echo_Amount;
			if (echo_Delay == 0)
			{
				echo_Delay = 0.00001f;
			}
			this.echo_Delay = echo_Delay;
			Timing.KillCoroutines();
		}

		public Echo_CMP(string name, List<IComponent> children, int echo_Amount = 0, float echo_Delay = 0) : base(name, children)
		{
			this.echo_Amount = echo_Amount;
			if(echo_Delay == 0)
			{
				echo_Delay = 0.00001f;
			}
			this.echo_Delay = echo_Delay;
			Timing.KillCoroutines();
		}

		public override void Execute()
		{
			base.Execute();

			for(int i = 0; i < 1 + echo_Amount; i++)
			{
				if(i == 0)
				{
					Next_Components(Get_My_Children());
				}
				else
				{
					Timing.RunCoroutine(Delayed_Execute(echo_Delay * i));
				}

			}
		}

		public IEnumerator<float> Delayed_Execute(float time)
		{
			yield return Timing.WaitForSeconds(time);
			Next_Components(Get_My_Children());
		}

		public void Next_Components(IComponent[] components)
		{
			Component_Utilities.Next_Components(components);
		}

		~Echo_CMP()
		{
			Timing.KillCoroutines();
		}
	}
}
