﻿using System;
using NUnit.Framework;
using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Input;
using SiliconStudio.Xenko.Games.Testing;

namespace ParticlesSampleTest
{
    [TestFixture]
    public class ParticlesSampleTest
    {
        private const string Path = "samples\\Particles\\ParticlesSample\\Bin\\Windows\\Debug\\ParticlesSample.exe";

#if TEST_ANDROID
        private const PlatformType TestPlatform = PlatformType.Android;
#elif TEST_IOS
        private const PlatformType TestPlatform = PlatformType.iOS;
#else
        private const PlatformType TestPlatform = PlatformType.Windows;
#endif

        [Test]
        public void TestLaunch()
        {
            using (var game = new GameTestingClient(Path, TestPlatform))
            {
                game.Wait(TimeSpan.FromMilliseconds(5000));
            }
        }

        [Test]
        public void TestInputs()
        {
            using (var game = new GameTestingClient(Path, TestPlatform))
            {
                game.Wait(TimeSpan.FromMilliseconds(2000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(1000));
                game.TakeScreenshot();
                game.KeyPress(Keys.Right, TimeSpan.FromMilliseconds(500));

                game.Wait(TimeSpan.FromMilliseconds(500));
            }
        }
    }
}
