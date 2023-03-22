using System;
using UnityEngine;

namespace ShizoGames.Extensions
{
    /// <summary>
    /// Provides extension methods to modify RectTransform properties.
    /// </summary>
    public static class RectTransformExtensions
    {
        /// <summary>
        /// Sets the left edge of a RectTransform to the specified value.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="left">The value to set the left edge to.</param>
        public static void SetLeft(this RectTransform rt, float left)
        {
            rt.offsetMin = new Vector2(left, rt.offsetMin.y);
        }
 
        /// <summary>
        /// Sets the right edge of a RectTransform to the specified value.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="right">The value to set the right edge to.</param>
        public static void SetRight(this RectTransform rt, float right)
        {
            rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
        }
 
        /// <summary>
        /// Sets the top edge of a RectTransform to the specified value.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="top">The value to set the top edge to.</param>
        public static void SetTop(this RectTransform rt, float top)
        {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
        }

        /// <summary>
        /// Sets the bottom edge of a RectTransform to the specified value.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="bottom">The value to set the bottom edge to.</param>
        public static void SetBottom(this RectTransform rt, float bottom)
        {
            rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
        }

        /// <summary>
        /// Sets the anchored position and anchor points of a RectTransform to the specified values.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="align">The preset anchor point to use.</param>
        /// <param name="offsetX">The X offset of the anchored position.</param>
        /// <param name="offsetY">The Y offset of the anchored position.</param>
        public static void SetAnchor(this RectTransform rt, AnchorPresets align, int offsetX = 0, int offsetY = 0)
        {
            rt.anchoredPosition = new Vector2(offsetX, offsetY);

            switch (align)
            {
                case AnchorPresets.TopLeft:
                {
                    rt.anchorMin = new Vector2(0, 1);
                    rt.anchorMax = new Vector2(0, 1);
                    break;
                }
                case AnchorPresets.TopCenter:
                {
                    rt.anchorMin = new Vector2(0.5f, 1);
                    rt.anchorMax = new Vector2(0.5f, 1);
                    break;
                }
                case AnchorPresets.TopRight:
                {
                    rt.anchorMin = new Vector2(1, 1);
                    rt.anchorMax = new Vector2(1, 1);
                    break;
                }
                case AnchorPresets.MiddleLeft:
                {
                    rt.anchorMin = new Vector2(0, 0.5f);
                    rt.anchorMax = new Vector2(0, 0.5f);
                    break;
                }
                case AnchorPresets.MiddleCenter:
                {
                    rt.anchorMin = new Vector2(0.5f, 0.5f);
                    rt.anchorMax = new Vector2(0.5f, 0.5f);
                    break;
                }
                case AnchorPresets.MiddleRight:
                {
                    rt.anchorMin = new Vector2(1, 0.5f);
                    rt.anchorMax = new Vector2(1, 0.5f);
                    break;
                }

                case AnchorPresets.BottomLeft:
                {
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(0, 0);
                    break;
                }
                case AnchorPresets.BottomCenter:
                {
                    rt.anchorMin = new Vector2(0.5f, 0);
                    rt.anchorMax = new Vector2(0.5f, 0);
                    break;
                }
                case AnchorPresets.BottomRight:
                {
                    rt.anchorMin = new Vector2(1, 0);
                    rt.anchorMax = new Vector2(1, 0);
                    break;
                }

                case AnchorPresets.HorStretchTop:
                {
                    rt.anchorMin = new Vector2(0, 1);
                    rt.anchorMax = new Vector2(1, 1);
                    break;
                }
                case AnchorPresets.HorStretchMiddle:
                {
                    rt.anchorMin = new Vector2(0, 0.5f);
                    rt.anchorMax = new Vector2(1, 0.5f);
                    break;
                }
                case AnchorPresets.HorStretchBottom:
                {
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(1, 0);
                    break;
                }
                case AnchorPresets.VertStretchLeft:
                {
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(0, 1);
                    break;
                }
                case AnchorPresets.VertStretchCenter:
                {
                    rt.anchorMin = new Vector2(0.5f, 0);
                    rt.anchorMax = new Vector2(0.5f, 1);
                    break;
                }
                case AnchorPresets.VertStretchRight:
                {
                    rt.anchorMin = new Vector2(1, 0);
                    rt.anchorMax = new Vector2(1, 1);
                    break;
                }

                case AnchorPresets.StretchAll:
                {
                    rt.anchorMin = new Vector2(0, 0);
                    rt.anchorMax = new Vector2(1, 1);
                    break;
                }
                case AnchorPresets.BottomStretch:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(align), align, null);
            }
        }

        /// <summary>
        /// Sets the pivot point of a RectTransform to the specified preset.
        /// </summary>
        /// <param name="rt">The RectTransform to modify.</param>
        /// <param name="preset">The preset pivot point to use.</param>
        public static void SetPivot(this RectTransform rt, PivotPresets preset)
        {
            switch (preset)
            {
                case PivotPresets.TopLeft:
                    rt.pivot = new Vector2(0, 1);
                    break;
                case PivotPresets.TopCenter:
                    rt.pivot = new Vector2(0.5f, 1);
                    break;
                case PivotPresets.TopRight:
                    rt.pivot = new Vector2(1, 1);
                    break;
                case PivotPresets.MiddleLeft:
                    rt.pivot = new Vector2(0, 0.5f);
                    break;
                case PivotPresets.MiddleCenter:
                    rt.pivot = new Vector2(0.5f, 0.5f);
                    break;
                case PivotPresets.MiddleRight:
                    rt.pivot = new Vector2(1, 0.5f);
                    break;
                case PivotPresets.BottomLeft:
                    rt.pivot = new Vector2(0, 0);
                    break;
                case PivotPresets.BottomCenter:
                    rt.pivot = new Vector2(0.5f, 0);
                    break;
                case PivotPresets.BottomRight:
                    rt.pivot = new Vector2(1, 0);
                    break;
                default:
                    rt.pivot = rt.pivot;
                    break;
            }
        }
    }
    
    public enum AnchorPresets
    {
        TopLeft,
        TopCenter,
        TopRight,

        MiddleLeft,
        MiddleCenter,
        MiddleRight,

        BottomLeft,
        BottomCenter,
        BottomRight,
        BottomStretch,

        VertStretchLeft,
        VertStretchRight,
        VertStretchCenter,

        HorStretchTop,
        HorStretchMiddle,
        HorStretchBottom,

        StretchAll
    }

    public enum PivotPresets
    {
        TopLeft,
        TopCenter,
        TopRight,

        MiddleLeft,
        MiddleCenter,
        MiddleRight,

        BottomLeft,
        BottomCenter,
        BottomRight,
    }
}