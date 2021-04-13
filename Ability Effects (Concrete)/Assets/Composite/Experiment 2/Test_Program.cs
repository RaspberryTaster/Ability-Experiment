using Assets.Composite.Experiment_2.Concrete;
using UnityEngine;

namespace Assets.Composite.Experiment_2
{
	public class Test_Program : MonoBehaviour
	{
		public Composite composite;
		private void Start()
		{
			composite = new Self_Cast_CMP("Enrage", gameObject);
			composite.Add(new Change_Color_LF("Blue", Color.blue));
			composite.Execute(1);
		}
	}
}
