namespace Fluent.Testing.Library
{
    public class FluentTester : IFluentTester
    {
        public FluentTester(IWhen when, IThen then)
        {
            When = when;
            Then = then;
        }
        
        public IWhen When { get; }
        
        public IThen Then { get; }
    }
}