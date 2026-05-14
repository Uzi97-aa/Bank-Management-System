using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsAduitLog
    {
        public enum enMode { Create = 1, Update = 2}

        enMode Mode = enMode.Create;

        public int LogID { get; set; }
        public int UserID { get; set; }
        public short ActionType { get; set; }     // 1 : CREATE , 2 : UPDATE , 3 : DELETE , 4 : TRANSACTION , 5 : LOGIN
        public short EntityTypeID { get; set; }
        public int EntityID { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string IPAddress { get; set; }

        public AuditLogDTO ALDTO { get { return new AuditLogDTO(this.LogID, this.UserID, this.ActionType, this.EntityTypeID,
             this.EntityID, this.OldValue, this.NewValue, this.IPAddress);
            }
        }
    
        public clsAduitLog(AuditLogDTO ALDTO, enMode Mode = enMode.Create)
        {
            this.LogID = ALDTO.LogID;
            this.UserID = ALDTO.UserID;
            this.ActionType = ALDTO.ActionType;
            this.EntityTypeID = ALDTO.EntityTypeID;
            this.EntityID = ALDTO.EntityID;
            this.OldValue = ALDTO.OldValue;
            this.NewValue = ALDTO.NewValue;
            this.IPAddress = ALDTO.IPAddress;
            this.Mode = Mode;
        }

            private bool Create()
            {
                this.LogID = clsAuditLogs.CreateAuditLog(ALDTO);
                return this.LogID != -1;
            }

    }
}
