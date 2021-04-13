using Assets.Composite.Experiment_6.Concrete;
using Assets.Composite.Experiment_6.Interfaces;
using NaughtyAttributes;
using UnityEngine;

namespace Assets.Composite.Experiment_6
{
	public class Test_Program : MonoBehaviour
	{
		public Composite composite;
		public Spawnable_Object prefab;
		public bool Sneak_Attack;
		private void Start()
		{
			//Construct_Spell();
		}

		[Button("Construct Spell", EButtonEnableMode.Always)]
		private void Construct_Spell()
		{
			composite = new Self_Cast_CMP("Self Cast", gameObject);

			Children_Execute_Once_CMP execute_once = new Children_Execute_Once_CMP("Execute once");
			composite.Add(execute_once);

			Spawn_Object_CMP spawn_Object_CMP = new Spawn_Object_CMP("Spawn Object Composite", prefab);
			execute_once.Add(spawn_Object_CMP);

			spawn_Object_CMP.Add(new Change_Color_LF("Red", Color.red));
		}

		[Button("Execute", EButtonEnableMode.Always)]
		private void Execute()
		{

			int count = composite.Get_All_Children().Count;
			for (int i = 0; i < count; i++)
			{
				if(composite.Get_All_Children()[i] is IReset reset)
				{
					reset.Reset();
				}
			}
			composite.Execute(1);
		}
	}
}
