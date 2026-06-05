using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApp_DelegEvents
{
    class Program 
    {
        ////static void Main(string[] args)
        ////{
        ////}
        //public void WriteToFile(string path, string content)
        //{
        //    using (StreamWriter writer = new StreamWriter(path))
        //    {
        //        writer.Write(content);
        //    }

        //}       
    }

    //class ResourceHandler : IDisposable
    //{
    //    StreamWriter writer;
    //    public ResourceHandler(string path, string content)
    //    {
    //        writer = new StreamWriter(path);
    //        writer.Write(content);
    //    }
    //    public void Dispose()
    //    {
    //        GC.SuppressFinalize(this.writer);
    //    }
    //    ~ResourceHandler()             // Destructor
    //    {
    //        Dispose();
    //    }
    //}

    class ResourceHandler : IDisposable
    {
        private bool _disposed = false;
        private Stream _managedResource = new MemoryStream();
        private IntPtr _unmanagedResource ;

        public ResourceHandler()
        {
            // Allocate 10 bytes of unmanaged memory
            _unmanagedResource = Marshal.AllocHGlobal(10);
            // Optionally write something to the unmanaged memory 
            //...................................................
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);          //Use GC.SuppressFinalize(this) in Dispose() to prevent finalizer from running if it's already disposed.
        }

        // Finalizer (destructor) to catch missed disposal  (called by GC)
        ~ResourceHandler()
        {
            Dispose(false);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose/Free managed resources
                    _managedResource?.Dispose();
                    _managedResource = null;
                }
                // Here you would free unmanaged resources if any, for example: CloseHandle(handle), Marshal.FreeHGlobal(ptr), etc.
                if (_unmanagedResource != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(_unmanagedResource);
                    _unmanagedResource = IntPtr.Zero;
                }

                _disposed = true;
            }
        }
    }
}
