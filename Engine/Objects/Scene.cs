using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace Engine2D.Objects
{
    public class Scene
    {
        private List<BaseLayer> _layers;

        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }

        public Scene()
        {
            _layers = new List<BaseLayer>();
            _layers.Add(new DefaultLayer());
        }

        public BaseLayer GetLayer(System.Type type)
        {
            foreach (var layer in _layers)
            {
                if (layer.GetType() == type)
                {
                    return layer;
                }
            }

            // if layer is not found, return an empty layer
            return new EmptyLayer();
        }

        public void AddGameObject(BaseGameObject obj)
        {
            var layer = GetLayer(typeof(DefaultLayer));
            AddGameObject(obj, layer);
        }

        public void AddGameObject(BaseGameObject obj, BaseLayer layer)
        {
            layer.GameObjects.Add(obj);
        }

        public void Render(SpriteBatch spriteBatch)
        {
            if (!IsVisible)
            {
                return;
            }

            // draw all objects on all layers, ordered by depth

            var orderedLayers = _layers.OrderBy(l => l.Depth);
            foreach (var layer in orderedLayers)
            {
                foreach (var gameObject in layer.GameObjects)
                {
                    if (Debug.Instance.IsDebugMode)
                    {
                        gameObject.RenderBoundingBoxes(spriteBatch);
                    }

                    gameObject.Render(spriteBatch);
                }
            }
        }
    }

    public abstract class BaseLayer
    {
        private List<BaseLayer> _interactsWith;

        /// <summary>
        /// Depth is between 0.0f and 1.0f. Can be used to order layers for drawing order and
        /// for parallax in conjunction with the MonoGame.extended orthographic camera
        /// </summary>
        public float Depth { get; private set; }

        /// <summary>
        /// List of all the game objects on this layer
        /// </summary>
        public virtual List<BaseGameObject> GameObjects { get; private set; }

        /// <summary>
        /// List of layers this layer can interact with. This will be used for collision detection. 
        /// Layers that don't interact with each other have objects that can't collide with each other. 
        /// Each layer has at least itself as part of this list
        /// </summary>
        public List<BaseLayer> InteractsWith 
        {
            get
            {
                if (_interactsWith.Count == 0)
                {
                    _interactsWith.Add(this);
                }

                return _interactsWith;
            }
        }

        public BaseLayer(float depth)
        {
            Depth = depth;
            GameObjects = new List<BaseGameObject>();
            _interactsWith = new List<BaseLayer>();
        }
    }

    public class DefaultLayer : BaseLayer
    {
        public DefaultLayer() : base(1.0f)
        {
        }
    }

    public class EmptyLayer : BaseLayer
    {
        public EmptyLayer() : base(0.0f)
        {
        }

        // force game object list to always be empty
        public override List<BaseGameObject> GameObjects => new List<BaseGameObject>();
    }
}
