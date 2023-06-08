using UnityEngine;

namespace ShizoGames.ShizoExtensions.Base
{
    /// <summary>
    /// Provides extension methods for the <see cref="Vector3Int"/> struct.
    /// </summary>
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// Returns a new Vector3Int with the X component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithX(this Vector3Int vector, int x)
        {
            return vector.With(x: x);
        }

        /// <summary>
        /// Returns a new Vector3Int with the Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithY(this Vector3Int vector, int y)
        {
            return vector.With(y: y);
        }

        /// <summary>
        /// Returns a new Vector3Int with the Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithZ(this Vector3Int vector, int z)
        {
            return vector.With(z: z);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, int x, int y)
        {
            return vector.With(x: x, y: y);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The Vector2Int containing the new X and Y values.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, Vector2Int value)
        {
            return vector.With(x: value.x, y: value.y);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Y component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The new X and Y value to set.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, int value)
        {
            return vector.With(x: value, y: value);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z)
        {
            return vector.With(x: x, z: z);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The Vector2Int containing the new X and Z values.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, Vector2Int value)
        {
            return vector.With(x: value.x, z: value.y);
        }

        /// <summary>
        /// Returns a new Vector3Int with the X and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The new X and Z value to set.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, int value)
        {
            return vector.With(x: value, z: value);
        }

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z)
        {
            return vector.With(y: y, z: z);
        }

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The Vector2Int containing the new Y and Z values.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, Vector2Int value)
        {
            return vector.With(y: value.x, z: value.y);
        }

        /// <summary>
        /// Returns a new Vector3Int with the Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The new Y and Z value to set.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, int value)
        {
            return vector.With(y: value, z: value);
        }
        
        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The value to set the X component to.</param>
        /// <param name="y">The value to set the Y component to.</param>
        /// <param name="z">The value to set the Z component to.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXYZ(this Vector3Int vector, int x, int y, int z)
        {
            return vector.With(x: x, y: y, z: z);
        }
        
        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The Vector3Int containing the new X, Y and Z values.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXYZ(this Vector3Int vector, Vector3Int value)
        {
            return vector.With(x: value.x, y: value.y, z: value.z);
        }
        
        /// <summary>
        /// Returns a new Vector3Int with the X, Y and Z component set to the given value.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The new X, Y and Z value to set.</param>
        /// <returns>New Vector3Int with replacement for the specified values.</returns>
        public static Vector3Int WithXYZ(this Vector3Int vector, int value)
        {
            return vector.With(x: value, y: value, z: value);
        }

        /// <summary>
        /// Gets a new Vector2Int with the X and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector2Int with the X and Y components.</returns>
        public static Vector2Int GetXY(this Vector3Int vector)
        {
            return new Vector2Int(vector.x, vector.y);
        }

        /// <summary>
        /// Gets a new Vector2Int with the X and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector2Int with the X and Z components.</returns>
        public static Vector2Int GetXZ(this Vector3Int vector)
        {
            return new Vector2Int(vector.x, vector.z);
        }

        /// <summary>
        /// Gets a new Vector2Int with the Y and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector2Int with the Y and Z components.</returns>
        public static Vector2Int GetYZ(this Vector3Int vector)
        {
            return new Vector2Int(vector.y, vector.z);
        }

        /// <summary>
        /// Gets a new Vector3Int with the X, Z, and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector3Int with the components arranged in XZY order.</returns>
        public static Vector3Int GetXZY(this Vector3Int vector)
        {
            return vector.Get(0, 2, 1);
        }

        /// <summary>
        /// Gets a new Vector3Int with the Y, X, and Z components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector3Int with the components arranged in YXZ order.</returns>
        public static Vector3Int GetYXZ(this Vector3Int vector)
        {
            return vector.Get(1, 0, 2);
        }

        /// <summary>
        /// Gets a new Vector3Int with the Y, Z, and X components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector3Int with the components arranged in YZX order.</returns>
        public static Vector3Int GetYZX(this Vector3Int vector)
        {
            return vector.Get(1, 2, 0);
        }

        /// <summary>
        /// Gets a new Vector3Int with the Z, X, and Y components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector3Int with the components arranged in ZXY order.</returns>
        public static Vector3Int GetZXY(this Vector3Int vector)
        {
            return vector.Get(2, 0, 1);
        }

        /// <summary>
        /// Gets a new Vector3Int with the Z, Y, and X components of the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A new Vector3Int with the components arranged in ZYX order.</returns>
        public static Vector3Int GetZYX(this Vector3Int vector)
        {
            return vector.Get(2, 1, 0);
        }

        /// <summary>
        /// Inserts the specified X value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The X value to insert.</param>
        /// <returns>A new Vector3Int with the specified W value and the Y, Z and W values from the original Vector3Int.</returns>
        public static Vector4 InsertX(this Vector3Int vector, int x)
        {
            return new Vector4(x, vector.x, vector.y, vector.z);
        }

        /// <summary>
        /// Inserts the specified Y value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="y">The Y value to insert.</param>
        /// <returns>A new Vector3Int with the specified W value and the X, Z and W values from the original Vector3Int.</returns>
        public static Vector4 InsertY(this Vector3Int vector, int y)
        {
            return new Vector4(vector.x, y, vector.y, vector.z);
        }

        /// <summary>
        /// Inserts the specified Z value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="z">The Z value to insert.</param>
        /// <returns>A new Vector3Int with the specified Z value and the X, Y and W values from the original Vector3Int.</returns>
        public static Vector4 InsertZ(this Vector3Int vector, int z)
        {
            return new Vector4(vector.x, vector.y, z, vector.z);
        }

        /// <summary>
        /// Inserts the specified W value into the Vector3Int, resulting in a Vector4.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="w">The W value to insert.</param>
        /// <returns>A new Vector3Int with the specified W value and the X, Y and Z values from the original Vector3Int.</returns>
        public static Vector4 InsertW(this Vector3Int vector, int w)
        {
            return new Vector4(vector.x, vector.y, vector.z, w);
        }

        /// <summary>
        /// Returns the minimum value of the Vector3Int components.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>The minimum value of the Vector3Int components.</returns>
        public static int MinValue(this Vector3Int vector)
        {
            return Mathf.Min(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the maximum value of the Vector3Int components.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>The maximum value of the Vector3Int components.</returns>
        public static int MaxValue(this Vector3Int vector)
        {
            return Mathf.Max(vector.x, vector.y);
        }

        /// <summary>
        /// Returns the index of the largest component of the Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>The index of the largest component (0 is X, 1 is Y, 2 is Z).</returns>
        public static int MaxValueIndex(this Vector3Int vector)
        {
            if (vector.x > vector.y && vector.x > vector.z)
            {
                return 0;
            }

            return vector.y > vector.z ? 1 : 2;
        }

        /// <summary>
        /// Returns the index of the smallest component of the Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>The index of the smallest component (0 is X, 1 is Y, 2 is Z).</returns>
        public static int MinValueIndex(this Vector3Int vector)
        {
            if (vector.x < vector.y && vector.x < vector.z)
            {
                return 0;
            }

            return vector.y < vector.z ? 1 : 2;
        }

        /// <summary>
        /// Returns a vector where each component is the absolute value of the corresponding component in the original vector.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>A Vector3Int with each component replaced by its absolute value.</returns>
        public static Vector3Int Abs(this Vector3Int vector)
        {
            return new Vector3Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Adds a int value to all components of a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The int value to add to all components.</param>
        /// <returns>A new Vector3Int with the added values.</returns>
        public static Vector3Int Add(this Vector3Int vector, int value)
        {
            return new Vector3Int(vector.x + value, vector.y + value, vector.z + value);
        }

        /// <summary>
        /// Adds int values to X, Y, and Z components of a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The int value to add to X component.</param>
        /// <param name="y">The int value to add to Y component.</param>
        /// <param name="z">The int value to add to Z component.</param>
        /// <returns>A new Vector3Int with the added values.</returns>
        public static Vector3Int Add(this Vector3Int vector, int x, int y, int z)
        {
            return new Vector3Int(vector.x + x, vector.y + y, vector.z + z);
        }

        /// <summary>
        /// Subtracts a int value from all components of a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="value">The int value to subtract from all components.</param>
        /// <returns>A new Vector3Int with the subtracted values.</returns>
        public static Vector3Int Subtract(this Vector3Int vector, int value)
        {
            return new Vector3Int(vector.x - value, vector.y - value, vector.z - value);
        }

        /// <summary>
        /// Subtracts int values from X, Y, and Z components of a Vector3Int.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="x">The int value to subtract from X component.</param>
        /// <param name="y">The int value to subtract from Y component.</param>
        /// <param name="z">The int value to subtract from Z component.</param>
        /// <returns>A new Vector3Int with the subtracted values.</returns>
        public static Vector3Int Subtract(this Vector3Int vector, int x, int y, int z)
        {
            return new Vector3Int(vector.x - x, vector.y - y, vector.z - z);
        }

        /// <summary>
        /// Clamps the values of the vector's components between the specified minimum and maximum values.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <param name="min">The minimum value to clamp to.</param>
        /// <param name="max">The maximum value to clamp to.</param>
        /// <returns>The clamped vector.</returns>
        public static Vector3Int Clamp(this Vector3Int vector, int min, int max)
        {
            return new Vector3Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max), Mathf.Clamp(vector.z, min, max));
        }

        /// <summary>
        /// Checks if all elements in the Vector3Int are approximately equal.
        /// </summary>
        /// <param name="vector">The original Vector3Int.</param>
        /// <returns>Returns true if all elements in the Vector3Int are approximately equal; false otherwise.</returns>
        public static bool IsUniform(this Vector3Int vector)
        {
            return Mathf.Approximately(vector.x, vector.y) && Mathf.Approximately(vector.y, vector.z);
        }

        private static Vector3Int With(this Vector3Int vector, int x = int.MinValue, int y = int.MinValue, int z = int.MinValue)
        {
            if (x != int.MinValue) vector.x = x;
            if (y != int.MinValue) vector.y = y;
            if (z != int.MinValue) vector.z = z;

            return vector;
        }
        
        private static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3)
        {
            return new Vector3Int(vector[axis1], vector[axis2], vector[axis3]);
        }
    }
}