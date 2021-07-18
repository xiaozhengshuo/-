using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class MemberManage
    {
        public DataTable GetAllMembers()
        {
            try
            {
                MemberService memberdal = new MemberService();
                return memberdal.GetAllMembers();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
            
    }
}
