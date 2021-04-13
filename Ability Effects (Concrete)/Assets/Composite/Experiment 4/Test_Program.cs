using Assets.Composite.Experiment_4.Concrete;
using UnityEngine;

namespace Assets.Composite.Experiment_4
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
			composite.Add(new Spawn_Object_LF("Spawn_Object", prefab));
			//Composite temp = new Sneak_Check_CMP("Sneak check", this);
			//composite.Add(temp);
			//temp.Add(new Change_Color_LF("Green for poison", Color.green));
			composite.Execute(1);
		}
	}
}
