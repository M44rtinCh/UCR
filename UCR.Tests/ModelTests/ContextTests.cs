﻿using System;
using NUnit.Framework;
using UCR.Core;

namespace UCR.Tests.ModelTests
{
    [TestFixture]
    public class ContextTests
    {
        [Test]
        public void InitializationTest()
        {
            var context = new Context();
            Assert.That(context, Is.Not.Null);
            Assert.That(context.Profiles, Is.Not.Null);
            Assert.That(context.InputGroups, Is.Not.Null);
            Assert.That(context.OutputGroups, Is.Not.Null);
            Assert.That(context.IsNotSaved, Is.False);
        }

        [Test]
        public void AddProfile()
        {
            var context = new Context();
            Assert.That(context.Profiles.Count, Is.EqualTo(0));
            var profileName = "Test";
            context.ProfilesManager.AddProfile(profileName);
            Assert.That(context.Profiles.Count, Is.EqualTo(1));
            Assert.That(context.Profiles[0].Title, Is.EqualTo(profileName));
            Assert.That(context.Profiles[0].Guid, Is.Not.EqualTo(Guid.Empty));
        }
    }
}