using UnityEngine;

namespace Nature
{
    public class CommandData
    {
        public string ID;
        public Color Color;
        public CommandData(string a_ID, Color a_Color)
        {
            ID = a_ID;
            Color = a_Color;
        }
    }
}
