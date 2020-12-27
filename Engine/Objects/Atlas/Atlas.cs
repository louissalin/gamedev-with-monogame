using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Engine2D.Objects.Atlas
{
    public class Atlas
    {
        private readonly Dictionary<string, Rectangle> _tilesByName;
        private readonly Dictionary<int, Rectangle> _tilesById;

        public Texture2D Texture { get; private set; }

        public Atlas(Texture2D texture, IEnumerable<TileDefinition> tileDefinitions)
        {
            Texture = texture;
            _tilesById = new Dictionary<int, Rectangle>();
            _tilesByName = new Dictionary<string, Rectangle>();

            InitializeTiles(tileDefinitions);
        }

        private void InitializeTiles(IEnumerable<TileDefinition> tileDefinitions)
        {
            foreach(var tileDef in tileDefinitions)
            {
                if (_tilesByName.ContainsKey(tileDef.Name) )
                {
                    throw new AtlasException("Name already present in Atlas");
                }

                if (_tilesById.ContainsKey(tileDef.Id) )
                {
                    throw new AtlasException("Id already present in Atlas");
                }

                _tilesByName.Add(tileDef.Name, new Rectangle(tileDef.X, tileDef.Y, tileDef.Width, tileDef.Height));
                _tilesById.Add(tileDef.Id, new Rectangle(tileDef.X, tileDef.Y, tileDef.Width, tileDef.Height));
            }
        }

        public Rectangle GetAtlasRectangle(int id)
        {
            if (_tilesById.ContainsKey(id))
            {
                return _tilesById[id];
            }
            else
            {
                throw new AtlasException($"Id {id} not found in atlas");
            }
        }

        public Rectangle GetAtlasRectangle(string name)
        {
            if (_tilesByName.ContainsKey(name))
            {
                return _tilesByName[name];
            }
            else
            {
                throw new AtlasException($"Name {name} not found in atlas");
            }
        }
    }

    public class AtlasException : Exception
    {
        public AtlasException(string message) : base(message)
        {
        }
    }
}
