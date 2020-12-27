﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Engine2D.Objects.Atlas
{
    public class Atlas
    {
        private readonly Dictionary<int, Rectangle> _tilesById;

        public Texture2D Texture { get; private set; }

        public Atlas(Texture2D texture, IEnumerable<TileData> tileData)
        {
            Texture = texture;
            _tilesById = new Dictionary<int, Rectangle>();

            InitializeTiles(tileData);
        }

        private void InitializeTiles(IEnumerable<TileData> tileData)
        {
            foreach(var tileDef in tileData)
            {
                if (_tilesById.ContainsKey(tileDef.Id) )
                {
                    throw new AtlasException("Id already present in Atlas");
                }

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
    }

    public struct TileData
    {
        public int Id;
        public int X;
        public int Y;
        public int Width;
        public int Height;
    }

    public class AtlasException : Exception
    {
        public AtlasException(string message) : base(message)
        {
        }
    }
}
