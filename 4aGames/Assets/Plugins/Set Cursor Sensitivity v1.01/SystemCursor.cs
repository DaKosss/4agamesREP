using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;

public class SystemCursor : MonoBehaviour {
[DllImport("User32.dll")]
static extern Boolean SystemParametersInfo(UInt32 uiAction,UInt32 uiParam,UInt32 pvParam,UInt32 fWinIni);
public static int StoredSensitivity;
public static int LocalSensitivity;
public static int CustomSensitivity;
public static bool InsideCustomArea;
//============== Awake
void Awake () {
//--------------------------------------------------------------------------------------------------------- Initialize values
LocalSensitivity = System.Windows.Forms.SystemInformation.MouseSpeed;
StoredSensitivity = System.Windows.Forms.SystemInformation.MouseSpeed;
CustomSensitivity = System.Windows.Forms.SystemInformation.MouseSpeed;
}
//============== Update
void Update() {
//--------------------------------------------------------------------------------------------------------- Sensitivity Checks
if (new Rect(0,0,UnityEngine.Screen.width,UnityEngine.Screen.height).Contains(Input.mousePosition)) {
if (InsideCustomArea) {
if (GetCurrentSensitivity() != CustomSensitivity) {
SystemParametersInfo((UInt32)0x0071,0,(uint)CustomSensitivity,0);
}} else {
if (GetCurrentSensitivity() != LocalSensitivity) {
SystemParametersInfo((UInt32)0x0071,0,(uint)LocalSensitivity,0);
}}} else {
if (GetCurrentSensitivity() != StoredSensitivity) {
SystemParametersInfo((UInt32)0x0071,0,(uint)StoredSensitivity,0);
}}}
//============== Others
//--------------------------------------------------------------------------------------------------------- ALL/Reset Sensitivity
public static void ResetSensitivity() {
SetSensitivity(8); }
public static void ResetSensitivity(int Speed) {
SetSensitivity(Speed); }
public static void SetSensitivity(int Speed) {
SystemParametersInfo((UInt32)0x0071,0,(uint)Speed,0);
StoredSensitivity = Speed;
LocalSensitivity = Speed;
CustomSensitivity = Speed;
}
//--------------------------------------------------------------------------------------------------------- Global Sensitivity
public static void SetGlobalSensitivity(int Speed) {
SystemParametersInfo((UInt32)0x0071,0,(uint)Speed,0);
StoredSensitivity = Speed;
}
public static int GetGlobalSensitivity() {
return StoredSensitivity;
}
//--------------------------------------------------------------------------------------------------------- Local Sensitivity
public static void SetLocalSensitivity(int Speed) {
LocalSensitivity = Speed;
}
public static int GetLocalSensitivity() {
return LocalSensitivity;
}
//--------------------------------------------------------------------------------------------------------- Custom Sensitivity
public static void SetCustomSensitivity(int Speed) {
CustomSensitivity = Speed;
}
public static int GetCurrentCustomSensitivity() {
return CustomSensitivity;
}
//--------------------------------------------------------------------------------------------------------- Current Sensitivity
public static int GetCurrentSensitivity() {
return (int) System.Windows.Forms.SystemInformation.MouseSpeed;
}
}