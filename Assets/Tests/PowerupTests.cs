using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PowerupTests
    {
        [Test]
        public void _0_Default_Id_Is_0()
        {
            Powerup powerup = new Powerup();
            Assert.AreEqual(0, powerup.Id);
        }
        [Test]
        public void _1_Setting_Id_Sets_Id()
        {
            Powerup powerup = new Powerup();
            powerup.Id = 2;
            Assert.AreEqual(2, powerup.Id);
        }
    }
}
