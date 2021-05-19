//Copyright 2020, ALT LLC. All Rights Reserved.
//This file is part of Antilatency SDK.
//It is subject to the license terms in the LICENSE file found in the top-level directory
//of this distribution and at http://www.antilatency.com/eula
//You may not use this file except in compliance with the License.
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
#pragma warning disable IDE1006 // Do not warn about naming style violations
#pragma warning disable IDE0017 // Do not suggest to simplify object initialization
using System.Runtime.InteropServices; //GuidAttribute
namespace Antilatency.Math {

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct float3 {
	public float x;
	public float y;
	public float z;
}

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct floatQ {
	public float x;
	public float y;
	public float z;
	public float w;
}

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct floatP3Q {
	public Antilatency.Math.float3 position;
	public Antilatency.Math.floatQ rotation;
}

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct float2 {
	public float x;
	public float y;
}

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct float2x3 {
	public Antilatency.Math.float3 x;
	public Antilatency.Math.float3 y;
}

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public struct doubleQ {
	public double x;
	public double y;
	public double z;
	public double w;
}


}
