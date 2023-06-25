using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLchatLieuServices : IQLchatLieuServices
    {
        private IchatLieuRepositories _chatlieu;
        private List<chatLieu> _lstchatLieu;
        public QLchatLieuServices()
        {
            _lstchatLieu = new List<chatLieu>();
            _chatlieu = new chatLieuRepositories();
        }
        public bool addchatLieu(chatLieu ChatLieu)
        {
            _chatlieu.addchatLieu(ChatLieu);
            return true;
        }

        public List<chatLieu> GetchatLieuFromDB()
        {
            _lstchatLieu = _chatlieu.GetChatLieuFromDB();
            return _lstchatLieu;
        }

        public bool RemovechatLieu(chatLieu ChatLieu)
        {
            _chatlieu.RemovechatLieu(ChatLieu);
            return true;
        }

        public bool UpdatechatLieu(chatLieu ChatLieu)
        {
            _chatlieu.UpdateChatLieu(ChatLieu);
            return true;
        }
    }
}
