using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
// not sure how to run test and how exactly to add the assertions.
// also im not sure if i even created a correct class for my game.
public class RockPaperScissorsTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void RockPaperScissorsTestSimplePasses()
    {
        
        Assert.AreEqual 
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator RockPaperScissorsTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
