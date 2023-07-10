using UnityEngine;

namespace KDebugger.Plugins.ShizoGames.ShizoExtensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Color32"/> struct.
    /// </summary>
    public static class Color32Extensions
    {
        /// <summary>
        /// Returns a new Color32 with the red channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color32.</param>
        /// <param name="r">The new red value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithR(this Color32 color, byte r) => color.With(r: r);
        
        /// <summary>
        /// Returns a new Color32 with the green channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color32.</param>
        /// <param name="g">The new green value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithG(this Color32 color, byte g) => color.With(g: g);
        
        /// <summary>
        /// Returns a new Color32 with the blue channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color32.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithB(this Color32 color, byte b) => color.With(b: b);
        
        /// <summary>
        /// Returns a new Color32 with the alpha channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color32.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithA(this Color32 color, byte a) => color.With(a: a);
        
        /// <summary>
        /// Returns a new Color32 with the red and green channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="g">The new green value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRG(this Color32 color, byte r, byte g) => color.With(r: r, g: g);
        
        /// <summary>
        /// Returns a new Color32 with the red and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRB(this Color32 color, byte r, byte b) => color.With(r: r, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the red and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRA(this Color32 color, byte r, byte a) => color.With(r: r, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the green and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithGB(this Color32 color, byte g, byte b) => color.With(g: g, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the green and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithGA(this Color32 color, byte g, byte a) => color.With(g: g, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="b">The new blue value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithBA(this Color32 color, byte b, byte a) => color.With(b: b, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the red, green and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRGB(this Color32 color, byte r, byte g, byte b) => color.With(r: r, g: g, b: b);
        
        /// <summary>
        /// Returns a new Color32 with the red, green and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRGA(this Color32 color, byte r, byte g, byte a) => color.With(r: r, g: g, a: a);

        /// <summary>
        /// Returns a new Color32 with the red, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRBA(this Color32 color, byte r, byte b, byte a) => color.With(r: r, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the green, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithGBA(this Color32 color, byte g, byte b, byte a) => color.With(g: g, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color32 with the red, green, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color32 with replacement for the specified values.</returns>
        public static Color32 WithRGBA(this Color32 color, byte r, byte g, byte b, byte a) => color.With(r: r, g: g, b: b, a: a);
        
        private static Color32 With(this Color32 color, int r = -1, int g = -1, int b = -1, int a = -1)
        {
            if (r >= 0) color.r = (byte) (r > 255 ? 255 : r);
            if (g >= 0) color.g = (byte) (g > 255 ? 255 : g);
            if (b >= 0) color.b = (byte) (b > 255 ? 255 : b);
            if (a >= 0) color.a = (byte) (a > 255 ? 255 : a);
            
            return color;
        }
    }
}