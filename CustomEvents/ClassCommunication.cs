using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEvents
{
    public class CommunicationEventClass
    {
        public class MessageEventArgs : EventArgs
        {
            public string Message { get; set; }
            public int Value { get; set; }
        }

        public event EventHandler SendMessage;

        public void FileObserver()
        {
            var watcher = new FileSystemWatcher(@"Files")
            {
                NotifyFilter = NotifyFilters.FileName
            };

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;

            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            OnSendMessage(e.FullPath, 12);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            OnSendMessage(e.FullPath, 12);
        }

        protected virtual void OnSendMessage(string msgContent, int valor)
        {
            if (null != SendMessage)
            {
                MessageEventArgs e = new MessageEventArgs();
                e.Message = msgContent;
                e.Value = valor;
                SendMessage(this, e);
            }
        }
    }
}
