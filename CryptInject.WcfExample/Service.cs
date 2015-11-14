﻿using System.Collections.Generic;
using System.ServiceModel;

namespace CryptInject.WcfExample
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        private Dictionary<int, Patient> StoredPatients { get; set; }

        public Service()
        {
            StoredPatients = new Dictionary<int, Patient>();
        }

        public void SetValue(int idx, Patient value)
        {
            StoredPatients[idx] = value;
        }

        public Patient GetValue(int idx)
        {
            if (!StoredPatients.ContainsKey(idx))
                return null;
            return StoredPatients[idx];
        }
    }
}