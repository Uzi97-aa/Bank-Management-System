using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBankLayer;
using static SharedClass.clsShared;
namespace BuisnessLogicLayer
{
    public class clsPosting
    {
      public  enum enTransactionType
        {
            DEBIT = 1,
            CREDIT = 2
        }
        public int PostingID { get; set; }
        public int GroupID { get; set; }
        public int AccountID { get; set; }
        public enTransactionType TransactionType { get; set; }  // -- 1 : DEBIT, 2 : CREDIT
        public decimal Amount { get; set; }
        public string Reference { get; set; }
        public int? Reversal_Of_PostingID { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] Row_Version { get; set; }

        clsTransactionGroup TransactionGroup { get; set; }
        public PostingsDTO PDTO
        {
            get
            {
                return new PostingsDTO
                (
                   this.PostingID,
                   this.GroupID,
                   this.AccountID,
                   (byte)this.TransactionType,
                   this.Amount,
                   this.Reference,
                   this.Reversal_Of_PostingID,
                   this.CreatedAt,
                   this.Row_Version
                );
            }
        }

        public clsPosting(PostingsDTO PDTO,clsTransactionGroup Group)
        {
            this.PostingID = PDTO.PostingID;
            this.GroupID = PDTO.GroupID;
            this.TransactionGroup= Group;
            this.AccountID = PDTO.AccountID;
            this.TransactionType = (enTransactionType)PDTO.TransactionType;
            this.Amount = PDTO.Amount;
            this.Reference = PDTO.Reference;
            this.Reversal_Of_PostingID = PDTO.Reversal_Of_PostingID;
            this.CreatedAt = PDTO.CreatedAt;
            this.Row_Version = PDTO.Row_Version;

        }



        public static clsPosting FindByID(int PostingID)
        {
            PostingsDTO PDTO = clsPostings.FindByID(PostingID);
            clsTransactionGroup Group=clsTransactionGroup.FindByID(PDTO.GroupID);
            if (PDTO != null&&Group!=null)
                return new clsPosting(PDTO, Group);
            else
                return null;
        }


        public bool AddPosting()
        {
           int ID=this.PostingID= clsPostings.AddPosting(PDTO);
            return ID!=-1;
        }
        public static List<clsPosting> GetPostingsByGroupID(int GroupID)
        {
            List<PostingsDTO> PDTOs = clsPostings.GetPostingsByGroupID(GroupID);
            List<clsPosting> Postings = new List<clsPosting>();
            clsTransactionGroup group = clsTransactionGroup.FindByID(GroupID);
            foreach (PostingsDTO PDTO in PDTOs)
            {
                Postings.Add(new clsPosting(PDTO, group));
            }
            return Postings;

        }

        }


}
