﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [FontEffectShader]
//
//     Command Line: C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGLES --platform=Windows --output-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\app_data --build-path=C:\Dev\xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class FontEffectShader
    {
        private static readonly byte[] fontBytecodeSDF = new byte[] {
2, 192, 254, 239, 0, 5, 0, 0, 0, 16, 70, 111, 110, 116, 69, 102, 102, 101, 99, 116, 83, 104, 97, 100, 101, 114, 1, 112, 91, 98, 119, 156, 75, 22, 172, 92, 188, 217, 102, 222, 115, 41, 107, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 76, 31, 25, 215, 193, 29, 168, 182, 119, 159, 
125, 91, 210, 35, 12, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 67, 83, 107, 157, 134, 7, 83, 68, 70, 70, 111, 110, 116, 1, 28, 90, 222, 41, 246, 29, 143, 94, 51, 14, 159, 254, 116, 84, 27, 
124, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 
0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 
108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 4, 0, 0, 202, 2, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 
50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 
59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 
32, 40, 41, 10, 123, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 
79, 82, 68, 48, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 122, 32, 42, 
32, 50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 121, 41, 59, 10, 125, 10, 10, 189, 
2, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 105, 110, 32, 118, 101, 99, 
52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 
40, 41, 10, 123, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 
82, 68, 48, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 122, 32, 42, 32, 
50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 121, 41, 59, 10, 125, 10, 10, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 187, 102, 38, 116, 35, 126, 139, 58, 231, 120, 26, 148, 
179, 49, 180, 86, 0, 5, 0, 0, 0, 0, 0, 16, 0, 0, 170, 16, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 
10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 
114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 
125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 
50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 
120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 13, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 
99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 50, 40, 102, 108, 111, 97, 116, 32, 114, 44, 32, 102, 108, 111, 97, 116, 32, 103, 44, 32, 102, 108, 111, 97, 116, 32, 98, 41, 13, 10, 123, 13, 10, 32, 32, 
32, 32, 114, 101, 116, 117, 114, 110, 32, 109, 97, 120, 40, 109, 105, 110, 40, 114, 44, 32, 103, 41, 44, 32, 109, 105, 110, 40, 109, 97, 120, 40, 114, 44, 32, 103, 41, 44, 32, 98, 41, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 
100, 51, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 44, 32, 118, 101, 99, 52, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 
118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 
77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 61, 32, 49, 46, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 32, 61, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 50, 40, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 114, 44, 
32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 103, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 98, 41, 32, 45, 32, 48, 46, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 99, 101, 110, 116, 114, 97, 108, 76, 105, 110, 101, 32, 61, 
32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 42, 32, 115, 105, 103, 68, 105, 115, 116, 32, 47, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 68, 105, 115, 116, 41, 32, 43, 32, 48, 46, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 
116, 32, 111, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 49, 41, 44, 32, 99, 101, 110, 116, 114, 97, 108, 76, 105, 110, 101, 41, 59, 13, 10, 32, 32, 32, 32, 105, 102, 
32, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 62, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 119, 105, 100, 116, 104, 32, 61, 32, 102, 108, 111, 97, 
116, 40, 40, 102, 119, 105, 100, 116, 104, 40, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 41, 41, 32, 42, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 
108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 32, 61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 49, 41, 44, 32, 115, 105, 103, 68, 105, 115, 116, 32, 47, 32, 119, 105, 100, 116, 104, 41, 59, 13, 10, 
32, 32, 32, 32, 32, 32, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 98, 111, 114, 100, 101, 114, 41, 41, 59, 13, 10, 
32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 46, 97, 32, 61, 32, 102, 108, 111, 97, 116, 40, 49, 41, 59, 13, 10, 32, 32, 32, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 118, 101, 99, 52, 40, 
48, 44, 32, 48, 44, 32, 48, 44, 32, 48, 41, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 111, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 
59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 52, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 115, 105, 
103, 110, 101, 100, 77, 117, 108, 116, 105, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 50, 68, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 115, 116, 114, 101, 97, 109, 
115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 41, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 32, 61, 32, 118, 101, 99, 52, 40, 49, 44, 32, 48, 44, 32, 48, 44, 32, 49, 41, 59, 13, 10, 32, 32, 32, 
32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 61, 32, 48, 46, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 51, 40, 115, 116, 114, 101, 97, 109, 115, 44, 32, 
115, 105, 103, 110, 101, 100, 77, 117, 108, 116, 105, 68, 105, 115, 116, 97, 110, 99, 101, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 44, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 
107, 110, 101, 115, 115, 41, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 
116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 
79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 
83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 
114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 95, 105, 100, 55, 50, 59, 13, 10, 32, 32, 32, 32, 115, 116, 
114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 52, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 
117, 116, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 
100, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 13, 10, 213, 5, 35, 118, 101, 114, 
115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 49, 
93, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 
79, 82, 68, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 
109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 108, 
111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 95, 50, 59, 10, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 95, 50, 46, 120, 121, 122, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 46, 120, 121, 122, 59, 10, 32, 32, 108, 111, 119, 112, 32, 102, 
108, 111, 97, 116, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 40, 109, 97, 120, 32, 40, 109, 105, 110, 32, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 44, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 44, 32, 
109, 105, 110, 32, 40, 10, 32, 32, 32, 32, 109, 97, 120, 32, 40, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 44, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 121, 41, 10, 32, 32, 44, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 122, 41, 41, 32, 45, 32, 48, 46, 53, 41, 59, 10, 
32, 32, 108, 111, 119, 112, 32, 102, 108, 111, 97, 116, 32, 116, 109, 112, 118, 97, 114, 95, 52, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 99, 108, 97, 109, 112, 32, 40, 40, 40, 10, 32, 32, 32, 32, 40, 49, 46, 53, 32, 42, 32, 116, 109, 112, 118, 97, 114, 95, 
51, 41, 10, 32, 32, 32, 47, 32, 10, 32, 32, 32, 32, 40, 97, 98, 115, 40, 100, 70, 100, 120, 40, 116, 109, 112, 118, 97, 114, 95, 51, 41, 41, 32, 43, 32, 97, 98, 115, 40, 100, 70, 100, 121, 40, 116, 109, 112, 118, 97, 114, 95, 51, 41, 41, 41, 10, 32, 32, 41, 32, 43, 32, 48, 
46, 53, 41, 44, 32, 48, 46, 48, 44, 32, 49, 46, 48, 41, 59, 10, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 95, 50, 46, 119, 32, 61, 32, 49, 46, 48, 59, 10, 32, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 40, 116, 101, 120, 
116, 67, 111, 108, 111, 114, 95, 50, 32, 42, 32, 118, 101, 99, 52, 40, 40, 116, 109, 112, 118, 97, 114, 95, 52, 32, 42, 32, 40, 116, 109, 112, 118, 97, 114, 95, 52, 32, 42, 32, 10, 32, 32, 32, 32, 40, 51, 46, 48, 32, 45, 32, 40, 50, 46, 48, 32, 42, 32, 116, 109, 112, 118, 97, 
114, 95, 52, 41, 41, 10, 32, 32, 41, 41, 41, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 192, 32, 92, 192, 172, 48, 23, 161, 130, 16, 190, 177, 61, 195, 88, 177, 
        };
    }
}
#endif
