using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    class BLL_QLGC
    {
        private static BLL_QLGC _Instance;
        public static BLL_QLGC Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLGC();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLGC()
        {

        }

        public List<Note> GetAllNoteByAccountUsername(string accountUsername)
        {
            return DAL_QLGC.Instance.GetAllNoteByAccountUsername(accountUsername);
        }

        public bool AddNewNote(Note note)
        {
            if (DAL_QLGC.Instance.AddNewNote(note))
                return true;
            else
                return false;
        }

        public bool UpdateNote(Note note)
        {
            if (DAL_QLGC.Instance.UpdateNote(note))
                return true;
            else
                return false;
        }

        public bool DeleteNote(Note note)
        {
            if (DAL_QLGC.Instance.DeleteNote(note))
                return true;
            else
                return false;
        }

        public Note GetNoteByID(int ID_Note)
        {
            return DAL_QLGC.Instance.GetNoteByID(ID_Note);
        }
    }
}
