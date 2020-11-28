using System;
using System.Collections.Generic;

namespace Engine2D.Objects
{
    public class GameObjectPool
    {
        private Dictionary<Type, LinkedList<BaseGameObject>> _activePools;
        private Dictionary<Type, LinkedList<BaseGameObject>> _inactivePools;

        public GameObjectPool()
        {
            _activePools = new Dictionary<Type, LinkedList<BaseGameObject>>();
        }

        public void CreatePool(Type type, LinkedList<BaseGameObject> pool)
        {
            if (!_activePools.ContainsKey(type))
            {
                _activePools[type] = pool;
                _inactivePools[type] = new LinkedList<BaseGameObject>();
            }
        }

        public IEnumerable<BaseGameObject> GetObject(Type type, int nbObjects, Func<BaseGameObject> createNbObjectFn)
        {
            var activatedObjects = new List<BaseGameObject>();

            if (_activePools.ContainsKey(type))
            {
                var nbToReactivate = Math.Min(_inactivePools[type].Count, nbObjects);
                var nbToCreate = nbObjects - nbToReactivate;

                for (int i = 0; i < nbToReactivate; i++)
                {
                    var gameObject = _inactivePools[type].First.Value;
                    gameObject.Activate();
                    activatedObjects.Add(gameObject);

                    _activePools[type].AddLast(gameObject);
                    _inactivePools[type].RemoveFirst();
                }

                for (int i = 0; i < nbToCreate; i++)
                {
                    var gameObject = createNbObjectFn();
                    gameObject.Activate();
                    activatedObjects.Add(gameObject);

                    _activePools[type].AddLast(gameObject);
                }
            }

            return activatedObjects;
        }

        public void DeactivateObject(Type type, BaseGameObject gameObject)
        {
            gameObject.Deactivate();

            if (_activePools.ContainsKey(type))
            {
                var activeObject = _activePools[type].Find(gameObject);
                if (activeObject != null)
                {
                    _activePools[type].Remove(gameObject);
                    _inactivePools[type].AddLast(gameObject);
                }
            }
        }
    }
}
