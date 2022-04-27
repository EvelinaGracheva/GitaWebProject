namespace GitaWebProject.Interfaces
{
    public interface IEntity<T>
         where T : struct
    {
        T Id { get; set; }
    }
}
