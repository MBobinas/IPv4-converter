namespace TeltonikaBackEndTask.Tests
{
    public class InputInfoTests
    {
        public InputInfoTests()
        {

        }

        [Fact]
        public void TryParseNumericValues_ParseValues_Success()
        {
            // Arrange
            var inputInfo = GetValidInputInfo();

            // Act
            var actual = inputInfo.TryParseNumericValues();

            // Assert
            Assert.True(actual);
            Assert.Equal(167772160, inputInfo.FirstInputNumeric);
            Assert.Equal(167772210, inputInfo.SecondInputNumeric);
        }

        [Fact]
        public void TryParseNumericValues_ParseValues_IncorrectValueFormat_Failed()
        {
            // Arrange
            var inputInfo = GetIncorrectInputInfo();

            // Act
            var actual = inputInfo.TryParseNumericValues();

            // Assert
            Assert.False(actual);
            Assert.Equal(0, inputInfo.FirstInputNumeric);
            Assert.Equal(0, inputInfo.SecondInputNumeric);
        }

        private InputInfo GetValidInputInfo()
        {
            return new InputInfo()
            {
                FirstInput = "10.0.0.0",
                SecondInput = "10.0.0.50"
            };
        }
        private InputInfo GetIncorrectInputInfo()
        {
            return new InputInfo()
            {
                FirstInput = "10.0.0",
                SecondInput = "10.0.0.50"
            };
        }
    }
}