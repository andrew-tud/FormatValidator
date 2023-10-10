using FormatValidator.String;

namespace FormatValidator.UnitTest
{
    [TestClass]
    public class AngelBracketValidatorTest
    {
        private IValidator validator;

        [TestInitialize]
        public void TestInitialize()
        {
            validator = new AngleBracketValidator();
        }

        [TestMethod]
        public void Input_BasicEnclosure_IsValid()
        {
            Assert.IsTrue(validator.Validate("<>"));
        }

        [TestMethod]
        public void Input_BasicEnclosureInReversed_IsNotValid()
        {
            Assert.IsFalse(validator.Validate("><"));
        }

        [TestMethod]
        public void Input_UnEnclosed_IsNotValid()
        {
            Assert.IsFalse(validator.Validate("<<>"));
        }

        [TestMethod]
        public void Input_NoEnclosure_IsValid()
        {
            Assert.IsTrue(validator.Validate(""));
        }

        [TestMethod]
        public void Input_EnclosureWithTextInBetween_IsValid()
        {
            Assert.IsTrue(validator.Validate("<abc...xyz>"));
        }
    }
}