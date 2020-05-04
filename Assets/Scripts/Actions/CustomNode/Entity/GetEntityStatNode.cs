using Actions.Core;
using Components.Stat;
using XNode;

namespace Actions.CustomNode.Entity
{
    public class GetEntityStatNode : ActionNode
    {
        public VarFlag VarFlag;
        [Output] public float Value;

        public override object GetValue(NodePort port)
        {
            if (port.fieldName == "Value")
                return entity.statsComp.Vars[VarFlag.ToIdx()];

            return null;
        }
    }
}