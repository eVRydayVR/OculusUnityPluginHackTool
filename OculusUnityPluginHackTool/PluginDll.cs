using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace OculusUnityPluginHackTool {
    public class PluginDll {
        public string Version;
        public string Filename;
        byte[] hash;
        Dictionary<String, IntRange> patchPoints;

        public PluginDll(string version, string filename, byte[] hash, Dictionary<String, IntRange> patchPoints) {
            this.Version = version;
            this.Filename = filename;
            this.hash = (byte[])hash.Clone();
            this.patchPoints = new Dictionary<String, IntRange>(patchPoints);
        }
        static HashAlgorithm GetSelectedHasher() {
            return MD5.Create();
        }

        public int GetOffset(string patchName) {
            return patchPoints[patchName].Begin;
        }

        public static byte[] HashWithPatchPoints(byte[] fileContent, Dictionary<String, IntRange> patchPoints) {
            byte[] contentCopy = (byte[])fileContent.Clone();
            foreach (var patchPoint in patchPoints.Values) {
                for (int i = patchPoint.Begin; i < patchPoint.End; i++) {
                    contentCopy[i] = 0; // Blank out patch points for hashing so we can identify already-patched DLL
                }
            }
            using (var hasher = GetSelectedHasher()) {
                return hasher.ComputeHash(contentCopy);
            }
        }

        public bool Matches(byte[] fileContent) {
            return HashWithPatchPoints(fileContent, patchPoints).SequenceEqual(hash);
        }
    }
}
