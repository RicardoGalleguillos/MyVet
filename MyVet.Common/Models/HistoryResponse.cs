using System;
using System.Collections.Generic;
using System.Text;

namespace MyVet.Common.Models
{
    public class HistoryResponse
    {
        public int Id { get; set; }
        //formato string ya que devolveremos solo el nombre del tipo de servicio, no el objeto
        public string ServiceType { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Remarks { get; set; }
    }

}
