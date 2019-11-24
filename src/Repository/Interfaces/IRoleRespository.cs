using DbModel;
using ServicesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Reuqest;

namespace Repository.Interfaces
{
    /// <summary>
    /// 角色权限管理
    /// </summary>
    public interface IRoleRespository : IRepository<SystemRole>
    {
        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="model"></param>
        /// <param name="eid"></param>
        /// <returns></returns>
        Task<Tuple<long, List<SystemRole>>> GetList(RoleVm model, Token eid);
        /// <summary>
        /// 新增Role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="uid"></param>
        /// <returns></returns>
        Task<string> AddRole(AddRoleVm role, Token uid);
        /// <summary>
        /// 获取所有的角色
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        Task<List<SystemRole>> GetAllRoleList(Token uid);
        /// <summary>
        /// 获取当前页面的action集合
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="RoleTid"></param>
        /// <param name="currentMenuTid"></param>
        /// <returns></returns>
        Task<SystemAction> GetSystemUserActions(string eid, long RoleTid, long currentMenuTid);
        /// <summary>
        /// 页面与接口关联
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<string> AddRoleActions(RoleAction model);
        /// <summary>
        /// 权限与接口关联配置 获取某一个菜单的某一个功能配置的接口列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<List<SystemPageAction>> GetRoleActions(RoleAction model);
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="tid"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<string> DeleteRole(long tid, Token user);
    }
}
