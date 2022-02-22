
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Models
{
    public class AvisMembreBienModel  
    {
        private int _idavis;
        private int _note;
        private string _message;
        private int _idmembre;
        private int _idbien;
        private DateTime _dateavis;
        private bool _approuve;


        public int Idavis { get => _idavis; set => _idavis = value; }
        public int Note { get => _note; set => _note = value; }
        public string Message { get => _message; set => _message = value; }
        public int Idmembre { get => _idmembre; set => _idmembre = value; }
        public int Idbien { get => _idbien; set => _idbien = value; }
        public DateTime Dateavis { get => _dateavis; set => _dateavis = value; }
        public bool Approuve { get => _approuve; set => _approuve = value; }

         
    }
}
