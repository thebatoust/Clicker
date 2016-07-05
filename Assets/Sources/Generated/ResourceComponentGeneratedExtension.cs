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
        public ResourceComponent resource { get { return (ResourceComponent)GetComponent(CoreComponentIds.Resource); } }

        public bool hasResource { get { return HasComponent(CoreComponentIds.Resource); } }

        public Entity AddResource(float newAmount) {
            var component = CreateComponent<ResourceComponent>(CoreComponentIds.Resource);
            component.amount = newAmount;
            return AddComponent(CoreComponentIds.Resource, component);
        }

        public Entity ReplaceResource(float newAmount) {
            var component = CreateComponent<ResourceComponent>(CoreComponentIds.Resource);
            component.amount = newAmount;
            ReplaceComponent(CoreComponentIds.Resource, component);
            return this;
        }

        public Entity RemoveResource() {
            return RemoveComponent(CoreComponentIds.Resource);
        }
    }

    public partial class Pool {
        public Entity resourceEntity { get { return GetGroup(CoreMatcher.Resource).GetSingleEntity(); } }

        public ResourceComponent resource { get { return resourceEntity.resource; } }

        public bool hasResource { get { return resourceEntity != null; } }

        public Entity SetResource(float newAmount) {
            if (hasResource) {
                throw new EntitasException("Could not set resource!\n" + this + " already has an entity with ResourceComponent!",
                    "You should check if the pool already has a resourceEntity before setting it or use pool.ReplaceResource().");
            }
            var entity = CreateEntity();
            entity.AddResource(newAmount);
            return entity;
        }

        public Entity ReplaceResource(float newAmount) {
            var entity = resourceEntity;
            if (entity == null) {
                entity = SetResource(newAmount);
            } else {
                entity.ReplaceResource(newAmount);
            }

            return entity;
        }

        public void RemoveResource() {
            DestroyEntity(resourceEntity);
        }
    }
}

    public partial class CoreMatcher {
        static IMatcher _matcherResource;

        public static IMatcher Resource {
            get {
                if (_matcherResource == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Resource);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherResource = matcher;
                }

                return _matcherResource;
            }
        }
    }
