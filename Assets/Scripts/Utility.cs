using System;
using UnityEngine;

namespace Nature
{
    public static class Utility 
    {
        public static string GetUniqueID()
        {
            return Guid.NewGuid().ToString("N");
        } 
        public static string GetRGBAColorHexWithHash(Color a_color)
        {
            return "#" + ColorUtility.ToHtmlStringRGBA(a_color).ToLower();
        }
    }
}   
