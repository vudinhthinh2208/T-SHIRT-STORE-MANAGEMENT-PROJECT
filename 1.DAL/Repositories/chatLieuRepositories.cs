using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class chatLieuRepositories : IchatLieuRepositories
    {
        private List<chatLieu> _lstchatLieu;
        private DatabaseContext _context;
        public chatLieuRepositories()
        {
            _lstchatLieu = new List<chatLieu>();
            _context = new DatabaseContext();
        }
        public bool addchatLieu(chatLieu chatLieu)
        {
            _context.Add(chatLieu);
            _context.SaveChanges();
            return true;
        }

        public List<chatLieu> GetChatLieuFromDB()
        {
            _lstchatLieu = _context.ChatLieus.ToList();
            return _lstchatLieu;
        }

        public bool RemovechatLieu(chatLieu chatLieu)
        {
            _context.Remove(chatLieu);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateChatLieu(chatLieu chatLieu)
        {
            _context.Update(chatLieu);
            _context.SaveChanges();
            return true;
        }
    }
}
