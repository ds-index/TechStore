namespace TechStore.Domain.Exceptions
{
    public class DomainNotFoundException : Exception
    {
        public DomainNotFoundException(string entity, object key) : base($"{entity} with key {key} not found!") { }
    }
}
