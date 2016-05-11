//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        public MyIntComponent myInt { get { return (MyIntComponent)GetComponent(VisualDebuggingComponentIds.MyInt); } }

        public bool hasMyInt { get { return HasComponent(VisualDebuggingComponentIds.MyInt); } }

        public Entity AddMyInt(int newMyInt) {
            var component = CreateComponent<MyIntComponent>(VisualDebuggingComponentIds.MyInt);
            component.myInt = newMyInt;
            return AddComponent(VisualDebuggingComponentIds.MyInt, component);
        }

        public Entity ReplaceMyInt(int newMyInt) {
            var component = CreateComponent<MyIntComponent>(VisualDebuggingComponentIds.MyInt);
            component.myInt = newMyInt;
            ReplaceComponent(VisualDebuggingComponentIds.MyInt, component);
            return this;
        }

        public Entity RemoveMyInt() {
            return RemoveComponent(VisualDebuggingComponentIds.MyInt);
        }
    }
}

    public partial class VisualDebuggingMatcher {
        static IMatcher _matcherMyInt;

        public static IMatcher MyInt {
            get {
                if (_matcherMyInt == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.MyInt);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherMyInt = matcher;
                }

                return _matcherMyInt;
            }
        }
    }