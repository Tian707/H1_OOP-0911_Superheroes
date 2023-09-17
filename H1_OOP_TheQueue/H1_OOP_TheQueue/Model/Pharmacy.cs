using H1_OOP_TheQueue.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_TheQueue.Model
{
    internal class Pharmacy
    {
        #region Attributes
        private Queue<Patient> _patientsQueue;
        private ushort _queueID;

        #endregion

        #region Properties  
        internal Queue<Patient> PatientsQueue { get => _patientsQueue; set => _patientsQueue = value; }
        public ushort QueueID { get => _queueID; private set => _queueID = value; }


        #endregion
        #region Constructors  
        public Pharmacy()
        {
            QueueID = 0;
            PatientsQueue = new Queue<Patient>();
        }
        #endregion
        /// <summary>
        /// create a new patient with self-increment ID 
        /// then add to queue
        /// here we use the FindPatient method and return the new patient as a string
        /// </summary>
        /// <param name="name"></param>
        public string AddNewPatientToQueue(string name)
        {
            if (++QueueID > 100){
                QueueID = 1;
            }
            PatientsQueue.Enqueue(new Patient(name, QueueID));
            return $"{FindAPatient(name)} added to the queue.";
        }
        /// <summary>
        /// Remove first patient from the queue, return removed patient as a string to infirm the user
        /// exception: when there is no patient left in the queue
        /// </summary>
        /// <returns></returns>
        public string RemoveFirstPatient()
        {
            try
            {
                return $"{PatientsQueue.Dequeue()} removed from the queue.";
            }
            catch
            {
                return "No patient left in the queue.";
            }
        }

        public int ShowQueueCount()
        {
            return PatientsQueue.Count();
        }


        /// <summary>
        /// Use Peek() method in Queue to get the First patient
        /// convert the queue to array then get the last one by index
        /// </summary>
        /// <returns></returns>
        public string MinMax()
        {
            //return $"First Patient is {PatientsQueue.Min()}, Last Patient is {PatientsQueue.Max()}.";

            StringBuilder sb = new StringBuilder();
            sb.Append("The first patient is:\n");
            sb.Append(PatientsQueue.Peek().ToString());
            sb.Append("\nThe last patient is:\n");
            sb.Append(PatientsQueue.ToArray()[PatientsQueue.Count - 1].ToString());
            return sb.ToString();
        }


        /// <summary>
        /// Find a patient by the Name given by user
        /// Iterate through the PatientsQueue and compare Name of each object 
        /// if there is a match, set bool found to true
        /// after the iteration, if found still false, return nofound message
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string FindAPatient(string name)
        {
            // use LinQ Where
            string inQueue = "";
            bool found = false;

            foreach (Patient patient in PatientsQueue)
            {
                if (patient.Name == name)
                {
                    found = true;
                    inQueue = $"{patient.QueueNumber} : {patient.Name}";
                }
            }

            if(found == false)
                {
                    inQueue = $"{name} does not exist in the queue.";
                }

            return inQueue;
        }
        public string GetAllPatient()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Patient patient in PatientsQueue)
            {
                sb.AppendLine(patient.ToString());
            }
            return sb.ToString();
        }
    }
}
