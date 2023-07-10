using UnityEngine;

namespace KDebugger.Plugins.ShizoGames.ShizoExtensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Vector3"/> struct.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Returns a new Vector3 with the X component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithX(this Vector3 vector, float x)
        {
            return vector.With(x: x);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithY(this Vector3 vector, float y)
        {
            return vector.With(y: y);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithZ(this Vector3 vector, float z)
        {
            return vector.With(z: z);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXY(this Vector3 vector, float x, float y)
        {
            return vector.With(x: x, y: y);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The Vector2 containing the new X and Y values.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXY(this Vector3 vector, Vector2 value)
        {
            return vector.With(x: value.x, y: value.y);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The new X and Y value to set.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXY(this Vector3 vector, float value)
        {
            return vector.With(x: value, y: value);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXZ(this Vector3 vector, float x, float z)
        {
            return vector.With(x: x, z: z);
        }

        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The Vector2 containing the new X and Z values.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXZ(this Vector3 vector, Vector2 value)
        {
            return vector.With(x: value.x, z: value.y);
        }

        /// <summary>
        /// Returns a new Vector3 with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The new X and Z value to set.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXZ(this Vector3 vector, float value)
        {
            return vector.With(x: value, z: value);
        }

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithYZ(this Vector3 vector, float y, float z)
        {
            return vector.With(y: y, z: z);
        }

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The Vector2 containing the new Y and Z values.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithYZ(this Vector3 vector, Vector2 value)
        {
            return vector.With(y: value.x, z: value.y);
        }

        /// <summary>
        /// Returns a new Vector3 with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The new Y and Z value to set.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithYZ(this Vector3 vector, float value)
        {
            return vector.With(y: value, z: value);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXYZ(this Vector3 vector, float x, float y, float z)
        {
            return vector.With(x: x, y: y, z: z);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The Vector3 containing the new X, Y and Z values.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXYZ(this Vector3 vector, Vector3 value)
        {
            return vector.With(x: value.x, y: value.y, z: value.z);
        }
        
        /// <summary>
        /// Returns a new Vector3 with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The new X, Y and Z value to set.</param>
        /// <returns>New Vector3 with replacement for the specified values.</returns>
        public static Vector3 WithXYZ(this Vector3 vector, float value)
        {
            return vector.With(x: value, y: value, z: value);
        }
        
        /// <summary>
        /// Gets a new Vector2 with the X and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector2 with the X and Y components.</returns>
        public static Vector2 GetXY(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }

        /// <summary>
        /// Gets a new Vector2 with the X and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector2 with the X and Z components.</returns>
        public static Vector2 GetXZ(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        /// <summary>
        /// Gets a new Vector2 with the Y and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector2 with the Y and Z components.</returns>
        public static Vector2 GetYZ(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }

        /// <summary>
        /// Gets a new Vector3 with the X, Z, and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector3 with the components arranged in XZY order.</returns>
        public static Vector3 GetXZY(this Vector3 vector)
        {
            return vector.Get(0, 2, 1);
        }

        /// <summary>
        /// Gets a new Vector3 with the Y, X, and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector3 with the components arranged in YXZ order.</returns>
        public static Vector3 GetYXZ(this Vector3 vector)
        {
            return vector.Get(1, 0, 2);
        }

        /// <summary>
        /// Gets a new Vector3 with the Y, Z, and X components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector3 with the components arranged in YZX order.</returns>
        public static Vector3 GetYZX(this Vector3 vector)
        {
            return vector.Get(1, 2, 0);
        }

        /// <summary>
        /// Gets a new Vector3 with the Z, X, and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector3 with the components arranged in ZXY order.</returns>
        public static Vector3 GetZXY(this Vector3 vector)
        {
            return vector.Get(2, 0, 1);
        }

        /// <summary>
        /// Gets a new Vector3 with the Z, Y, and X components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A new Vector3 with the components arranged in ZYX order.</returns>
        public static Vector3 GetZYX(this Vector3 vector)
        {
            return vector.Get(2, 1, 0);
        }

        /// <summary>
        /// Inserts the specified X value into the Vector3, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The X value to insert.</param>
        /// <returns>A new Vector3 with the specified W value and the Y, Z and W values from the original Vector3.</returns>
        public static Vector4 InsertX(this Vector3 vector, float x)
        {
            return new Vector4(x, vector.x, vector.y, vector.z);
        }

        /// <summary>
        /// Inserts the specified Y value into the Vector3, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="y">The Y value to insert.</param>
        /// <returns>A new Vector3 with the specified W value and the X, Z and W values from the original Vector3.</returns>
        public static Vector4 InsertY(this Vector3 vector, float y)
        {
            return new Vector4(vector.x, y, vector.y, vector.z);
        }

        /// <summary>
        /// Inserts the specified Z value into the Vector3, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="z">The Z value to insert.</param>
        /// <returns>A new Vector3 with the specified Z value and the X, Y and W values from the original Vector3.</returns>
        public static Vector4 InsertZ(this Vector3 vector, float z)
        {
            return new Vector4(vector.x, vector.y, z, vector.z);
        }

        /// <summary>
        /// Inserts the specified W value into the Vector3, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="w">The W value to insert.</param>
        /// <returns>A new Vector3 with the specified W value and the X, Y and Z values from the original Vector3.</returns>
        public static Vector4 InsertW(this Vector3 vector, float w)
        {
            return new Vector4(vector.x, vector.y, vector.z, w);
        }

        /// <summary>
        /// Returns the minimum value of the Vector3 components.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>The minimum value of the Vector3 components.</returns>
        public static float MinValue(this Vector3 vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector3 components.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>The maximum value of the Vector3 components.</returns>
        public static float MaxValue(this Vector3 vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>The index of the largest component (0 is X, 1 is Y, 2 is Z).</returns>
        public static int MaxValueIndex(this Vector3 vector)
        {
            if (vector.x > vector.y && vector.x > vector.z)
            {
                return 0;
            }

            return vector.y > vector.z ? 1 : 2;
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>The index of the smallest component (0 is X, 1 is Y, 2 is Z).</returns>
        public static int MinValueIndex(this Vector3 vector)
        {
            if (vector.x < vector.y && vector.x < vector.z)
            {
                return 0;
            }

            return vector.y < vector.z ? 1 : 2;
        }

        /// <summary>
        /// Remaps all components of a Vector3 from one range of values to another.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="min1">The minimum value of the starting range.</param>
        /// <param name="max1">The maximum value of the starting range.</param>
        /// <param name="min2">The minimum value of the target range.</param>
        /// <param name="max2">The maximum value of the target range.</param>
        /// <returns>A new Vector3 with remapped components.</returns>
        public static Vector3 Remap(this Vector3 vector, float min1, float max1, float min2, float max2)
        {
            return new Vector3(vector.x.Remap(min1, max1, min2, max2), vector.y.Remap(min1, max1, min2, max2));
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A Vector3 with each component replaced by its absolute value.</returns>
        public static Vector3 Abs(this Vector3 vector)
        {
            return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Adds a float value to all components of a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The float value to add to all components.</param>
        /// <returns>A new Vector3 with the added values.</returns>
        public static Vector3 Add(this Vector3 vector, float value)
        {
            return new Vector3(vector.x + value, vector.y + value, vector.z + value);
        }

        /// <summary>
        /// Adds float values to X, Y, and Z components of a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The float value to add to X component.</param>
        /// <param name="y">The float value to add to Y component.</param>
        /// <param name="z">The float value to add to Z component.</param>
        /// <returns>A new Vector3 with the added values.</returns>
        public static Vector3 Add(this Vector3 vector, float x, float y, float z)
        {
            return new Vector3(vector.x + x, vector.y + y, vector.z + z);
        }

        /// <summary>
        /// Subtracts a float value from all components of a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="value">The float value to subtract from all components.</param>
        /// <returns>A new Vector3 with the subtracted values.</returns>
        public static Vector3 Subtract(this Vector3 vector, float value)
        {
            return new Vector3(vector.x - value, vector.y - value, vector.z - value);
        }

        /// <summary>
        /// Subtracts float values from X, Y, and Z components of a Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="x">The float value to subtract from X component.</param>
        /// <param name="y">The float value to subtract from Y component.</param>
        /// <param name="z">The float value to subtract from Z component.</param>
        /// <returns>A new Vector3 with the subtracted values.</returns>
        public static Vector3 Subtract(this Vector3 vector, float x, float y, float z)
        {
            return new Vector3(vector.x - x, vector.y - y, vector.z - z);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="min">The minimum value to clamp to.</param>
        /// <param name="max">The maximum value to clamp to.</param>
        /// <returns>The clamped vector.</returns>
        public static Vector3 Clamp(this Vector3 vector, float min, float max)
        {
            return new Vector3(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Returns a vector whose components are clamped between 0 and 1.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>A vector with components clamped between 0 and 1.</returns>
        public static Vector3 Clamp01(this Vector3 vector)
        {
            return new Vector3(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y), Mathf.Clamp01(vector.z));
        }

        /// <summary>
        /// Checks if all elements in the Vector3 are approximately equal.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <returns>Returns true if all elements in the Vector3 are approximately equal; false otherwise.</returns>
        public static bool IsUniform(this Vector3 vector)
        {
            return Mathf.Approximately(vector.x, vector.y) && Mathf.Approximately(vector.y, vector.z);
        }

        private static Vector3 With(this Vector3 vector, float x = float.NaN, float y = float.NaN, float z = float.NaN)
        {
            if (!float.IsNaN(x)) vector.x = x;
            if (!float.IsNaN(y)) vector.y = y;
            if (!float.IsNaN(z)) vector.z = z;

            return vector;
        }
        
        private static Vector3 Get(this Vector3 vector, int axis1, int axis2, int axis3)
        {
            return new Vector3(vector[axis1], vector[axis2], vector[axis3]);
        }
    }
}