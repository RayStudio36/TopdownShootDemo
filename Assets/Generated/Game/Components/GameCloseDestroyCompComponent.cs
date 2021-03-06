//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CloseDestroyComp closeDestroyComp { get { return (CloseDestroyComp)GetComponent(GameComponentsLookup.CloseDestroyComp); } }
    public bool hasCloseDestroyComp { get { return HasComponent(GameComponentsLookup.CloseDestroyComp); } }

    public void AddCloseDestroyComp(float newDistance) {
        var index = GameComponentsLookup.CloseDestroyComp;
        var component = (CloseDestroyComp)CreateComponent(index, typeof(CloseDestroyComp));
        component.Distance = newDistance;
        AddComponent(index, component);
    }

    public void ReplaceCloseDestroyComp(float newDistance) {
        var index = GameComponentsLookup.CloseDestroyComp;
        var component = (CloseDestroyComp)CreateComponent(index, typeof(CloseDestroyComp));
        component.Distance = newDistance;
        ReplaceComponent(index, component);
    }

    public void RemoveCloseDestroyComp() {
        RemoveComponent(GameComponentsLookup.CloseDestroyComp);
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

    static Entitas.IMatcher<GameEntity> _matcherCloseDestroyComp;

    public static Entitas.IMatcher<GameEntity> CloseDestroyComp {
        get {
            if (_matcherCloseDestroyComp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CloseDestroyComp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCloseDestroyComp = matcher;
            }

            return _matcherCloseDestroyComp;
        }
    }
}
