using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelClassLibrary;

namespace Persitence
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TapasService" in both code and config file together.
    public class TapasService : ITapasService
    {
        public List<Tapas> GetAllTapas()
        {
            return DBPersistence.Instance.GetAllTapas();
        }
    }
}
