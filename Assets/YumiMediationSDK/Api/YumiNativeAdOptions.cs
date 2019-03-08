﻿using System;
namespace YumiMediationSDK.Api
{
    public class YumiNativeAdOptions
    {
        internal AdOptionViewPosition adChoiseViewPosition;
        internal AdAttribution adAttribution;
        internal TextOptions titleTextOptions;
        internal TextOptions descTextOptions;
        internal TextOptions callToActionTextOptions;
        internal ScaleType iconScaleType;
        internal ScaleType coverImageScaleType;

        internal YumiNativeAdOptions(NativeAdOptionsBuilder builder)
        {
            adChoiseViewPosition = builder.adChoiseViewPosition;
            adAttribution = builder.adAttribution;
            titleTextOptions = builder.titleTextOptions;
            descTextOptions = builder.descTextOptions;
            callToActionTextOptions = builder.callToActionTextOptions;
            iconScaleType = builder.iconScaleType;
            coverImageScaleType = builder.coverImageScaleType;
        }
    }

    public class NativeAdOptionsBuilder
    {
        internal AdOptionViewPosition adChoiseViewPosition = AdOptionViewPosition.TOP_RIGHT;
        internal AdAttribution adAttribution = new AdAttribution
        {
            AdOptionsPosition = AdOptionViewPosition.TOP_LEFT,
            text = "ad",
            textColor = 0xff222222,
            backgroundColor = 0x00000000,
            textSize = 8,
            hide = false
        };

        internal TextOptions titleTextOptions = new TextOptions
        {
            textSize = 12,
            textColor = 0x12345678,
            backgroundColor = 0x12345678

        };

        internal TextOptions descTextOptions = new TextOptions
        {
            textSize = 8,
            textColor = 0xff222222,
            backgroundColor = 0x00000000
        };

        internal TextOptions callToActionTextOptions = new TextOptions
        {
            textSize = 8,
            textColor = 0xff222222,
            backgroundColor = 0x00000000
        };

        internal ScaleType iconScaleType = ScaleType.CENTER_CROP;
        internal ScaleType coverImageScaleType = ScaleType.CENTER_CROP;


        public NativeAdOptionsBuilder setAdChoices(AdOptionViewPosition position)
        {
            adChoiseViewPosition = position;
            return this;
        }

        public NativeAdOptionsBuilder setAdAttribution(AdOptionViewPosition position, string text, int textSize, uint textColor, uint backgroundColor, bool hide)
        {
            adAttribution.AdOptionsPosition = position;
            adAttribution.text = text;
            adAttribution.textSize = textSize;
            adAttribution.textColor = textColor;
            adAttribution.backgroundColor = backgroundColor;
            adAttribution.hide = hide;
            return this;
        }

        public NativeAdOptionsBuilder setTitleTextOptions(int textSize, uint textColor, uint backgroundColor)
        {
            titleTextOptions.textSize = textSize;
            titleTextOptions.textColor = textColor;
            titleTextOptions.backgroundColor = backgroundColor;
            return this;
        }

        public NativeAdOptionsBuilder setDescTextOptions(int textSize, uint textColor, uint backgroundColor)
        {
            descTextOptions.textSize = textSize;
            descTextOptions.textColor = textColor;
            descTextOptions.backgroundColor = backgroundColor;
            return this;
        }

        public NativeAdOptionsBuilder setCallToActionTextOptions(int textSize, uint textColor, uint backgroundColor)
        {
            callToActionTextOptions.textSize = textSize;
            callToActionTextOptions.textColor = textColor;
            callToActionTextOptions.backgroundColor = backgroundColor;
            return this;
        }

        public NativeAdOptionsBuilder setIconScaleType(ScaleType scaleType)
        {
            iconScaleType = scaleType;
            return this;
        }

        public NativeAdOptionsBuilder setCoverImageScaleType(ScaleType scaleType)
        {
            coverImageScaleType = scaleType;
            return this;
        }

        public YumiNativeAdOptions Build()
        {
            return new YumiNativeAdOptions(this);
        }
    }

    public enum AdOptionViewPosition
    {
        TOP_LEFT,
        TOP_RIGHT,
        BOTTOM_LEFT,
        BOTTOM_RIGHT
    }

    public enum ScaleType
    {
        CENTER_CROP,
        FIT_CENTER
    }

    struct AdAttribution
    {
        internal AdOptionViewPosition AdOptionsPosition;
        internal string text;
        /// <summary>
        /// ARGB format: 0xffffffff(0xAARRGGBB) refer to wihte
        /// </summary>
        internal uint textColor;
        internal uint backgroundColor;
        /// <summary>
        /// The size of the ad attribution text. 
        /// 1 = 1 point on iOS, 1 = 1sp on Android.
        /// </summary>
        internal int textSize;
        internal bool hide;
    }

    struct TextOptions
    {
        internal int textSize;
        internal uint textColor;
        internal uint backgroundColor;
    }
}
