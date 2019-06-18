namespace bonagenda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class appointment
    {
        [Key]
        public int idAppointment { get; set; }

        public DateTime dateHour { get; set; }
        
        public string subject { get; set; }

        public int idBroker { get; set; }

        public int idCustomer { get; set; }

        public virtual broker broker { get; set; }

        public virtual customer customer { get; set; }
    }
}
