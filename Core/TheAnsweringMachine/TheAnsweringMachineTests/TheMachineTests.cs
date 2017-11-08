using System;
using NUnit.Framework;
using TheAnsweringMachine;

namespace TheAnsweringMachineTests
{
    [TestFixture]
    public class TheMachineTests
    {
        [Test]
        public void TheMachine_InvalidArguments_Throws()
        {
            Assert.That(() => TheMachine.GetTheAnswer(""), Throws.ArgumentNullException);
            Assert.That(() => TheMachine.GetTheAnswer("  "), Throws.ArgumentNullException);
            Assert.That(() => TheMachine.GetTheAnswer(null), Throws.ArgumentNullException);
        }

        [Test]
        public void TheMachine_GetAnwer_CorrectResult()
        {
            Int32 answer = TheMachine.GetTheAnswer("To all and everything in the universe");
            Assert.That(answer, Is.EqualTo(42));
        }
    }
}
