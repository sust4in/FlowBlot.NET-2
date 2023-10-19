namespace FlowBlot.Flows.Field_Sensitivity
{
    public class Flow_Multi2
    {
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