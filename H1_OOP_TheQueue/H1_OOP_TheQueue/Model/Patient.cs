using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_TheQueue.Model
{
    internal class Patient
    {
        #region Attributes
        private string _name;
        private ushort _queueNumber;
        #endregion

        #region Properties  
        public string Name { get => _name; private set => _name = value; }
        public ushort QueueNumber { get => _queueNumber; private set => _queueNumber = value; }
        #endregion

        #region Constructors  
        /// <summary>
        /// Construct a patient with a name and a queueNumber
        /// </summary>
        private Patient() 
        {
            Name = "";
        }
        private Patient(string name): this()
        {
            Name = name;
        }
        public Patient(string name, ushort queueNumber) : this(name)
        {
            QueueNumber = queueNumber;
        }
        #endregion

        public override string ToString()
        {
            return $"{QueueNumber}: {Name}";
        }
    }
}
