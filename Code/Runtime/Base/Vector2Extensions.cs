using UnityEngine;

namespace KDebugger.Plugins.ShizoGames.ShizoExtensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Vector2"/> struct.
    /// </summary>
    public static class Vector2Extensions
    {
        /// <summary>
        /// Returns a new Vector2 with the X component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <returns>New Vector2 with replacement for the specified values.</returns>
        public static Vector2 WithX(this Vector2 vector, float x)
        {
            return vector.With(x: x);
        }

        /// <summary>
        /// Returns a new Vector2 with the Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector2 with replacement for the specified values.</returns>
        public static Vector2 WithY(this Vector2 vector, float y)
        {
            return vector.With(y: y);
        }

        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector2 with replacement for the specified values.</returns>
        public static Vector2 WithXY(this Vector2 vector, float x, float y)
        {
            return vector.With(x: x, y: y);
        }
        
        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="value">The Vector2 containing the new X and Y values.</param>
        /// <returns>New Vector2 with replacement for the specified values.</returns>
        public static Vector2 WithXY(this Vector2 vector, Vector2 value)
        {
            return vector.With(x: value.x, y: value.y);
        }
        
        /// <summary>
        /// Returns a new Vector2 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="value">The new X and Y value to set.</param>
        /// <returns>New Vector2 with replacement for the specified values.</returns>
        public static Vector2 WithXY(this Vector2 vector, float value)
        {
            return vector.With(x: value, y: value);
        }
        
        /// <summary>
        /// Returns a new Vector2 object with the X and Y components swapped.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>A new Vector2 object with the X and Y components swapped.</returns>
        public static Vector2 GetYX(this Vector2 vector)
        {
            return vector.Get(1, 0);
        }
        
        /// <summary>
        /// Inserts the specified X value into the Vector2, resulting in a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="x">The X value to insert.</param>
        /// <returns>A new Vector3 with the specified X value and the Y and Z values from the original Vector2.</returns>
        public static Vector3 InsertX(this Vector2 vector, float x)
        {
            return new Vector3(x, vector.x, vector.y);
        }

        /// <summary>
        /// Inserts the specified Y value into the Vector2, resulting in a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="y">The Y value to insert.</param>
        /// <returns>A new Vector3 with the specified Y value and the X and Z values from the original Vector2.</returns>
        public static Vector3 InsertY(this Vector2 vector, float y)
        {
            return new Vector3(vector.x, y, vector.y);
        }

        /// <summary>
        /// Inserts the specified Z value into the Vector2, resulting in a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="z">The Z value to insert.</param>
        /// <returns>A new Vector3 with the specified Z value and the X and Y values from the original Vector2.</returns>
        public static Vector3 InsertZ(this Vector2 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }

        /// <summary>
        /// Returns the minimum value of the Vector2 components.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>The minimum value of the Vector2 components.</returns>
        public static float MinValue(this Vector2 vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector2 components.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>The maximum value of the Vector2 components.</returns>
        public static float MaxValue(this Vector2 vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }
        
        /// <summary>
        /// Returns the index of the largest component of the Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>The index of the largest component (0 is X, 1 is Y).</returns>
        public static int MaxValueIndex(this Vector2 vector)
        {
            return vector.x > vector.y ? 0 : 1;
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>The index of the smallest component (0 is X, 1 is Y).</returns>
        public static int MinValueIndex(this Vector2 vector)
        {
            return vector.x < vector.y ? 0 : 1;
        }

        /// <summary>
        /// Remaps all components of a Vector2 from one range of values to another.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        /// <returns>A new Vector2 with remapped components.</returns>
        public static Vector2 Remap(this Vector2 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector2(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }
        
        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>A vector with each component replaced by its absolute value.</returns>
        public static Vector2 Abs(this Vector2 vector)
        {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Adds a float value to all components of a Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="value">The float value to add to all components.</param>
        /// <returns>A new Vector2 with the added values.</returns>
        public static Vector2 Add(this Vector2 vector, float value)
        {
            return new Vector2(vector.x + value, vector.y + value);
        }

        /// <summary>
        /// Adds float values to X and Y components of a Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="x">The float value to add to X component.</param>
        /// <param name="y">The float value to add to Y component.</param>
        /// <returns>A new Vector2 with the added values.</returns>
        public static Vector2 Add(this Vector2 vector, float x, float y)
        {
            return new Vector2(vector.x + x, vector.y + y);
        }

        /// <summary>
        /// Subtracts a Vector2 value from a Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="value">The Vector2 value to subtract.</param>
        /// <returns>A new Vector2 with the subtracted values.</returns>
        public static Vector2 Subtract(this Vector2 vector, Vector2 value)
        {
            return new Vector2(vector.x - value.x, vector.y - value.y);
        }

        /// <summary>
        /// Subtracts a float value from all components of a Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2 to modify.</param>
        /// <param name="value">The float value to subtract from all components.</param>
        /// <returns>A new Vector2 with the subtracted values.</returns>
        public static Vector2 Subtract(this Vector2 vector, float value)
        {
            return new Vector2(vector.x - value, vector.y - value);
        }

        /// <summary>
        /// Subtracts float values from X and Y components of a Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="x">The float value to subtract from X component.</param>
        /// <param name="y">The float value to subtract from Y component.</param>
        /// <returns>A new Vector2 with the subtracted values.</returns>
        public static Vector2 Subtract(this Vector2 vector, float x, float y)
        {
            return new Vector2(vector.x - x, vector.y - y);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="min">The minimum value to clamp to.</param>
        /// <param name="max">The maximum value to clamp to.</param>
        /// <returns>The clamped vector.</returns>
        public static Vector2 Clamp(this Vector2 vector, float min, float max)
        {
            return new Vector2(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }
        
        /// <summary>
        /// Returns a vector whose components are clamped between 0 and 1.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>A vector with components clamped between 0 and 1.</returns>
        public static Vector2 Clamp01(this Vector2 vector)
        {
            return new Vector2(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y));
        }
        
        /// <summary>
        /// Checks if all elements in the Vector2 are approximately equal.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <returns>Returns true if all elements in the Vector2 are approximately equal; false otherwise.</returns>
        public static bool IsUniform(this Vector2 vector)
        {
            return Mathf.Approximately(vector.x, vector.y);
        }
        
        private static Vector2 With(this Vector2 vector, float x = float.NaN, float y = float.NaN)
        {
            if (!float.IsNaN(x)) vector.x = x;
            if (!float.IsNaN(y)) vector.y = y;
            
            return vector;
        }
        
        private static Vector2 Get(this Vector2 vector, int axis1, int axis2)
        {
            return new Vector2(vector[axis1], vector[axis2]);
        }
    }
}