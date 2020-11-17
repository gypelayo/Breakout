using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System;

namespace Tests
{
    public class AccountTests
    {
        [Test]
        public void _0_Creating_New_Account_Sets_Balance_To_0()
        {
            Account account = new Account();
            Assert.AreEqual(0, account.Balance);
        }
        [Test]
        public void _1_Adding_Funds_Adds_Funds()
        {
            Account account = new Account();
            account.AddFunds(500);
            Assert.AreEqual(500, account.Balance);
        }
        [Test]
        public void _2_Adding_Negative_Funds_Throws_Exception()
        {
            Account account = new Account();
            Assert.Throws<ArgumentOutOfRangeException>(() => account.AddFunds(-500));
        }
        [Test]
        public void _3_Substracting_Funds_Substracts_Funds()
        {
            Account account = new Account();
            account.AddFunds(1000);
            account.SubstractFunds(500);
            Assert.AreEqual(500, account.Balance);
        }
        [Test]
        public void _4_Subtracting_Negative_Funds_Throws_Exception()
        {
            Account account = new Account();
            Assert.Throws<ArgumentOutOfRangeException>(() => account.SubstractFunds(-500));
        }
    }
}
