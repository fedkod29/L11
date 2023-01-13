using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Problem_1
{
    delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    internal class Dispatcher
    {
        private string _name;
        public string Name 
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                OnNameChange(new NameChangeEventArgs(value));
            } 
        }

        public event NameChangeEventHandler NameChange;

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
