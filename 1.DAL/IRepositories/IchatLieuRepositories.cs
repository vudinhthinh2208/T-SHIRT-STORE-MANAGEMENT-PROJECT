using _1.DAL.Models;
using System.Collections.Generic;
using System;

namespace _1.DAL.IRepositories
{
    public interface IchatLieuRepositories
    {
        List<chatLieu> GetChatLieuFromDB();
        bool addchatLieu(chatLieu chatLieu);
        bool RemovechatLieu(chatLieu chatLieu);
        bool UpdateChatLieu(chatLieu chatLieu);
    }
}
