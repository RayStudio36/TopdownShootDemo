//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Components.Base;

public partial interface IIdCompEntity {

    IdComp idComp { get; }
    bool hasIdComp { get; }

    void AddIdComp(int newValue);
    void ReplaceIdComp(int newValue);
    void RemoveIdComp();
}
