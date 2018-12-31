﻿namespace InputSimulatorStandard.Tests
{
    using System;

    using Moq;

    using Xunit;

    public class MouseSimulatorTests
    {
        private IMouseSimulator mouseSimulator;

        public MouseSimulatorTests()
        {
            this.mouseSimulator = new MouseSimulator(Mock.Of<IInputSimulator>(), Mock.Of<IInputMessageDispatcher>());
        }

        public class Constructor : MouseSimulatorTests
        {
            [Fact]
            public void NullInputSimulatorThrowsArgumentNullException()
            {
                Assert.Throws<ArgumentNullException>("inputSimulator", () => this.mouseSimulator = new MouseSimulator(null));
            }

            [Fact]
            public void NullMessageDispatcherThrowsInvalidOperationException()
            {
                Assert.Throws<InvalidOperationException>(() => this.mouseSimulator = new MouseSimulator(Mock.Of<IInputSimulator>(), null));
            }
        }
    }
}