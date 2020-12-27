namespace Engine2D.Objects.Atlas
{
    public class TileDefinition
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public TileDefinition(int id, string name, int x, int y, int width, int height)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
