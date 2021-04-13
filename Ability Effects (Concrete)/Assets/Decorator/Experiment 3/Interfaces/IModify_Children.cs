using Assets.Decorator.Experiment_3.Interfaces;
namespace Assets.Decorator.Experiment_3.Interfaces
{
	public interface IModify_Children : IHave_Children
	{
		void Add(IComponent component);
		void Remove(IComponent component);
	}
}
