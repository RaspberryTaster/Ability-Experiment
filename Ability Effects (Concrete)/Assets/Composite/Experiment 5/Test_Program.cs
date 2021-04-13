using Assets.Composite.Experiment_5.Concrete;
using UnityEngine;

namespace Assets.Composite.Experiment_5
{
	public class Test_Program : MonoBehaviour
	{
		public Composite composite;
		public Spawnable_Object prefab;
		public bool Sneak_Attack;
		private void Start()
		{
			composite = new Self_Cast_CMP("Self Cast", gameObject);
			composite.Add(new Change_Color_LF("Blue", Color.blue));

			Spawn_Object_CMP spawn_Object_CMP = new Spawn_Object_CMP("Spawn Object Composite", prefab);
			composite.Add(spawn_Object_CMP);
			spawn_Object_CMP.Add(new Change_Color_LF("Red", Color.red));
			composite.Execute(1);
		}
	}
}
