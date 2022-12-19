﻿using System;
using System.Runtime.InteropServices;

namespace RecastNav
{
    public static class RecastInterface
    {
        const string RecastDLL = "RecastNav";
        public const int MAX_POLYS = 256;

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RecastLoad(int id, byte[] buffer, int n);

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RecastGet(int id);

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecastClear();

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RecastFind(IntPtr navPtr, float[] extents, float[] startPos, float[] endPos, float[] straightPath);

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RecastFindNearestPoint(IntPtr navPtr, float[] extents, float[] pos, float[] nearestPos);

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RecastFindRandomPointAroundCircle(IntPtr navPtr, float[] extents, float[] centerPos, float radius, float[] randomPos);

        [DllImport(RecastDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int RecastFindRandomPoint(IntPtr navPtr, float[] randomPos);
    }
}