using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLchatLieuServices
    {
        List<chatLieu> GetchatLieuFromDB();
        bool addchatLieu(chatLieu ChatLieu);
        bool RemovechatLieu(chatLieu ChatLieu);
        bool UpdatechatLieu(chatLieu ChatLieu);
    }
}
