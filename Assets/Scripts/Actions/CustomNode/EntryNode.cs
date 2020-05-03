using Actions.Core;

namespace Actions.CustomNode
{
    public class EntryNode : ActionNode
    {
        [Output] public byte Out;

        protected override bool OnExecute()
        {
            ExitNode("Out");
            
            return true;
        }
    }
}