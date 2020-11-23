using System;
using System.Collections.Generic;
using System.Linq;

namespace PipelineExtensions
{
    public class LevelEvent
    {
        public class Nothing : LevelEvent { }

        public class GenerateEnemies : LevelEvent
        { 
            public int NbEnemies { get; private set; }
            public GenerateEnemies(int nbEnemies)
            {
                NbEnemies = nbEnemies;
            }
        }

        public class GenerateTurret : LevelEvent { }

        public class StartLevel : LevelEvent { }

        public class EndLevel : LevelEvent { }

        public class NoRowEvent : LevelEvent { }
    }

    public class Level
    {
        private const int NB_ROWS = 11;

        public string LevelStringEncoding { get; }
        public List<List<LevelEvent>> ProcessedLevel { get; }

        public Level(string encoding)
        {
            LevelStringEncoding = encoding;
            ProcessedLevel = LoadLevel();
        }

        private List<List<LevelEvent>> LoadLevel()
        {
            if (LevelStringEncoding != null && LevelStringEncoding.Length > 0)
            {
                var rows = LevelStringEncoding.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var convertedRows = from r in rows
                                    select ToEventRow(r);

                return convertedRows.Reverse().ToList();
            }
            else
            {
                return new List<List<LevelEvent>>();
            }
        }

        private List<LevelEvent> ToEventRow(string rowString)
        {
            var elements = rowString.Split(',');

            var newRow = new List<LevelEvent>();
            for (int i = 0; i < NB_ROWS; i++)
            {
                newRow.Add(ToEvent(elements[i]));
            }

            return newRow;
        }

        private LevelEvent ToEvent(string input)
        {
            switch (input) 
            {
                case "0":
                    return new LevelEvent.Nothing();
                    
                case "_":
                    return new LevelEvent.NoRowEvent();

                case "1":
                    return new LevelEvent();

                case "s":
                    return new LevelEvent.StartLevel();

                case "e":
                    return new LevelEvent.EndLevel();

                case string g when g.StartsWith("g"):
                    var nb = int.Parse(g.Substring(1));
                    return new LevelEvent.GenerateEnemies(nb);

                default:
                    return new LevelEvent.Nothing();
            }
        }
    }
}
