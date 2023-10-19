namespace FlowBlot.Flows.Field_Sensitivity
{
    public class TestObject
    {
        public string Label { get; set; }
    }
    
    public class Flow_Multi
    {
        public void Run()
        {
            var to = new TestObject();
            to.Label = FlowBlot.Model.Framework.Source();
            Bar(to);
        }
        
        public void Run2()
        {
            var to = new TestObject();
            to.Label = FlowBlot.Model.Framework.Source();
            Bar(to);
        }
        
        public void Bar(TestObject to)
        {
            FlowBlot.Model.Framework.Sink(to.Label);
        }
    }
}