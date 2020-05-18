using System.Collections;
using System.Collections.Generic;
using BankSim;
using BankSim.Enums;
using BankSim.Exceptions;
using Xunit;
using Xunit.Abstractions;


namespace BankSimTests {
    public class SimulatorTests {
        private readonly ITestOutputHelper _output;

        public SimulatorTests(ITestOutputHelper output)
        {
            _output = output;
        }

        #region Open Close Tests
        [Fact] //Facts are tests used to evaluate or test one specific function
        [Trait("Category", "Open Close Tests")]
        public void FactTest()
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount("1234567890", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR);
            simulator.CloseAccount("1234567890"); //if the account is opened correctly we should be able to close it
        }

        [Theory]
        [Trait("Category", "Open Close Tests")]
        [InlineData("1234567890", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR)]
        public void InlineDataExample(string accNo, string accName, AccountType accType, Currencies accCurr)
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount(accNo, accName, accType, accCurr);
            simulator.CloseAccount(accNo);
        }

        [Theory]
        [Trait("Category", "Open Close Tests")]
        [ClassData(typeof(SingleAccountTestData))]
        public void ClassDataExample(string accNo, string accName, AccountType accType, Currencies accCurr)
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount(accNo, accName, accType, accCurr);
            simulator.CloseAccount(accNo);
        }

        #region MemberData Example Data

        public static IEnumerable<object[]> TestdataEnumerableProperty => new List<object[]>()
        {
          new object[]{  "1234567890","Member Data Prop Test Account",AccountType.CustomerAccount,Currencies.ZAR }
        };

        public static IEnumerable<object[]> TestdataEnumerableMethod()
        {
            return new List<object[]>()
            {
                new object[] {"1234567890", "Member Data Method Test Account", AccountType.CustomerAccount, Currencies.ZAR}
            };
        }

        #endregion


        [Theory]
        [Trait("Category", "Open Close Tests")]
        [MemberData(nameof(TestdataEnumerableProperty))]
        [MemberData(nameof(TestdataEnumerableMethod))]
        public void MemberDataExample(string accNo, string accName, AccountType accType, Currencies accCurr)
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount(accNo, accName, accType, accCurr);
            simulator.CloseAccount(accNo);

        }

        #endregion

        #region Exception Tests

        [Fact]
        [Trait("Category", "Exception Tests")]
        [Trait("Sub-Category", "Single")]
        public void ThrowsAccountNotFoundTest()
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount("1234567894", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR);
            Assert.Throws<AccountNotFoundException>(() =>
                simulator.Transfer("1234567894", "789456123", 100)
            );
        }

        [Fact]
        [Trait("Category", "Exception Tests")]
        [Trait("Sub-Category", "Single")]
        public void ThrowsAccountExistsExceptionTest()
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount("1234567899", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR);
            Assert.Throws<AccountExistsException>(() =>
                    simulator.OpenAccount("1234567899", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR)
            );
        }

        [Fact]
        [Trait("Category", "Exception Tests")]
        [Trait("Sub-Category", "Single")]

        public void ThrowsInsuffientFundsExceptionTest()
        {
            BankSimulator simulator = new BankSimulator();
            simulator.OpenAccount("1234567895", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR);
            simulator.OpenAccount("1234567896", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR);
            Assert.Throws<InsufficientFundsException>(testCode: () =>
                simulator.Transfer("1234567895", "1234567896", 10000)
            );
        }

        #endregion
    }

    #region DataClasses

    public class SingleAccountTestData : IEnumerable<object[]> {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1234567890", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class MultiAccountTestData : IEnumerable<object[]> {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "1234567890", "Test Account1", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567891", "Test Account2", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567892", "Test Account3", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567893", "Test Account4", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567894", "Test Account5", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567895", "Test Account6", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567896", "Test Account7", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567897", "Test Account8", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567898", "Test Account9", AccountType.CustomerAccount, Currencies.ZAR };
            yield return new object[] { "1234567899", "Test Account10", AccountType.CustomerAccount, Currencies.ZAR };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    #endregion


}

