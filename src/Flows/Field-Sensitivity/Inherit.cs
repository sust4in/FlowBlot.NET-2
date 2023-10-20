namespace FlowBlot.Flows.Field_Sensitivity
{
    public class Test
    {
        public string a;

        public void Run()
        {
            FlowBlot.Model.Framework.Sink(this.a);
        }
    }

    public class SubTest : Test
    {
    }

    public class Inherit
    {
        public void Run()
        {
            var blot1 = new SubTest();
            blot1.a = FlowBlot.Model.Framework.Source();
            blot1.Run();
        }
    }
}