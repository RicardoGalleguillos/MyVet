using System;
using System.Collections.Generic;
using System.Text;

namespace MyVet.Common.Models
{
    public class PetResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Race { get; set; }

        public DateTime Born { get; set; }

        public string Remarks { get; set; }
        //formato string ya que devolveremos solo el nombre del tipo de mascota, no el objeto
        public string PetType { get; set; }

        public ICollection<HistoryResponse> Histories { get; set; }

    }
}
