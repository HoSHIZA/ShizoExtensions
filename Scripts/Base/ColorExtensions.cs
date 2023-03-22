using UnityEngine;

namespace ShizoGames.Extensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Color"/> struct.
    /// </summary>
    public static class ColorExtensions
    {
        /// <summary>
        /// Returns a new Color with the red channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color.</param>
        /// <param name="r">The new red value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithR(this Color color, float r) => color.With(r: r);
        
        /// <summary>
        /// Returns a new Color with the green channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color.</param>
        /// <param name="g">The new green value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithG(this Color color, float g) => color.With(g: g);
        
        /// <summary>
        /// Returns a new Color with the blue channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithB(this Color color, float b) => color.With(b: b);
        
        /// <summary>
        /// Returns a new Color with the alpha channel replaced by the specified values.
        /// </summary>
        /// <param name="color">The original Color.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithA(this Color color, float a) => color.With(a: a);
        
        /// <summary>
        /// Returns a new Color with the red and green channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="g">The new green value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRG(this Color color, float r, float g) => color.With(r: r, g: g);
        
        /// <summary>
        /// Returns a new Color with the red and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRB(this Color color, float r, float b) => color.With(r: r, b: b);
        
        /// <summary>
        /// Returns a new Color with the red and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRA(this Color color, float r, float a) => color.With(r: r, a: a);
        
        /// <summary>
        /// Returns a new Color with the green and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="b">The new blue value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithGB(this Color color, float g, float b) => color.With(g: g, b: b);
        
        /// <summary>
        /// Returns a new Color with the green and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithGA(this Color color, float g, float a) => color.With(g: g, a: a);
        
        /// <summary>
        /// Returns a new Color with the blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="b">The new blue value.</param>
        /// <param name="a">The new alpha value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithBA(this Color color, float b, float a) => color.With(b: b, a: a);
        
        /// <summary>
        /// Returns a new Color with the red, green and blue channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRGB(this Color color, float r, float g, float b) => color.With(r: r, g: g, b: b);
        
        /// <summary>
        /// Returns a new Color with the red, green and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRGA(this Color color, float r, float g, float a) => color.With(r: r, g: g, a: a);

        /// <summary>
        /// Returns a new Color with the red, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRBA(this Color color, float r, float b, float a) => color.With(r: r, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color with the green, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithGBA(this Color color, float g, float b, float a) => color.With(g: g, b: b, a: a);
        
        /// <summary>
        /// Returns a new Color with the red, green, blue and alpha channels replaced by the specified values.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="r">The new red channel value.</param>
        /// <param name="g">The new green channel value.</param>
        /// <param name="b">The new blue channel value.</param>
        /// <param name="a">The new alpha channel value.</param>
        /// <returns>New Color with replacement for the specified values.</returns>
        public static Color WithRGBA(this Color color, float r, float g, float b, float a) => color.With(r: r, g: g, b: b, a: a);
        
        private static Color With(this Color color, float r = -1f, float g = -1f, float b = -1f, float a = -1f)
        {
            if (r >= 0f) color.r = r > 1f ? 1f : r;
            if (g >= 0f) color.g = g > 1f ? 1f : g;
            if (b >= 0f) color.b = b > 1f ? 1f : b;
            if (a >= 0f) color.a = a > 1f ? 1f : a;
            
            return color;
        }
    }
}