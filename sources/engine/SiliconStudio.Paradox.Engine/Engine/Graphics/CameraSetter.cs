// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;

using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Engine;
using SiliconStudio.Paradox.Engine.Graphics;

namespace SiliconStudio.Paradox.Effects
{
    /// <summary>
    /// A processor that updates camera view and projection along the setup of <see cref="RenderTargetSetter"/>
    /// </summary>
    public class CameraSetter : RendererExtendedBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RendererExtendedBase" /> class.
        /// </summary>
        /// <param name="services">The services.</param>
        public CameraSetter(IServiceRegistry services) : base(services)
        {
        }

        /// <summary>
        /// Gets or sets the camera.
        /// </summary>
        /// <value>The camera.</value>
        public CameraComponent Camera { get; set; }

        protected override void OnRendering(RenderContext context)
        {
            if (Camera == null)
                return;

            // TODO Should we really want to throw an exception
            if(Camera.Entity == null)
                throw new Exception("The camera component provided to 'CameraSetter' should be associated to an entity");

            var viewParameters = context.Parameters;

            Matrix projection;
            Matrix worldToCamera;
            Camera.Calculate(out projection, out worldToCamera);

            viewParameters.Set(TransformationKeys.View, worldToCamera);
            viewParameters.Set(TransformationKeys.Projection, projection);
            viewParameters.Set(CameraKeys.NearClipPlane, Camera.NearPlane);
            viewParameters.Set(CameraKeys.FarClipPlane, Camera.FarPlane);
            viewParameters.Set(CameraKeys.FieldOfView, Camera.VerticalFieldOfView);
            viewParameters.Set(CameraKeys.Aspect, Camera.AspectRatio);
            viewParameters.Set(CameraKeys.FocusDistance, Camera.FocusDistance);   
        }
    }
}