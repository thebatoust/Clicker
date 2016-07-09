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
        public ResourceGeneratorComponent resourceGenerator { get { return (ResourceGeneratorComponent)GetComponent(CoreComponentIds.ResourceGenerator); } }

        public bool hasResourceGenerator { get { return HasComponent(CoreComponentIds.ResourceGenerator); } }

        public Entity AddResourceGenerator(float newStep, int newFrequency, int newCount) {
            var component = CreateComponent<ResourceGeneratorComponent>(CoreComponentIds.ResourceGenerator);
            component.step = newStep;
            component.frequency = newFrequency;
            component.count = newCount;
            return AddComponent(CoreComponentIds.ResourceGenerator, component);
        }

        public Entity ReplaceResourceGenerator(float newStep, int newFrequency, int newCount) {
            var component = CreateComponent<ResourceGeneratorComponent>(CoreComponentIds.ResourceGenerator);
            component.step = newStep;
            component.frequency = newFrequency;
            component.count = newCount;
            ReplaceComponent(CoreComponentIds.ResourceGenerator, component);
            return this;
        }

        public Entity RemoveResourceGenerator() {
            return RemoveComponent(CoreComponentIds.ResourceGenerator);
        }
    }
}

    public partial class CoreMatcher {
        static IMatcher _matcherResourceGenerator;

        public static IMatcher ResourceGenerator {
            get {
                if (_matcherResourceGenerator == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.ResourceGenerator);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherResourceGenerator = matcher;
                }

                return _matcherResourceGenerator;
            }
        }
    }