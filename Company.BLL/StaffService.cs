using Company.IBLL;
using Company.IDAL;
using Company.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BLL
{
    public partial class StaffService : BaseService<Staff>, IStaffService
    {
        private IStaffDAL StaffDAL = DALContainer.Container.Resolve<IStaffDAL>();
        public override void SetDal()
        {
            Dal = StaffDAL;
        }
    }
}
