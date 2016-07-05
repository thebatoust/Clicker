//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public class IResourceListenerComponent : IComponent {
    public IResourceListener value;
}

namespace Entitas {
    public partial class Entity {
        public IResourceListenerComponent iResourceListener { get { return (IResourceListenerComponent)GetComponent(UIComponentIds.IResourceListener); } }

        public bool hasIResourceListener { get { return HasComponent(UIComponentIds.IResourceListener); } }

        public Entity AddIResourceListener(IResourceListener newValue) {
            var component = CreateComponent<IResourceListenerComponent>(UIComponentIds.IResourceListener);
            component.value = newValue;
            return AddComponent(UIComponentIds.IResourceListener, component);
        }

        public Entity ReplaceIResourceListener(IResourceListener newValue) {
            var component = CreateComponent<IResourceListenerComponent>(UIComponentIds.IResourceListener);
            component.value = newValue;
            ReplaceComponent(UIComponentIds.IResourceListener, component);
            return this;
        }

        public Entity RemoveIResourceListener() {
            return RemoveComponent(UIComponentIds.IResourceListener);
        }
    }
}

    public partial class UIMatcher {
        static IMatcher _matcherIResourceListener;

        public static IMatcher IResourceListener {
            get {
                if (_matcherIResourceListener == null) {
                    var matcher = (Matcher)Matcher.AllOf(UIComponentIds.IResourceListener);
                    matcher.componentNames = UIComponentIds.componentNames;
                    _matcherIResourceListener = matcher;
                }

                return _matcherIResourceListener;
            }
        }
    }
