using System;
using UnityEngine;

namespace ShizoGames.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="GameObject"/> class.
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Checks if the game object has a component of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of component to check for.</typeparam>
        /// <param name="gameObject">The game object to check for the component.</param>
        /// <returns><c>true</c> if the game object has the component; otherwise, <c>false</c>.</returns>
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component
        {
            return gameObject.TryGetComponent<T>(out _);
        }
        
        /// <summary>
        /// Checks if the game object has a component of the specified type.
        /// </summary>
        /// <param name="gameObject">The game object to check for the component.</param>
        /// <param name="type">The type of component to check for.</param>
        /// <returns><c>true</c> if the game object has the component; otherwise, <c>false</c>.</returns>
        public static bool HasComponent(this GameObject gameObject, Type type)
        {
            return gameObject.TryGetComponent(type, out _);
        }
        
        /// <summary>
        /// Returns the component of type <typeparamref name="T"/> attached to the game object, or adds a new one if none exists.
        /// </summary>
        /// <typeparam name="T">The type of component to get or add.</typeparam>
        /// <param name="gameObject">The game object to get or add the component to.</param>
        /// <returns>The component of type <typeparamref name="T"/> attached to the game object.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if (gameObject.TryGetComponent<T>(out var component)) return component;
            
            component = gameObject.AddComponent<T>();

            return component;
        }
        
        /// <summary>
        /// Returns the component of the specified <paramref name="type"/> attached to the game object, or adds a new one if none exists.
        /// </summary>
        /// <param name="gameObject">The game object to get or add the component to.</param>
        /// <param name="type">The type of component to get or add.</param>
        /// <returns>The component of the specified <paramref name="type"/> attached to the game object.</returns>
        public static Component GetOrAddComponent(this GameObject gameObject, Type type)
        {
            if (gameObject.TryGetComponent(out Component component)) return component;
            
            component = gameObject.AddComponent(type);
            
            return component;
        }
        
        /// <summary>
        /// Attempts to get the component of type <typeparamref name="T"/> in the child objects of the game object.
        /// </summary>
        /// <typeparam name="T">The type of component to get.</typeparam>
        /// <param name="gameObject">The game object to search in.</param>
        /// <param name="component">When this method returns, contains the component of type <typeparamref name="T"/> if found; otherwise, the default value.</param>
        /// <param name="includeInactive">Determines whether to include inactive child objects in the search.</param>
        /// <returns><c>true</c> if the component is found in the child objects; otherwise, <c>false</c>.</returns>
        public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component, bool includeInactive = false) 
            where T : Component
        {
            return component = gameObject.GetComponentInChildren<T>(includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of the specified <paramref name="type"/> in the child objects of the game object.
        /// </summary>
        /// <param name="gameObject">The game object to search in.</param>
        /// <param name="type">The type of component to get.</param>
        /// <param name="component">When this method returns, contains the component of the specified <paramref name="type"/> if found; otherwise, the default value.</param>
        /// <param name="includeInactive">Determines whether to include inactive child objects in the search.</param>
        /// <returns><c>true</c> if the component is found in the child objects; otherwise, <c>false</c>.</returns>
        public static bool TryGetComponentInChildren(this GameObject gameObject, Type type, out Component component, 
            bool includeInactive = false)
        {
            return component = gameObject.GetComponentInChildren(type, includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of type <typeparamref name="T"/> in the parent object of the game object.
        /// </summary>
        /// <typeparam name="T">The type of component to get.</typeparam>
        /// <param name="gameObject">The game object to search in.</param>
        /// <param name="component">When this method returns, contains the component of type <typeparamref name="T"/> if found; otherwise, the default value.</param>
        /// <param name="includeInactive">Determines whether to include inactive parent objects in the search.</param>
        /// <returns><c>true</c> if the component is found in the parent object; otherwise, <c>false</c>.</returns>
        public static bool TryGetComponentInParent<T>(this GameObject gameObject, out T component, bool includeInactive = false) 
            where T : Component
        {
            return component = gameObject.GetComponentInParent<T>(includeInactive);
        }
        
        /// <summary>
        /// Attempts to get the component of the specified <paramref name="type"/> in the parent object of the game object.
        /// </summary>
        /// <param name="gameObject">The game object to search in.</param>
        /// <param name="type">The type of component to get.</param>
        /// <param name="component">When this method returns, contains the component of the specified <paramref name="type"/> if found; otherwise, the default value.</param>
        /// <param name="includeInactive">Determines whether to include inactive parent objects in the search.</param>
        /// <returns><c>true</c> if the component is found in the parent object; otherwise, <c>false</c>.</returns>
        public static bool TryGetComponentInParent(this GameObject gameObject, Type type, out Component component, 
            bool includeInactive = false)
        {
            return component = gameObject.GetComponentInParent(type, includeInactive);
        }
    }
}