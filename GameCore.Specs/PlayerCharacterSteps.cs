using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            player = new PlayerCharacter();
        }

        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            player.Hit(damage);
        }

        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, player.Health);
        }

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.True(player.IsDead);
        }
    }
}
