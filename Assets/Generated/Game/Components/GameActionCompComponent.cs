//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ActionComp actionComp { get { return (ActionComp)GetComponent(GameComponentsLookup.ActionComp); } }
    public bool hasActionComp { get { return HasComponent(GameComponentsLookup.ActionComp); } }

    public void AddActionComp(System.Collections.Generic.List<Actions.Core.ActionGraphHost> newActionGraphHostArr) {
        var index = GameComponentsLookup.ActionComp;
        var component = (ActionComp)CreateComponent(index, typeof(ActionComp));
        component.ActionGraphHostArr = newActionGraphHostArr;
        AddComponent(index, component);
    }

    public void ReplaceActionComp(System.Collections.Generic.List<Actions.Core.ActionGraphHost> newActionGraphHostArr) {
        var index = GameComponentsLookup.ActionComp;
        var component = (ActionComp)CreateComponent(index, typeof(ActionComp));
        component.ActionGraphHostArr = newActionGraphHostArr;
        ReplaceComponent(index, component);
    }

    public void RemoveActionComp() {
        RemoveComponent(GameComponentsLookup.ActionComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherActionComp;

    public static Entitas.IMatcher<GameEntity> ActionComp {
        get {
            if (_matcherActionComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ActionComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherActionComp = matcher;
            }

            return _matcherActionComp;
        }
    }
}
