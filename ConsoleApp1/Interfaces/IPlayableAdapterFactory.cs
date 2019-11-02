
namespace ConsoleApp1.Interfaces
{
    public interface IPlayableAdapterFactory
    {
        IPlayableAdapter Adapter { get; set; }

        IPlayableAdapter Create();
    }
}
