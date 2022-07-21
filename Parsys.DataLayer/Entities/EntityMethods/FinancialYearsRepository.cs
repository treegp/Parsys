using Parsys.DataLayer.Entities.EntityAbstracts;
using Parsys.DataLayer.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Parsys.DataLayer.Entities.EntityMethods
{
    public class FinancialYearsRepository : GenericRepo<FinancialYears> , IFinancialYearsRepository
    {
        string conStr;
        public FinancialYearsRepository(string connection) : base(connection) { conStr = connection; }

        public List<FinancialYears> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByCorporationId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [CorporationId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [Title] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByStartDate(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [StartDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByFinishDate(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [FinishDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByIsClosed(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [IsClosed] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByCloseDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [CloseDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByClosedByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [ClosedByUserId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByIsDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [IsDeleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByDeleteDate(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [DeleteDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<FinancialYears> GetByDeleteByUserId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from FinancialYears where [DeleteByUserId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
