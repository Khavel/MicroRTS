using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace MicroRts.Tests.PlayMode
{
    public sealed class SmokeSceneLoadsTests
    {
        [UnityTest]
        public IEnumerator SmokeScene_Loads_WithoutErrors()
        {
            var asyncLoad = SceneManager.LoadSceneAsync("Smoke", LoadSceneMode.Single);
            Assert.IsNotNull(asyncLoad);

            while (!asyncLoad.isDone)
                yield return null;

            Assert.AreEqual("Smoke", SceneManager.GetActiveScene().name);
        }
    }
}
