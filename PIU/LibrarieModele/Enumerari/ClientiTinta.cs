using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele.Enumerari
{
    [Flags]
    public enum ClientiTinta
    {
        None = 0,
        Elev = 1 << 0,
        Student = 1 << 1,
        Angajat = 1 << 2,
        Somer = 1 << 3,
        Pensionar = 1 << 4,
    }
}
