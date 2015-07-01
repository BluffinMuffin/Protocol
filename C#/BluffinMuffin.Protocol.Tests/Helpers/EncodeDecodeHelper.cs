using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests.Helpers
{
    public static class EncodeDecodeHelper
    {
        public static T GetDecodedCommand<T>(T c) where T : AbstractCommand
        {
            string ce = c.Encode();
            AbstractCommand dc = AbstractCommand.DeserializeCommand(ce);

            Assert.AreEqual(c.GetType(), dc.GetType(), "Command and Decoded Command should be the same");
            return (T)dc;
        }
    }
}
