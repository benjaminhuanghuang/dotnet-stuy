using System.Diagnostics;

namespace TestingDelegates
{
    [TestClass]
    public class Test_Delegates
    {
        private void DoWork()
        {
            // Do some work
            Debug.WriteLine("DoWork");
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
        }

        delegate void DoWorkDelegate();

        [TestMethod]
        public void Demo01()
        {
            DoWork();
        }


        [TestMethod]
        public void Demo02()
        {
            DoWorkDelegate m = new DoWorkDelegate(DoWork);
            m.Invoke();
        }

        [TestMethod]
        public void Demo03()
        {
            Debug.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
            DoWorkDelegate m = new DoWorkDelegate(DoWork);
            IAsyncResult ar = m.BeginInvoke(null, null);

            m.EndInvoke(ar);
        }
    }
}