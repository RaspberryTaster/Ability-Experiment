using Assets.Composite.Experiment_3.Concrete;
using UnityEngine;

namespace Assets.Composite.Experiment_3
{
	public class Test_Program : MonoBehaviour
	{
		public Composite composite;
		public bool Sneak_Attack;
		private void Start()
		{
			composite = new Self_Cast_CMP("Enrage", gameObject);
			composite.Add(new Change_Color_LF("Blue", Color.blue));
			Composite temp = new Sneak_Check_CMP("Sneak check", this);
			composite.Add(temp);
			temp.Add(new Change_Color_LF("Green for poison", Color.green));
			composite.Execute(1);
		}
	}
}
