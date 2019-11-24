using ServicesModel;
using System.Collections.Generic;
using ViewModel.Reuqest;

namespace Repository.Interfaces
{
    public interface ICommonRespository : IRepository
    {
        /// <summary>
        /// 获取所有的Table和Columns
        /// </summary>
        /// <returns></returns>
        string GetDbTablesAndColumns();

        /// <summary>
        /// 获取所有的表
        /// </summary>
        /// <returns></returns>
        List<CodeGenTable> GetDbTables();

        /// <summary>
        /// 获取表下面所有的字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        List<CodeGenField> GetDbTablesColumns(string tableName);

        /// <summary>
        /// 自动生成代码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        byte[] CodeGen(CodeGenVm model);
    }
}
