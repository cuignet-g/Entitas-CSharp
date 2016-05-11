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
        public BoundsComponent bounds { get { return (BoundsComponent)GetComponent(VisualDebuggingComponentIds.Bounds); } }

        public bool hasBounds { get { return HasComponent(VisualDebuggingComponentIds.Bounds); } }

        public Entity AddBounds(UnityEngine.Bounds newBounds) {
            var component = CreateComponent<BoundsComponent>(VisualDebuggingComponentIds.Bounds);
            component.bounds = newBounds;
            return AddComponent(VisualDebuggingComponentIds.Bounds, component);
        }

        public Entity ReplaceBounds(UnityEngine.Bounds newBounds) {
            var component = CreateComponent<BoundsComponent>(VisualDebuggingComponentIds.Bounds);
            component.bounds = newBounds;
            ReplaceComponent(VisualDebuggingComponentIds.Bounds, component);
            return this;
        }

        public Entity RemoveBounds() {
            return RemoveComponent(VisualDebuggingComponentIds.Bounds);
        }
    }
}

    public partial class VisualDebuggingMatcher {
        static IMatcher _matcherBounds;

        public static IMatcher Bounds {
            get {
                if (_matcherBounds == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.Bounds);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherBounds = matcher;
                }

                return _matcherBounds;
            }
        }
    }