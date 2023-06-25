using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    public class chatLieuConfigurations:IEntityTypeConfiguration<chatLieu>
    {
        public void Configure(EntityTypeBuilder<chatLieu> builder)
        {
            // Đặt tên bảng
            builder.ToTable("chatlieu");
            // Set khóa chính
            builder.HasKey(x => x.IDChatlieu);
            builder.Property(x => x.IDChatlieu).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.ChatLieu).IsRequired();
            builder.Property(x => x.trangThai).IsRequired();
        }
    }
}
