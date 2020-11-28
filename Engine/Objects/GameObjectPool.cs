﻿using System;
using System.Collections.Generic;

namespace Engine2D.Objects
{
    public class GameObjectPool<T> where T : BaseGameObject
    {
        private LinkedList<T> _activePool = new LinkedList<T>();
        private LinkedList<T> _inactivePool = new LinkedList<T>();

        public IEnumerable<T> ActiveObjects { get { return _activePool; } }

        public GameObjectPool() { }

        public IEnumerable<T> GetOrCreate(int nbObjects, Func<T> createNbObjectFn)
        {
            var activatedObjects = new List<T>();

            var nbToReactivate = Math.Min(_inactivePool.Count, nbObjects);
            var nbToCreate = nbObjects - nbToReactivate;

            for (int i = 0; i < nbToReactivate; i++)
            {
                var gameObject = _inactivePool.First.Value;
                gameObject.Activate();
                activatedObjects.Add(gameObject);

                _activePool.AddLast(gameObject);
                _inactivePool.RemoveFirst();
            }

            for (int i = 0; i < nbToCreate; i++)
            {
                var gameObject = createNbObjectFn();
                gameObject.Activate();
                activatedObjects.Add(gameObject);

                _activePool.AddLast(gameObject);
            }

            return activatedObjects;
        }

        public void DeactivateObject(T gameObject, Action<T> postDeactivateFn)
        {
            gameObject.Deactivate();

            var activeObject = _activePool.Find(gameObject);
            if (activeObject != null)
            {
                _activePool.Remove(gameObject);
                _inactivePool.AddLast(gameObject);
            }

            postDeactivateFn(gameObject);
        }

        public void DeactivateObject(T gameObject)
        {
            DeactivateObject(gameObject, _ => { });
        }

        public void DeactivateAllObjects(Action<T> postDeactivateFn)
        {
            foreach (var gameObject in ActiveObjects)
            {
                DeactivateObject(gameObject, postDeactivateFn);
            }
        }

        public void DeactivateAllObjects()
        {
            foreach (var gameObject in ActiveObjects)
            {
                DeactivateObject(gameObject);
            }
        }

    }
}