#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_2017_1_OR_NEWER
using UnityEngine.Timeline;
#endif

namespace UMotionEditor
{
    public class TimelineClipWrapper
    {
        //********************************************************************************
        // Public Properties
        //********************************************************************************

        public string DisplayName
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.displayName;
                #else
                return "";
                #endif
            }
        }

        public AnimationClip AnimationClip
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.animationClip;
                #else
                return null;
                #endif
            }
        }

        public bool AnimationTrackApplyOffsets
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return ((AnimationTrack)timelineClip.parentTrack).applyOffsets;
                #else
                return false;
                #endif
            }
        }

        public Vector3 AnimationTrackPosition
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return ((AnimationTrack)timelineClip.parentTrack).position;
                #else
                return Vector3.zero;
                #endif
            }
        }

        public Quaternion AnimationTrackRotation
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return ((AnimationTrack)timelineClip.parentTrack).rotation;
                #else
                return Quaternion.identity;
                #endif
            }
        }

        public Vector3 AnimationPlayablePosition
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return ((AnimationPlayableAsset)timelineClip.asset).position;
                #else
                return Vector3.zero;
                #endif
            }
        }

        public Quaternion AnimationPlayableRotation
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return ((AnimationPlayableAsset)timelineClip.asset).rotation;
                #else
                return Quaternion.identity;
                #endif
            }
        }

        public ScriptableObject ParentTrack
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.parentTrack;
                #else
                return null;
                #endif
            }
        }

        public double Start
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.start;
                #else
                return 0;
                #endif
            }
        }

        public double ClipIn
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.clipIn;
                #else
                return 0;
                #endif
            }
        }

        public double TimeScale
        {
            get
            {
                #if UNITY_2017_1_OR_NEWER
                return timelineClip.timeScale;
                #else
                return 0;
                #endif
            }
        }

        //********************************************************************************
        // Private Properties
        //********************************************************************************
        #if UNITY_2017_1_OR_NEWER
        private TimelineClip timelineClip = null;
        #endif

        //********************************************************************************
        // Public Methods
        //********************************************************************************

        public static TimelineClipWrapper WrapTimelineClip(object timelineClipObj)
        {
            #if UNITY_2017_1_OR_NEWER
            TimelineClip timelineClip = timelineClipObj as TimelineClip;
            TimelineClipWrapper wrapper = null;
            if (timelineClip != null)
            {
                wrapper = new TimelineClipWrapper();
                wrapper.timelineClip = timelineClip;
            }
            return wrapper;
            #else
            return null;
            #endif
        }

        //********************************************************************************
        // Private Methods
        //********************************************************************************

        private TimelineClipWrapper()
        {
        }
    }
}
#endif