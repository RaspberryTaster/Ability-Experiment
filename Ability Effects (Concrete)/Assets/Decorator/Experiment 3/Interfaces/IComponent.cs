using Assets.Decorator.Experiment_3.Interfaces;

namespace Assets.Decorator.Experiment_3.Interfaces
{
	public interface IComponent : ICloneable<IComponent>, IExecute
	{
		int Depth { get; set; }
		void Set_Root(IComponent root);
	}
}
