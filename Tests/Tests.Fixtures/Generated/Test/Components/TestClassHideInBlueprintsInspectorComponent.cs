//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public ClassHideInBlueprintsInspectorComponent classHideInBlueprintsInspector { get { return (ClassHideInBlueprintsInspectorComponent)GetComponent(TestComponentsLookup.ClassHideInBlueprintsInspector); } }
    public bool hasClassHideInBlueprintsInspector { get { return HasComponent(TestComponentsLookup.ClassHideInBlueprintsInspector); } }

    public void AddClassHideInBlueprintsInspector(ClassHideInBlueprintsInspector newValue) {
        var component = CreateComponent<ClassHideInBlueprintsInspectorComponent>(TestComponentsLookup.ClassHideInBlueprintsInspector);
        component.value = newValue;
        AddComponent(TestComponentsLookup.ClassHideInBlueprintsInspector, component);
    }

    public void ReplaceClassHideInBlueprintsInspector(ClassHideInBlueprintsInspector newValue) {
        var component = CreateComponent<ClassHideInBlueprintsInspectorComponent>(TestComponentsLookup.ClassHideInBlueprintsInspector);
        component.value = newValue;
        ReplaceComponent(TestComponentsLookup.ClassHideInBlueprintsInspector, component);
    }

    public void RemoveClassHideInBlueprintsInspector() {
        RemoveComponent(TestComponentsLookup.ClassHideInBlueprintsInspector);
    }
}