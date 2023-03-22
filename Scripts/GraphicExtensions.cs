using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ShizoGames.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="Graphic"/> class.
    /// </summary>
    public static class GraphicExtensions
    {
        /// <summary>
        /// Fades the color of the graphic to the specified <paramref name="targetColor"/> over the specified <paramref name="duration"/>.
        /// </summary>
        /// <param name="graphic">The graphic to fade.</param>
        /// <param name="targetColor">The target color to fade to.</param>
        /// <param name="duration">The duration of the fade.</param>
        public static void FadeColorTo(this Graphic graphic, Color targetColor, float duration)
        {
            graphic.StartCoroutine(graphic.FadeColor(targetColor, duration));
        }

        /// <summary>
        /// Fades the graphic in over the specified <paramref name="duration"/>.
        /// </summary>
        /// <param name="graphic">The graphic to fade in.</param>
        /// <param name="duration">The duration of the fade.</param>
        public static void FadeIn(this Graphic graphic, float duration)
        {
            var color = graphic.color;
            color.a = 1f;

            graphic.FadeColorTo(color, duration);
        }

        /// <summary>
        /// Fades the graphic out over the specified <paramref name="duration"/>.
        /// </summary>
        /// <param name="graphic">The graphic to fade out.</param>
        /// <param name="duration">The duration of the fade.</param>
        public static void FadeOut(this Graphic graphic, float duration)
        {
            var color = graphic.color;
            color.a = 0f;

            graphic.FadeColorTo(color, duration);
        }

        /// <summary>
        /// Fades the color of the graphic to the specified <paramref name="targetColor"/> over the specified <paramref name="duration"/>.
        /// </summary>
        /// <param name="graphic">The graphic to fade.</param>
        /// <param name="targetColor">The target color to fade to.</param>
        /// <param name="duration">The duration of the fade.</param>
        /// <returns>An enumerator for the coroutine.</returns>
        public static IEnumerator FadeColor(this Graphic graphic, Color targetColor, float duration)
        {
            var startColor = graphic.color;
            var elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                var t = elapsedTime / duration;
                graphic.color = Color.Lerp(startColor, targetColor, t);
                elapsedTime += Time.unscaledDeltaTime;

                yield return null;
            }

            graphic.color = targetColor;
        }
    }
}