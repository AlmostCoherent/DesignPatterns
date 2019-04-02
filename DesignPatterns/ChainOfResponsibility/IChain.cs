namespace DesignPatterns.ChainOfResponsibility
{
    public interface IChain
    {
        void setNextChain(IChain nextInChain);
        void Process(string input);
    }
}
