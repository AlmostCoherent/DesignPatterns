using DesignPatterns.ObserverPattern;
using Xunit;


namespace DesignPatterns.Tests
{
    public class ObserverPatternTests
    {
        [Fact]
        public void TestObserverPattern()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "x"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "y"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "z"));

            concreteSubject.SubjectState = "ABC";
            concreteSubject.Notify();

            Assert.True(true);

        }
    }
}
