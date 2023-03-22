namespace ShizoGames.Extensions.Base
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Remap the given value from one range to another.
        /// </summary>
        /// <param name="value">The value to remap.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        /// <returns>The remapped value.</returns>
        public static float Remap(this float value, float min1, float max1, float min2, float max2)
        {
            return (value - min1) / (max1 - min1) * (max2 - min2) + min2;
        }
    }
}