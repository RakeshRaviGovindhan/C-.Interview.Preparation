using System;

namespace CSharpInterview.Examples
{
    public static class Dispose
    {
        public static void Execute()
        {
            DisposeClass dispose = new DisposeClass();
            dispose.MyProperty = "Some value..";
            dispose.Dispose();
        }
    }

    class DisposeClass : IDisposable
    {
        public string MyProperty { get; set; }
        bool IsDisposed;

        public DisposeClass()
        {

        }

        protected virtual void Dispose(bool IsDispose)
        {
            if (IsDisposed) return;

            if (IsDispose)
            {
                Console.WriteLine("clean up managed");
                // clean up managed objects
            }

            Console.ReadKey();
            //clean up unmanaged objects
            IsDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


}
