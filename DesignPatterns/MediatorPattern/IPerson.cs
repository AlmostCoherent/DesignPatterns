namespace DesignPatterns.MediatorPattern
{
    public interface IPerson
    {
        void Listen(Message message, Person source);
        void Say(Message message);
    }
}