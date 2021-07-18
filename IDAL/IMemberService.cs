using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models;

namespace IDAL
{
    interface IMemberService
    {
        //获取所有社团成员信息
        DataTable GetAllMembers();
        //根据成员编号获得社团成员信息
        ClubMember GetMemberByID(string id);
        //添加成员
        bool AddMember(ClubMember member);
        //修改成员
        bool UpdateMember(ClubMember member);
        //根据成员编号删除成员
        bool DeleteMember(string id);


    }
}
