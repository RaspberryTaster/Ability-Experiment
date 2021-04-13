using Assets.Decorator.Experiment_3.Library;
using Assets.Decorator.Throw_Away_Scripts;
using UnityEngine;

namespace Assets.Decorator.Experiment_3.Concrete
{
	public class Rotate_Object_LF : Leaf
	{
		public Rotate subject_Rotate;
		public Rotate_Object_LF(string name, GameObject subject, Vector3 rotate_Vector) : base(name)
		{
			if (subject == null) return;
			GameObject_Utilities.Reference_Component(subject, ref subject_Rotate);
			subject_Rotate.rotation_Vector = rotate_Vector;
			subject_Rotate.enabled = false;
		}

		public override void Execute()
		{
			base.Execute();
			if (subject_Rotate == null) return;
			subject_Rotate.enabled = true;
		}
	}
}
