using UnityEngine;

namespace ShizoGames.Extensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Vector2Int"/> struct.
    /// </summary>
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// Returns a new Vector2Int with the X component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <returns>New Vector2Int with replacement for the specified values.</returns>
        public static Vector2Int WithX(this Vector2Int vector, int x)
        {
            return vector.With(x: x);
        }

        /// <summary>
        /// Returns a new Vector2Int with the Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector2Int with replacement for the specified values.</returns>
        public static Vector2Int WithY(this Vector2Int vector, int y)
        {
            return vector.With(y: y);
        }

        /// <summary>
        /// Returns a new Vector2Int with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector2Int with replacement for the specified values.</returns>
        public static Vector2Int WithXY(this Vector2Int vector, int x, int y)
        {
            return vector.With(x: x, y: y);
        }
        
        /// <summary>
        /// Returns a new Vector2Int with X and Y components swapped.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>A new Vector2Int with swapped X and Y components.</returns>
        public static Vector2Int GetYX(this Vector2Int vector)
        {
            return new Vector2Int(vector.y, vector.x);
        }

        /// <summary>
        /// Inserts the specified X value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="x">The X value to insert.</param>
        /// <returns>A new Vector3Int with the specified X value and the Y and Z values from the original Vector2Int.</returns>
        public static Vector3Int InsertX(this Vector2Int vector, int x)
        {
            return new Vector3Int(x, vector.x, vector.y);
        }

        /// <summary>
        /// Inserts the specified Y value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="y">The Y value to insert.</param>
        /// <returns>A new Vector3Int with the specified Y value and the X and Z values from the original Vector2Int.</returns>
        public static Vector3Int InsertY(this Vector2Int vector, int y)
        {
            return new Vector3Int(vector.x, y, vector.y);
        }

        /// <summary>
        /// Inserts the specified Z value into the Vector2Int, resulting in a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="z">The Z value to insert.</param>
        /// <returns>A new Vector3Int with the specified Z value and the X and Y values from the original Vector2Int.</returns>
        public static Vector3Int InsertZ(this Vector2Int vector, int z)
        {
            return new Vector3Int(vector.x, vector.y, z);
        }

        /// <summary>
        /// Returns the minimum value of the Vector2Int components.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>The minimum value of the Vector2Int components.</returns>
        public static int MinValue(this Vector2Int vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector2Int components.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>The maximum value of the Vector2Int components.</returns>
        public static int MaxValue(this Vector2Int vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>The index of the largest component (0 is X, 1 is Y).</returns>
        public static int MaxValueIndex(this Vector2Int vector)
        {
            return vector.x > vector.y ? 0 : 1;
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>The index of the smallest component (0 is X, 1 is Y).</returns>
        public static int MinValueIndex(this Vector2Int vector)
        {
            return vector.x < vector.y ? 0 : 1;
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>A vector with each component replaced by its absolute value.</returns>
        public static Vector2Int Abs(this Vector2Int vector)
        {
            return new Vector2Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Adds an int value to all components of a Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="value">The int value to add to all components.</param>
        /// <returns>A new Vector2Int with the added values.</returns>
        public static Vector2Int Add(this Vector2Int vector, int value)
        {
            return new Vector2Int(vector.x + value, vector.y + value);
        }

        /// <summary>
        /// Adds int values to X and Y components of a Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="x">The int value to add to X component.</param>
        /// <param name="y">The int value to add to Y component.</param>
        /// <returns>A new Vector2Int with the added values.</returns>
        public static Vector2Int Add(this Vector2Int vector, int x, int y)
        {
            return new Vector2Int(vector.x + x, vector.y + y);
        }

        /// <summary>
        /// Subtracts an int value from all components of a Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="value">The int value to subtract from all components.</param>
        /// <returns>A new Vector2Int with the subtracted values.</returns>
        public static Vector2Int Subtract(this Vector2Int vector, int value)
        {
            return new Vector2Int(vector.x - value, vector.y - value);
        }

        /// <summary>
        /// Subtracts int values from X and Y components of a Vector2Int.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="x">The int value to subtract from X component.</param>
        /// <param name="y">The int value to subtract from Y component.</param>
        /// <returns>A new Vector2Int with the subtracted values.</returns>
        public static Vector2Int Subtract(this Vector2Int vector, int x, int y)
        {
            return new Vector2Int(vector.x - x, vector.y - y);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <param name="min">The minimum value to clamp to.</param>
        /// <param name="max">The maximum value to clamp to.</param>
        /// <returns>The clamped vector.</returns>
        public static Vector2Int Clamp(this Vector2Int vector, int min, int max)
        {
            return new Vector2Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Checks if all elements in the Vector2Int are approximately equal.
        /// </summary>
        /// <param name="vector">The original Vector2Int.</param>
        /// <returns>Returns true if all elements in the Vector2Int are approximately equal; false otherwise.</returns>
        public static bool IsUniform(this Vector2Int vector)
        {
            return Mathf.Approximately(vector.x, vector.y);
        }

        private static Vector2Int With(this Vector2Int vector, int x = int.MinValue, int y = int.MinValue)
        {
            if (x != int.MinValue) vector.x = x;
            if (y != int.MinValue) vector.y = y;

            return vector;
        }
    }
}