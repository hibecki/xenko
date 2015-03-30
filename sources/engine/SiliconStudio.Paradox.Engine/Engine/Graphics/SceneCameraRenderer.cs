﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;
using SiliconStudio.Core.Annotations;
using SiliconStudio.Core.Collections;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Effects.Materials;
using SiliconStudio.Paradox.Engine.Graphics.Composers;
using SiliconStudio.Paradox.Shaders;

namespace SiliconStudio.Paradox.Engine.Graphics
{
    /// <summary>
    /// A camera renderer.
    /// </summary>
    [DataContract("SceneCameraRenderer")]
    [Display("Render Camera")]
    public sealed class SceneCameraRenderer : SceneEntityRenderer
    {
        // TODO: Add option for Occlusion culling
        // TODO: Add support for fixed aspect ratio and auto-centered-viewport

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneCameraRenderer"/> class.
        /// </summary>
        public SceneCameraRenderer()
        {
            Mode = new CameraRendererModeForward();
            PreRenderers = new SafeList<IGraphicsRenderer>();
            PostRenderers = new SafeList<IGraphicsRenderer>();
        }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        [DataMember(10)]
        [NotNull]
        public CameraRendererMode Mode { get; set; }

        /// <summary>
        /// Gets or sets the camera.
        /// </summary>
        /// <value>The camera.</value>
        [DataMember(20)]
        public SceneCameraSlotIndex Camera { get; set; }

        /// <summary>
        /// Gets or sets the material filter used to render this scene camera.
        /// </summary>
        /// <value>The material filter.</value>
        [DataMemberIgnore]
        public ShaderSource MaterialFilter { get; set; }

        /// <summary>
        /// Gets the pre-renderers attached to this instance that are called before rendering this camera.
        /// </summary>
        /// <value>The pre renderers.</value>
        [DataMemberIgnore]
        public SafeList<IGraphicsRenderer> PreRenderers { get; private set; }

        /// <summary>
        /// Gets the post-renderers attached to this instance that are called after rendering this camera.
        /// </summary>
        /// <value>The post renderers.</value>
        [DataMemberIgnore]
        public SafeList<IGraphicsRenderer> PostRenderers { get; private set; }

        protected override void DrawCore(RenderContext context, RenderFrame output)
        {
            // Early exit if some properties are null
            if (Mode == null)
            {
                return;
            }

            // Gets the current camera state from the slot
            var camera = context.GetCameraFromSlot(Camera);
            if (camera == null)
            {
                return;
            }

            // Draw this camera.
            using (context.PushTagAndRestore(Current, this))
            using (context.PushTagAndRestore(CameraComponentRenderer.Current, camera))
            {
                // Run all pre-renderers
                foreach (var renderer in PreRenderers)
                {
                    renderer.Draw(context);
                }

                // TODO: Find a better extensibility point for PixelStageSurfaceFilter
                var currentFilter = context.Parameters.Get(MaterialKeys.PixelStageSurfaceFilter);
                if (!ReferenceEquals(currentFilter, MaterialFilter))
                {
                    context.Parameters.Set(MaterialKeys.PixelStageSurfaceFilter, MaterialFilter);
                }

                // Draw the scene based on its drawing mode (e.g. implementation forward or deferred... etc.)
                Mode.Draw(context);

                // Run all post-renderers
                foreach (var renderer in PostRenderers)
                {
                    renderer.Draw(context);
                }
            }
        }
    }
}