using Actions.CustomNode.Basic;
using UnityEngine;

namespace Actions.CustomNode.Entity
{
    public class CreateEntityNode : FlowActionNode
    {
        public ActorTag ActorTag;
        
        [Input] public Vector2 Pos;
        [Input] public float Angle;
        
        protected override void OnFlowExecute()
        {
            var pos = GetInputValue("Pos", Pos);
            var angle = GetInputValue("Angle", Angle);
            
            // todo 扩展该类，实现各种Entity创建
            if (ActorTag == ActorTag.PlayerShadow)
            {
                EntityUtil.CreatePlayerShadowEntity(
                    GameManager.Contexts,
                    pos,
                    angle);
            }
        }
    }
}